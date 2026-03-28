#nullable enable

namespace Letta
{
    public partial interface IScheduledMessagesClient
    {
        /// <summary>
        /// Retrieve Scheduled Agent Message<br/>
        /// Retrieve a scheduled message by its ID for a specific agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="scheduledMessageId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.ScheduledMessagesRetrieveScheduledMessageResponse> ScheduledMessagesRetrieveScheduledMessageAsync(
            string agentId,
            string scheduledMessageId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}