
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsSearchDeployedAgentsRequestSearchItemVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant1FieldJsonConverter))]
        public global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant1Field Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsSearchDeployedAgentsRequestSearchItemVariant1" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsSearchDeployedAgentsRequestSearchItemVariant1(
            string value,
            global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant1Field field)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Field = field;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsSearchDeployedAgentsRequestSearchItemVariant1" /> class.
        /// </summary>
        public AgentsSearchDeployedAgentsRequestSearchItemVariant1()
        {
        }
    }
}