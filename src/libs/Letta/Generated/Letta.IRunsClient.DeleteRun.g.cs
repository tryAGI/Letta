#nullable enable

namespace Letta
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Delete Run<br/>
        /// Delete a run by its run_id.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteRunAsync(
            string runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}