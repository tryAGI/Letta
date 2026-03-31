
#nullable enable

namespace Letta
{
    /// <summary>
    /// Client-side skills available in the environment. These are rendered in the system prompt's available skills section alongside agent-scoped skills from MemFS.
    /// </summary>
    public sealed partial class LettaStreamingRequestClientSkills
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}