#nullable enable

namespace Letta
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Delete Environment<br/>
        /// Removes environment from list of environments
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.EnvironmentsDeleteEnvironmentResponse> EnvironmentsDeleteEnvironmentAsync(
            string id,

            object request,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Environment<br/>
        /// Removes environment from list of environments
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.EnvironmentsDeleteEnvironmentResponse> EnvironmentsDeleteEnvironmentAsync(
            string id,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}