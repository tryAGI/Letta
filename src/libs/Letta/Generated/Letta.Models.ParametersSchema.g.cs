
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ParametersSchema
    {
        /// <summary>
        /// Default Value: object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Letta.ParameterProperties> Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametersSchema" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: object
        /// </param>
        /// <param name="properties"></param>
        /// <param name="required"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParametersSchema(
            global::System.Collections.Generic.Dictionary<string, global::Letta.ParameterProperties> properties,
            string? type,
            global::System.Collections.Generic.IList<string>? required)
        {
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
            this.Type = type;
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametersSchema" /> class.
        /// </summary>
        public ParametersSchema()
        {
        }
    }
}