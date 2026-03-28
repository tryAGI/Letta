
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesUpdatePipelineResponsePipelineConfigVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.PipelinesUpdatePipelineResponsePipelineConfigVariant1TypeJsonConverter))]
        public global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1Data Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesUpdatePipelineResponsePipelineConfigVariant1" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelinesUpdatePipelineResponsePipelineConfigVariant1(
            global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1Data data,
            global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1Type type)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesUpdatePipelineResponsePipelineConfigVariant1" /> class.
        /// </summary>
        public PipelinesUpdatePipelineResponsePipelineConfigVariant1()
        {
        }
    }
}