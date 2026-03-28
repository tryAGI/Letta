#nullable enable

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public sealed class MetadataSendTelemetryRequestEventVariant3TypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.MetadataSendTelemetryRequestEventVariant3Type?>
    {
        /// <inheritdoc />
        public override global::Letta.MetadataSendTelemetryRequestEventVariant3Type? Read(
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
                        return global::Letta.MetadataSendTelemetryRequestEventVariant3TypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Letta.MetadataSendTelemetryRequestEventVariant3Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Letta.MetadataSendTelemetryRequestEventVariant3Type?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.MetadataSendTelemetryRequestEventVariant3Type? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Letta.MetadataSendTelemetryRequestEventVariant3TypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
