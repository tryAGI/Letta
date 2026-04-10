#nullable enable

namespace Letta
{
    public partial interface IMemoryFilesClient
    {
        /// <summary>
        /// List Directory<br/>
        /// List immediate children of a directory in the agent memory repo (single level).
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="path"></param>
        /// <param name="depth"></param>
        /// <param name="ref"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.MemoryFilesListDirectoryResponse> MemoryFilesListDirectoryAsync(
            string agentId,
            string? path = default,
            double? depth = default,
            string? @ref = default,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}