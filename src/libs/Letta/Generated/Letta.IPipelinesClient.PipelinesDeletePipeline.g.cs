#nullable enable

namespace Letta
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Delete Pipeline<br/>
        /// Soft delete a pipeline and cascade to feed + subscriptions
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.PipelinesDeletePipelineResponse> PipelinesDeletePipelineAsync(
            string pipelineId,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Pipeline<br/>
        /// Soft delete a pipeline and cascade to feed + subscriptions
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.PipelinesDeletePipelineResponse> PipelinesDeletePipelineAsync(
            string pipelineId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}