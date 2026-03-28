
#nullable enable

namespace Letta
{
    /// <summary>
    /// The stop reason from Letta indicating why agent loop stopped execution.
    /// </summary>
    public sealed partial class LettaStopReason
    {
        /// <summary>
        /// The type of the message.<br/>
        /// Default Value: stop_reason
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        public string? MessageType { get; set; }

        /// <summary>
        /// The reason why execution stopped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.StopReasonTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.StopReasonType StopReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaStopReason" /> class.
        /// </summary>
        /// <param name="messageType">
        /// The type of the message.<br/>
        /// Default Value: stop_reason
        /// </param>
        /// <param name="stopReason">
        /// The reason why execution stopped.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LettaStopReason(
            global::Letta.StopReasonType stopReason,
            string? messageType)
        {
            this.StopReason = stopReason;
            this.MessageType = messageType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaStopReason" /> class.
        /// </summary>
        public LettaStopReason()
        {
        }
    }
}