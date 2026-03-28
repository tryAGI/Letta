#nullable enable

namespace Letta
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Retrieve Run<br/>
        /// Get the status of a run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.Run> RetrieveRunAsync(
            string runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}