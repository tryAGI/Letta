#nullable enable

namespace Letta
{
    public partial interface IBlocksClient
    {
        /// <summary>
        /// Attach Identity To Block<br/>
        /// Attach an identity to a block.
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="blockId">
        /// The ID of the block in the format 'block-&lt;uuid4&gt;'
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.BlockResponse> AttachIdentityToBlockAsync(
            string identityId,
            string blockId,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}