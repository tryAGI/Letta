#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class ModifyGroupMessageResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.ModifyGroupMessageResponse>
    {
        /// <inheritdoc />
        public override global::Letta.ModifyGroupMessageResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ModifyGroupMessageResponseDiscriminator>(ref readerCopy, options);

            global::Letta.SystemMessage? systemMessage = default;
            if (discriminator?.MessageType == global::Letta.ModifyGroupMessageResponseDiscriminatorMessageType.SystemMessage)
            {
                systemMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.SystemMessage>(ref reader, options);
            }
            global::Letta.UserMessage? userMessage = default;
            if (discriminator?.MessageType == global::Letta.ModifyGroupMessageResponseDiscriminatorMessageType.UserMessage)
            {
                userMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.UserMessage>(ref reader, options);
            }
            global::Letta.ReasoningMessage? reasoningMessage = default;
            if (discriminator?.MessageType == global::Letta.ModifyGroupMessageResponseDiscriminatorMessageType.ReasoningMessage)
            {
                reasoningMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ReasoningMessage>(ref reader, options);
            }
            global::Letta.HiddenReasoningMessage? hiddenReasoningMessage = default;
            if (discriminator?.MessageType == global::Letta.ModifyGroupMessageResponseDiscriminatorMessageType.HiddenReasoningMessage)
            {
                hiddenReasoningMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.HiddenReasoningMessage>(ref reader, options);
            }
            global::Letta.ToolCallMessage? toolCallMessage = default;
            if (discriminator?.MessageType == global::Letta.ModifyGroupMessageResponseDiscriminatorMessageType.ToolCallMessage)
            {
                toolCallMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ToolCallMessage>(ref reader, options);
            }
            global::Letta.ToolReturnMessage? toolReturnMessage = default;
            if (discriminator?.MessageType == global::Letta.ModifyGroupMessageResponseDiscriminatorMessageType.ToolReturnMessage)
            {
                toolReturnMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ToolReturnMessage>(ref reader, options);
            }
            global::Letta.AssistantMessage? assistantMessage = default;
            if (discriminator?.MessageType == global::Letta.ModifyGroupMessageResponseDiscriminatorMessageType.AssistantMessage)
            {
                assistantMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.AssistantMessage>(ref reader, options);
            }
            global::Letta.ApprovalRequestMessage? approvalRequestMessage = default;
            if (discriminator?.MessageType == global::Letta.ModifyGroupMessageResponseDiscriminatorMessageType.ApprovalRequestMessage)
            {
                approvalRequestMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ApprovalRequestMessage>(ref reader, options);
            }
            global::Letta.ApprovalResponseMessage? approvalResponseMessage = default;
            if (discriminator?.MessageType == global::Letta.ModifyGroupMessageResponseDiscriminatorMessageType.ApprovalResponseMessage)
            {
                approvalResponseMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ApprovalResponseMessage>(ref reader, options);
            }
            global::Letta.SummaryMessage? summaryMessage = default;
            if (discriminator?.MessageType == global::Letta.ModifyGroupMessageResponseDiscriminatorMessageType.SummaryMessage)
            {
                summaryMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.SummaryMessage>(ref reader, options);
            }
            global::Letta.EventMessage? eventMessage = default;
            if (discriminator?.MessageType == global::Letta.ModifyGroupMessageResponseDiscriminatorMessageType.EventMessage)
            {
                eventMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.EventMessage>(ref reader, options);
            }

            var __value = new global::Letta.ModifyGroupMessageResponse(
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
            global::Letta.ModifyGroupMessageResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSystemMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SystemMessage, typeof(global::Letta.SystemMessage), options);
            }
            else if (value.IsUserMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserMessage, typeof(global::Letta.UserMessage), options);
            }
            else if (value.IsReasoningMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningMessage, typeof(global::Letta.ReasoningMessage), options);
            }
            else if (value.IsHiddenReasoningMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HiddenReasoningMessage, typeof(global::Letta.HiddenReasoningMessage), options);
            }
            else if (value.IsToolCallMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallMessage, typeof(global::Letta.ToolCallMessage), options);
            }
            else if (value.IsToolReturnMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolReturnMessage, typeof(global::Letta.ToolReturnMessage), options);
            }
            else if (value.IsAssistantMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssistantMessage, typeof(global::Letta.AssistantMessage), options);
            }
            else if (value.IsApprovalRequestMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApprovalRequestMessage, typeof(global::Letta.ApprovalRequestMessage), options);
            }
            else if (value.IsApprovalResponseMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApprovalResponseMessage, typeof(global::Letta.ApprovalResponseMessage), options);
            }
            else if (value.IsSummaryMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SummaryMessage, typeof(global::Letta.SummaryMessage), options);
            }
            else if (value.IsEventMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EventMessage, typeof(global::Letta.EventMessage), options);
            }
        }
    }
}