#nullable enable

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public sealed class LettaSchemasLettaMessageToolReturnStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.LettaSchemasLettaMessageToolReturnStatus?>
    {
        /// <inheritdoc />
        public override global::Letta.LettaSchemasLettaMessageToolReturnStatus? Read(
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
                        return global::Letta.LettaSchemasLettaMessageToolReturnStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Letta.LettaSchemasLettaMessageToolReturnStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Letta.LettaSchemasLettaMessageToolReturnStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.LettaSchemasLettaMessageToolReturnStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Letta.LettaSchemasLettaMessageToolReturnStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
