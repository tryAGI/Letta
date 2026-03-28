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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.SearchAllMessagesResponseItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.SearchAllMessagesResponseItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.SearchAllMessagesResponseItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Letta.SystemMessageListResult? systemMessage = default;
            if (discriminator?.MessageType == global::Letta.SearchAllMessagesResponseItemDiscriminatorMessageType.SystemMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.SystemMessageListResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.SystemMessageListResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.SystemMessageListResult)}");
                systemMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.UserMessageListResult? userMessage = default;
            if (discriminator?.MessageType == global::Letta.SearchAllMessagesResponseItemDiscriminatorMessageType.UserMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.UserMessageListResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.UserMessageListResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.UserMessageListResult)}");
                userMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ReasoningMessageListResult? reasoningMessage = default;
            if (discriminator?.MessageType == global::Letta.SearchAllMessagesResponseItemDiscriminatorMessageType.ReasoningMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ReasoningMessageListResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ReasoningMessageListResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ReasoningMessageListResult)}");
                reasoningMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.AssistantMessageListResult? assistantMessage = default;
            if (discriminator?.MessageType == global::Letta.SearchAllMessagesResponseItemDiscriminatorMessageType.AssistantMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.AssistantMessageListResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.AssistantMessageListResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.AssistantMessageListResult)}");
                assistantMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSystemMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.SystemMessageListResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.SystemMessageListResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.SystemMessageListResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SystemMessage, typeInfo);
            }
            else if (value.IsUserMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.UserMessageListResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.UserMessageListResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.UserMessageListResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserMessage, typeInfo);
            }
            else if (value.IsReasoningMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ReasoningMessageListResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ReasoningMessageListResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.ReasoningMessageListResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningMessage, typeInfo);
            }
            else if (value.IsAssistantMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.AssistantMessageListResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.AssistantMessageListResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.AssistantMessageListResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssistantMessage, typeInfo);
            }
        }
    }
}