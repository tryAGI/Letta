
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1TypeJsonConverter))]
        public global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1Type? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_template")]
        public string? PromptTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("children")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Children { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("child_arg_nodes")]
        public global::System.Collections.Generic.IList<global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1ChildArgNode>? ChildArgNodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="children"></param>
        /// <param name="type"></param>
        /// <param name="promptTemplate"></param>
        /// <param name="childArgNodes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1(
            string toolName,
            global::System.Collections.Generic.IList<string> children,
            global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1Type? type,
            string? promptTemplate,
            global::System.Collections.Generic.IList<global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1ChildArgNode>? childArgNodes)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Type = type;
            this.PromptTemplate = promptTemplate;
            this.Children = children ?? throw new global::System.ArgumentNullException(nameof(children));
            this.ChildArgNodes = childArgNodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1" /> class.
        /// </summary>
        public TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1()
        {
        }
    }
}