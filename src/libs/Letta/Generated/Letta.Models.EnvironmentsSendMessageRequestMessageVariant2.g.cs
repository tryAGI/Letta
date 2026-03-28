
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentsSendMessageRequestMessageVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2TypeJsonConverter))]
        public global::Letta.EnvironmentsSendMessageRequestMessageVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approvals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1, global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2>> Approvals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsSendMessageRequestMessageVariant2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="approvals"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentsSendMessageRequestMessageVariant2(
            global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1, global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2>> approvals,
            global::Letta.EnvironmentsSendMessageRequestMessageVariant2Type type)
        {
            this.Approvals = approvals ?? throw new global::System.ArgumentNullException(nameof(approvals));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsSendMessageRequestMessageVariant2" /> class.
        /// </summary>
        public EnvironmentsSendMessageRequestMessageVariant2()
        {
        }
    }
}