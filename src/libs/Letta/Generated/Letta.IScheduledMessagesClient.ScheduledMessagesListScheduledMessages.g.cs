#nullable enable

namespace Letta
{
    public partial interface IScheduledMessagesClient
    {
        /// <summary>
        /// List Scheduled Agent Messages<br/>
        /// List all scheduled messages for a specific agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.ScheduledMessagesListScheduledMessagesResponse> ScheduledMessagesListScheduledMessagesAsync(
            string agentId,
            string? limit = default,
            string? after = default,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}