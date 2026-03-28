#nullable enable

namespace Letta
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Delete Conversation<br/>
        /// Delete a conversation (soft delete).<br/>
        /// This marks the conversation as deleted but does not permanently remove it from the database.<br/>
        /// The conversation will no longer appear in list operations.<br/>
        /// Any isolated blocks associated with the conversation will be permanently deleted.
        /// </summary>
        /// <param name="conversationId">
        /// The ID of the conv in the format 'conv-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteConversationAsync(
            string conversationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}