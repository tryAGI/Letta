#nullable enable

namespace Letta
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Send Message to Environment<br/>
        /// Send a message to a specific environment connection
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.EnvironmentsSendMessageResponse> EnvironmentsSendMessageAsync(
            string connectionId,

            global::Letta.EnvironmentsSendMessageRequest request,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send Message to Environment<br/>
        /// Send a message to a specific environment connection
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="messages"></param>
        /// <param name="agentId"></param>
        /// <param name="conversationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.EnvironmentsSendMessageResponse> EnvironmentsSendMessageAsync(
            string connectionId,
            global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.EnvironmentsSendMessageRequestMessageVariant1, global::Letta.EnvironmentsSendMessageRequestMessageVariant2>> messages,
            string? agentId = default,
            string? conversationId = default,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}