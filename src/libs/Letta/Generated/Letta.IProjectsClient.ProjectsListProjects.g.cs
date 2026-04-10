#nullable enable

namespace Letta
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List Projects (Cloud-only)<br/>
        /// List all projects
        /// </summary>
        /// <param name="name"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.ProjectsListProjectsResponse> ProjectsListProjectsAsync(
            string? name = default,
            global::Letta.OneOf<string, double?>? offset = default,
            string? limit = default,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}