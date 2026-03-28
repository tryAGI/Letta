
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Letta
{
    /// <summary>
    /// Pydantic model for updating SandboxConfig fields.
    /// </summary>
    public sealed partial class SandboxConfigUpdate
    {
        /// <summary>
        /// The JSON configuration data for the sandbox.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.LocalSandboxConfig, global::Letta.E2BSandboxConfig, global::Letta.ModalSandboxConfig>))]
        public global::Letta.AnyOf<global::Letta.LocalSandboxConfig, global::Letta.E2BSandboxConfig, global::Letta.ModalSandboxConfig>? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxConfigUpdate" /> class.
        /// </summary>
        /// <param name="config">
        /// The JSON configuration data for the sandbox.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxConfigUpdate(
            global::Letta.AnyOf<global::Letta.LocalSandboxConfig, global::Letta.E2BSandboxConfig, global::Letta.ModalSandboxConfig>? config)
        {
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxConfigUpdate" /> class.
        /// </summary>
        public SandboxConfigUpdate()
        {
        }
    }
}