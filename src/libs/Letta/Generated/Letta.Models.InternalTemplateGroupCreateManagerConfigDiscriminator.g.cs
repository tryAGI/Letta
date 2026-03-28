
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InternalTemplateGroupCreateManagerConfigDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manager_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerTypeJsonConverter))]
        public global::Letta.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType? ManagerType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalTemplateGroupCreateManagerConfigDiscriminator" /> class.
        /// </summary>
        /// <param name="managerType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternalTemplateGroupCreateManagerConfigDiscriminator(
            global::Letta.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType? managerType)
        {
            this.ManagerType = managerType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalTemplateGroupCreateManagerConfigDiscriminator" /> class.
        /// </summary>
        public InternalTemplateGroupCreateManagerConfigDiscriminator()
        {
        }
    }
}