
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentsSendMessageRequestMessageVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant1RoleJsonConverter))]
        public global::Letta.EnvironmentsSendMessageRequestMessageVariant1Role Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.OneOf<string, global::System.Collections.Generic.IList<global::Letta.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item>> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_message_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientMessageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otid")]
        public string? Otid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsSendMessageRequestMessageVariant1" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="clientMessageId"></param>
        /// <param name="otid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentsSendMessageRequestMessageVariant1(
            global::Letta.OneOf<string, global::System.Collections.Generic.IList<global::Letta.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item>> content,
            string clientMessageId,
            global::Letta.EnvironmentsSendMessageRequestMessageVariant1Role role,
            string? otid)
        {
            this.Content = content;
            this.ClientMessageId = clientMessageId ?? throw new global::System.ArgumentNullException(nameof(clientMessageId));
            this.Role = role;
            this.Otid = otid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsSendMessageRequestMessageVariant1" /> class.
        /// </summary>
        public EnvironmentsSendMessageRequestMessageVariant1()
        {
        }
    }
}