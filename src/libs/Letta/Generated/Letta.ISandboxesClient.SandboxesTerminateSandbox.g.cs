#nullable enable

namespace Letta
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Terminate Sandbox<br/>
        /// Terminate a Modal Sandbox
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.SandboxesTerminateSandboxResponse> SandboxesTerminateSandboxAsync(
            string sandboxId,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Terminate Sandbox<br/>
        /// Terminate a Modal Sandbox
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.SandboxesTerminateSandboxResponse> SandboxesTerminateSandboxAsync(
            string sandboxId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}