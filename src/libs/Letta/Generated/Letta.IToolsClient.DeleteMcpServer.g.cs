#nullable enable

namespace Letta
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Delete Mcp Server From Config<br/>
        /// Delete a MCP server configuration
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>>> DeleteMcpServerAsync(
            string mcpServerName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}