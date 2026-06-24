namespace Letta.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static Environment? _environment;

    public static LettaClient Client => _environment!.Client;

    [AssemblyInitialize]
    public static async Task AssemblyInit(TestContext context)
    {
        _environment = await Environment.PrepareAsync();
    }

    [AssemblyCleanup]
    public static async Task AssemblyCleanup()
    {
        if (_environment is not null)
        {
            await _environment.DisposeAsync();
        }
    }
}
