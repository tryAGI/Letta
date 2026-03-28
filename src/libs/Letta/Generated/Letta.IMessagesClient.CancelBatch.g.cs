#nullable enable

namespace Letta
{
    public partial interface IMessagesClient
    {
        /// <summary>
        /// Cancel Batch<br/>
        /// Cancel a batch run.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CancelBatchAsync(
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}