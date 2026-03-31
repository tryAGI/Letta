
#nullable enable

namespace Letta
{
    /// <summary>
    /// A message sent by the user. Never streamed back on a response, only used for cursor pagination.<br/>
    /// Args:<br/>
    ///     id (str): The ID of the message<br/>
    ///     date (datetime): The date the message was created in ISO format<br/>
    ///     name (Optional[str]): The name of the sender of the message<br/>
    ///     content (Union[str, List[LettaUserMessageContentUnion]]): The message content sent by the user (can be a string or an array of multi-modal content parts)
    /// </summary>
    public sealed partial class UserMessage
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
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The type of the message.<br/>
        /// Default Value: user_message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        public string? MessageType { get; set; }

        /// <summary>
        /// The offline threading id (OTID). Set by the client to deduplicate requests. Used for idempotency in background streaming mode — each message in a request must have a unique OTID. Retries of the same request should reuse the same OTIDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otid")]
        public string? Otid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender_id")]
        public string? SenderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_id")]
        public string? StepId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_err")]
        public bool? IsErr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seq_id")]
        public int? SeqId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// The message content sent by the user (can be a string or an array of multi-modal content parts)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaUserMessageContentUnion>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.LettaUserMessageContentUnion>, string> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessage" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        /// <param name="content">
        /// The message content sent by the user (can be a string or an array of multi-modal content parts)
        /// </param>
        /// <param name="name"></param>
        /// <param name="messageType">
        /// The type of the message.<br/>
        /// Default Value: user_message
        /// </param>
        /// <param name="otid">
        /// The offline threading id (OTID). Set by the client to deduplicate requests. Used for idempotency in background streaming mode — each message in a request must have a unique OTID. Retries of the same request should reuse the same OTIDs.
        /// </param>
        /// <param name="senderId"></param>
        /// <param name="stepId"></param>
        /// <param name="isErr"></param>
        /// <param name="seqId"></param>
        /// <param name="runId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserMessage(
            string id,
            global::System.DateTime date,
            global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.LettaUserMessageContentUnion>, string> content,
            string? name,
            string? messageType,
            string? otid,
            string? senderId,
            string? stepId,
            bool? isErr,
            int? seqId,
            string? runId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Date = date;
            this.Name = name;
            this.MessageType = messageType;
            this.Otid = otid;
            this.SenderId = senderId;
            this.StepId = stepId;
            this.IsErr = isErr;
            this.SeqId = seqId;
            this.RunId = runId;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessage" /> class.
        /// </summary>
        public UserMessage()
        {
        }
    }
}