#nullable enable

namespace Letta
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Retrieve Conversation Stream<br/>
        /// Resume the stream for the most recent active run in a conversation.<br/>
        /// This endpoint allows you to reconnect to an active background stream<br/>
        /// for a conversation, enabling recovery from network interruptions.<br/>
        /// **Agent-direct mode**: Pass conversation_id="default" with agent_id in request body<br/>
        /// to retrieve the stream for the agent's most recent active run.<br/>
        /// **Direct run access**: Pass run_id directly to skip run lookup entirely.<br/>
        /// Useful for recovery from duplicate request 409 errors.<br/>
        /// **OTID lookup**: Pass otid to look up the run_id from Redis.<br/>
        /// Useful when you have the otid from a 409 error response.<br/>
        /// **Deprecated**: Passing an agent ID as conversation_id still works but will be removed.
        /// </summary>
        /// <param name="conversationId">
        /// The conversation identifier. Can be a conversation ID ('conv-&lt;uuid4&gt;'), 'default' for agent-direct mode (with agent_id parameter), or an agent ID ('agent-&lt;uuid4&gt;') for backwards compatibility (deprecated).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RetrieveConversationStreamAsync(
            string conversationId,

            global::Letta.RetrieveStreamRequest request,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve Conversation Stream<br/>
        /// Resume the stream for the most recent active run in a conversation.<br/>
        /// This endpoint allows you to reconnect to an active background stream<br/>
        /// for a conversation, enabling recovery from network interruptions.<br/>
        /// **Agent-direct mode**: Pass conversation_id="default" with agent_id in request body<br/>
        /// to retrieve the stream for the agent's most recent active run.<br/>
        /// **Direct run access**: Pass run_id directly to skip run lookup entirely.<br/>
        /// Useful for recovery from duplicate request 409 errors.<br/>
        /// **OTID lookup**: Pass otid to look up the run_id from Redis.<br/>
        /// Useful when you have the otid from a 409 error response.<br/>
        /// **Deprecated**: Passing an agent ID as conversation_id still works but will be removed.
        /// </summary>
        /// <param name="conversationId">
        /// The conversation identifier. Can be a conversation ID ('conv-&lt;uuid4&gt;'), 'default' for agent-direct mode (with agent_id parameter), or an agent ID ('agent-&lt;uuid4&gt;') for backwards compatibility (deprecated).
        /// </param>
        /// <param name="agentId">
        /// Agent ID for agent-direct mode with 'default' conversation. Use with conversation_id='default' in the URL path.
        /// </param>
        /// <param name="runId">
        /// Run ID to stream directly, bypassing run lookup. Use for recovery from duplicate requests.
        /// </param>
        /// <param name="otid">
        /// Offline threading ID to look up the run_id. Bypasses active run lookup if run_id not provided.
        /// </param>
        /// <param name="startingAfter">
        /// Sequence id to use as a cursor for pagination. Response will start streaming after this chunk sequence id<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="includePings">
        /// Whether to include periodic keepalive ping messages in the stream to prevent connection timeouts.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="pollInterval">
        /// Seconds to wait between polls when no new data.<br/>
        /// Default Value: 0.1F
        /// </param>
        /// <param name="batchSize">
        /// Number of entries to read per batch.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> RetrieveConversationStreamAsync(
            string conversationId,
            string? agentId = default,
            string? runId = default,
            string? otid = default,
            int? startingAfter = default,
            bool? includePings = default,
            double? pollInterval = default,
            int? batchSize = default,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}