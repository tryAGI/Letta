#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta
{
    public partial interface IInternalTemplatesClient
    {
        /// <summary>
        /// Create Group<br/>
        /// Create a new multi-agent group with the specified configuration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.Group> CreateInternalTemplateGroupAsync(

            global::Letta.InternalTemplateGroupCreate request,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Group<br/>
        /// Create a new multi-agent group with the specified configuration.
        /// </summary>
        /// <param name="agentIds"></param>
        /// <param name="description"></param>
        /// <param name="managerConfig">
        /// Default Value: {"manager_type":"round_robin"}
        /// </param>
        /// <param name="projectId">
        /// The associated project id.
        /// </param>
        /// <param name="hidden">
        /// If set to True, the group will be hidden.
        /// </param>
        /// <param name="baseTemplateId">
        /// The id of the base template.
        /// </param>
        /// <param name="templateId">
        /// The id of the template.
        /// </param>
        /// <param name="deploymentId">
        /// The id of the deployment.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.Group> CreateInternalTemplateGroupAsync(
            global::System.Collections.Generic.IList<string> agentIds,
            string description,
            string baseTemplateId,
            string templateId,
            string deploymentId,
            global::Letta.ManagerConfig3? managerConfig = default,
            string? projectId = default,
            bool? hidden = default,
            global::Letta.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}