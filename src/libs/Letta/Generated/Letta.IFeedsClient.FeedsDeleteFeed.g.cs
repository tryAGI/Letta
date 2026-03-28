#nullable enable

namespace Letta
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// Delete Feed<br/>
        /// Soft delete a feed and clean up its sequence
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.FeedsDeleteFeedResponse> FeedsDeleteFeedAsync(
            string feedId,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Feed<br/>
        /// Soft delete a feed and clean up its sequence
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.FeedsDeleteFeedResponse> FeedsDeleteFeedAsync(
            string feedId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}