
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsGetAgentVariablesResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.AgentsGetAgentVariablesResponseMessageJsonConverter))]
        public global::Letta.AgentsGetAgentVariablesResponseMessage Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsGetAgentVariablesResponse2" /> class.
        /// </summary>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsGetAgentVariablesResponse2(
            global::Letta.AgentsGetAgentVariablesResponseMessage message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsGetAgentVariablesResponse2" /> class.
        /// </summary>
        public AgentsGetAgentVariablesResponse2()
        {
        }
    }
}