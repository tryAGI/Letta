#nullable enable

namespace Letta
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// List Pipeline Sync History<br/>
        /// List the sync run history for a pipeline from Temporal with error details
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.PipelinesListPipelineSyncHistoryResponse> PipelinesListPipelineSyncHistoryAsync(
            string pipelineId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}