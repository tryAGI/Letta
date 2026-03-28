#nullable enable

namespace Letta
{
    public partial interface IMetadataClient
    {
        /// <summary>
        /// Get current user information<br/>
        /// Retrieve information about the current authenticated user including email, name, organization, and current project.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.MetadataGetUserResponse> MetadataGetUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}