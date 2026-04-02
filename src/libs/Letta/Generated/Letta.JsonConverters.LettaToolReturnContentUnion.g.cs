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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.LettaToolReturnContentUnionDiscriminator>(ref readerCopy, options);

            global::Letta.TextContent? text = default;
            if (discriminator?.Type == global::Letta.LettaToolReturnContentUnionDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.TextContent>(ref reader, options);
            }
            global::Letta.ImageContent? image = default;
            if (discriminator?.Type == global::Letta.LettaToolReturnContentUnionDiscriminatorType.Image)
            {
                image = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ImageContent>(ref reader, options);
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

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::Letta.TextContent), options);
            }
            else if (value.IsImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeof(global::Letta.ImageContent), options);
            }
        }
    }
}