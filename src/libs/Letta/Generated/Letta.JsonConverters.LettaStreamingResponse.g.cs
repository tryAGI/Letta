#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class LettaStreamingResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.LettaStreamingResponse>
    {
        /// <inheritdoc />
        public override global::Letta.LettaStreamingResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.LettaStreamingResponseDiscriminator>(ref readerCopy, options);

            global::Letta.SystemMessage? systemMessage = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.SystemMessage)
            {
                systemMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.SystemMessage>(ref reader, options);
            }
            global::Letta.UserMessage? userMessage = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.UserMessage)
            {
                userMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.UserMessage>(ref reader, options);
            }
            global::Letta.ReasoningMessage? hiddenReasoningMessage1 = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.HiddenReasoningMessage)
            {
                hiddenReasoningMessage1 = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ReasoningMessage>(ref reader, options);
            }
            global::Letta.HiddenReasoningMessage? hiddenReasoningMessage2 = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.HiddenReasoningMessage)
            {
                hiddenReasoningMessage2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.HiddenReasoningMessage>(ref reader, options);
            }
            global::Letta.ToolCallMessage? toolCallMessage = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.ToolCallMessage)
            {
                toolCallMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ToolCallMessage>(ref reader, options);
            }
            global::Letta.ToolReturnMessage? toolReturnMessage = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.ToolReturnMessage)
            {
                toolReturnMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ToolReturnMessage>(ref reader, options);
            }
            global::Letta.AssistantMessage? assistantMessage = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.AssistantMessage)
            {
                assistantMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.AssistantMessage>(ref reader, options);
            }
            global::Letta.ApprovalRequestMessage? approvalRequestMessage = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.ApprovalRequestMessage)
            {
                approvalRequestMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ApprovalRequestMessage>(ref reader, options);
            }
            global::Letta.ApprovalResponseMessage? approvalResponseMessage = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.ApprovalResponseMessage)
            {
                approvalResponseMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ApprovalResponseMessage>(ref reader, options);
            }
            global::Letta.LettaPing? ping = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.Ping)
            {
                ping = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.LettaPing>(ref reader, options);
            }
            global::Letta.LettaErrorMessage? errorMessage = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.ErrorMessage)
            {
                errorMessage = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.LettaErrorMessage>(ref reader, options);
            }
            global::Letta.LettaStopReason? stopReason = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.StopReason)
            {
                stopReason = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.LettaStopReason>(ref reader, options);
            }
            global::Letta.LettaUsageStatistics? usageStatistics = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.UsageStatistics)
            {
                usageStatistics = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.LettaUsageStatistics>(ref reader, options);
            }

            var __value = new global::Letta.LettaStreamingResponse(
                discriminator?.MessageType,
                systemMessage,

                userMessage,

                hiddenReasoningMessage1,

                hiddenReasoningMessage2,

                toolCallMessage,

                toolReturnMessage,

                assistantMessage,

                approvalRequestMessage,

                approvalResponseMessage,

                ping,

                errorMessage,

                stopReason,

                usageStatistics
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.LettaStreamingResponse value,
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
            else if (value.IsHiddenReasoningMessage1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HiddenReasoningMessage1, typeof(global::Letta.ReasoningMessage), options);
            }
            else if (value.IsHiddenReasoningMessage2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HiddenReasoningMessage2, typeof(global::Letta.HiddenReasoningMessage), options);
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
            else if (value.IsPing)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ping, typeof(global::Letta.LettaPing), options);
            }
            else if (value.IsErrorMessage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ErrorMessage, typeof(global::Letta.LettaErrorMessage), options);
            }
            else if (value.IsStopReason)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StopReason, typeof(global::Letta.LettaStopReason), options);
            }
            else if (value.IsUsageStatistics)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UsageStatistics, typeof(global::Letta.LettaUsageStatistics), options);
            }
        }
    }
}