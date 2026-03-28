#nullable enable

namespace Letta
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Retrieve Metrics For Run<br/>
        /// Get run metrics by run ID.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.RunMetrics> RetrieveMetricsForRunAsync(
            string runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}