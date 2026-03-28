#nullable enable

namespace Letta
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// Publish Messages<br/>
        /// Batch insert messages into a feed (up to 10,000 per request)
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.FeedsPublishMessagesResponse> FeedsPublishMessagesAsync(
            string feedId,

            global::Letta.FeedsPublishMessagesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Publish Messages<br/>
        /// Batch insert messages into a feed (up to 10,000 per request)
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="messages"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.FeedsPublishMessagesResponse> FeedsPublishMessagesAsync(
            string feedId,
            global::System.Collections.Generic.IList<global::Letta.FeedsPublishMessagesRequestMessage> messages,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}