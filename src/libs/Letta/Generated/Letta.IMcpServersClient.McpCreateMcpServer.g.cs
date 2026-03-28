#nullable enable

namespace Letta
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Create Mcp Server<br/>
        /// Add a new MCP server to the Letta MCP server config
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.AnyOf<global::Letta.StdioMCPServer, global::Letta.SSEMCPServer, global::Letta.StreamableHTTPMCPServer>> McpCreateMcpServerAsync(

            global::Letta.CreateMCPServerRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Mcp Server<br/>
        /// Add a new MCP server to the Letta MCP server config
        /// </summary>
        /// <param name="serverName">
        /// The name of the MCP server
        /// </param>
        /// <param name="config">
        /// The MCP server configuration (Stdio, SSE, or Streamable HTTP)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.AnyOf<global::Letta.StdioMCPServer, global::Letta.SSEMCPServer, global::Letta.StreamableHTTPMCPServer>> McpCreateMcpServerAsync(
            string serverName,
            global::Letta.Config config,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}