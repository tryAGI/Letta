#nullable enable

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public sealed class PipelinesCreatePipelineRequestIntegrationTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.PipelinesCreatePipelineRequestIntegrationType?>
    {
        /// <inheritdoc />
        public override global::Letta.PipelinesCreatePipelineRequestIntegrationType? Read(
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
                        return global::Letta.PipelinesCreatePipelineRequestIntegrationTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Letta.PipelinesCreatePipelineRequestIntegrationType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Letta.PipelinesCreatePipelineRequestIntegrationType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.PipelinesCreatePipelineRequestIntegrationType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Letta.PipelinesCreatePipelineRequestIntegrationTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
