#nullable enable

namespace Letta
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// Unsubscribe Agent from Feed<br/>
        /// Remove agent subscription from a feed (by agent_id)
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.FeedsUnsubscribeAgentResponse> FeedsUnsubscribeAgentAsync(
            string feedId,

            global::Letta.FeedsUnsubscribeAgentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unsubscribe Agent from Feed<br/>
        /// Remove agent subscription from a feed (by agent_id)
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="agentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.FeedsUnsubscribeAgentResponse> FeedsUnsubscribeAgentAsync(
            string feedId,
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}