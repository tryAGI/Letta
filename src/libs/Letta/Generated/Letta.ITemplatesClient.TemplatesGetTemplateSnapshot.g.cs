#nullable enable

namespace Letta
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Get template snapshot (Cloud-only)<br/>
        /// Get a snapshot of the template version, this will return the template state at a specific version
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="templateVersion"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.TemplatesGetTemplateSnapshotResponse> TemplatesGetTemplateSnapshotAsync(
            string projectId,
            string templateVersion,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}