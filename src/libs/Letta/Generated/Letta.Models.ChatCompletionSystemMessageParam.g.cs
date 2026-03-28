
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Letta
{
    /// <summary>
    /// Developer-provided instructions that the model should follow, regardless of<br/>
    /// messages sent by the user. With o1 models and newer, use `developer` messages<br/>
    /// for this purpose instead.
    /// </summary>
    public sealed partial class ChatCompletionSystemMessageParam
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
        /// <default>"system"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string Role { get; set; } = "system";

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
        /// Initializes a new instance of the <see cref="ChatCompletionSystemMessageParam" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="role"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionSystemMessageParam(
            global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.ChatCompletionContentPartTextParam>> content,
            string? name,
            string role = "system")
        {
            this.Content = content;
            this.Role = role;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionSystemMessageParam" /> class.
        /// </summary>
        public ChatCompletionSystemMessageParam()
        {
        }
    }
}