#nullable enable

namespace Letta
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Create Pipeline<br/>
        /// Create a new pipeline (producer + feed + optionally subscribers)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.PipelinesCreatePipelineResponse> PipelinesCreatePipelineAsync(

            global::Letta.PipelinesCreatePipelineRequest request,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Pipeline<br/>
        /// Create a new pipeline (producer + feed + optionally subscribers)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="integrationType"></param>
        /// <param name="producerConfig"></param>
        /// <param name="subscriberAgentIds"></param>
        /// <param name="subscriberCronSchedule"></param>
        /// <param name="promptTemplate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.PipelinesCreatePipelineResponse> PipelinesCreatePipelineAsync(
            string name,
            string projectId,
            global::Letta.PipelinesCreatePipelineRequestIntegrationType integrationType,
            global::Letta.ProducerConfig producerConfig,
            global::System.Collections.Generic.IList<string>? subscriberAgentIds = default,
            string? subscriberCronSchedule = default,
            string? promptTemplate = default,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}