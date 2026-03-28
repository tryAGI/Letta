#nullable enable

namespace Letta
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Get Pipeline<br/>
        /// Get a single pipeline with details
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.PipelinesGetPipelineResponse> PipelinesGetPipelineAsync(
            string pipelineId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}