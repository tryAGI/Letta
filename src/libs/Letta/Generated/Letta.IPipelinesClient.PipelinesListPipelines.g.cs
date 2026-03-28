#nullable enable

namespace Letta
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// List Pipelines<br/>
        /// List all pipelines for the organization with optional filtering
        /// </summary>
        /// <param name="search"></param>
        /// <param name="integrationType"></param>
        /// <param name="integrationId"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.PipelinesListPipelinesResponse> PipelinesListPipelinesAsync(
            string? search = default,
            string? integrationType = default,
            string? integrationId = default,
            global::Letta.OneOf<string, double?>? offset = default,
            string? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}