#nullable enable

namespace Letta
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Retrieve Mcp Server<br/>
        /// Get a specific MCP server
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.AnyOf<global::Letta.StdioMCPServer, global::Letta.SSEMCPServer, global::Letta.StreamableHTTPMCPServer>> McpRetrieveMcpServerAsync(
            string mcpServerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}