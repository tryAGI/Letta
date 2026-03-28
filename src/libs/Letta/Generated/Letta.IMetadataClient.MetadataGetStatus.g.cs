#nullable enable

namespace Letta
{
    public partial interface IMetadataClient
    {
        /// <summary>
        /// Gets your Letta Cloud status
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.MetadataGetStatusResponse> MetadataGetStatusAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}