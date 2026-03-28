#nullable enable

namespace Letta
{
    public partial interface IScheduledMessagesClient
    {
        /// <summary>
        /// Schedule Agent Message<br/>
        /// Schedule a message to be sent by the agent at a specified time or on a recurring basis.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.ScheduledMessagesScheduleAgentMessageResponse> ScheduledMessagesScheduleAgentMessageAsync(
            string agentId,

            global::Letta.ScheduledMessagesScheduleAgentMessageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Schedule Agent Message<br/>
        /// Schedule a message to be sent by the agent at a specified time or on a recurring basis.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="messages"></param>
        /// <param name="maxSteps"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="includeReturnMessageTypes"></param>
        /// <param name="schedule"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.ScheduledMessagesScheduleAgentMessageResponse> ScheduledMessagesScheduleAgentMessageAsync(
            string agentId,
            global::System.Collections.Generic.IList<global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessage> messages,
            global::Letta.OneOf<global::Letta.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1, global::Letta.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2> schedule,
            double? maxSteps = default,
            string? callbackUrl = default,
            global::System.Collections.Generic.IList<global::Letta.ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType>? includeReturnMessageTypes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}