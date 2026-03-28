#nullable enable

namespace Letta
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Delete Tool<br/>
        /// Delete a tool by name
        /// </summary>
        /// <param name="toolId">
        /// The ID of the tool in the format 'tool-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteToolAsync(
            string toolId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}