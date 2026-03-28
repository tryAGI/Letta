#nullable enable

namespace Letta
{
    public partial interface IFoldersClient
    {
        /// <summary>
        /// Count Folders<br/>
        /// Count all data folders created by a user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<int> CountFoldersAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}