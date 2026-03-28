#nullable enable

namespace Letta
{
    public partial interface IMemoryFilesClient
    {
        /// <summary>
        /// Get File History<br/>
        /// Get commit history for a specific file in the agent memory repo.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="filePath"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.MemoryFilesGetFileHistoryResponse> MemoryFilesGetFileHistoryAsync(
            string agentId,
            string filePath,
            double? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}