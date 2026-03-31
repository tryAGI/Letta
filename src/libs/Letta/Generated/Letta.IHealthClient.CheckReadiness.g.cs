#nullable enable

namespace Letta
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// Check Readiness<br/>
        /// Readiness endpoint gated by internal readiness state when enforcement is enabled.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.Health> CheckReadinessAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}