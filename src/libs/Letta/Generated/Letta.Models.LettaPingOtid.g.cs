
#nullable enable

namespace Letta
{
    /// <summary>
    /// The offline threading id (OTID). Set by the client to deduplicate requests. Used for idempotency in background streaming mode — each message in a request must have a unique OTID. Retries of the same request should reuse the same OTIDs.
    /// </summary>
    public sealed partial class LettaPingOtid
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}