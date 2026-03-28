#nullable enable

namespace Letta
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Modify Message<br/>
        /// Update the details of a message associated with an agent.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="messageId">
        /// The ID of the message in the format 'message-&lt;uuid4&gt;'
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.ModifyMessageResponse> ModifyMessageAsync(
            string agentId,
            string messageId,

            global::Letta.AnyOf<global::Letta.UpdateSystemMessage, global::Letta.UpdateUserMessage, global::Letta.UpdateReasoningMessage, global::Letta.UpdateAssistantMessage> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Modify Message<br/>
        /// Update the details of a message associated with an agent.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="messageId">
        /// The ID of the message in the format 'message-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.ModifyMessageResponse> ModifyMessageAsync(
            string agentId,
            string messageId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}