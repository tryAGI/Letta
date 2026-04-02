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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.LettaMessageContentUnionDiscriminator>(ref readerCopy, options);

            global::Letta.TextContent? text = default;
            if (discriminator?.Type == global::Letta.LettaMessageContentUnionDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.TextContent>(ref reader, options);
            }
            global::Letta.ImageContent? image = default;
            if (discriminator?.Type == global::Letta.LettaMessageContentUnionDiscriminatorType.Image)
            {
                image = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ImageContent>(ref reader, options);
            }
            global::Letta.ToolCallContent? toolCall = default;
            if (discriminator?.Type == global::Letta.LettaMessageContentUnionDiscriminatorType.ToolCall)
            {
                toolCall = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ToolCallContent>(ref reader, options);
            }
            global::Letta.ToolReturnContent? toolReturn = default;
            if (discriminator?.Type == global::Letta.LettaMessageContentUnionDiscriminatorType.ToolReturn)
            {
                toolReturn = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ToolReturnContent>(ref reader, options);
            }
            global::Letta.ReasoningContent? reasoning = default;
            if (discriminator?.Type == global::Letta.LettaMessageContentUnionDiscriminatorType.Reasoning)
            {
                reasoning = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ReasoningContent>(ref reader, options);
            }
            global::Letta.RedactedReasoningContent? redactedReasoning = default;
            if (discriminator?.Type == global::Letta.LettaMessageContentUnionDiscriminatorType.RedactedReasoning)
            {
                redactedReasoning = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.RedactedReasoningContent>(ref reader, options);
            }
            global::Letta.OmittedReasoningContent? omittedReasoning = default;
            if (discriminator?.Type == global::Letta.LettaMessageContentUnionDiscriminatorType.OmittedReasoning)
            {
                omittedReasoning = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.OmittedReasoningContent>(ref reader, options);
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

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::Letta.TextContent), options);
            }
            else if (value.IsImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeof(global::Letta.ImageContent), options);
            }
            else if (value.IsToolCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCall, typeof(global::Letta.ToolCallContent), options);
            }
            else if (value.IsToolReturn)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolReturn, typeof(global::Letta.ToolReturnContent), options);
            }
            else if (value.IsReasoning)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Reasoning, typeof(global::Letta.ReasoningContent), options);
            }
            else if (value.IsRedactedReasoning)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RedactedReasoning, typeof(global::Letta.RedactedReasoningContent), options);
            }
            else if (value.IsOmittedReasoning)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OmittedReasoning, typeof(global::Letta.OmittedReasoningContent), options);
            }
        }
    }
}