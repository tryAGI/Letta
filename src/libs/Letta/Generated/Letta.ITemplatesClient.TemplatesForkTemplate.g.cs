#nullable enable

namespace Letta
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Fork template (Cloud-only)<br/>
        /// Forks a template version into a new template
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="templateVersion"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.TemplatesForkTemplateResponse> TemplatesForkTemplateAsync(
            string projectId,
            string templateVersion,

            global::Letta.TemplatesForkTemplateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fork template (Cloud-only)<br/>
        /// Forks a template version into a new template
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="templateVersion"></param>
        /// <param name="name">
        /// Optional custom name for the forked template. If not provided, a random name will be generated.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.TemplatesForkTemplateResponse> TemplatesForkTemplateAsync(
            string projectId,
            string templateVersion,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}