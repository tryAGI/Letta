
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesCreatePipelineRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.PipelinesCreatePipelineRequestIntegrationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.PipelinesCreatePipelineRequestIntegrationType IntegrationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("producer_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.ProducerConfigJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.ProducerConfig ProducerConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriber_agent_ids")]
        public global::System.Collections.Generic.IList<string>? SubscriberAgentIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriber_cron_schedule")]
        public string? SubscriberCronSchedule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesCreatePipelineRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="integrationType"></param>
        /// <param name="producerConfig"></param>
        /// <param name="subscriberAgentIds"></param>
        /// <param name="subscriberCronSchedule"></param>
        /// <param name="promptTemplate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelinesCreatePipelineRequest(
            string name,
            string projectId,
            global::Letta.PipelinesCreatePipelineRequestIntegrationType integrationType,
            global::Letta.ProducerConfig producerConfig,
            global::System.Collections.Generic.IList<string>? subscriberAgentIds,
            string? subscriberCronSchedule,
            string? promptTemplate)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.IntegrationType = integrationType;
            this.ProducerConfig = producerConfig;
            this.SubscriberAgentIds = subscriberAgentIds;
            this.SubscriberCronSchedule = subscriberCronSchedule;
            this.PromptTemplate = promptTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesCreatePipelineRequest" /> class.
        /// </summary>
        public PipelinesCreatePipelineRequest()
        {
        }
    }
}