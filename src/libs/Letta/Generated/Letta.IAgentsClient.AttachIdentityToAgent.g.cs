#nullable enable

namespace Letta
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Attach Identity To Agent<br/>
        /// Attach an identity to an agent.
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AttachIdentityToAgentAsync(
            string identityId,
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}