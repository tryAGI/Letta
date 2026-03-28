#nullable enable

namespace Letta
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Retrieve Usage For Run<br/>
        /// Get usage statistics for a run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.UsageStatistics> RetrieveUsageForRunAsync(
            string runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}