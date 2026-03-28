#nullable enable

namespace Letta
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Delete Job<br/>
        /// Delete a job by its job_id.
        /// </summary>
        /// <param name="jobId">
        /// The ID of the job in the format 'job-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.Job> DeleteJobAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}