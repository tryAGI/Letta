#nullable enable

namespace Letta
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Update Pipeline<br/>
        /// Update pipeline name or disable/enable it
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.PipelinesUpdatePipelineResponse> PipelinesUpdatePipelineAsync(
            string pipelineId,

            global::Letta.PipelinesUpdatePipelineRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Pipeline<br/>
        /// Update pipeline name or disable/enable it
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="name"></param>
        /// <param name="disabled"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.PipelinesUpdatePipelineResponse> PipelinesUpdatePipelineAsync(
            string pipelineId,
            string? name = default,
            bool? disabled = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}