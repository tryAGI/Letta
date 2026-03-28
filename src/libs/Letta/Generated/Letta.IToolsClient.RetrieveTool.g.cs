#nullable enable

namespace Letta
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Retrieve Tool<br/>
        /// Get a tool by ID
        /// </summary>
        /// <param name="toolId">
        /// The ID of the tool in the format 'tool-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.Tool> RetrieveToolAsync(
            string toolId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}