
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyVersionJsonConverter))]
        public global::Letta.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyVersion Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Letta.DataItem> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicy" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicy(
            global::System.Collections.Generic.IList<global::Letta.DataItem> data,
            global::Letta.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyVersion version)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicy" /> class.
        /// </summary>
        public ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicy()
        {
        }
    }
}