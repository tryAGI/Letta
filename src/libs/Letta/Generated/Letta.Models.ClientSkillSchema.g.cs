
#nullable enable

namespace Letta
{
    /// <summary>
    /// Schema for a client-side skill passed in the request.<br/>
    /// Client-side skills represent environment-provided capabilities (e.g. project-scoped<br/>
    /// skills) that are not stored in the agent's MemFS but should appear in the system<br/>
    /// prompt's available skills section.
    /// </summary>
    public sealed partial class ClientSkillSchema
    {
        /// <summary>
        /// The name of the skill
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of what the skill does
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Path or location hint for the skill (e.g. skills/my-skill/SKILL.md)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Location { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSkillSchema" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the skill
        /// </param>
        /// <param name="description">
        /// Description of what the skill does
        /// </param>
        /// <param name="location">
        /// Path or location hint for the skill (e.g. skills/my-skill/SKILL.md)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientSkillSchema(
            string name,
            string description,
            string location)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Location = location ?? throw new global::System.ArgumentNullException(nameof(location));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSkillSchema" /> class.
        /// </summary>
        public ClientSkillSchema()
        {
        }
    }
}