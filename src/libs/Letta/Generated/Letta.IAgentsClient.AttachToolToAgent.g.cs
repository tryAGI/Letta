#nullable enable

namespace Letta
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Attach Tool To Agent<br/>
        /// Attach a tool to an agent.
        /// </summary>
        /// <param name="toolId">
        /// The ID of the tool in the format 'tool-&lt;uuid4&gt;'
        /// </param>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.AgentState> AttachToolToAgentAsync(
            string toolId,
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}