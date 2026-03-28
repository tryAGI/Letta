
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupUpdateManagerConfigVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manager_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.GroupUpdateManagerConfigVariant1DiscriminatorManagerTypeJsonConverter))]
        public global::Letta.GroupUpdateManagerConfigVariant1DiscriminatorManagerType? ManagerType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupUpdateManagerConfigVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="managerType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupUpdateManagerConfigVariant1Discriminator(
            global::Letta.GroupUpdateManagerConfigVariant1DiscriminatorManagerType? managerType)
        {
            this.ManagerType = managerType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupUpdateManagerConfigVariant1Discriminator" /> class.
        /// </summary>
        public GroupUpdateManagerConfigVariant1Discriminator()
        {
        }
    }
}