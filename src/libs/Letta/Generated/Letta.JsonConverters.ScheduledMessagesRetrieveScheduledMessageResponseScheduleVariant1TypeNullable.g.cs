#nullable enable

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public sealed class ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1TypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1Type?>
    {
        /// <inheritdoc />
        public override global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1Type? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1TypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1Type?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1Type? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1TypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
