#nullable enable

namespace Letta
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Retrieve Job<br/>
        /// Get the status of a job.
        /// </summary>
        /// <param name="jobId">
        /// The ID of the job in the format 'job-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.Job> RetrieveJobAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}