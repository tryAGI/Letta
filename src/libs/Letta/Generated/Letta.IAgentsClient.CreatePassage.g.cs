#nullable enable

namespace Letta
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Create Passage<br/>
        /// Insert a memory into an agent's archival memory store.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Letta.Passage>> CreatePassageAsync(
            string agentId,

            global::Letta.CreateArchivalMemory request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Passage<br/>
        /// Insert a memory into an agent's archival memory store.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
        /// </param>
        /// <param name="text">
        /// Text to write to archival memory.
        /// </param>
        /// <param name="tags">
        /// Optional list of tags to attach to the memory.
        /// </param>
        /// <param name="createdAt">
        /// Optional timestamp for the memory (defaults to current UTC time).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Letta.Passage>> CreatePassageAsync(
            string agentId,
            string text,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.DateTime? createdAt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}