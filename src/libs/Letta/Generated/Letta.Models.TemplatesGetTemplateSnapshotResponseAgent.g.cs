
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesGetTemplateSnapshotResponseAgent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemPrompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SystemPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolIds")]
        public global::System.Collections.Generic.IList<string>? ToolIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceIds")]
        public global::System.Collections.Generic.IList<string>? SourceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoryVariables")]
        public global::Letta.TemplatesGetTemplateSnapshotResponseAgentMemoryVariables? MemoryVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolVariables")]
        public global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolVariables? ToolVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identityIds")]
        public global::System.Collections.Generic.IList<string>? IdentityIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolRules")]
        public global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant2, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9>>? ToolRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentAgentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.TemplatesGetTemplateSnapshotResponseAgentAgentType AgentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::Letta.TemplatesGetTemplateSnapshotResponseAgentProperties? Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entityId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseAgent" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="systemPrompt"></param>
        /// <param name="toolIds"></param>
        /// <param name="sourceIds"></param>
        /// <param name="memoryVariables"></param>
        /// <param name="toolVariables"></param>
        /// <param name="tags"></param>
        /// <param name="identityIds"></param>
        /// <param name="toolRules"></param>
        /// <param name="agentType"></param>
        /// <param name="properties"></param>
        /// <param name="entityId"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplatesGetTemplateSnapshotResponseAgent(
            string model,
            string systemPrompt,
            global::Letta.TemplatesGetTemplateSnapshotResponseAgentAgentType agentType,
            string entityId,
            string name,
            global::System.Collections.Generic.IList<string>? toolIds,
            global::System.Collections.Generic.IList<string>? sourceIds,
            global::Letta.TemplatesGetTemplateSnapshotResponseAgentMemoryVariables? memoryVariables,
            global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolVariables? toolVariables,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? identityIds,
            global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant2, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9>>? toolRules,
            global::Letta.TemplatesGetTemplateSnapshotResponseAgentProperties? properties)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.SystemPrompt = systemPrompt ?? throw new global::System.ArgumentNullException(nameof(systemPrompt));
            this.AgentType = agentType;
            this.EntityId = entityId ?? throw new global::System.ArgumentNullException(nameof(entityId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ToolIds = toolIds;
            this.SourceIds = sourceIds;
            this.MemoryVariables = memoryVariables;
            this.ToolVariables = toolVariables;
            this.Tags = tags;
            this.IdentityIds = identityIds;
            this.ToolRules = toolRules;
            this.Properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseAgent" /> class.
        /// </summary>
        public TemplatesGetTemplateSnapshotResponseAgent()
        {
        }
    }
}