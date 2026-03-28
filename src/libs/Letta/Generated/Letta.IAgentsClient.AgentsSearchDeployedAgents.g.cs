#nullable enable

namespace Letta
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Search Deployed Agents<br/>
        /// Search deployed agents
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.AgentsSearchDeployedAgentsResponse> AgentsSearchDeployedAgentsAsync(

            global::Letta.AgentsSearchDeployedAgentsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search Deployed Agents<br/>
        /// Search deployed agents
        /// </summary>
        /// <param name="search"></param>
        /// <param name="projectId"></param>
        /// <param name="combinator"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="sortBy"></param>
        /// <param name="ascending"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.AgentsSearchDeployedAgentsResponse> AgentsSearchDeployedAgentsAsync(
            global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant1, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant2, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant3, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant4, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant5, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant6>>? search = default,
            string? projectId = default,
            global::Letta.AgentsSearchDeployedAgentsRequestCombinator? combinator = default,
            double? limit = default,
            string? after = default,
            global::Letta.AgentsSearchDeployedAgentsRequestSortBy? sortBy = default,
            bool? ascending = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}