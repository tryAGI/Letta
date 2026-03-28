
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesPreviewPipelineRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.PipelinesPreviewPipelineRequestIntegrationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.PipelinesPreviewPipelineRequestIntegrationType IntegrationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("producer_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.ProducerConfig3JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.ProducerConfig3 ProducerConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesPreviewPipelineRequest" /> class.
        /// </summary>
        /// <param name="integrationType"></param>
        /// <param name="integrationId"></param>
        /// <param name="producerConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelinesPreviewPipelineRequest(
            global::Letta.PipelinesPreviewPipelineRequestIntegrationType integrationType,
            string integrationId,
            global::Letta.ProducerConfig3 producerConfig)
        {
            this.IntegrationType = integrationType;
            this.IntegrationId = integrationId ?? throw new global::System.ArgumentNullException(nameof(integrationId));
            this.ProducerConfig = producerConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesPreviewPipelineRequest" /> class.
        /// </summary>
        public PipelinesPreviewPipelineRequest()
        {
        }
    }
}