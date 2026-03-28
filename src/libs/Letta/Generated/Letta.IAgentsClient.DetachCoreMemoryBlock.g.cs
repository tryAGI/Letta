#nullable enable

namespace Letta
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Detach Block From Agent<br/>
        /// Detach a core memory block from an agent.
        /// </summary>
        /// <param name="blockId">
        /// The ID of the block in the format 'block-&lt;uuid4&gt;'
        /// </param>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.AgentState> DetachCoreMemoryBlockAsync(
            string blockId,
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}