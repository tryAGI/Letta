#nullable enable

namespace Letta
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// List Mcp Servers<br/>
        /// Get a list of all configured MCP servers
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ListMcpServersAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}