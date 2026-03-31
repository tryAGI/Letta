
#nullable enable

namespace Letta
{
    /// <summary>
    /// Run ID to stream directly, bypassing run lookup. Use for recovery from duplicate requests.
    /// </summary>
    public sealed partial class RetrieveStreamRequestRunId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}