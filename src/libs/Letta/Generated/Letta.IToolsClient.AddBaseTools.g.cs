#nullable enable

namespace Letta
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Upsert Base Tools<br/>
        /// Upsert base tools
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Letta.Tool>> AddBaseToolsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}