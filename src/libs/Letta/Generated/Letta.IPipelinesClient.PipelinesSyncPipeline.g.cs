#nullable enable

namespace Letta
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Sync Pipeline<br/>
        /// Manually trigger a pipeline sync to fetch new messages immediately
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.PipelinesSyncPipelineResponse> PipelinesSyncPipelineAsync(
            string pipelineId,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sync Pipeline<br/>
        /// Manually trigger a pipeline sync to fetch new messages immediately
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.PipelinesSyncPipelineResponse> PipelinesSyncPipelineAsync(
            string pipelineId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}