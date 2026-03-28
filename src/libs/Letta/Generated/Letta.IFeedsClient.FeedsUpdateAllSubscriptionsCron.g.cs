#nullable enable

namespace Letta
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// Update All Subscriptions Cron Schedule<br/>
        /// Update the cron schedule for all subscriptions of a feed
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.FeedsUpdateAllSubscriptionsCronResponse> FeedsUpdateAllSubscriptionsCronAsync(
            string feedId,

            global::Letta.FeedsUpdateAllSubscriptionsCronRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update All Subscriptions Cron Schedule<br/>
        /// Update the cron schedule for all subscriptions of a feed
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="cronSchedule"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.FeedsUpdateAllSubscriptionsCronResponse> FeedsUpdateAllSubscriptionsCronAsync(
            string feedId,
            string cronSchedule,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}