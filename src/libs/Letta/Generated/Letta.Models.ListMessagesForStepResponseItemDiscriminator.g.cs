
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListMessagesForStepResponseItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.ListMessagesForStepResponseItemDiscriminatorMessageTypeJsonConverter))]
        public global::Letta.ListMessagesForStepResponseItemDiscriminatorMessageType? MessageType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMessagesForStepResponseItemDiscriminator" /> class.
        /// </summary>
        /// <param name="messageType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListMessagesForStepResponseItemDiscriminator(
            global::Letta.ListMessagesForStepResponseItemDiscriminatorMessageType? messageType)
        {
            this.MessageType = messageType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMessagesForStepResponseItemDiscriminator" /> class.
        /// </summary>
        public ListMessagesForStepResponseItemDiscriminator()
        {
        }
    }
}