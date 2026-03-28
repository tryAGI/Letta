
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetadataSendTelemetryRequestEventVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant3TypeJsonConverter))]
        public global::Letta.MetadataSendTelemetryRequestEventVariant3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.MetadataSendTelemetryRequestEventVariant3Data Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSendTelemetryRequestEventVariant3" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="timestamp"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataSendTelemetryRequestEventVariant3(
            string timestamp,
            global::Letta.MetadataSendTelemetryRequestEventVariant3Data data,
            global::Letta.MetadataSendTelemetryRequestEventVariant3Type type)
        {
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSendTelemetryRequestEventVariant3" /> class.
        /// </summary>
        public MetadataSendTelemetryRequestEventVariant3()
        {
        }
    }
}