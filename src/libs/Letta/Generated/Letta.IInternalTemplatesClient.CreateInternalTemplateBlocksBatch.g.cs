#nullable enable

namespace Letta
{
    public partial interface IInternalTemplatesClient
    {
        /// <summary>
        /// Create Blocks Batch<br/>
        /// Create multiple blocks with template-related fields.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Letta.Block>> CreateInternalTemplateBlocksBatchAsync(

            global::System.Collections.Generic.IList<global::Letta.InternalTemplateBlockCreate> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}