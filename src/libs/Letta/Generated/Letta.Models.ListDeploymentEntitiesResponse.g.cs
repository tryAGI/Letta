
#nullable enable

namespace Letta
{
    /// <summary>
    /// Response model for listing deployment entities.
    /// </summary>
    public sealed partial class ListDeploymentEntitiesResponse
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        public global::System.Collections.Generic.IList<global::Letta.DeploymentEntity>? Entities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDeploymentEntitiesResponse" /> class.
        /// </summary>
        /// <param name="entities">
        /// Default Value: []
        /// </param>
        /// <param name="totalCount"></param>
        /// <param name="deploymentId"></param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListDeploymentEntitiesResponse(
            int totalCount,
            string deploymentId,
            string message,
            global::System.Collections.Generic.IList<global::Letta.DeploymentEntity>? entities)
        {
            this.TotalCount = totalCount;
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Entities = entities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDeploymentEntitiesResponse" /> class.
        /// </summary>
        public ListDeploymentEntitiesResponse()
        {
        }
    }
}