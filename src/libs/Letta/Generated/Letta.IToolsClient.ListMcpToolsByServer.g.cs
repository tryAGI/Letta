#nullable enable

namespace Letta
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// List Mcp Tools By Server<br/>
        /// Get a list of all tools for a specific MCP server
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Letta.MCPTool>> ListMcpToolsByServerAsync(
            string mcpServerName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}