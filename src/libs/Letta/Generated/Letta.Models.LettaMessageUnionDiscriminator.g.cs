
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LettaMessageUnionDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.LettaMessageUnionDiscriminatorMessageTypeJsonConverter))]
        public global::Letta.LettaMessageUnionDiscriminatorMessageType? MessageType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaMessageUnionDiscriminator" /> class.
        /// </summary>
        /// <param name="messageType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LettaMessageUnionDiscriminator(
            global::Letta.LettaMessageUnionDiscriminatorMessageType? messageType)
        {
            this.MessageType = messageType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaMessageUnionDiscriminator" /> class.
        /// </summary>
        public LettaMessageUnionDiscriminator()
        {
        }
    }
}