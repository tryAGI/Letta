
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionToolMessageParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.ChatCompletionContentPartTextParam>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.ChatCompletionContentPartTextParam>> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"tool"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string Role { get; set; } = "tool";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionToolMessageParam" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="role"></param>
        /// <param name="toolCallId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionToolMessageParam(
            global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.ChatCompletionContentPartTextParam>> content,
            string toolCallId,
            string role = "tool")
        {
            this.Content = content;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionToolMessageParam" /> class.
        /// </summary>
        public ChatCompletionToolMessageParam()
        {
        }
    }
}