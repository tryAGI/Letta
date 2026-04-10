#nullable enable

namespace Letta
{
    public partial interface IMemoryFilesClient
    {
        /// <summary>
        /// Read File Content<br/>
        /// Read a single file content at a specific git ref from the agent memory repo.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="filePath"></param>
        /// <param name="ref"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.MemoryFilesReadFileContentResponse> MemoryFilesReadFileContentAsync(
            string agentId,
            string filePath,
            string? @ref = default,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}