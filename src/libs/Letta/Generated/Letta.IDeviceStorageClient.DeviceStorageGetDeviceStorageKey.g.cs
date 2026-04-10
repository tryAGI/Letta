#nullable enable

namespace Letta
{
    public partial interface IDeviceStorageClient
    {
        /// <summary>
        /// Get Device Storage Key<br/>
        /// Returns an HMAC-derived AES-256-GCM key scoped to the authenticated user and device. Used to encrypt/decrypt local IndexedDB caches on the client.
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.DeviceStorageGetDeviceStorageKeyResponse> DeviceStorageGetDeviceStorageKeyAsync(
            string deviceId,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}