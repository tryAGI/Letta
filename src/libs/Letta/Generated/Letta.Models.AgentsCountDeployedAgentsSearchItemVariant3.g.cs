
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsCountDeployedAgentsSearchItemVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant3FieldJsonConverter))]
        public global::Letta.AgentsCountDeployedAgentsSearchItemVariant3Field Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant3OperatorJsonConverter))]
        public global::Letta.AgentsCountDeployedAgentsSearchItemVariant3Operator Operator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsCountDeployedAgentsSearchItemVariant3" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="operator"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsCountDeployedAgentsSearchItemVariant3(
            global::System.Collections.Generic.IList<string> value,
            global::Letta.AgentsCountDeployedAgentsSearchItemVariant3Field field,
            global::Letta.AgentsCountDeployedAgentsSearchItemVariant3Operator @operator)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Field = field;
            this.Operator = @operator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsCountDeployedAgentsSearchItemVariant3" /> class.
        /// </summary>
        public AgentsCountDeployedAgentsSearchItemVariant3()
        {
        }
    }
}