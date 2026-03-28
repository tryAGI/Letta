#nullable enable

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateAgentResponseFormatVariant1DiscriminatorTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.UpdateAgentResponseFormatVariant1DiscriminatorType?>
    {
        /// <inheritdoc />
        public override global::Letta.UpdateAgentResponseFormatVariant1DiscriminatorType? Read(
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
                        return global::Letta.UpdateAgentResponseFormatVariant1DiscriminatorTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Letta.UpdateAgentResponseFormatVariant1DiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Letta.UpdateAgentResponseFormatVariant1DiscriminatorType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.UpdateAgentResponseFormatVariant1DiscriminatorType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Letta.UpdateAgentResponseFormatVariant1DiscriminatorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
