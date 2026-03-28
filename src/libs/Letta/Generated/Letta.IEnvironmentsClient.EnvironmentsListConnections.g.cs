#nullable enable

namespace Letta
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// List Environment Connections<br/>
        /// List all active environment connections for the organization
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="userId"></param>
        /// <param name="onlineOnly"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.EnvironmentsListConnectionsResponse> EnvironmentsListConnectionsAsync(
            string? limit = default,
            string? after = default,
            string? userId = default,
            string? onlineOnly = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}