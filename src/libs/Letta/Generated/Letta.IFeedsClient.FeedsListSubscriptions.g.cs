#nullable enable

namespace Letta
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// List Feed Subscriptions<br/>
        /// List all agent subscriptions for a feed
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.FeedsListSubscriptionsResponse> FeedsListSubscriptionsAsync(
            string feedId,
            string? limit = default,
            global::Letta.OneOf<string, double?>? offset = default,
            string? agentId = default,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}