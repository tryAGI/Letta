#nullable enable

namespace Letta
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Test Mcp Server<br/>
        /// Test connection to an MCP server without adding it.<br/>
        /// Returns the list of available tools if successful.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TestMcpServerAsync(

            global::Letta.AnyOf<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Mcp Server<br/>
        /// Test connection to an MCP server without adding it.<br/>
        /// Returns the list of available tools if successful.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> TestMcpServerAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}