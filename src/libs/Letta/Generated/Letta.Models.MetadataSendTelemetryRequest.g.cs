
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetadataSendTelemetryRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.MetadataSendTelemetryRequestServiceJsonConverter))]
        public global::Letta.MetadataSendTelemetryRequestService Service { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_version")]
        public string? ServerVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Letta.EventsItem> Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSendTelemetryRequest" /> class.
        /// </summary>
        /// <param name="events"></param>
        /// <param name="service"></param>
        /// <param name="serverVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataSendTelemetryRequest(
            global::System.Collections.Generic.IList<global::Letta.EventsItem> events,
            global::Letta.MetadataSendTelemetryRequestService service,
            string? serverVersion)
        {
            this.Service = service;
            this.ServerVersion = serverVersion;
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSendTelemetryRequest" /> class.
        /// </summary>
        public MetadataSendTelemetryRequest()
        {
        }
    }
}