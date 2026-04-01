#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class LettaToolReturnContentUnionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.LettaToolReturnContentUnion>
    {
        /// <inheritdoc />
        public override global::Letta.LettaToolReturnContentUnion Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.LettaToolReturnContentUnionDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.LettaToolReturnContentUnionDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.LettaToolReturnContentUnionDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Letta.TextContent? text = default;
            if (discriminator?.Type == global::Letta.LettaToolReturnContentUnionDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.TextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.TextContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.TextContent)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ImageContent? image = default;
            if (discriminator?.Type == global::Letta.LettaToolReturnContentUnionDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ImageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ImageContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ImageContent)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Letta.LettaToolReturnContentUnion(
                discriminator?.Type,
                text,

                image
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.LettaToolReturnContentUnion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.TextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.TextContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.TextContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ImageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ImageContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.ImageContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!, typeInfo);
            }
        }
    }
}