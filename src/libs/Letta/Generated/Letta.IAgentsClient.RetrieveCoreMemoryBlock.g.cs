#nullable enable

namespace Letta
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Retrieve Block For Agent<br/>
        /// Retrieve a core memory block from an agent.
        /// </summary>
        /// <param name="blockLabel"></param>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.BlockResponse> RetrieveCoreMemoryBlockAsync(
            string blockLabel,
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}