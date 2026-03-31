
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesListSandboxesResponseSandboxe
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SandboxId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeviceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionId")]
        public string? ConnectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("podId")]
        public string? PodId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectedAt")]
        public double? ConnectedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastHeartbeat")]
        public double? LastHeartbeat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastSeenAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LastSeenAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstSeenAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FirstSeenAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.SandboxesListSandboxesResponseSandboxeCurrentModeJsonConverter))]
        public global::Letta.SandboxesListSandboxesResponseSandboxeCurrentMode? CurrentMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Letta.SandboxesListSandboxesResponseSandboxeMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesListSandboxesResponseSandboxe" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sandboxId"></param>
        /// <param name="agentId"></param>
        /// <param name="connectionName"></param>
        /// <param name="deviceId"></param>
        /// <param name="organizationId"></param>
        /// <param name="lastSeenAt"></param>
        /// <param name="firstSeenAt"></param>
        /// <param name="connectionId"></param>
        /// <param name="podId"></param>
        /// <param name="connectedAt"></param>
        /// <param name="lastHeartbeat"></param>
        /// <param name="currentMode"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesListSandboxesResponseSandboxe(
            string id,
            string sandboxId,
            string agentId,
            string connectionName,
            string deviceId,
            string organizationId,
            double lastSeenAt,
            double firstSeenAt,
            string? connectionId,
            string? podId,
            double? connectedAt,
            double? lastHeartbeat,
            global::Letta.SandboxesListSandboxesResponseSandboxeCurrentMode? currentMode,
            global::Letta.SandboxesListSandboxesResponseSandboxeMetadata? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.SandboxId = sandboxId ?? throw new global::System.ArgumentNullException(nameof(sandboxId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.ConnectionName = connectionName ?? throw new global::System.ArgumentNullException(nameof(connectionName));
            this.DeviceId = deviceId ?? throw new global::System.ArgumentNullException(nameof(deviceId));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.ConnectionId = connectionId;
            this.PodId = podId;
            this.ConnectedAt = connectedAt;
            this.LastHeartbeat = lastHeartbeat;
            this.LastSeenAt = lastSeenAt;
            this.FirstSeenAt = firstSeenAt;
            this.CurrentMode = currentMode;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesListSandboxesResponseSandboxe" /> class.
        /// </summary>
        public SandboxesListSandboxesResponseSandboxe()
        {
        }
    }
}