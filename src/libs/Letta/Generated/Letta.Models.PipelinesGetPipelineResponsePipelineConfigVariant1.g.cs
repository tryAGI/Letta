
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesGetPipelineResponsePipelineConfigVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.PipelinesGetPipelineResponsePipelineConfigVariant1TypeJsonConverter))]
        public global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant1Data Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesGetPipelineResponsePipelineConfigVariant1" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelinesGetPipelineResponsePipelineConfigVariant1(
            global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant1Data data,
            global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant1Type type)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesGetPipelineResponsePipelineConfigVariant1" /> class.
        /// </summary>
        public PipelinesGetPipelineResponsePipelineConfigVariant1()
        {
        }
    }
}