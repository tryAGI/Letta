
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LettaStreamingResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.LettaStreamingResponseDiscriminatorMessageTypeJsonConverter))]
        public global::Letta.LettaStreamingResponseDiscriminatorMessageType? MessageType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaStreamingResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="messageType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LettaStreamingResponseDiscriminator(
            global::Letta.LettaStreamingResponseDiscriminatorMessageType? messageType)
        {
            this.MessageType = messageType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaStreamingResponseDiscriminator" /> class.
        /// </summary>
        public LettaStreamingResponseDiscriminator()
        {
        }
    }
}