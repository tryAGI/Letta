#nullable enable

namespace Letta
{
    public partial interface IArchivesClient
    {
        /// <summary>
        /// Create Passages In Archive<br/>
        /// Create multiple passages in an archive.<br/>
        /// This adds passages to the archive and creates embeddings for vector storage.
        /// </summary>
        /// <param name="archiveId">
        /// The ID of the archive in the format 'archive-&lt;uuid4&gt;'
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Letta.Passage>> CreatePassagesInArchiveAsync(
            string archiveId,

            global::Letta.PassageBatchCreateRequest request,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Passages In Archive<br/>
        /// Create multiple passages in an archive.<br/>
        /// This adds passages to the archive and creates embeddings for vector storage.
        /// </summary>
        /// <param name="archiveId">
        /// The ID of the archive in the format 'archive-&lt;uuid4&gt;'
        /// </param>
        /// <param name="passages">
        /// Passages to create in the archive
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Letta.Passage>> CreatePassagesInArchiveAsync(
            string archiveId,
            global::System.Collections.Generic.IList<global::Letta.PassageCreateRequest> passages,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}