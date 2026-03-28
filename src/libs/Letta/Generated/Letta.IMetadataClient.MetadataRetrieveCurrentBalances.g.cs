#nullable enable

namespace Letta
{
    public partial interface IMetadataClient
    {
        /// <summary>
        /// Retrieve current organization balance<br/>
        /// Retrieve the current usage balances for the organization.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.MetadataRetrieveCurrentBalancesResponse> MetadataRetrieveCurrentBalancesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}