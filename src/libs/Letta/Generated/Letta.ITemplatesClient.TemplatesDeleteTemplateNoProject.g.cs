#nullable enable

namespace Letta
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Delete template (Cloud-only)<br/>
        /// Deletes all versions of a template with the specified name
        /// </summary>
        /// <param name="templateName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.TemplatesDeleteTemplateNoProjectResponse> TemplatesDeleteTemplateNoProjectAsync(
            string templateName,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete template (Cloud-only)<br/>
        /// Deletes all versions of a template with the specified name
        /// </summary>
        /// <param name="templateName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.TemplatesDeleteTemplateNoProjectResponse> TemplatesDeleteTemplateNoProjectAsync(
            string templateName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}