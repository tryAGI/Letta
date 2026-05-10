#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class Config6JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.Config6>
    {
        /// <inheritdoc />
        public override global::Letta.Config6 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.PipelinesListPipelinesResponsePipelineConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.PipelinesListPipelinesResponsePipelineConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1? slackChannelReader = default;
            if (discriminator?.Type == global::Letta.PipelinesListPipelinesResponsePipelineConfigDiscriminatorType.SlackChannelReader)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1)}");
                slackChannelReader = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2? customWebhook = default;
            if (discriminator?.Type == global::Letta.PipelinesListPipelinesResponsePipelineConfigDiscriminatorType.CustomWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2)}");
                customWebhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Letta.Config6(
                discriminator?.Type,
                slackChannelReader,

                customWebhook
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.Config6 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSlackChannelReader)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackChannelReader!, typeInfo);
            }
            else if (value.IsCustomWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomWebhook!, typeInfo);
            }
        }
    }
}