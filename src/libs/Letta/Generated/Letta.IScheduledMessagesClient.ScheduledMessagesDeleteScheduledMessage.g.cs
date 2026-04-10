#nullable enable

namespace Letta
{
    public partial interface IScheduledMessagesClient
    {
        /// <summary>
        /// Delete Scheduled Agent Message<br/>
        /// Delete a scheduled message by its ID for a specific agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="scheduledMessageId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.ScheduledMessagesDeleteScheduledMessageResponse> ScheduledMessagesDeleteScheduledMessageAsync(
            string agentId,
            string scheduledMessageId,

            object request,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Scheduled Agent Message<br/>
        /// Delete a scheduled message by its ID for a specific agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="scheduledMessageId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.ScheduledMessagesDeleteScheduledMessageResponse> ScheduledMessagesDeleteScheduledMessageAsync(
            string agentId,
            string scheduledMessageId,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}