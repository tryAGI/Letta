#nullable enable

namespace Letta
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create Project (Cloud-only)<br/>
        /// Create a new project
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.ProjectsCreateProjectResponse> ProjectsCreateProjectAsync(

            global::Letta.ProjectsCreateProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Project (Cloud-only)<br/>
        /// Create a new project
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.ProjectsCreateProjectResponse> ProjectsCreateProjectAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}