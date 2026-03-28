
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduledMessagesRetrieveScheduledMessageResponseMessageMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2>>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.OneOf<global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2>>, string> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otid")]
        public string? Otid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender_id")]
        public string? SenderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageTypeJsonConverter))]
        public global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesRetrieveScheduledMessageResponseMessageMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="role"></param>
        /// <param name="name"></param>
        /// <param name="otid"></param>
        /// <param name="senderId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduledMessagesRetrieveScheduledMessageResponseMessageMessage(
            global::Letta.OneOf<global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2>>, string> content,
            global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRole role,
            string? name,
            string? otid,
            string? senderId,
            global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageType? type)
        {
            this.Content = content;
            this.Role = role;
            this.Name = name;
            this.Otid = otid;
            this.SenderId = senderId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesRetrieveScheduledMessageResponseMessageMessage" /> class.
        /// </summary>
        public ScheduledMessagesRetrieveScheduledMessageResponseMessageMessage()
        {
        }
    }
}