#nullable enable

namespace Letta
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// List Subscription History<br/>
        /// List the run history for a subscription including scheduled runs, manual triggers, and backfills.
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="pageSize"></param>
        /// <param name="nextPageToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.FeedsListSubscriptionHistoryResponse> FeedsListSubscriptionHistoryAsync(
            string feedId,
            string subscriptionId,
            string? pageSize = default,
            string? nextPageToken = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}