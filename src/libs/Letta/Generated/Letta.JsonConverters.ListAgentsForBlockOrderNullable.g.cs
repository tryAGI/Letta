#nullable enable

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListAgentsForBlockOrderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.ListAgentsForBlockOrder?>
    {
        /// <inheritdoc />
        public override global::Letta.ListAgentsForBlockOrder? Read(
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
                        return global::Letta.ListAgentsForBlockOrderExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Letta.ListAgentsForBlockOrder)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Letta.ListAgentsForBlockOrder?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.ListAgentsForBlockOrder? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Letta.ListAgentsForBlockOrderExtensions.ToValueString(value.Value));
            }
        }
    }
}
