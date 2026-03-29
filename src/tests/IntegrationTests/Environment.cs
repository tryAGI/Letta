using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Containers;

namespace Letta.IntegrationTests;

public sealed class Environment : IAsyncDisposable
{
    private const string LettaImage = "letta/letta:latest";
    private const ushort LettaPort = 8283;
    private static readonly TimeSpan StartupTimeout = TimeSpan.FromMinutes(3);

    public IContainer? Container { get; init; }
    public required LettaClient Client { get; init; }

    public async ValueTask DisposeAsync()
    {
        Client.Dispose();
        if (Container != null)
        {
            await Container.DisposeAsync();
        }
    }

    public static async Task<Environment> PrepareAsync(EnvironmentType? environmentType = null)
    {
        environmentType ??= InferEnvironment();
        switch (environmentType)
        {
            case EnvironmentType.Local:
            {
                var apiKey =
                    System.Environment.GetEnvironmentVariable("LETTA_API_KEY") is { Length: > 0 } apiKeyValue
                        ? apiKeyValue
                        : throw new AssertInconclusiveException("LETTA_API_KEY environment variable is not found.");

                var baseUrl =
                    System.Environment.GetEnvironmentVariable("LETTA_BASE_URL") is { Length: > 0 } baseUrlValue
                        ? baseUrlValue
                        : $"http://127.0.0.1:{LettaPort}";

                var client = new LettaClient(apiKey, baseUri: new Uri(baseUrl));

                return new Environment
                {
                    Client = client,
                };
            }
            case EnvironmentType.Container:
            {
                var container = new ContainerBuilder(LettaImage)
                    .WithPortBinding(LettaPort, assignRandomHostPort: true)
                    .WithWaitStrategy(
                        Wait.ForUnixContainer()
                            .UntilHttpRequestIsSucceeded(request => request
                                .ForPath("/v1/health/")
                                .ForPort(LettaPort)))
                    .Build();

                using var cts = new CancellationTokenSource(StartupTimeout);
                await container.StartAsync(cts.Token);

                var client = new LettaClient(
                    baseUri: new UriBuilder(
                        Uri.UriSchemeHttp,
                        container.Hostname,
                        container.GetMappedPublicPort(LettaPort)).Uri);

                return new Environment
                {
                    Container = container,
                    Client = client,
                };
            }
            default:
                throw new ArgumentOutOfRangeException(nameof(environmentType), environmentType, null);
        }
    }

    private static EnvironmentType InferEnvironment()
    {
#if DEBUG
        return EnvironmentType.Local;
#else
        return EnvironmentType.Container;
#endif
    }
}

public enum EnvironmentType
{
    Local,
    Container,
}
