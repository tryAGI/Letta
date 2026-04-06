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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.LettaStreamingResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.LettaStreamingResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.LettaStreamingResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Letta.SystemMessage? systemMessage = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.SystemMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.SystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.SystemMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.SystemMessage)}");
                systemMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.UserMessage? userMessage = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.UserMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.UserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.UserMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.UserMessage)}");
                userMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ReasoningMessage? hiddenReasoningMessage1 = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.HiddenReasoningMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ReasoningMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ReasoningMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ReasoningMessage)}");
                hiddenReasoningMessage1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.HiddenReasoningMessage? hiddenReasoningMessage2 = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.HiddenReasoningMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.HiddenReasoningMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.HiddenReasoningMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.HiddenReasoningMessage)}");
                hiddenReasoningMessage2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ToolCallMessage? toolCallMessage = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.ToolCallMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ToolCallMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ToolCallMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ToolCallMessage)}");
                toolCallMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ToolReturnMessage? toolReturnMessage = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.ToolReturnMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ToolReturnMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ToolReturnMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ToolReturnMessage)}");
                toolReturnMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.AssistantMessage? assistantMessage = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.AssistantMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.AssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.AssistantMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.AssistantMessage)}");
                assistantMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ApprovalRequestMessage? approvalRequestMessage = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.ApprovalRequestMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ApprovalRequestMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ApprovalRequestMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ApprovalRequestMessage)}");
                approvalRequestMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ApprovalResponseMessage? approvalResponseMessage = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.ApprovalResponseMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ApprovalResponseMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ApprovalResponseMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ApprovalResponseMessage)}");
                approvalResponseMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.LettaPing? ping = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.Ping)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.LettaPing), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.LettaPing> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.LettaPing)}");
                ping = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.LettaErrorMessage? errorMessage = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.ErrorMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.LettaErrorMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.LettaErrorMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.LettaErrorMessage)}");
                errorMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.LettaStopReason? stopReason = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.StopReason)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.LettaStopReason), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.LettaStopReason> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.LettaStopReason)}");
                stopReason = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.LettaUsageStatistics? usageStatistics = default;
            if (discriminator?.MessageType == global::Letta.LettaStreamingResponseDiscriminatorMessageType.UsageStatistics)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.LettaUsageStatistics), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.LettaUsageStatistics> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.LettaUsageStatistics)}");
                usageStatistics = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            else if (value.IsHiddenReasoningMessage1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ReasoningMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ReasoningMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.ReasoningMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HiddenReasoningMessage1!, typeInfo);
            }
            else if (value.IsHiddenReasoningMessage2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.HiddenReasoningMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.HiddenReasoningMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.HiddenReasoningMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HiddenReasoningMessage2!, typeInfo);
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
            else if (value.IsPing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.LettaPing), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.LettaPing?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.LettaPing).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ping!, typeInfo);
            }
            else if (value.IsErrorMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.LettaErrorMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.LettaErrorMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.LettaErrorMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ErrorMessage!, typeInfo);
            }
            else if (value.IsStopReason)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.LettaStopReason), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.LettaStopReason?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.LettaStopReason).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StopReason!, typeInfo);
            }
            else if (value.IsUsageStatistics)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.LettaUsageStatistics), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.LettaUsageStatistics?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.LettaUsageStatistics).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UsageStatistics!, typeInfo);
            }
        }
    }
}