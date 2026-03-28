#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class FuncResponseVariant2ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.FuncResponseVariant2Item>
    {
        /// <inheritdoc />
        public override global::Letta.FuncResponseVariant2Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Letta.TextContent? text = default;
            if (discriminator?.Type == global::Letta.LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.TextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.TextContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.TextContent)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ImageContent? image = default;
            if (discriminator?.Type == global::Letta.LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ImageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ImageContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ImageContent)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Letta.FuncResponseVariant2Item(
                discriminator?.Type,
                text,

                image
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.FuncResponseVariant2Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.TextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.TextContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.TextContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ImageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ImageContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.ImageContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeInfo);
            }
        }
    }
}