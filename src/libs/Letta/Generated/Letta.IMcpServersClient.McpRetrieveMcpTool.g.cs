#nullable enable

namespace Letta
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Retrieve Mcp Tool<br/>
        /// Get a specific MCP tool by its ID
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="toolId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.Tool> McpRetrieveMcpToolAsync(
            string mcpServerId,
            string toolId,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}