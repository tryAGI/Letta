
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LettaAsyncRequest
    {
        /// <summary>
        /// The messages to be sent to the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.MessageCreate, global::Letta.ApprovalCreate, global::Letta.ToolReturnCreate>>? Messages { get; set; }

        /// <summary>
        /// Syntactic sugar for a single user message. Equivalent to messages=[{'role': 'user', 'content': input}].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item2>, object>))]
        public global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item2>, object>? Input { get; set; }

        /// <summary>
        /// Maximum number of steps the agent should take to process the request.<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_steps")]
        public int? MaxSteps { get; set; }

        /// <summary>
        /// Whether the server should parse specific tool call arguments (default `send_message`) as `AssistantMessage` objects. Still supported for legacy agent types, but deprecated for letta_v1_agent onward.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_assistant_message")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? UseAssistantMessage { get; set; }

        /// <summary>
        /// The name of the designated message tool. Still supported for legacy agent types, but deprecated for letta_v1_agent onward.<br/>
        /// Default Value: send_message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant_message_tool_name")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? AssistantMessageToolName { get; set; }

        /// <summary>
        /// The name of the message argument in the designated message tool. Still supported for legacy agent types, but deprecated for letta_v1_agent onward.<br/>
        /// Default Value: message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant_message_tool_kwarg")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? AssistantMessageToolKwarg { get; set; }

        /// <summary>
        /// Only return specified message types in the response. If `None` (default) returns all messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_return_message_types")]
        public global::System.Collections.Generic.IList<global::Letta.MessageType>? IncludeReturnMessageTypes { get; set; }

        /// <summary>
        /// If set to True, enables reasoning before responses or tool calls from the agent.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_thinking")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? EnableThinking { get; set; }

        /// <summary>
        /// Client-side tools that the agent can call. When the agent calls a client-side tool, execution pauses and returns control to the client to execute the tool and provide the result via a ToolReturn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_tools")]
        public global::System.Collections.Generic.IList<global::Letta.ClientToolSchema>? ClientTools { get; set; }

        /// <summary>
        /// Client-side skills available in the environment. These are rendered in the system prompt's available skills section alongside agent-scoped skills from MemFS.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_skills")]
        public global::System.Collections.Generic.IList<global::Letta.ClientSkillSchema>? ClientSkills { get; set; }

        /// <summary>
        /// Model handle to use for this request instead of the agent's default model. This allows sending a message to a different model without changing the agent's configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("override_model")]
        public string? OverrideModel { get; set; }

        /// <summary>
        /// If True, compaction events emit structured `SummaryMessage` and `EventMessage` types. If False (default), compaction messages are not included in the response.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_compaction_messages")]
        public bool? IncludeCompactionMessages { get; set; }

        /// <summary>
        /// If True, returns log probabilities of the output tokens in the response. Useful for RL training. Only supported for OpenAI-compatible providers (including SGLang).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_logprobs")]
        public bool? ReturnLogprobs { get; set; }

        /// <summary>
        /// Number of most likely tokens to return at each position (0-20). Requires return_logprobs=True.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public int? TopLogprobs { get; set; }

        /// <summary>
        /// If True, returns token IDs and logprobs for ALL LLM generations in the agent step, not just the last one. Uses SGLang native /generate endpoint. Returns 'turns' field with TurnTokenData for each assistant/tool turn. Required for proper multi-turn RL training with loss masking.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_token_ids")]
        public bool? ReturnTokenIds { get; set; }

        /// <summary>
        /// Optional per-request system prompt override. When set, this is passed directly to the underlying LLM request and bypasses the persisted/compiled system message for that request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("override_system")]
        public string? OverrideSystem { get; set; }

        /// <summary>
        /// Optional callback URL to POST to when the job completes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaAsyncRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// The messages to be sent to the agent.
        /// </param>
        /// <param name="input">
        /// Syntactic sugar for a single user message. Equivalent to messages=[{'role': 'user', 'content': input}].
        /// </param>
        /// <param name="maxSteps">
        /// Maximum number of steps the agent should take to process the request.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="includeReturnMessageTypes">
        /// Only return specified message types in the response. If `None` (default) returns all messages.
        /// </param>
        /// <param name="clientTools">
        /// Client-side tools that the agent can call. When the agent calls a client-side tool, execution pauses and returns control to the client to execute the tool and provide the result via a ToolReturn.
        /// </param>
        /// <param name="clientSkills">
        /// Client-side skills available in the environment. These are rendered in the system prompt's available skills section alongside agent-scoped skills from MemFS.
        /// </param>
        /// <param name="overrideModel">
        /// Model handle to use for this request instead of the agent's default model. This allows sending a message to a different model without changing the agent's configuration.
        /// </param>
        /// <param name="includeCompactionMessages">
        /// If True, compaction events emit structured `SummaryMessage` and `EventMessage` types. If False (default), compaction messages are not included in the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="returnLogprobs">
        /// If True, returns log probabilities of the output tokens in the response. Useful for RL training. Only supported for OpenAI-compatible providers (including SGLang).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="topLogprobs">
        /// Number of most likely tokens to return at each position (0-20). Requires return_logprobs=True.
        /// </param>
        /// <param name="returnTokenIds">
        /// If True, returns token IDs and logprobs for ALL LLM generations in the agent step, not just the last one. Uses SGLang native /generate endpoint. Returns 'turns' field with TurnTokenData for each assistant/tool turn. Required for proper multi-turn RL training with loss masking.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="overrideSystem">
        /// Optional per-request system prompt override. When set, this is passed directly to the underlying LLM request and bypasses the persisted/compiled system message for that request.
        /// </param>
        /// <param name="callbackUrl">
        /// Optional callback URL to POST to when the job completes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LettaAsyncRequest(
            global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.MessageCreate, global::Letta.ApprovalCreate, global::Letta.ToolReturnCreate>>? messages,
            global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item2>, object>? input,
            int? maxSteps,
            global::System.Collections.Generic.IList<global::Letta.MessageType>? includeReturnMessageTypes,
            global::System.Collections.Generic.IList<global::Letta.ClientToolSchema>? clientTools,
            global::System.Collections.Generic.IList<global::Letta.ClientSkillSchema>? clientSkills,
            string? overrideModel,
            bool? includeCompactionMessages,
            bool? returnLogprobs,
            int? topLogprobs,
            bool? returnTokenIds,
            string? overrideSystem,
            string? callbackUrl)
        {
            this.Messages = messages;
            this.Input = input;
            this.MaxSteps = maxSteps;
            this.IncludeReturnMessageTypes = includeReturnMessageTypes;
            this.ClientTools = clientTools;
            this.ClientSkills = clientSkills;
            this.OverrideModel = overrideModel;
            this.IncludeCompactionMessages = includeCompactionMessages;
            this.ReturnLogprobs = returnLogprobs;
            this.TopLogprobs = topLogprobs;
            this.ReturnTokenIds = returnTokenIds;
            this.OverrideSystem = overrideSystem;
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaAsyncRequest" /> class.
        /// </summary>
        public LettaAsyncRequest()
        {
        }
    }
}