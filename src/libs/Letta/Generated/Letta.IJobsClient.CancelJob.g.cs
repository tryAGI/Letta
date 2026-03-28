#nullable enable

namespace Letta
{
    public partial interface IJobsClient
    {
        /// <summary>
        /// Cancel Job<br/>
        /// Cancel a job by its job_id.<br/>
        /// This endpoint marks a job as cancelled, which will cause any associated<br/>
        /// agent execution to terminate as soon as possible.
        /// </summary>
        /// <param name="jobId">
        /// The ID of the job in the format 'job-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.Job> CancelJobAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}