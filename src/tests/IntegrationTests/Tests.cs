namespace Letta.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static LettaClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("LETTA_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("LETTA_API_KEY environment variable is not found.");

        var client = new LettaClient(apiKey);
        
        return client;
    }
}
