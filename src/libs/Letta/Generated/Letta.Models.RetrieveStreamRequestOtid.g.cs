
#nullable enable

namespace Letta
{
    /// <summary>
    /// Offline threading ID to look up the run_id. Bypasses active run lookup if run_id not provided.
    /// </summary>
    public sealed partial class RetrieveStreamRequestOtid
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}