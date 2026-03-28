#nullable enable

namespace Letta
{
    public partial interface IFoldersClient
    {
        /// <summary>
        /// Retrieve Folder<br/>
        /// Get a folder by ID
        /// </summary>
        /// <param name="folderId">
        /// The ID of the source in the format 'source-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.Folder> RetrieveFolderAsync(
            string folderId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}