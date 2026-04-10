#nullable enable

namespace Letta
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Search Tools<br/>
        /// Search tools using semantic search.<br/>
        /// Requires tool embedding to be enabled (embed_tools=True). Uses vector search,<br/>
        /// full-text search, or hybrid mode to find tools matching the query.<br/>
        /// Returns tools ranked by relevance with their search scores.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Letta.ToolSearchResult>> SearchToolsAsync(

            global::Letta.ToolSearchRequest request,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search Tools<br/>
        /// Search tools using semantic search.<br/>
        /// Requires tool embedding to be enabled (embed_tools=True). Uses vector search,<br/>
        /// full-text search, or hybrid mode to find tools matching the query.<br/>
        /// Returns tools ranked by relevance with their search scores.
        /// </summary>
        /// <param name="query">
        /// Text query for semantic search.
        /// </param>
        /// <param name="searchMode">
        /// Search mode: vector, fts, or hybrid.<br/>
        /// Default Value: hybrid
        /// </param>
        /// <param name="toolTypes">
        /// Filter by tool types (e.g., 'custom', 'letta_core').
        /// </param>
        /// <param name="tags">
        /// Filter by tags (match any).
        /// </param>
        /// <param name="limit">
        /// Maximum number of results to return.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Letta.ToolSearchResult>> SearchToolsAsync(
            string? query = default,
            global::Letta.ToolSearchRequestSearchMode? searchMode = default,
            global::System.Collections.Generic.IList<string>? toolTypes = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            int? limit = default,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}