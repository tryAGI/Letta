#nullable enable

namespace Letta
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Retrieve Conversation<br/>
        /// Retrieve a specific conversation.
        /// </summary>
        /// <param name="conversationId">
        /// The ID of the conv in the format 'conv-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.Conversation> RetrieveConversationAsync(
            string conversationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}