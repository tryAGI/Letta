#nullable enable

namespace Letta
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Update template description (Cloud-only)<br/>
        /// Updates the description for all versions of a template with the specified name. Versions are automatically stripped from the current template name if accidentally included.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="templateName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.TemplatesUpdateTemplateDescriptionResponse> TemplatesUpdateTemplateDescriptionAsync(
            string projectId,
            string templateName,

            global::Letta.TemplatesUpdateTemplateDescriptionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update template description (Cloud-only)<br/>
        /// Updates the description for all versions of a template with the specified name. Versions are automatically stripped from the current template name if accidentally included.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="templateName"></param>
        /// <param name="description">
        /// The new description for the template
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.TemplatesUpdateTemplateDescriptionResponse> TemplatesUpdateTemplateDescriptionAsync(
            string projectId,
            string templateName,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}