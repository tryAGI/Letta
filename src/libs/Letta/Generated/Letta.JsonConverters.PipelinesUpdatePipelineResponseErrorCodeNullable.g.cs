#nullable enable

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public sealed class PipelinesUpdatePipelineResponseErrorCodeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.PipelinesUpdatePipelineResponseErrorCode?>
    {
        /// <inheritdoc />
        public override global::Letta.PipelinesUpdatePipelineResponseErrorCode? Read(
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
                        return global::Letta.PipelinesUpdatePipelineResponseErrorCodeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Letta.PipelinesUpdatePipelineResponseErrorCode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Letta.PipelinesUpdatePipelineResponseErrorCode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.PipelinesUpdatePipelineResponseErrorCode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Letta.PipelinesUpdatePipelineResponseErrorCodeExtensions.ToValueString(value.Value));
            }
        }
    }
}
