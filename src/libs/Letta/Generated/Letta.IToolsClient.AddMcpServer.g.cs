#nullable enable

namespace Letta
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Add Mcp Server To Config<br/>
        /// Add a new MCP server to the Letta MCP server config
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>>> AddMcpServerAsync(

            global::Letta.AnyOf<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Mcp Server To Config<br/>
        /// Add a new MCP server to the Letta MCP server config
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>>> AddMcpServerAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}