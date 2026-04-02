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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ImageContentSourceDiscriminator>(ref readerCopy, options);

            global::Letta.UrlImage? url = default;
            if (discriminator?.Type == global::Letta.ImageContentSourceDiscriminatorType.Url)
            {
                url = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.UrlImage>(ref reader, options);
            }
            global::Letta.Base64Image? base64 = default;
            if (discriminator?.Type == global::Letta.ImageContentSourceDiscriminatorType.Base64)
            {
                base64 = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.Base64Image>(ref reader, options);
            }
            global::Letta.LettaImage? letta = default;
            if (discriminator?.Type == global::Letta.ImageContentSourceDiscriminatorType.Letta)
            {
                letta = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.LettaImage>(ref reader, options);
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

            if (value.IsUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url, typeof(global::Letta.UrlImage), options);
            }
            else if (value.IsBase64)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base64, typeof(global::Letta.Base64Image), options);
            }
            else if (value.IsLetta)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Letta, typeof(global::Letta.LettaImage), options);
            }
        }
    }
}