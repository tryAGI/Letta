#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class ResponseFormatVariant110JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.ResponseFormatVariant110>
    {
        /// <inheritdoc />
        public override global::Letta.ResponseFormatVariant110 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ModelResponseFormatVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ModelResponseFormatVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ModelResponseFormatVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Letta.TextResponseFormat? text = default;
            if (discriminator?.Type == global::Letta.ModelResponseFormatVariant1DiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.TextResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.TextResponseFormat> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.TextResponseFormat)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.JsonSchemaResponseFormat? jsonSchema = default;
            if (discriminator?.Type == global::Letta.ModelResponseFormatVariant1DiscriminatorType.JsonSchema)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.JsonSchemaResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.JsonSchemaResponseFormat> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.JsonSchemaResponseFormat)}");
                jsonSchema = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.JsonObjectResponseFormat? jsonObject = default;
            if (discriminator?.Type == global::Letta.ModelResponseFormatVariant1DiscriminatorType.JsonObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.JsonObjectResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.JsonObjectResponseFormat> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.JsonObjectResponseFormat)}");
                jsonObject = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Letta.ResponseFormatVariant110(
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
            global::Letta.ResponseFormatVariant110 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.TextResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.TextResponseFormat?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.TextResponseFormat).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsJsonSchema)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.JsonSchemaResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.JsonSchemaResponseFormat?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.JsonSchemaResponseFormat).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonSchema, typeInfo);
            }
            else if (value.IsJsonObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.JsonObjectResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.JsonObjectResponseFormat?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.JsonObjectResponseFormat).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonObject, typeInfo);
            }
        }
    }
}