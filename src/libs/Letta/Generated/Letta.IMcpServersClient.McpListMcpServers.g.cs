#nullable enable

namespace Letta
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// List Mcp Servers<br/>
        /// Get a list of all configured MCP servers
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.StdioMCPServer, global::Letta.SSEMCPServer, global::Letta.StreamableHTTPMCPServer>>> McpListMcpServersAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}