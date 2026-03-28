#nullable enable

namespace Letta
{
    public partial interface IProvidersClient
    {
        /// <summary>
        /// Retrieve Provider<br/>
        /// Get a provider by ID.
        /// </summary>
        /// <param name="providerId">
        /// The ID of the provider in the format 'provider-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.Provider> RetrieveProviderAsync(
            string providerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}