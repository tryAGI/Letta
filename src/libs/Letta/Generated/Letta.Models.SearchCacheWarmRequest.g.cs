
#nullable enable

namespace Letta
{
    /// <summary>
    /// Request for warming an internal search cache.
    /// </summary>
    public sealed partial class SearchCacheWarmRequest
    {
        /// <summary>
        /// Embedded collection whose cache should be warmed.
        /// </summary>
        /// <default>"messages"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        public string Collection { get; set; } = "messages";

        /// <summary>
        /// Collection-specific scope. Messages currently infer organization from the authenticated actor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.MessageSearchCacheWarmScope Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCacheWarmRequest" /> class.
        /// </summary>
        /// <param name="scope">
        /// Collection-specific scope. Messages currently infer organization from the authenticated actor.
        /// </param>
        /// <param name="collection">
        /// Embedded collection whose cache should be warmed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchCacheWarmRequest(
            global::Letta.MessageSearchCacheWarmScope scope,
            string collection = "messages")
        {
            this.Collection = collection;
            this.Scope = scope ?? throw new global::System.ArgumentNullException(nameof(scope));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCacheWarmRequest" /> class.
        /// </summary>
        public SearchCacheWarmRequest()
        {
        }
    }
}