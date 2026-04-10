#nullable enable

namespace Letta
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Search Messages<br/>
        /// Search messages across the entire organization with optional project and template filtering. Returns messages with FTS/vector ranks and total RRF score.<br/>
        /// This is a cloud-only feature.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Letta.MessageSearchResult>> SearchMessagesAsync(

            global::Letta.MessageSearchRequest request,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search Messages<br/>
        /// Search messages across the entire organization with optional project and template filtering. Returns messages with FTS/vector ranks and total RRF score.<br/>
        /// This is a cloud-only feature.
        /// </summary>
        /// <param name="query">
        /// Text query for full-text search
        /// </param>
        /// <param name="searchMode">
        /// Search mode to use<br/>
        /// Default Value: hybrid
        /// </param>
        /// <param name="roles">
        /// Filter messages by role
        /// </param>
        /// <param name="agentId">
        /// Filter messages by agent ID
        /// </param>
        /// <param name="projectId">
        /// Filter messages by project ID
        /// </param>
        /// <param name="templateId">
        /// Filter messages by template ID
        /// </param>
        /// <param name="conversationId">
        /// Filter messages by conversation ID
        /// </param>
        /// <param name="limit">
        /// Maximum number of results to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="startDate">
        /// Filter messages created after this date
        /// </param>
        /// <param name="endDate">
        /// Filter messages created on or before this date
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Letta.MessageSearchResult>> SearchMessagesAsync(
            string? query = default,
            global::Letta.MessageSearchRequestSearchMode? searchMode = default,
            global::System.Collections.Generic.IList<global::Letta.MessageRole>? roles = default,
            string? agentId = default,
            string? projectId = default,
            string? templateId = default,
            string? conversationId = default,
            int? limit = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}