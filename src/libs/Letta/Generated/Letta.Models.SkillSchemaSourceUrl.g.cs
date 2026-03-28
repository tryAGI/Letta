
#nullable enable

namespace Letta
{
    /// <summary>
    /// Source URL for skill resolution (e.g., 'letta:slack', 'anthropic:pdf', 'owner/repo/path')
    /// </summary>
    public sealed partial class SkillSchemaSourceUrl
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}