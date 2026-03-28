#nullable enable

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public sealed class LettaSchemasMessageToolReturnOutputStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.LettaSchemasMessageToolReturnOutputStatus?>
    {
        /// <inheritdoc />
        public override global::Letta.LettaSchemasMessageToolReturnOutputStatus? Read(
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
                        return global::Letta.LettaSchemasMessageToolReturnOutputStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Letta.LettaSchemasMessageToolReturnOutputStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Letta.LettaSchemasMessageToolReturnOutputStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.LettaSchemasMessageToolReturnOutputStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Letta.LettaSchemasMessageToolReturnOutputStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
