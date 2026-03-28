#nullable enable

namespace Letta
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Connect Mcp Server<br/>
        /// Connect to an MCP server with support for OAuth via SSE.<br/>
        /// Returns a stream of events handling authorization state and exchange if OAuth is required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ConnectMcpServerAsync(

            global::Letta.AnyOf<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Connect Mcp Server<br/>
        /// Connect to an MCP server with support for OAuth via SSE.<br/>
        /// Returns a stream of events handling authorization state and exchange if OAuth is required.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ConnectMcpServerAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}