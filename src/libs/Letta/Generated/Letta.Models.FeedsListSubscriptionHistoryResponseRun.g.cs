
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedsListSubscriptionHistoryResponseRun
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.FeedsListSubscriptionHistoryResponseRunTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.FeedsListSubscriptionHistoryResponseRunType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.FeedsListSubscriptionHistoryResponseRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.FeedsListSubscriptionHistoryResponseRunStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public string? CompletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsListSubscriptionHistoryResponseRun" /> class.
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="type"></param>
        /// <param name="status"></param>
        /// <param name="startedAt"></param>
        /// <param name="completedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedsListSubscriptionHistoryResponseRun(
            string workflowId,
            global::Letta.FeedsListSubscriptionHistoryResponseRunType type,
            global::Letta.FeedsListSubscriptionHistoryResponseRunStatus status,
            string startedAt,
            string? completedAt)
        {
            this.WorkflowId = workflowId ?? throw new global::System.ArgumentNullException(nameof(workflowId));
            this.Type = type;
            this.Status = status;
            this.StartedAt = startedAt ?? throw new global::System.ArgumentNullException(nameof(startedAt));
            this.CompletedAt = completedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsListSubscriptionHistoryResponseRun" /> class.
        /// </summary>
        public FeedsListSubscriptionHistoryResponseRun()
        {
        }
    }
}