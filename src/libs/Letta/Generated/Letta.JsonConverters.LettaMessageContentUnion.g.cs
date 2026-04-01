#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class LettaMessageContentUnionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.LettaMessageContentUnion>
    {
        /// <inheritdoc />
        public override global::Letta.LettaMessageContentUnion Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.LettaMessageContentUnionDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.LettaMessageContentUnionDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.LettaMessageContentUnionDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Letta.TextContent? text = default;
            if (discriminator?.Type == global::Letta.LettaMessageContentUnionDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.TextContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.TextContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.TextContent)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ImageContent? image = default;
            if (discriminator?.Type == global::Letta.LettaMessageContentUnionDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ImageContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ImageContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ImageContent)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ToolCallContent? toolCall = default;
            if (discriminator?.Type == global::Letta.LettaMessageContentUnionDiscriminatorType.ToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ToolCallContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ToolCallContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ToolCallContent)}");
                toolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ToolReturnContent? toolReturn = default;
            if (discriminator?.Type == global::Letta.LettaMessageContentUnionDiscriminatorType.ToolReturn)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ToolReturnContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ToolReturnContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ToolReturnContent)}");
                toolReturn = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ReasoningContent? reasoning = default;
            if (discriminator?.Type == global::Letta.LettaMessageContentUnionDiscriminatorType.Reasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ReasoningContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ReasoningContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ReasoningContent)}");
                reasoning = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.RedactedReasoningContent? redactedReasoning = default;
            if (discriminator?.Type == global::Letta.LettaMessageContentUnionDiscriminatorType.RedactedReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.RedactedReasoningContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.RedactedReasoningContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.RedactedReasoningContent)}");
                redactedReasoning = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.OmittedReasoningContent? omittedReasoning = default;
            if (discriminator?.Type == global::Letta.LettaMessageContentUnionDiscriminatorType.OmittedReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.OmittedReasoningContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.OmittedReasoningContent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.OmittedReasoningContent)}");
                omittedReasoning = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Letta.LettaMessageContentUnion(
                discriminator?.Type,
                text,

                image,

                toolCall,

                toolReturn,

                reasoning,

                redactedReasoning,

                omittedReasoning
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.LettaMessageContentUnion value,
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
            else if (value.IsToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ToolCallContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ToolCallContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.ToolCallContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCall!, typeInfo);
            }
            else if (value.IsToolReturn)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ToolReturnContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ToolReturnContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.ToolReturnContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolReturn!, typeInfo);
            }
            else if (value.IsReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ReasoningContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ReasoningContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.ReasoningContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Reasoning!, typeInfo);
            }
            else if (value.IsRedactedReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.RedactedReasoningContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.RedactedReasoningContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.RedactedReasoningContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RedactedReasoning!, typeInfo);
            }
            else if (value.IsOmittedReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.OmittedReasoningContent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.OmittedReasoningContent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.OmittedReasoningContent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OmittedReasoning!, typeInfo);
            }
        }
    }
}