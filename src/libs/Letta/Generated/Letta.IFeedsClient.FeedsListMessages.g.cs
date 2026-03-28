#nullable enable

namespace Letta
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// List Feed Messages<br/>
        /// List messages from a feed (for debugging/inspection)
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="afterSequence"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.FeedsListMessagesResponse> FeedsListMessagesAsync(
            string feedId,
            string? afterSequence = default,
            string? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}