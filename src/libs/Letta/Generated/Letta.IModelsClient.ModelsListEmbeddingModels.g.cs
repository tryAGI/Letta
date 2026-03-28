#nullable enable

namespace Letta
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task ModelsListEmbeddingModelsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}