#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class InputVariant2Item2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.InputVariant2Item2>
    {
        /// <inheritdoc />
        public override global::Letta.InputVariant2Item2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.LettaAsyncRequestInputVariant2ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.LettaAsyncRequestInputVariant2ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.LettaAsyncRequestInputVariant2ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Letta.TextContent? text = default;
            if (discriminator?.Type == global::Letta.LettaAsyncRequestInputVariant2ItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.TextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.TextContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.TextContent)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ImageContent? image = default;
            if (discriminator?.Type == global::Letta.LettaAsyncRequestInputVariant2ItemDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ImageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ImageContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ImageContent)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ToolCallContent? toolCall = default;
            if (discriminator?.Type == global::Letta.LettaAsyncRequestInputVariant2ItemDiscriminatorType.ToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ToolCallContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ToolCallContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ToolCallContent)}");
                toolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ToolReturnContent? toolReturn = default;
            if (discriminator?.Type == global::Letta.LettaAsyncRequestInputVariant2ItemDiscriminatorType.ToolReturn)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ToolReturnContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ToolReturnContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ToolReturnContent)}");
                toolReturn = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ReasoningContent? omittedReasoning1 = default;
            if (discriminator?.Type == global::Letta.LettaAsyncRequestInputVariant2ItemDiscriminatorType.OmittedReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ReasoningContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ReasoningContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ReasoningContent)}");
                omittedReasoning1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.RedactedReasoningContent? redactedReasoning = default;
            if (discriminator?.Type == global::Letta.LettaAsyncRequestInputVariant2ItemDiscriminatorType.RedactedReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.RedactedReasoningContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.RedactedReasoningContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.RedactedReasoningContent)}");
                redactedReasoning = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.OmittedReasoningContent? omittedReasoning2 = default;
            if (discriminator?.Type == global::Letta.LettaAsyncRequestInputVariant2ItemDiscriminatorType.OmittedReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.OmittedReasoningContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.OmittedReasoningContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.OmittedReasoningContent)}");
                omittedReasoning2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.SummarizedReasoningContent? summarizedReasoning = default;
            if (discriminator?.Type == global::Letta.LettaAsyncRequestInputVariant2ItemDiscriminatorType.SummarizedReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.SummarizedReasoningContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.SummarizedReasoningContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.SummarizedReasoningContent)}");
                summarizedReasoning = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Letta.InputVariant2Item2(
                discriminator?.Type,
                text,

                image,

                toolCall,

                toolReturn,

                omittedReasoning1,

                redactedReasoning,

                omittedReasoning2,

                summarizedReasoning
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.InputVariant2Item2 value,
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
            else if (value.IsToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ToolCallContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ToolCallContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.ToolCallContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCall, typeInfo);
            }
            else if (value.IsToolReturn)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ToolReturnContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ToolReturnContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.ToolReturnContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolReturn, typeInfo);
            }
            else if (value.IsOmittedReasoning1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ReasoningContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ReasoningContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.ReasoningContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OmittedReasoning1, typeInfo);
            }
            else if (value.IsRedactedReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.RedactedReasoningContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.RedactedReasoningContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.RedactedReasoningContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RedactedReasoning, typeInfo);
            }
            else if (value.IsOmittedReasoning2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.OmittedReasoningContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.OmittedReasoningContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.OmittedReasoningContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OmittedReasoning2, typeInfo);
            }
            else if (value.IsSummarizedReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.SummarizedReasoningContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.SummarizedReasoningContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.SummarizedReasoningContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SummarizedReasoning, typeInfo);
            }
        }
    }
}