#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class SourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.Source>
    {
        /// <inheritdoc />
        public override global::Letta.Source Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ImageContentSourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ImageContentSourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ImageContentSourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Letta.UrlImage? url = default;
            if (discriminator?.Type == global::Letta.ImageContentSourceDiscriminatorType.Url)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.UrlImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.UrlImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.UrlImage)}");
                url = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.Base64Image? base64 = default;
            if (discriminator?.Type == global::Letta.ImageContentSourceDiscriminatorType.Base64)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.Base64Image), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.Base64Image> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.Base64Image)}");
                base64 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.LettaImage? letta = default;
            if (discriminator?.Type == global::Letta.ImageContentSourceDiscriminatorType.Letta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.LettaImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.LettaImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.LettaImage)}");
                letta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Letta.Source(
                discriminator?.Type,
                url,

                base64,

                letta
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.Source value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.UrlImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.UrlImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.UrlImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url, typeInfo);
            }
            else if (value.IsBase64)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.Base64Image), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.Base64Image?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.Base64Image).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base64, typeInfo);
            }
            else if (value.IsLetta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.LettaImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.LettaImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.LettaImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Letta, typeInfo);
            }
        }
    }
}