#nullable enable

namespace Letta
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Add Mcp Tool<br/>
        /// Register a new MCP tool as a Letta server by MCP server + tool name
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="mcpToolName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.Tool> AddMcpToolAsync(
            string mcpServerName,
            string mcpToolName,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}