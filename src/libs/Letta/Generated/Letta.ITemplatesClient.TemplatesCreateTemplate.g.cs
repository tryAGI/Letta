#nullable enable

namespace Letta
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Create template (Cloud-only)<br/>
        /// Creates a new template from an existing agent or agent file
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.TemplatesCreateTemplateResponse> TemplatesCreateTemplateAsync(
            string projectId,

            global::Letta.TemplatesCreateTemplateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create template (Cloud-only)<br/>
        /// Creates a new template from an existing agent or agent file
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.TemplatesCreateTemplateResponse> TemplatesCreateTemplateAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}