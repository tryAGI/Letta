
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAssistantMessage
    {
        /// <summary>
        /// Default Value: assistant_message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        public string? MessageType { get; set; }

        /// <summary>
        /// The message content sent by the assistant (can be a string or an array of content parts)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaAssistantMessageContentUnion>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.LettaAssistantMessageContentUnion>, string> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssistantMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The message content sent by the assistant (can be a string or an array of content parts)
        /// </param>
        /// <param name="messageType">
        /// Default Value: assistant_message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAssistantMessage(
            global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.LettaAssistantMessageContentUnion>, string> content,
            string? messageType)
        {
            this.MessageType = messageType;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssistantMessage" /> class.
        /// </summary>
        public UpdateAssistantMessage()
        {
        }
    }
}