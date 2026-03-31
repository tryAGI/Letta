#nullable enable

namespace Letta
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Fork Conversation<br/>
        /// Fork an existing conversation.<br/>
        /// Creates a new conversation that shares the same in-context messages as the source<br/>
        /// conversation, but with a newly compiled system message reflecting the latest memory<br/>
        /// block values. The forked conversation belongs to the same agent as the source.<br/>
        /// **Agent-direct mode**: Pass conversation_id="default" with agent_id query parameter<br/>
        /// to fork the agent's default (agent-direct) message history into a new conversation.<br/>
        /// **Deprecated**: Passing an agent ID as conversation_id still works but will be removed.
        /// </summary>
        /// <param name="conversationId">
        /// The conversation identifier. Can be a conversation ID ('conv-&lt;uuid4&gt;'), 'default' for agent-direct mode (with agent_id parameter), or an agent ID ('agent-&lt;uuid4&gt;') for backwards compatibility (deprecated).
        /// </param>
        /// <param name="agentId">
        /// Agent ID for agent-direct mode with 'default' conversation
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.Conversation> ForkConversationAsync(
            string conversationId,
            string? agentId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}