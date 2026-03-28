
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxConfigCreate
    {
        /// <summary>
        /// The configuration for the sandbox.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.LocalSandboxConfig, global::Letta.E2BSandboxConfig, global::Letta.ModalSandboxConfig>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.AnyOf<global::Letta.LocalSandboxConfig, global::Letta.E2BSandboxConfig, global::Letta.ModalSandboxConfig> Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxConfigCreate" /> class.
        /// </summary>
        /// <param name="config">
        /// The configuration for the sandbox.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxConfigCreate(
            global::Letta.AnyOf<global::Letta.LocalSandboxConfig, global::Letta.E2BSandboxConfig, global::Letta.ModalSandboxConfig> config)
        {
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxConfigCreate" /> class.
        /// </summary>
        public SandboxConfigCreate()
        {
        }
    }
}