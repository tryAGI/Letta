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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.LettaAsyncRequestInputVariant2ItemDiscriminator>(ref readerCopy, options);

            global::Letta.TextContent? text = default;
            if (discriminator?.Type == global::Letta.LettaAsyncRequestInputVariant2ItemDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.TextContent>(ref reader, options);
            }
            global::Letta.ImageContent? image = default;
            if (discriminator?.Type == global::Letta.LettaAsyncRequestInputVariant2ItemDiscriminatorType.Image)
            {
                image = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ImageContent>(ref reader, options);
            }
            global::Letta.ToolCallContent? toolCall = default;
            if (discriminator?.Type == global::Letta.LettaAsyncRequestInputVariant2ItemDiscriminatorType.ToolCall)
            {
                toolCall = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ToolCallContent>(ref reader, options);
            }
            global::Letta.ToolReturnContent? toolReturn = default;
            if (discriminator?.Type == global::Letta.LettaAsyncRequestInputVariant2ItemDiscriminatorType.ToolReturn)
            {
                toolReturn = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ToolReturnContent>(ref reader, options);
            }
            global::Letta.ReasoningContent? omittedReasoning1 = default;
            if (discriminator?.Type == global::Letta.LettaAsyncRequestInputVariant2ItemDiscriminatorType.OmittedReasoning)
            {
                omittedReasoning1 = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ReasoningContent>(ref reader, options);
            }
            global::Letta.RedactedReasoningContent? redactedReasoning = default;
            if (discriminator?.Type == global::Letta.LettaAsyncRequestInputVariant2ItemDiscriminatorType.RedactedReasoning)
            {
                redactedReasoning = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.RedactedReasoningContent>(ref reader, options);
            }
            global::Letta.OmittedReasoningContent? omittedReasoning2 = default;
            if (discriminator?.Type == global::Letta.LettaAsyncRequestInputVariant2ItemDiscriminatorType.OmittedReasoning)
            {
                omittedReasoning2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.OmittedReasoningContent>(ref reader, options);
            }
            global::Letta.SummarizedReasoningContent? summarizedReasoning = default;
            if (discriminator?.Type == global::Letta.LettaAsyncRequestInputVariant2ItemDiscriminatorType.SummarizedReasoning)
            {
                summarizedReasoning = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.SummarizedReasoningContent>(ref reader, options);
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
            else if (value.IsOmittedReasoning1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OmittedReasoning1, typeof(global::Letta.ReasoningContent), options);
            }
            else if (value.IsRedactedReasoning)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RedactedReasoning, typeof(global::Letta.RedactedReasoningContent), options);
            }
            else if (value.IsOmittedReasoning2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OmittedReasoning2, typeof(global::Letta.OmittedReasoningContent), options);
            }
            else if (value.IsSummarizedReasoning)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SummarizedReasoning, typeof(global::Letta.SummarizedReasoningContent), options);
            }
        }
    }
}