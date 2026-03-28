#nullable enable

namespace Letta
{
    public partial interface IMessagesClient
    {
        /// <summary>
        /// Retrieve Batch<br/>
        /// Retrieve the status and details of a batch run.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.BatchJob> RetrieveBatchAsync(
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}