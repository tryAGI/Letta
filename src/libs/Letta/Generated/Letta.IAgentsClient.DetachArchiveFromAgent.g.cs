#nullable enable

namespace Letta
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Detach Archive From Agent<br/>
        /// Detach an archive from an agent.
        /// </summary>
        /// <param name="archiveId"></param>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DetachArchiveFromAgentAsync(
            string archiveId,
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}