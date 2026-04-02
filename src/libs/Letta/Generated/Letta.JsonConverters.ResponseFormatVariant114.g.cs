#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class ResponseFormatVariant114JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.ResponseFormatVariant114>
    {
        /// <inheritdoc />
        public override global::Letta.ResponseFormatVariant114 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.TogetherModelSettingsResponseFormatVariant1Discriminator>(ref readerCopy, options);

            global::Letta.TextResponseFormat? text = default;
            if (discriminator?.Type == global::Letta.TogetherModelSettingsResponseFormatVariant1DiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.TextResponseFormat>(ref reader, options);
            }
            global::Letta.JsonSchemaResponseFormat? jsonSchema = default;
            if (discriminator?.Type == global::Letta.TogetherModelSettingsResponseFormatVariant1DiscriminatorType.JsonSchema)
            {
                jsonSchema = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.JsonSchemaResponseFormat>(ref reader, options);
            }
            global::Letta.JsonObjectResponseFormat? jsonObject = default;
            if (discriminator?.Type == global::Letta.TogetherModelSettingsResponseFormatVariant1DiscriminatorType.JsonObject)
            {
                jsonObject = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.JsonObjectResponseFormat>(ref reader, options);
            }

            var __value = new global::Letta.ResponseFormatVariant114(
                discriminator?.Type,
                text,

                jsonSchema,

                jsonObject
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.ResponseFormatVariant114 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::Letta.TextResponseFormat), options);
            }
            else if (value.IsJsonSchema)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonSchema, typeof(global::Letta.JsonSchemaResponseFormat), options);
            }
            else if (value.IsJsonObject)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonObject, typeof(global::Letta.JsonObjectResponseFormat), options);
            }
        }
    }
}