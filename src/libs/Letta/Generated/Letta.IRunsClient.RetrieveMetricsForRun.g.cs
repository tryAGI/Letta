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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.RunMetrics> RetrieveMetricsForRunAsync(
            string runId,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}