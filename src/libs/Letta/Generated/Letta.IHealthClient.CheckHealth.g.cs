#nullable enable

namespace Letta
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// Check Health<br/>
        /// Liveness endpoint; returns 200 when process is responsive.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.Health> CheckHealthAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}