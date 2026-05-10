#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class Config9JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.Config9>
    {
        /// <inheritdoc />
        public override global::Letta.Config9 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1? slackChannelReader = default;
            if (discriminator?.Type == global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminatorType.SlackChannelReader)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1)}");
                slackChannelReader = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2? customWebhook = default;
            if (discriminator?.Type == global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminatorType.CustomWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2)}");
                customWebhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Letta.Config9(
                discriminator?.Type,
                slackChannelReader,

                customWebhook
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.Config9 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSlackChannelReader)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackChannelReader!, typeInfo);
            }
            else if (value.IsCustomWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomWebhook!, typeInfo);
            }
        }
    }
}