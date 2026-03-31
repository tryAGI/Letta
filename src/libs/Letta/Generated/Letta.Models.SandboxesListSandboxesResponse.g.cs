
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesListSandboxesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Letta.SandboxesListSandboxesResponseSandboxe> Sandboxes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesListSandboxesResponse" /> class.
        /// </summary>
        /// <param name="sandboxes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesListSandboxesResponse(
            global::System.Collections.Generic.IList<global::Letta.SandboxesListSandboxesResponseSandboxe> sandboxes)
        {
            this.Sandboxes = sandboxes ?? throw new global::System.ArgumentNullException(nameof(sandboxes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesListSandboxesResponse" /> class.
        /// </summary>
        public SandboxesListSandboxesResponse()
        {
        }
    }
}