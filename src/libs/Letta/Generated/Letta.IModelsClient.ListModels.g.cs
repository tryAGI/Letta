#nullable enable

namespace Letta
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List Llm Models<br/>
        /// List available LLM models using the asynchronous implementation for improved performance.<br/>
        /// Returns Model format which extends LLMConfig with additional metadata fields.<br/>
        /// Legacy LLMConfig fields are marked as deprecated but still available for backward compatibility.
        /// </summary>
        /// <param name="providerCategory"></param>
        /// <param name="providerName"></param>
        /// <param name="providerType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Letta.Model>> ListModelsAsync(
            global::System.Collections.Generic.IList<global::Letta.ProviderCategory>? providerCategory = default,
            string? providerName = default,
            global::Letta.ProviderType? providerType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}