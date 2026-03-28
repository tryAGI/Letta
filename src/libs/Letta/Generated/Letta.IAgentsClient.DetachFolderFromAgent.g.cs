#nullable enable

namespace Letta
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Detach Folder From Agent<br/>
        /// Detach a folder from an agent.
        /// </summary>
        /// <param name="folderId">
        /// The ID of the source in the format 'source-&lt;uuid4&gt;'
        /// </param>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.AgentState> DetachFolderFromAgentAsync(
            string folderId,
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}