#nullable enable

namespace Letta
{
    public partial interface IProvidersClient
    {
        /// <summary>
        /// Refresh Provider Models<br/>
        /// Refresh models for a BYOK provider by querying the provider's API.<br/>
        /// Adds new models and removes ones no longer available.
        /// </summary>
        /// <param name="providerId">
        /// The ID of the provider in the format 'provider-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.Provider> RefreshProviderModelsAsync(
            string providerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}