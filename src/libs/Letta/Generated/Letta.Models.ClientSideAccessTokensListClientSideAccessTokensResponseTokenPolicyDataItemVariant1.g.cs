
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1TypeJsonConverter))]
        public global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Acces> Access { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="access"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1(
            string id,
            global::System.Collections.Generic.IList<global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Acces> access,
            global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Type type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Access = access ?? throw new global::System.ArgumentNullException(nameof(access));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1" /> class.
        /// </summary>
        public ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1()
        {
        }
    }
}