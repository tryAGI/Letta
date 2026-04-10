#nullable enable

namespace Letta
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// List Sandboxes<br/>
        /// List all sandboxes for the organization
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.SandboxesListSandboxesResponse> SandboxesListSandboxesAsync(
            string? agentId = default,
            string? limit = default,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}