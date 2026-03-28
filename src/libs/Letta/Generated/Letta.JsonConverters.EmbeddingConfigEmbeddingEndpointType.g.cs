#nullable enable

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public sealed class EmbeddingConfigEmbeddingEndpointTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.EmbeddingConfigEmbeddingEndpointType>
    {
        /// <inheritdoc />
        public override global::Letta.EmbeddingConfigEmbeddingEndpointType Read(
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
                        return global::Letta.EmbeddingConfigEmbeddingEndpointTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Letta.EmbeddingConfigEmbeddingEndpointType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Letta.EmbeddingConfigEmbeddingEndpointType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.EmbeddingConfigEmbeddingEndpointType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Letta.EmbeddingConfigEmbeddingEndpointTypeExtensions.ToValueString(value));
        }
    }
}
