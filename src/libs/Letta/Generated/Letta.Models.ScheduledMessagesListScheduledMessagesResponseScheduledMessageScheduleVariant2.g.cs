
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2TypeJsonConverter))]
        public global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron_expression")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CronExpression { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="cronExpression"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2(
            string cronExpression,
            global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2Type type)
        {
            this.CronExpression = cronExpression ?? throw new global::System.ArgumentNullException(nameof(cronExpression));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2" /> class.
        /// </summary>
        public ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2()
        {
        }
    }
}