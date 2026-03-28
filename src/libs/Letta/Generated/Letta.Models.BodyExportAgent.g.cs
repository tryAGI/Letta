
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyExportAgent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec")]
        public global::Letta.AgentFileSchema? Spec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("legacy_spec")]
        public global::Letta.LettaSerializeSchemasPydanticAgentSchemaAgentSchema? LegacySpec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyExportAgent" /> class.
        /// </summary>
        /// <param name="spec"></param>
        /// <param name="legacySpec"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyExportAgent(
            global::Letta.AgentFileSchema? spec,
            global::Letta.LettaSerializeSchemasPydanticAgentSchemaAgentSchema? legacySpec)
        {
            this.Spec = spec;
            this.LegacySpec = legacySpec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyExportAgent" /> class.
        /// </summary>
        public BodyExportAgent()
        {
        }
    }
}