
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1TypeJsonConverter))]
        public global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1Type? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ScheduledAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="scheduledAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1(
            double scheduledAt,
            global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1Type? type)
        {
            this.ScheduledAt = scheduledAt;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1" /> class.
        /// </summary>
        public ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1()
        {
        }
    }
}