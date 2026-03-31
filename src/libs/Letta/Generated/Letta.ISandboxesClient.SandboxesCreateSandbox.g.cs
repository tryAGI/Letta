#nullable enable

namespace Letta
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Create Sandbox<br/>
        /// Create a new Modal Sandbox that runs letta remote automatically
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.SandboxesCreateSandboxResponse> SandboxesCreateSandboxAsync(

            global::Letta.SandboxesCreateSandboxRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Sandbox<br/>
        /// Create a new Modal Sandbox that runs letta remote automatically
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="connectionName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.SandboxesCreateSandboxResponse> SandboxesCreateSandboxAsync(
            string agentId,
            string? connectionName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}