
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta
{
    public partial class ConversationsClient
    {
        partial void PrepareSendConversationMessageArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string conversationId,
            global::Letta.ConversationMessageRequest request);
        partial void PrepareSendConversationMessageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string conversationId,
            global::Letta.ConversationMessageRequest request);
        partial void ProcessSendConversationMessageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSendConversationMessageResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Send Conversation Message<br/>
        /// Send a message to a conversation and get a response.<br/>
        /// This endpoint sends a message to an existing conversation.<br/>
        /// By default (streaming=true), returns a streaming response (Server-Sent Events).<br/>
        /// Set streaming=false to get a complete JSON response.<br/>
        /// **Agent-direct mode**: Pass conversation_id="default" with agent_id in request body<br/>
        /// to send messages to the agent's default conversation with locking.<br/>
        /// **Deprecated**: Passing an agent ID as conversation_id still works but will be removed.
        /// </summary>
        /// <param name="conversationId">
        /// The conversation identifier. Can be a conversation ID ('conv-&lt;uuid4&gt;'), 'default' for agent-direct mode (with agent_id parameter), or an agent ID ('agent-&lt;uuid4&gt;') for backwards compatibility (deprecated).
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Letta.LettaResponse> SendConversationMessageAsync(
            string conversationId,

            global::Letta.ConversationMessageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSendConversationMessageArguments(
                httpClient: HttpClient,
                conversationId: ref conversationId,
                request: request);

            var __pathBuilder = new global::Letta.PathBuilder(
                path: $"/v1/conversations/{conversationId}/messages",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareSendConversationMessageRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                conversationId: conversationId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSendConversationMessageResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::Letta.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::Letta.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::Letta.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::Letta.ApiException<global::Letta.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessSendConversationMessageResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Letta.LettaResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Letta.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Letta.LettaResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Letta.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Send Conversation Message<br/>
        /// Send a message to a conversation and get a response.<br/>
        /// This endpoint sends a message to an existing conversation.<br/>
        /// By default (streaming=true), returns a streaming response (Server-Sent Events).<br/>
        /// Set streaming=false to get a complete JSON response.<br/>
        /// **Agent-direct mode**: Pass conversation_id="default" with agent_id in request body<br/>
        /// to send messages to the agent's default conversation with locking.<br/>
        /// **Deprecated**: Passing an agent ID as conversation_id still works but will be removed.
        /// </summary>
        /// <param name="conversationId">
        /// The conversation identifier. Can be a conversation ID ('conv-&lt;uuid4&gt;'), 'default' for agent-direct mode (with agent_id parameter), or an agent ID ('agent-&lt;uuid4&gt;') for backwards compatibility (deprecated).
        /// </param>
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
        /// <param name="agentId">
        /// Agent ID for agent-direct mode with 'default' conversation. Use with conversation_id='default' in the URL path.
        /// </param>
        /// <param name="streaming">
        /// If True (default), returns a streaming response (Server-Sent Events). If False, returns a complete JSON response.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="streamTokens">
        /// Flag to determine if individual tokens should be streamed, rather than streaming per step (only used when streaming=true).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includePings">
        /// Whether to include periodic keepalive ping messages in the stream to prevent connection timeouts (only used when streaming=true).<br/>
        /// Default Value: true
        /// </param>
        /// <param name="background">
        /// Whether to process the request in the background (only used when streaming=true).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Letta.LettaResponse> SendConversationMessageAsync(
            string conversationId,
            global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.MessageCreate, global::Letta.ApprovalCreate, global::Letta.ToolReturnCreate>>? messages = default,
            global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item>, object>? input = default,
            int? maxSteps = default,
            global::System.Collections.Generic.IList<global::Letta.MessageType>? includeReturnMessageTypes = default,
            global::System.Collections.Generic.IList<global::Letta.ClientToolSchema>? clientTools = default,
            global::System.Collections.Generic.IList<global::Letta.ClientSkillSchema>? clientSkills = default,
            string? overrideModel = default,
            bool? includeCompactionMessages = default,
            bool? returnLogprobs = default,
            int? topLogprobs = default,
            bool? returnTokenIds = default,
            string? overrideSystem = default,
            string? agentId = default,
            bool? streaming = default,
            bool? streamTokens = default,
            bool? includePings = default,
            bool? background = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Letta.ConversationMessageRequest
            {
                Messages = messages,
                Input = input,
                MaxSteps = maxSteps,
                IncludeReturnMessageTypes = includeReturnMessageTypes,
                ClientTools = clientTools,
                ClientSkills = clientSkills,
                OverrideModel = overrideModel,
                IncludeCompactionMessages = includeCompactionMessages,
                ReturnLogprobs = returnLogprobs,
                TopLogprobs = topLogprobs,
                ReturnTokenIds = returnTokenIds,
                OverrideSystem = overrideSystem,
                AgentId = agentId,
                Streaming = streaming,
                StreamTokens = streamTokens,
                IncludePings = includePings,
                Background = background,
            };

            return await SendConversationMessageAsync(
                conversationId: conversationId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}