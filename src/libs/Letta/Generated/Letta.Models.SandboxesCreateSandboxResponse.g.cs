
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesCreateSandboxResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SandboxId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeviceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectionName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesCreateSandboxResponse" /> class.
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="deviceId"></param>
        /// <param name="connectionName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesCreateSandboxResponse(
            string sandboxId,
            string deviceId,
            string connectionName)
        {
            this.SandboxId = sandboxId ?? throw new global::System.ArgumentNullException(nameof(sandboxId));
            this.DeviceId = deviceId ?? throw new global::System.ArgumentNullException(nameof(deviceId));
            this.ConnectionName = connectionName ?? throw new global::System.ArgumentNullException(nameof(connectionName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesCreateSandboxResponse" /> class.
        /// </summary>
        public SandboxesCreateSandboxResponse()
        {
        }
    }
}