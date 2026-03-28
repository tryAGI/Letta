#nullable enable

namespace Letta
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Update Mcp Server<br/>
        /// Update an existing MCP server configuration
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.AnyOf<global::Letta.StdioMCPServer, global::Letta.SSEMCPServer, global::Letta.StreamableHTTPMCPServer>> McpUpdateMcpServerAsync(
            string mcpServerId,

            global::Letta.UpdateMCPServerRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Mcp Server<br/>
        /// Update an existing MCP server configuration
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="serverName">
        /// The name of the MCP server
        /// </param>
        /// <param name="config">
        /// The MCP server configuration updates (Stdio, SSE, or Streamable HTTP)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.AnyOf<global::Letta.StdioMCPServer, global::Letta.SSEMCPServer, global::Letta.StreamableHTTPMCPServer>> McpUpdateMcpServerAsync(
            string mcpServerId,
            global::Letta.Config4 config,
            string? serverName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}