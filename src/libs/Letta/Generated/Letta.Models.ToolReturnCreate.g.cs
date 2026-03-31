
#nullable enable

namespace Letta
{
    /// <summary>
    /// Submit tool return(s) from client-side tool execution.<br/>
    /// This is the preferred way to send tool results back to the agent after<br/>
    /// client-side tool execution. It is equivalent to sending an ApprovalCreate<br/>
    /// with tool return approvals, but provides a cleaner API for the common case.
    /// </summary>
    public sealed partial class ToolReturnCreate
    {
        /// <summary>
        /// The message type to be created.<br/>
        /// Default Value: tool_return
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The offline threading id (OTID). Set by the client to deduplicate requests. Used for idempotency in background streaming mode — each message in a request must have a unique OTID. Retries of the same request should reuse the same OTIDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otid")]
        public string? Otid { get; set; }

        /// <summary>
        /// The multi-agent group that the message was sent in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// List of tool returns from client-side execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_returns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Letta.LettaSchemasLettaMessageToolReturn> ToolReturns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolReturnCreate" /> class.
        /// </summary>
        /// <param name="toolReturns">
        /// List of tool returns from client-side execution
        /// </param>
        /// <param name="type">
        /// The message type to be created.<br/>
        /// Default Value: tool_return
        /// </param>
        /// <param name="otid">
        /// The offline threading id (OTID). Set by the client to deduplicate requests. Used for idempotency in background streaming mode — each message in a request must have a unique OTID. Retries of the same request should reuse the same OTIDs.
        /// </param>
        /// <param name="groupId">
        /// The multi-agent group that the message was sent in
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolReturnCreate(
            global::System.Collections.Generic.IList<global::Letta.LettaSchemasLettaMessageToolReturn> toolReturns,
            string? type,
            string? otid,
            string? groupId)
        {
            this.Type = type;
            this.Otid = otid;
            this.GroupId = groupId;
            this.ToolReturns = toolReturns ?? throw new global::System.ArgumentNullException(nameof(toolReturns));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolReturnCreate" /> class.
        /// </summary>
        public ToolReturnCreate()
        {
        }
    }
}