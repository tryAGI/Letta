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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.Conversation> RetrieveConversationAsync(
            string conversationId,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}