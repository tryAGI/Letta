
#nullable enable

namespace Letta
{
    /// <summary>
    /// Messages sent by an end user, containing prompts or additional context<br/>
    /// information.
    /// </summary>
    public sealed partial class ChatCompletionUserMessageParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartImageParam, global::Letta.ChatCompletionContentPartInputAudioParam, global::Letta.File>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartImageParam, global::Letta.ChatCompletionContentPartInputAudioParam, global::Letta.File>>> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"user"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string Role { get; set; } = "user";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessageParam" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="role"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionUserMessageParam(
            global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartImageParam, global::Letta.ChatCompletionContentPartInputAudioParam, global::Letta.File>>> content,
            string? name,
            string role = "user")
        {
            this.Content = content;
            this.Role = role;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionUserMessageParam" /> class.
        /// </summary>
        public ChatCompletionUserMessageParam()
        {
        }
    }
}