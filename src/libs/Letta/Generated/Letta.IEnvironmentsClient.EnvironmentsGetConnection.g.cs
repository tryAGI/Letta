#nullable enable

namespace Letta
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Get Environment Connection<br/>
        /// Get a specific environment connection by deviceId
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.EnvironmentsGetConnectionResponse> EnvironmentsGetConnectionAsync(
            string deviceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}