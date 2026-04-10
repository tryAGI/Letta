#nullable enable

namespace Letta
{
    public partial interface IArchivesClient
    {
        /// <summary>
        /// List Agents For Archive<br/>
        /// Get a list of agents that have access to an archive with pagination support.
        /// </summary>
        /// <param name="archiveId">
        /// The ID of the archive in the format 'archive-&lt;uuid4&gt;'
        /// </param>
        /// <param name="before">
        /// Agent ID cursor for pagination. Returns agents that come before this agent ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Agent ID cursor for pagination. Returns agents that come after this agent ID in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of agents to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="order">
        /// Sort order for agents by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="include">
        /// Specify which relational fields to include in the response. No relationships are included by default.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Letta.AgentState>> ListAgentsForArchiveAsync(
            string archiveId,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::Letta.ListAgentsForArchiveOrder? order = default,
            global::System.Collections.Generic.IList<global::Letta.ListAgentsForArchiveIncludeItem>? include = default,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}