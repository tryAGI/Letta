#nullable enable

namespace Letta
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// List template versions (Cloud-only)<br/>
        /// List all versions of a specific template
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.TemplatesListTemplateVersionsResponse> TemplatesListTemplateVersionsAsync(
            string projectId,
            string name,
            global::Letta.OneOf<string, double?>? offset = default,
            string? limit = default,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}