
#nullable enable

namespace Letta
{
    /// <summary>
    /// Effort level for supported Anthropic models (controls token spending). 'max' is only available on Opus 4.6. Not setting this gives similar performance to 'high'.
    /// </summary>
    public sealed partial class AnthropicModelSettingsEffort
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}