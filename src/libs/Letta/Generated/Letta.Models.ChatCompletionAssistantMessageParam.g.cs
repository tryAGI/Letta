
#nullable enable

namespace Letta
{
    /// <summary>
    /// Messages sent by the model in response to user messages.
    /// </summary>
    public sealed partial class ChatCompletionAssistantMessageParam
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"assistant"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string Role { get; set; } = "assistant";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::Letta.Audio? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartRefusalParam>>, object>))]
        public global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartRefusalParam>>, object>? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_call")]
        public global::Letta.FunctionCallInput? FunctionCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refusal")]
        public string? Refusal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionMessageFunctionToolCallParam, global::Letta.ChatCompletionMessageCustomToolCallParam>>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionAssistantMessageParam" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="audio"></param>
        /// <param name="content"></param>
        /// <param name="functionCall"></param>
        /// <param name="name"></param>
        /// <param name="refusal"></param>
        /// <param name="toolCalls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionAssistantMessageParam(
            global::Letta.Audio? audio,
            global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartRefusalParam>>, object>? content,
            global::Letta.FunctionCallInput? functionCall,
            string? name,
            string? refusal,
            global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionMessageFunctionToolCallParam, global::Letta.ChatCompletionMessageCustomToolCallParam>>? toolCalls,
            string role = "assistant")
        {
            this.Role = role;
            this.Audio = audio;
            this.Content = content;
            this.FunctionCall = functionCall;
            this.Name = name;
            this.Refusal = refusal;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionAssistantMessageParam" /> class.
        /// </summary>
        public ChatCompletionAssistantMessageParam()
        {
        }
    }
}