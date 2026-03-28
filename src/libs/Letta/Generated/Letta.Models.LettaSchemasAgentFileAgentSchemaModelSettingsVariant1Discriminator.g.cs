
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LettaSchemasAgentFileAgentSchemaModelSettingsVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderTypeJsonConverter))]
        public global::Letta.LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType? ProviderType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasAgentFileAgentSchemaModelSettingsVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="providerType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LettaSchemasAgentFileAgentSchemaModelSettingsVariant1Discriminator(
            global::Letta.LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType? providerType)
        {
            this.ProviderType = providerType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasAgentFileAgentSchemaModelSettingsVariant1Discriminator" /> class.
        /// </summary>
        public LettaSchemasAgentFileAgentSchemaModelSettingsVariant1Discriminator()
        {
        }
    }
}