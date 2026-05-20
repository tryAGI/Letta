#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class ProducerConfig3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.ProducerConfig3>
    {
        /// <inheritdoc />
        public override global::Letta.ProducerConfig3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.PipelinesPreviewPipelineRequestProducerConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1? slackChannelReader = default;
            if (discriminator?.Type == global::Letta.PipelinesPreviewPipelineRequestProducerConfigDiscriminatorType.SlackChannelReader)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1)}");
                slackChannelReader = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant2? customWebhook = default;
            if (discriminator?.Type == global::Letta.PipelinesPreviewPipelineRequestProducerConfigDiscriminatorType.CustomWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant2)}");
                customWebhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Letta.ProducerConfig3(
                discriminator?.Type,
                slackChannelReader,

                customWebhook
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.ProducerConfig3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSlackChannelReader)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackChannelReader!, typeInfo);
            }
            else if (value.IsCustomWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomWebhook!, typeInfo);
            }
        }
    }
}