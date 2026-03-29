
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesPreviewPipelineRequestProducerConfigVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.PipelinesPreviewPipelineRequestProducerConfigVariant1TypeJsonConverter))]
        public global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1Data Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesPreviewPipelineRequestProducerConfigVariant1" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelinesPreviewPipelineRequestProducerConfigVariant1(
            global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1Data data,
            global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1Type type)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesPreviewPipelineRequestProducerConfigVariant1" /> class.
        /// </summary>
        public PipelinesPreviewPipelineRequestProducerConfigVariant1()
        {
        }
    }
}