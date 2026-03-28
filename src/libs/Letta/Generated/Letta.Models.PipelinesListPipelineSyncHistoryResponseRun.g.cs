
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesListPipelineSyncHistoryResponseRun
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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.PipelinesListPipelineSyncHistoryResponseRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.PipelinesListPipelineSyncHistoryResponseRunStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Letta.PipelinesListPipelineSyncHistoryResponseRunError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesListPipelineSyncHistoryResponseRun" /> class.
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="status"></param>
        /// <param name="startedAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelinesListPipelineSyncHistoryResponseRun(
            string workflowId,
            global::Letta.PipelinesListPipelineSyncHistoryResponseRunStatus status,
            global::System.DateTime startedAt,
            global::System.DateTime? completedAt,
            global::Letta.PipelinesListPipelineSyncHistoryResponseRunError? error)
        {
            this.WorkflowId = workflowId ?? throw new global::System.ArgumentNullException(nameof(workflowId));
            this.Status = status;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesListPipelineSyncHistoryResponseRun" /> class.
        /// </summary>
        public PipelinesListPipelineSyncHistoryResponseRun()
        {
        }
    }
}