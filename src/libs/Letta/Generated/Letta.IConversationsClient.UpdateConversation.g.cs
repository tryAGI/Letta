#nullable enable

namespace Letta
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Update Conversation<br/>
        /// Update a conversation.
        /// </summary>
        /// <param name="conversationId">
        /// The ID of the conv in the format 'conv-&lt;uuid4&gt;'
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.Conversation> UpdateConversationAsync(
            string conversationId,

            global::Letta.UpdateConversation request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Conversation<br/>
        /// Update a conversation.
        /// </summary>
        /// <param name="conversationId">
        /// The ID of the conv in the format 'conv-&lt;uuid4&gt;'
        /// </param>
        /// <param name="summary">
        /// A summary of the conversation.
        /// </param>
        /// <param name="model">
        /// The model handle for this conversation (overrides agent's model). Format: provider/model-name.
        /// </param>
        /// <param name="modelSettings">
        /// The model settings for this conversation (overrides agent's model settings).
        /// </param>
        /// <param name="lastMessageAt">
        /// Timestamp of the most recent message request sent to this conversation.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.Conversation> UpdateConversationAsync(
            string conversationId,
            string? summary = default,
            string? model = default,
            global::Letta.ModelSettingsVariant19? modelSettings = default,
            global::System.DateTime? lastMessageAt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}