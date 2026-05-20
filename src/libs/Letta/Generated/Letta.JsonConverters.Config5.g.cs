#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class Config5JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.Config5>
    {
        /// <inheritdoc />
        public override global::Letta.Config5 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.PipelinesCreatePipelineResponsePipelineConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant1? slackChannelReader = default;
            if (discriminator?.Type == global::Letta.PipelinesCreatePipelineResponsePipelineConfigDiscriminatorType.SlackChannelReader)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant1)}");
                slackChannelReader = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant2? customWebhook = default;
            if (discriminator?.Type == global::Letta.PipelinesCreatePipelineResponsePipelineConfigDiscriminatorType.CustomWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant2)}");
                customWebhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Letta.Config5(
                discriminator?.Type,
                slackChannelReader,

                customWebhook
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.Config5 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSlackChannelReader)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackChannelReader!, typeInfo);
            }
            else if (value.IsCustomWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomWebhook!, typeInfo);
            }
        }
    }
}