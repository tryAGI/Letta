
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LettaServerRestApiRoutersV1ConversationsCompactionRequest
    {
        /// <summary>
        /// Agent ID for agent-direct mode with 'default' conversation. Use with conversation_id='default' in the URL path.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Optional compaction settings to use for this summarization request. If not provided, the agent's default settings will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compaction_settings")]
        public global::Letta.CompactionSettingsInput? CompactionSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaServerRestApiRoutersV1ConversationsCompactionRequest" /> class.
        /// </summary>
        /// <param name="agentId">
        /// Agent ID for agent-direct mode with 'default' conversation. Use with conversation_id='default' in the URL path.
        /// </param>
        /// <param name="compactionSettings">
        /// Optional compaction settings to use for this summarization request. If not provided, the agent's default settings will be used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LettaServerRestApiRoutersV1ConversationsCompactionRequest(
            string? agentId,
            global::Letta.CompactionSettingsInput? compactionSettings)
        {
            this.AgentId = agentId;
            this.CompactionSettings = compactionSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaServerRestApiRoutersV1ConversationsCompactionRequest" /> class.
        /// </summary>
        public LettaServerRestApiRoutersV1ConversationsCompactionRequest()
        {
        }
    }
}