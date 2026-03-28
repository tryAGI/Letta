#nullable enable

namespace Letta
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// List Conversations<br/>
        /// List all conversations for an agent (or all conversations if agent_id not provided).
        /// </summary>
        /// <param name="agentId">
        /// The agent ID to list conversations for (optional - returns all conversations if not provided)
        /// </param>
        /// <param name="limit">
        /// Maximum number of conversations to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="after">
        /// Cursor for pagination (conversation ID)
        /// </param>
        /// <param name="summarySearch">
        /// Search for text within conversation summaries
        /// </param>
        /// <param name="order">
        /// Sort order for conversations. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Letta.Conversation>> ListConversationsAsync(
            string? agentId = default,
            int? limit = default,
            string? after = default,
            string? summarySearch = default,
            global::Letta.ListConversationsOrder? order = default,
            global::Letta.ListConversationsOrderBy? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}