#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class SearchAllMessagesResponseItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.SearchAllMessagesResponseItem>
    {
        /// <inheritdoc />
        public override global::Letta.SearchAllMessagesResponseItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.SearchAllMessagesResponseItemDiscriminator>(ref readerCopy, options);

            global::Letta.SystemMessageListResult? systemMessage = default;
            if (discriminator?.MessageType == global::Letta.SearchAllMessagesResponseItemDiscriminatorMessageType.SystemMessage)
            {
                systemMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.SystemMessageListResult>(ref reader, options);
            }
            global::Letta.UserMessageListResult? userMessage = default;
            if (discriminator?.MessageType == global::Letta.SearchAllMessagesResponseItemDiscriminatorMessageType.UserMessage)
            {
                userMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.UserMessageListResult>(ref reader, options);
            }
            global::Letta.ReasoningMessageListResult? reasoningMessage = default;
            if (discriminator?.MessageType == global::Letta.SearchAllMessagesResponseItemDiscriminatorMessageType.ReasoningMessage)
            {
                reasoningMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ReasoningMessageListResult>(ref reader, options);
            }
            global::Letta.AssistantMessageListResult? assistantMessage = default;
            if (discriminator?.MessageType == global::Letta.SearchAllMessagesResponseItemDiscriminatorMessageType.AssistantMessage)
            {
                assistantMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.AssistantMessageListResult>(ref reader, options);
            }

            var __value = new global::Letta.SearchAllMessagesResponseItem(
                discriminator?.MessageType,
                systemMessage,

                userMessage,

                reasoningMessage,

                assistantMessage
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.SearchAllMessagesResponseItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSystemMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SystemMessage, typeof(global::Letta.SystemMessageListResult), options);
            }
            else if (value.IsUserMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserMessage, typeof(global::Letta.UserMessageListResult), options);
            }
            else if (value.IsReasoningMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningMessage, typeof(global::Letta.ReasoningMessageListResult), options);
            }
            else if (value.IsAssistantMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssistantMessage, typeof(global::Letta.AssistantMessageListResult), options);
            }
        }
    }
}