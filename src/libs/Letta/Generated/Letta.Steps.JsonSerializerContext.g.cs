
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Letta
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalRequestMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.StopReasonType), TypeInfoPropertyName = "StopReasonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalsVariant1Item), TypeInfoPropertyName = "ApprovalsVariant1Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalReturn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasLettaMessageToolReturn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.ToolCall2, global::Letta.ToolCallDelta>), TypeInfoPropertyName = "AnyOfToolCall2ToolCallDelta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolCall2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolCallDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.ToolCall2>, global::Letta.ToolCallDelta, object>), TypeInfoPropertyName = "AnyOfIListToolCall2ToolCallDeltaObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ToolCall2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalResponseMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ApprovalsVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalsVariant1Item2), TypeInfoPropertyName = "ApprovalsVariant1Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalResponseMessageApprovalsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType), TypeInfoPropertyName = "ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.LettaAssistantMessageContentUnion>, string>), TypeInfoPropertyName = "AnyOfIListLettaAssistantMessageContentUnionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaAssistantMessageContentUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaAssistantMessageContentUnion), TypeInfoPropertyName = "LettaAssistantMessageContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Base64Image))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.BillingContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionMessageFunctionToolCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FunctionOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompactionStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item), TypeInfoPropertyName = "InputVariant2Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ImageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolCallContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolReturnContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ReasoningContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.RedactedReasoningContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OmittedReasoningContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SummarizedReasoningContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EventMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedbackType), TypeInfoPropertyName = "FeedbackType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaUsageStatistics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.HiddenReasoningMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.HiddenReasoningMessageState), TypeInfoPropertyName = "HiddenReasoningMessageState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Source), TypeInfoPropertyName = "Source2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UrlImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ImageContentSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ImageContentSourceDiscriminatorType), TypeInfoPropertyName = "ImageContentSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item2), TypeInfoPropertyName = "InputVariant2Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item3), TypeInfoPropertyName = "InputVariant2Item32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaErrorMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaPing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item4), TypeInfoPropertyName = "InputVariant2Item42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaMessageUnion), TypeInfoPropertyName = "LettaMessageUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaStopReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item5), TypeInfoPropertyName = "InputVariant2Item52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaStreamingResponse), TypeInfoPropertyName = "LettaStreamingResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ReasoningMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolCallMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolReturnMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MessageRole), TypeInfoPropertyName = "MessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ContentVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ContentVariant1Item), TypeInfoPropertyName = "ContentVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MessageContentVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MessageContentVariant1ItemDiscriminatorType), TypeInfoPropertyName = "MessageContentVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ChatCompletionMessageFunctionToolCallOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaSchemasMessageToolReturnOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasMessageToolReturnOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ApprovalReturn, global::Letta.LettaSchemasMessageToolReturnOutput>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.ApprovalReturn, global::Letta.LettaSchemasMessageToolReturnOutput>), TypeInfoPropertyName = "AnyOfApprovalReturnLettaSchemasMessageToolReturnOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaMessageContentUnion), TypeInfoPropertyName = "LettaMessageContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyFeedbackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProviderTrace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ReasoningMessageSource), TypeInfoPropertyName = "ReasoningMessageSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Step))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.StepFeedback), TypeInfoPropertyName = "StepFeedback2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.StepStatus), TypeInfoPropertyName = "StepStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.StepMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.SummarizedReasoningContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SummarizedReasoningContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SummaryMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaSchemasLettaMessageToolReturn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolReturnMessageStatus), TypeInfoPropertyName = "ToolReturnMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.LettaUserMessageContentUnion>, string>), TypeInfoPropertyName = "AnyOfIListLettaUserMessageContentUnionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaUserMessageContentUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaUserMessageContentUnion), TypeInfoPropertyName = "LettaUserMessageContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.LettaToolReturnContentUnion>, string>), TypeInfoPropertyName = "AnyOfIListLettaToolReturnContentUnionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaToolReturnContentUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaToolReturnContentUnion), TypeInfoPropertyName = "LettaToolReturnContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasLettaMessageToolReturnStatus), TypeInfoPropertyName = "LettaSchemasLettaMessageToolReturnStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FuncResponseVariant2Item), TypeInfoPropertyName = "FuncResponseVariant2Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasMessageToolReturnOutputStatus), TypeInfoPropertyName = "LettaSchemasMessageToolReturnOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.FuncResponseVariant2Item2>, object>), TypeInfoPropertyName = "AnyOfStringIListFuncResponseVariant2Item2Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.FuncResponseVariant2Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FuncResponseVariant2Item2), TypeInfoPropertyName = "FuncResponseVariant2Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType), TypeInfoPropertyName = "LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaAssistantMessageContentUnionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaAssistantMessageContentUnionDiscriminatorType), TypeInfoPropertyName = "LettaAssistantMessageContentUnionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaToolReturnContentUnionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaToolReturnContentUnionDiscriminatorType), TypeInfoPropertyName = "LettaToolReturnContentUnionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaUserMessageContentUnionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaUserMessageContentUnionDiscriminatorType), TypeInfoPropertyName = "LettaUserMessageContentUnionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListStepsOrder), TypeInfoPropertyName = "ListStepsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListStepsFeedback), TypeInfoPropertyName = "ListStepsFeedback2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListMessagesForStepOrder), TypeInfoPropertyName = "ListMessagesForStepOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyMessageResponse), TypeInfoPropertyName = "ModifyMessageResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyGroupMessageResponse), TypeInfoPropertyName = "ModifyGroupMessageResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Step>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ListMessagesForStepResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListMessagesForStepResponseItem), TypeInfoPropertyName = "ListMessagesForStepResponseItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListMessagesForStepResponseItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListMessagesForStepResponseItemDiscriminatorMessageType), TypeInfoPropertyName = "ListMessagesForStepResponseItemDiscriminatorMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.StopReasonType?), TypeInfoPropertyName = "NullableStopReasonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalsVariant1Item?), TypeInfoPropertyName = "NullableApprovalsVariant1Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.ToolCall2, global::Letta.ToolCallDelta>?), TypeInfoPropertyName = "NullableAnyOfToolCall2ToolCallDelta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.ToolCall2>, global::Letta.ToolCallDelta, object>?), TypeInfoPropertyName = "NullableAnyOfIListToolCall2ToolCallDeltaObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalsVariant1Item2?), TypeInfoPropertyName = "NullableApprovalsVariant1Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.LettaAssistantMessageContentUnion>, string>?), TypeInfoPropertyName = "NullableAnyOfIListLettaAssistantMessageContentUnionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaAssistantMessageContentUnion?), TypeInfoPropertyName = "NullableLettaAssistantMessageContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item?), TypeInfoPropertyName = "NullableInputVariant2Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedbackType?), TypeInfoPropertyName = "NullableFeedbackType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.HiddenReasoningMessageState?), TypeInfoPropertyName = "NullableHiddenReasoningMessageState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Source?), TypeInfoPropertyName = "NullableSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ImageContentSourceDiscriminatorType?), TypeInfoPropertyName = "NullableImageContentSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item2?), TypeInfoPropertyName = "NullableInputVariant2Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item3?), TypeInfoPropertyName = "NullableInputVariant2Item32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item4?), TypeInfoPropertyName = "NullableInputVariant2Item42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaMessageUnion?), TypeInfoPropertyName = "NullableLettaMessageUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item5?), TypeInfoPropertyName = "NullableInputVariant2Item52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaStreamingResponse?), TypeInfoPropertyName = "NullableLettaStreamingResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MessageRole?), TypeInfoPropertyName = "NullableMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ContentVariant1Item?), TypeInfoPropertyName = "NullableContentVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MessageContentVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableMessageContentVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.ApprovalReturn, global::Letta.LettaSchemasMessageToolReturnOutput>?), TypeInfoPropertyName = "NullableAnyOfApprovalReturnLettaSchemasMessageToolReturnOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaMessageContentUnion?), TypeInfoPropertyName = "NullableLettaMessageContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ReasoningMessageSource?), TypeInfoPropertyName = "NullableReasoningMessageSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.StepFeedback?), TypeInfoPropertyName = "NullableStepFeedback2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.StepStatus?), TypeInfoPropertyName = "NullableStepStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolReturnMessageStatus?), TypeInfoPropertyName = "NullableToolReturnMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.LettaUserMessageContentUnion>, string>?), TypeInfoPropertyName = "NullableAnyOfIListLettaUserMessageContentUnionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaUserMessageContentUnion?), TypeInfoPropertyName = "NullableLettaUserMessageContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.LettaToolReturnContentUnion>, string>?), TypeInfoPropertyName = "NullableAnyOfIListLettaToolReturnContentUnionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaToolReturnContentUnion?), TypeInfoPropertyName = "NullableLettaToolReturnContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasLettaMessageToolReturnStatus?), TypeInfoPropertyName = "NullableLettaSchemasLettaMessageToolReturnStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FuncResponseVariant2Item?), TypeInfoPropertyName = "NullableFuncResponseVariant2Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasMessageToolReturnOutputStatus?), TypeInfoPropertyName = "NullableLettaSchemasMessageToolReturnOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.FuncResponseVariant2Item2>, object>?), TypeInfoPropertyName = "NullableAnyOfStringIListFuncResponseVariant2Item2Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FuncResponseVariant2Item2?), TypeInfoPropertyName = "NullableFuncResponseVariant2Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType?), TypeInfoPropertyName = "NullableLettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaAssistantMessageContentUnionDiscriminatorType?), TypeInfoPropertyName = "NullableLettaAssistantMessageContentUnionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaToolReturnContentUnionDiscriminatorType?), TypeInfoPropertyName = "NullableLettaToolReturnContentUnionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaUserMessageContentUnionDiscriminatorType?), TypeInfoPropertyName = "NullableLettaUserMessageContentUnionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListStepsOrder?), TypeInfoPropertyName = "NullableListStepsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListStepsFeedback?), TypeInfoPropertyName = "NullableListStepsFeedback2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListMessagesForStepOrder?), TypeInfoPropertyName = "NullableListMessagesForStepOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyMessageResponse?), TypeInfoPropertyName = "NullableModifyMessageResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyGroupMessageResponse?), TypeInfoPropertyName = "NullableModifyGroupMessageResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListMessagesForStepResponseItem?), TypeInfoPropertyName = "NullableListMessagesForStepResponseItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListMessagesForStepResponseItemDiscriminatorMessageType?), TypeInfoPropertyName = "NullableListMessagesForStepResponseItemDiscriminatorMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.List<global::Letta.ToolCall2>, global::Letta.ToolCallDelta, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ToolCall2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ApprovalsVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.List<global::Letta.LettaAssistantMessageContentUnion>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaAssistantMessageContentUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ContentVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ChatCompletionMessageFunctionToolCallOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaSchemasMessageToolReturnOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<global::Letta.ApprovalReturn, global::Letta.LettaSchemasMessageToolReturnOutput>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.SummarizedReasoningContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaSchemasLettaMessageToolReturn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.List<global::Letta.LettaUserMessageContentUnion>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaUserMessageContentUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.List<global::Letta.LettaToolReturnContentUnion>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaToolReturnContentUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.List<global::Letta.FuncResponseVariant2Item2>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.FuncResponseVariant2Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Step>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ListMessagesForStepResponseItem>))]
    internal sealed partial class StepsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StepsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static StepsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private StepsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Letta.JsonConverters.ApprovalsVariant1ItemJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ApprovalsVariant1Item2JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.InputVariant2ItemJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.SourceJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.InputVariant2Item2JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.InputVariant2Item3JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.InputVariant2Item4JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.InputVariant2Item5JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.LettaStreamingResponseJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ContentVariant1ItemJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.FuncResponseVariant2ItemJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.FuncResponseVariant2Item2JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.LettaMessageUnionJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.LettaMessageContentUnionJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.LettaAssistantMessageContentUnionJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.LettaToolReturnContentUnionJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.LettaUserMessageContentUnionJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ModifyMessageResponseJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ModifyGroupMessageResponseJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ListMessagesForStepResponseItemJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ToolCall2, global::Letta.ToolCallDelta>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.ToolCall2>, global::Letta.ToolCallDelta, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaAssistantMessageContentUnion>, string>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaAssistantMessageContentUnion>, string>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item>, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item2>, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item3>, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item4>, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item5>, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ApprovalReturn, global::Letta.LettaSchemasMessageToolReturnOutput>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaMessageContentUnion>, string>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ToolCall2, global::Letta.ToolCallDelta>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.ToolCall2>, global::Letta.ToolCallDelta, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaAssistantMessageContentUnion>, string>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaUserMessageContentUnion>, string>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaUserMessageContentUnion>, string>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaUserMessageContentUnion>, string>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaMessageContentUnion>, string>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaToolReturnContentUnion>, string>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.FuncResponseVariant2Item>, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.FuncResponseVariant2Item2>, object>());
            options.Converters.Add(new global::Letta.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Letta.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Letta.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Letta.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Letta.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Letta.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Letta.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Letta.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.FeedbackType)

                    || typeToConvert == typeof(global::Letta.FeedbackType?)

                    || typeToConvert == typeof(global::Letta.HiddenReasoningMessageState)

                    || typeToConvert == typeof(global::Letta.HiddenReasoningMessageState?)

                    || typeToConvert == typeof(global::Letta.ImageContentSourceDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.ImageContentSourceDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.MessageContentVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.MessageContentVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.MessageRole)

                    || typeToConvert == typeof(global::Letta.MessageRole?)

                    || typeToConvert == typeof(global::Letta.ReasoningMessageSource)

                    || typeToConvert == typeof(global::Letta.ReasoningMessageSource?)

                    || typeToConvert == typeof(global::Letta.StepFeedback)

                    || typeToConvert == typeof(global::Letta.StepFeedback?)

                    || typeToConvert == typeof(global::Letta.StepStatus)

                    || typeToConvert == typeof(global::Letta.StepStatus?)

                    || typeToConvert == typeof(global::Letta.StopReasonType)

                    || typeToConvert == typeof(global::Letta.StopReasonType?)

                    || typeToConvert == typeof(global::Letta.ToolReturnMessageStatus)

                    || typeToConvert == typeof(global::Letta.ToolReturnMessageStatus?)

                    || typeToConvert == typeof(global::Letta.LettaSchemasLettaMessageToolReturnStatus)

                    || typeToConvert == typeof(global::Letta.LettaSchemasLettaMessageToolReturnStatus?)

                    || typeToConvert == typeof(global::Letta.LettaSchemasMessageToolReturnOutputStatus)

                    || typeToConvert == typeof(global::Letta.LettaSchemasMessageToolReturnOutputStatus?)

                    || typeToConvert == typeof(global::Letta.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.LettaAssistantMessageContentUnionDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.LettaAssistantMessageContentUnionDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.LettaToolReturnContentUnionDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.LettaToolReturnContentUnionDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.LettaUserMessageContentUnionDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.LettaUserMessageContentUnionDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.ListStepsOrder)

                    || typeToConvert == typeof(global::Letta.ListStepsOrder?)

                    || typeToConvert == typeof(global::Letta.ListStepsFeedback)

                    || typeToConvert == typeof(global::Letta.ListStepsFeedback?)

                    || typeToConvert == typeof(global::Letta.ListMessagesForStepOrder)

                    || typeToConvert == typeof(global::Letta.ListMessagesForStepOrder?)

                    || typeToConvert == typeof(global::Letta.ListMessagesForStepResponseItemDiscriminatorMessageType)

                    || typeToConvert == typeof(global::Letta.ListMessagesForStepResponseItemDiscriminatorMessageType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Letta.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType))
                {
                    return new global::Letta.JsonConverters.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.FeedbackType))
                {
                    return new global::Letta.JsonConverters.FeedbackTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.FeedbackType?))
                {
                    return new global::Letta.JsonConverters.FeedbackTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.HiddenReasoningMessageState))
                {
                    return new global::Letta.JsonConverters.HiddenReasoningMessageStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.HiddenReasoningMessageState?))
                {
                    return new global::Letta.JsonConverters.HiddenReasoningMessageStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ImageContentSourceDiscriminatorType))
                {
                    return new global::Letta.JsonConverters.ImageContentSourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ImageContentSourceDiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.ImageContentSourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MessageContentVariant1ItemDiscriminatorType))
                {
                    return new global::Letta.JsonConverters.MessageContentVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MessageContentVariant1ItemDiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.MessageContentVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MessageRole))
                {
                    return new global::Letta.JsonConverters.MessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MessageRole?))
                {
                    return new global::Letta.JsonConverters.MessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ReasoningMessageSource))
                {
                    return new global::Letta.JsonConverters.ReasoningMessageSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ReasoningMessageSource?))
                {
                    return new global::Letta.JsonConverters.ReasoningMessageSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.StepFeedback))
                {
                    return new global::Letta.JsonConverters.StepFeedbackJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.StepFeedback?))
                {
                    return new global::Letta.JsonConverters.StepFeedbackNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.StepStatus))
                {
                    return new global::Letta.JsonConverters.StepStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.StepStatus?))
                {
                    return new global::Letta.JsonConverters.StepStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.StopReasonType))
                {
                    return new global::Letta.JsonConverters.StopReasonTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.StopReasonType?))
                {
                    return new global::Letta.JsonConverters.StopReasonTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ToolReturnMessageStatus))
                {
                    return new global::Letta.JsonConverters.ToolReturnMessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ToolReturnMessageStatus?))
                {
                    return new global::Letta.JsonConverters.ToolReturnMessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LettaSchemasLettaMessageToolReturnStatus))
                {
                    return new global::Letta.JsonConverters.LettaSchemasLettaMessageToolReturnStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LettaSchemasLettaMessageToolReturnStatus?))
                {
                    return new global::Letta.JsonConverters.LettaSchemasLettaMessageToolReturnStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LettaSchemasMessageToolReturnOutputStatus))
                {
                    return new global::Letta.JsonConverters.LettaSchemasMessageToolReturnOutputStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LettaSchemasMessageToolReturnOutputStatus?))
                {
                    return new global::Letta.JsonConverters.LettaSchemasMessageToolReturnOutputStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType))
                {
                    return new global::Letta.JsonConverters.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LettaAssistantMessageContentUnionDiscriminatorType))
                {
                    return new global::Letta.JsonConverters.LettaAssistantMessageContentUnionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LettaAssistantMessageContentUnionDiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.LettaAssistantMessageContentUnionDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LettaToolReturnContentUnionDiscriminatorType))
                {
                    return new global::Letta.JsonConverters.LettaToolReturnContentUnionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LettaToolReturnContentUnionDiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.LettaToolReturnContentUnionDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LettaUserMessageContentUnionDiscriminatorType))
                {
                    return new global::Letta.JsonConverters.LettaUserMessageContentUnionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LettaUserMessageContentUnionDiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.LettaUserMessageContentUnionDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListStepsOrder))
                {
                    return new global::Letta.JsonConverters.ListStepsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListStepsOrder?))
                {
                    return new global::Letta.JsonConverters.ListStepsOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListStepsFeedback))
                {
                    return new global::Letta.JsonConverters.ListStepsFeedbackJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListStepsFeedback?))
                {
                    return new global::Letta.JsonConverters.ListStepsFeedbackNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListMessagesForStepOrder))
                {
                    return new global::Letta.JsonConverters.ListMessagesForStepOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListMessagesForStepOrder?))
                {
                    return new global::Letta.JsonConverters.ListMessagesForStepOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListMessagesForStepResponseItemDiscriminatorMessageType))
                {
                    return new global::Letta.JsonConverters.ListMessagesForStepResponseItemDiscriminatorMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListMessagesForStepResponseItemDiscriminatorMessageType?))
                {
                    return new global::Letta.JsonConverters.ListMessagesForStepResponseItemDiscriminatorMessageTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new StepsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}