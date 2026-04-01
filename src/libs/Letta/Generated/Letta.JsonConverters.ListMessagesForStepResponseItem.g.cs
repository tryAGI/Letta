#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class ListMessagesForStepResponseItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.ListMessagesForStepResponseItem>
    {
        /// <inheritdoc />
        public override global::Letta.ListMessagesForStepResponseItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ListMessagesForStepResponseItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ListMessagesForStepResponseItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ListMessagesForStepResponseItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Letta.SystemMessage? systemMessage = default;
            if (discriminator?.MessageType == global::Letta.ListMessagesForStepResponseItemDiscriminatorMessageType.SystemMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.SystemMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.SystemMessage)}");
                systemMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.UserMessage? userMessage = default;
            if (discriminator?.MessageType == global::Letta.ListMessagesForStepResponseItemDiscriminatorMessageType.UserMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.UserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.UserMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.UserMessage)}");
                userMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ReasoningMessage? reasoningMessage = default;
            if (discriminator?.MessageType == global::Letta.ListMessagesForStepResponseItemDiscriminatorMessageType.ReasoningMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ReasoningMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ReasoningMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ReasoningMessage)}");
                reasoningMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.HiddenReasoningMessage? hiddenReasoningMessage = default;
            if (discriminator?.MessageType == global::Letta.ListMessagesForStepResponseItemDiscriminatorMessageType.HiddenReasoningMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.HiddenReasoningMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.HiddenReasoningMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.HiddenReasoningMessage)}");
                hiddenReasoningMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ToolCallMessage? toolCallMessage = default;
            if (discriminator?.MessageType == global::Letta.ListMessagesForStepResponseItemDiscriminatorMessageType.ToolCallMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ToolCallMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ToolCallMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ToolCallMessage)}");
                toolCallMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ToolReturnMessage? toolReturnMessage = default;
            if (discriminator?.MessageType == global::Letta.ListMessagesForStepResponseItemDiscriminatorMessageType.ToolReturnMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ToolReturnMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ToolReturnMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ToolReturnMessage)}");
                toolReturnMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.AssistantMessage? assistantMessage = default;
            if (discriminator?.MessageType == global::Letta.ListMessagesForStepResponseItemDiscriminatorMessageType.AssistantMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.AssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.AssistantMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.AssistantMessage)}");
                assistantMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ApprovalRequestMessage? approvalRequestMessage = default;
            if (discriminator?.MessageType == global::Letta.ListMessagesForStepResponseItemDiscriminatorMessageType.ApprovalRequestMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ApprovalRequestMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ApprovalRequestMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ApprovalRequestMessage)}");
                approvalRequestMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ApprovalResponseMessage? approvalResponseMessage = default;
            if (discriminator?.MessageType == global::Letta.ListMessagesForStepResponseItemDiscriminatorMessageType.ApprovalResponseMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ApprovalResponseMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ApprovalResponseMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ApprovalResponseMessage)}");
                approvalResponseMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.SummaryMessage? summaryMessage = default;
            if (discriminator?.MessageType == global::Letta.ListMessagesForStepResponseItemDiscriminatorMessageType.SummaryMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.SummaryMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.SummaryMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.SummaryMessage)}");
                summaryMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.EventMessage? eventMessage = default;
            if (discriminator?.MessageType == global::Letta.ListMessagesForStepResponseItemDiscriminatorMessageType.EventMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.EventMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.EventMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.EventMessage)}");
                eventMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Letta.ListMessagesForStepResponseItem(
                discriminator?.MessageType,
                systemMessage,

                userMessage,

                reasoningMessage,

                hiddenReasoningMessage,

                toolCallMessage,

                toolReturnMessage,

                assistantMessage,

                approvalRequestMessage,

                approvalResponseMessage,

                summaryMessage,

                eventMessage
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.ListMessagesForStepResponseItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSystemMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.SystemMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.SystemMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SystemMessage!, typeInfo);
            }
            else if (value.IsUserMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.UserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.UserMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.UserMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserMessage!, typeInfo);
            }
            else if (value.IsReasoningMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ReasoningMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ReasoningMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.ReasoningMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningMessage!, typeInfo);
            }
            else if (value.IsHiddenReasoningMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.HiddenReasoningMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.HiddenReasoningMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.HiddenReasoningMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HiddenReasoningMessage!, typeInfo);
            }
            else if (value.IsToolCallMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ToolCallMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ToolCallMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.ToolCallMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallMessage!, typeInfo);
            }
            else if (value.IsToolReturnMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ToolReturnMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ToolReturnMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.ToolReturnMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolReturnMessage!, typeInfo);
            }
            else if (value.IsAssistantMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.AssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.AssistantMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.AssistantMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssistantMessage!, typeInfo);
            }
            else if (value.IsApprovalRequestMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ApprovalRequestMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ApprovalRequestMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.ApprovalRequestMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApprovalRequestMessage!, typeInfo);
            }
            else if (value.IsApprovalResponseMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ApprovalResponseMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ApprovalResponseMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.ApprovalResponseMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApprovalResponseMessage!, typeInfo);
            }
            else if (value.IsSummaryMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.SummaryMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.SummaryMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.SummaryMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SummaryMessage!, typeInfo);
            }
            else if (value.IsEventMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.EventMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.EventMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.EventMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EventMessage!, typeInfo);
            }
        }
    }
}