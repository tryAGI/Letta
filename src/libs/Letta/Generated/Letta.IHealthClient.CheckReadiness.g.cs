#nullable enable

namespace Letta
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// Check Readiness<br/>
        /// Readiness endpoint gated by internal readiness state when enforcement is enabled.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.Health> CheckReadinessAsync(
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}