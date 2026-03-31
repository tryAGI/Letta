#nullable enable

namespace Letta
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Recompile Conversation<br/>
        /// Manually trigger system prompt recompilation for a conversation.
        /// </summary>
        /// <param name="conversationId">
        /// The conversation identifier. Can be a conversation ID ('conv-&lt;uuid4&gt;'), 'default' for agent-direct mode (with agent_id parameter), or an agent ID ('agent-&lt;uuid4&gt;') for backwards compatibility (deprecated).
        /// </param>
        /// <param name="dryRun">
        /// If True, do not persist changes; still returns the compiled system prompt.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RecompileConversationAsync(
            string conversationId,

            global::Letta.LettaServerRestApiRoutersV1ConversationsCompactionRequest request,
            bool? dryRun = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recompile Conversation<br/>
        /// Manually trigger system prompt recompilation for a conversation.
        /// </summary>
        /// <param name="conversationId">
        /// The conversation identifier. Can be a conversation ID ('conv-&lt;uuid4&gt;'), 'default' for agent-direct mode (with agent_id parameter), or an agent ID ('agent-&lt;uuid4&gt;') for backwards compatibility (deprecated).
        /// </param>
        /// <param name="dryRun">
        /// If True, do not persist changes; still returns the compiled system prompt.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> RecompileConversationAsync(
            string conversationId,
            bool? dryRun = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}