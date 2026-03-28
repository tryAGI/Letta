
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Letta
{
    /// <summary>
    /// A property of an identity
    /// </summary>
    public sealed partial class IdentityProperty
    {
        /// <summary>
        /// The key of the property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The value of the property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.AnyOf<string, int?, double?, bool?, object> Value { get; set; }

        /// <summary>
        /// The type of the property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.IdentityPropertyTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.IdentityPropertyType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProperty" /> class.
        /// </summary>
        /// <param name="key">
        /// The key of the property
        /// </param>
        /// <param name="value">
        /// The value of the property
        /// </param>
        /// <param name="type">
        /// The type of the property
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdentityProperty(
            string key,
            global::Letta.AnyOf<string, int?, double?, bool?, object> value,
            global::Letta.IdentityPropertyType type)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProperty" /> class.
        /// </summary>
        public IdentityProperty()
        {
        }
    }
}