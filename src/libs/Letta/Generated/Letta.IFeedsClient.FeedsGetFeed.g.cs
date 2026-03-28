#nullable enable

namespace Letta
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// Get Feed<br/>
        /// Retrieve feed details by ID
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.FeedsGetFeedResponse> FeedsGetFeedAsync(
            string feedId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}