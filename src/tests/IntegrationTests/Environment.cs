namespace Letta.IntegrationTests;

public sealed class Environment : IAsyncDisposable
{
    private const ushort LettaPort = 8283;

    public required LettaClient Client { get; init; }

    public ValueTask DisposeAsync()
    {
        Client.Dispose();
        return ValueTask.CompletedTask;
    }

    public static Task<Environment> PrepareAsync()
    {
        var apiKey =
            System.Environment.GetEnvironmentVariable("LETTA_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("LETTA_API_KEY environment variable is not found.");

        var baseUrl =
            System.Environment.GetEnvironmentVariable("LETTA_BASE_URL") is { Length: > 0 } baseUrlValue
                ? baseUrlValue
                : $"http://127.0.0.1:{LettaPort}";

        return Task.FromResult(new Environment
        {
            Client = new LettaClient(apiKey, baseUri: new Uri(baseUrl)),
        });
    }
}
