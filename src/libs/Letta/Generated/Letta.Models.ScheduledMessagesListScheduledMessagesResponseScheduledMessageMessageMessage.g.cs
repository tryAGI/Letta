
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2>>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.OneOf<global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2>>, string> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageRole Role { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageTypeJsonConverter))]
        public global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessage" /> class.
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
        public ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessage(
            global::Letta.OneOf<global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2>>, string> content,
            global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageRole role,
            string? name,
            string? otid,
            string? senderId,
            global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageType? type)
        {
            this.Content = content;
            this.Role = role;
            this.Name = name;
            this.Otid = otid;
            this.SenderId = senderId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessage" /> class.
        /// </summary>
        public ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessage()
        {
        }
    }
}