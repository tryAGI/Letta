#nullable enable

namespace Letta
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Preview Pipeline<br/>
        /// Fetch sample messages from integration to preview what agents will receive
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.PipelinesPreviewPipelineResponse> PipelinesPreviewPipelineAsync(

            global::Letta.PipelinesPreviewPipelineRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview Pipeline<br/>
        /// Fetch sample messages from integration to preview what agents will receive
        /// </summary>
        /// <param name="integrationType"></param>
        /// <param name="integrationId"></param>
        /// <param name="producerConfig"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.PipelinesPreviewPipelineResponse> PipelinesPreviewPipelineAsync(
            global::Letta.PipelinesPreviewPipelineRequestIntegrationType integrationType,
            string integrationId,
            global::Letta.ProducerConfig3 producerConfig,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}