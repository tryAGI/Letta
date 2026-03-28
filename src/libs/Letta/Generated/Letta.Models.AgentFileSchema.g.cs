
#nullable enable

namespace Letta
{
    /// <summary>
    /// Schema for serialized agent file that can be exported to JSON and imported into agent server.
    /// </summary>
    public sealed partial class AgentFileSchema
    {
        /// <summary>
        /// List of agents in this agent file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Letta.LettaSchemasAgentFileAgentSchema> Agents { get; set; }

        /// <summary>
        /// List of groups in this agent file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Letta.GroupSchema> Groups { get; set; }

        /// <summary>
        /// List of memory blocks in this agent file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Letta.BlockSchema> Blocks { get; set; }

        /// <summary>
        /// List of files in this agent file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Letta.FileSchema> Files { get; set; }

        /// <summary>
        /// List of sources in this agent file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Letta.SourceSchema> Sources { get; set; }

        /// <summary>
        /// List of tools in this agent file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Letta.LettaSchemasAgentFileToolSchema> Tools { get; set; }

        /// <summary>
        /// List of MCP servers in this agent file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_servers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Letta.MCPServerSchema> McpServers { get; set; }

        /// <summary>
        /// List of skills in this agent file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<global::Letta.SkillSchema>? Skills { get; set; }

        /// <summary>
        /// Metadata for this agent file, including revision_id and other export information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The timestamp when the object was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentFileSchema" /> class.
        /// </summary>
        /// <param name="agents">
        /// List of agents in this agent file
        /// </param>
        /// <param name="groups">
        /// List of groups in this agent file
        /// </param>
        /// <param name="blocks">
        /// List of memory blocks in this agent file
        /// </param>
        /// <param name="files">
        /// List of files in this agent file
        /// </param>
        /// <param name="sources">
        /// List of sources in this agent file
        /// </param>
        /// <param name="tools">
        /// List of tools in this agent file
        /// </param>
        /// <param name="mcpServers">
        /// List of MCP servers in this agent file
        /// </param>
        /// <param name="skills">
        /// List of skills in this agent file
        /// </param>
        /// <param name="metadata">
        /// Metadata for this agent file, including revision_id and other export information.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the object was created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentFileSchema(
            global::System.Collections.Generic.IList<global::Letta.LettaSchemasAgentFileAgentSchema> agents,
            global::System.Collections.Generic.IList<global::Letta.GroupSchema> groups,
            global::System.Collections.Generic.IList<global::Letta.BlockSchema> blocks,
            global::System.Collections.Generic.IList<global::Letta.FileSchema> files,
            global::System.Collections.Generic.IList<global::Letta.SourceSchema> sources,
            global::System.Collections.Generic.IList<global::Letta.LettaSchemasAgentFileToolSchema> tools,
            global::System.Collections.Generic.IList<global::Letta.MCPServerSchema> mcpServers,
            global::System.Collections.Generic.IList<global::Letta.SkillSchema>? skills,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.DateTime? createdAt)
        {
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
            this.Groups = groups ?? throw new global::System.ArgumentNullException(nameof(groups));
            this.Blocks = blocks ?? throw new global::System.ArgumentNullException(nameof(blocks));
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.Sources = sources ?? throw new global::System.ArgumentNullException(nameof(sources));
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.McpServers = mcpServers ?? throw new global::System.ArgumentNullException(nameof(mcpServers));
            this.Skills = skills;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentFileSchema" /> class.
        /// </summary>
        public AgentFileSchema()
        {
        }
    }
}