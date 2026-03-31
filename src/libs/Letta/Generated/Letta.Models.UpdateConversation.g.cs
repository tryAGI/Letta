
#nullable enable

namespace Letta
{
    /// <summary>
    /// Request model for updating a conversation.
    /// </summary>
    public sealed partial class UpdateConversation
    {
        /// <summary>
        /// A summary of the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// The model handle for this conversation (overrides agent's model). Format: provider/model-name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The model settings for this conversation (overrides agent's model settings).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_settings")]
        public global::Letta.ModelSettingsVariant19? ModelSettings { get; set; }

        /// <summary>
        /// Timestamp of the most recent message request sent to this conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_message_at")]
        public global::System.DateTime? LastMessageAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConversation" /> class.
        /// </summary>
        /// <param name="summary">
        /// A summary of the conversation.
        /// </param>
        /// <param name="model">
        /// The model handle for this conversation (overrides agent's model). Format: provider/model-name.
        /// </param>
        /// <param name="modelSettings">
        /// The model settings for this conversation (overrides agent's model settings).
        /// </param>
        /// <param name="lastMessageAt">
        /// Timestamp of the most recent message request sent to this conversation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateConversation(
            string? summary,
            string? model,
            global::Letta.ModelSettingsVariant19? modelSettings,
            global::System.DateTime? lastMessageAt)
        {
            this.Summary = summary;
            this.Model = model;
            this.ModelSettings = modelSettings;
            this.LastMessageAt = lastMessageAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConversation" /> class.
        /// </summary>
        public UpdateConversation()
        {
        }
    }
}