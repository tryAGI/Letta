#nullable enable

namespace Letta
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Count Deployed Agents<br/>
        /// Count deployed agents matching search criteria
        /// </summary>
        /// <param name="search"></param>
        /// <param name="projectId"></param>
        /// <param name="combinator"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.AgentsCountDeployedAgentsResponse> AgentsCountDeployedAgentsAsync(
            global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.AgentsCountDeployedAgentsSearchItemVariant1, global::Letta.AgentsCountDeployedAgentsSearchItemVariant2, global::Letta.AgentsCountDeployedAgentsSearchItemVariant3, global::Letta.AgentsCountDeployedAgentsSearchItemVariant4, global::Letta.AgentsCountDeployedAgentsSearchItemVariant5, global::Letta.AgentsCountDeployedAgentsSearchItemVariant6>>? search = default,
            string? projectId = default,
            global::Letta.AgentsCountDeployedAgentsCombinator? combinator = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}