
#nullable enable

namespace Letta
{
    /// <summary>
    /// Response for internal search cache warming.
    /// </summary>
    public sealed partial class SearchCacheWarmResponse
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"messages"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        public string Collection { get; set; } = "messages";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warmed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Warmed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCacheWarmResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="warmed"></param>
        /// <param name="collection"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchCacheWarmResponse(
            string status,
            bool warmed,
            string collection = "messages")
        {
            this.Collection = collection;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Warmed = warmed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCacheWarmResponse" /> class.
        /// </summary>
        public SearchCacheWarmResponse()
        {
        }
    }
}