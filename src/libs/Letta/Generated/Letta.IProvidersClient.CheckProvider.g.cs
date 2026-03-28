#nullable enable

namespace Letta
{
    public partial interface IProvidersClient
    {
        /// <summary>
        /// Check Provider<br/>
        /// Verify the API key and additional parameters for a provider.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CheckProviderAsync(

            global::Letta.ProviderCheck request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Provider<br/>
        /// Verify the API key and additional parameters for a provider.
        /// </summary>
        /// <param name="providerType">
        /// The type of the provider.
        /// </param>
        /// <param name="apiKey">
        /// API key or secret key used for requests to the provider.
        /// </param>
        /// <param name="accessKey">
        /// Access key used for requests to the provider.
        /// </param>
        /// <param name="region">
        /// Region used for requests to the provider.
        /// </param>
        /// <param name="baseUrl">
        /// Base URL used for requests to the provider.
        /// </param>
        /// <param name="apiVersion">
        /// API version used for requests to the provider.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CheckProviderAsync(
            global::Letta.ProviderType providerType,
            string apiKey,
            string? accessKey = default,
            string? region = default,
            string? baseUrl = default,
            string? apiVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}