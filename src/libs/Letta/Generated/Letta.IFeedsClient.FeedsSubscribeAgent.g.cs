#nullable enable

namespace Letta
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// Subscribe Agent to Feed<br/>
        /// Subscribe an agent to a feed with polling configuration
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.FeedsSubscribeAgentResponse> FeedsSubscribeAgentAsync(
            string feedId,

            global::Letta.FeedsSubscribeAgentRequest request,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Subscribe Agent to Feed<br/>
        /// Subscribe an agent to a feed with polling configuration
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="agentId"></param>
        /// <param name="cronSchedule"></param>
        /// <param name="promptTemplate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.FeedsSubscribeAgentResponse> FeedsSubscribeAgentAsync(
            string feedId,
            string agentId,
            string cronSchedule,
            string? promptTemplate = default,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}