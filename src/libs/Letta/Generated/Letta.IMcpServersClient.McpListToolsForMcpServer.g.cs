#nullable enable

namespace Letta
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// List Tools For Mcp Server<br/>
        /// Get a list of all tools for a specific MCP server
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Letta.Tool>> McpListToolsForMcpServerAsync(
            string mcpServerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}