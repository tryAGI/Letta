
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenAIModelSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SGLangModelSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicModelSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GoogleAIModelSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GoogleVertexModelSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AzureModelSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.XAIModelSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ZAIModelSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GroqModelSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.DeepseekModelSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TogetherModelSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.BedrockModelSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.BasetenModelSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenRouterModelSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatGPTOAuthModelSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TextResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.JsonSchemaResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.JsonObjectResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalRequestMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.StopReasonType), TypeInfoPropertyName = "StopReasonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicThinking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "AnthropicModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicModelSettingsVerbosity), TypeInfoPropertyName = "AnthropicModelSettingsVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicModelSettingsEffort), TypeInfoPropertyName = "AnthropicModelSettingsEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicThinkingType), TypeInfoPropertyName = "AnthropicThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ApprovalsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalsVariant1Item), TypeInfoPropertyName = "ApprovalsVariant1Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalReturn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasLettaMessageToolReturn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalCreateApprovalsVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalCreateApprovalsVariant1ItemDiscriminatorType), TypeInfoPropertyName = "ApprovalCreateApprovalsVariant1ItemDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AzureModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AzureModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "AzureModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Base64Image))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.BedrockModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.BedrockModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "BedrockModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatGPTOAuthReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatGPTOAuthReasoningReasoningEffort), TypeInfoPropertyName = "ChatGPTOAuthReasoningReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientSkillSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientToolSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompactionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompactionSettingsInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompactionSettingsInputModelSettingsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType), TypeInfoPropertyName = "CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompactionSettingsInputMode), TypeInfoPropertyName = "CompactionSettingsInputMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompactionStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Conversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ConversationModelSettingsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ConversationModelSettingsVariant1DiscriminatorProviderType), TypeInfoPropertyName = "ConversationModelSettingsVariant1DiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ConversationMessageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.MessageCreate, global::Letta.ApprovalCreate, global::Letta.ToolReturnCreate>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.MessageCreate, global::Letta.ApprovalCreate, global::Letta.ToolReturnCreate>), TypeInfoPropertyName = "AnyOfMessageCreateApprovalCreateToolReturnCreate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MessageCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolReturnCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item>, object>), TypeInfoPropertyName = "AnyOfStringIListInputVariant2ItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.InputVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item), TypeInfoPropertyName = "InputVariant2Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ImageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolCallContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolReturnContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ReasoningContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.RedactedReasoningContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OmittedReasoningContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SummarizedReasoningContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ConversationMessageRequestInputVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ConversationMessageRequestInputVariant2ItemDiscriminatorType), TypeInfoPropertyName = "ConversationMessageRequestInputVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.MessageType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MessageType), TypeInfoPropertyName = "MessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ClientToolSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ClientSkillSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CreateConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CreateConversationModelSettingsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CreateConversationModelSettingsVariant1DiscriminatorProviderType), TypeInfoPropertyName = "CreateConversationModelSettingsVariant1DiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.DeepseekModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.DeepseekModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "DeepseekModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EventMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GeminiThinkingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaUsageStatistics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseSchemaVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GoogleAIModelSettingsResponseSchemaVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType), TypeInfoPropertyName = "GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseSchemaVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GoogleVertexModelSettingsResponseSchemaVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType), TypeInfoPropertyName = "GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GroqModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GroqModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "GroqModelSettingsResponseFormatVariant1DiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item2), TypeInfoPropertyName = "InputVariant2Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item3), TypeInfoPropertyName = "InputVariant2Item32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaErrorMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaPing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item4), TypeInfoPropertyName = "InputVariant2Item42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaMessageUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaMessageUnion), TypeInfoPropertyName = "LettaMessageUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaStopReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasOpenaiChatCompletionResponseChoiceLogprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.TurnTokenData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TurnTokenData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item5), TypeInfoPropertyName = "InputVariant2Item52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaStreamingResponse), TypeInfoPropertyName = "LettaStreamingResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ReasoningMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolCallMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolReturnMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ContentVariant1Item), TypeInfoPropertyName = "ContentVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MessageCreateRole), TypeInfoPropertyName = "MessageCreateRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.LettaMessageContentUnion>, string>), TypeInfoPropertyName = "AnyOfIListLettaMessageContentUnionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaMessageContentUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaMessageContentUnion), TypeInfoPropertyName = "LettaMessageContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant110))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenAIReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant111))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenAIModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenAIModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "OpenAIModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenAIReasoningReasoningEffort), TypeInfoPropertyName = "OpenAIReasoningReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant112))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenRouterModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ReasoningMessageSource), TypeInfoPropertyName = "ReasoningMessageSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.RetrieveStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant113))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SGLangModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SGLangModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "SGLangModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.SummarizedReasoningContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SummarizedReasoningContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SummaryMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant114))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TogetherModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TogetherModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "TogetherModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaSchemasLettaMessageToolReturn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolReturnMessageStatus), TypeInfoPropertyName = "ToolReturnMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TurnTokenDataRole), TypeInfoPropertyName = "TurnTokenDataRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant115))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UpdateConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UpdateConversationModelSettingsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UpdateConversationModelSettingsVariant1DiscriminatorProviderType), TypeInfoPropertyName = "UpdateConversationModelSettingsVariant1DiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.LettaUserMessageContentUnion>, string>), TypeInfoPropertyName = "AnyOfIListLettaUserMessageContentUnionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaUserMessageContentUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaUserMessageContentUnion), TypeInfoPropertyName = "LettaUserMessageContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant116))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.XAIModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.XAIModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "XAIModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant117))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ZAIModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ZAIModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "ZAIModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ZAIThinking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ZAIThinkingType), TypeInfoPropertyName = "ZAIThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant110))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant118))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.LettaToolReturnContentUnion>, string>), TypeInfoPropertyName = "AnyOfIListLettaToolReturnContentUnionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaToolReturnContentUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaToolReturnContentUnion), TypeInfoPropertyName = "LettaToolReturnContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasLettaMessageToolReturnStatus), TypeInfoPropertyName = "LettaSchemasLettaMessageToolReturnStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FuncResponseVariant2Item), TypeInfoPropertyName = "FuncResponseVariant2Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FuncResponseVariant2Item2), TypeInfoPropertyName = "FuncResponseVariant2Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasOpenaiChatCompletionResponseChatCompletionTokenLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaSchemasOpenaiChatCompletionResponseTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasOpenaiChatCompletionResponseTopLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaSchemasOpenaiChatCompletionResponseChatCompletionTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaServerRestApiRoutersV1ConversationsCompactionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaMessageUnionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaMessageUnionDiscriminatorMessageType), TypeInfoPropertyName = "LettaMessageUnionDiscriminatorMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaMessageContentUnionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaMessageContentUnionDiscriminatorType), TypeInfoPropertyName = "LettaMessageContentUnionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaAssistantMessageContentUnionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaAssistantMessageContentUnionDiscriminatorType), TypeInfoPropertyName = "LettaAssistantMessageContentUnionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaToolReturnContentUnionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaToolReturnContentUnionDiscriminatorType), TypeInfoPropertyName = "LettaToolReturnContentUnionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaUserMessageContentUnionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaUserMessageContentUnionDiscriminatorType), TypeInfoPropertyName = "LettaUserMessageContentUnionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListConversationsOrder), TypeInfoPropertyName = "ListConversationsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListConversationsOrderBy), TypeInfoPropertyName = "ListConversationsOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListConversationMessagesOrder), TypeInfoPropertyName = "ListConversationMessagesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyMessageResponse), TypeInfoPropertyName = "ModifyMessageResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Conversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyGroupMessageResponse), TypeInfoPropertyName = "ModifyGroupMessageResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListMessagesForStepResponseItem), TypeInfoPropertyName = "ListMessagesForStepResponseItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.StopReasonType?), TypeInfoPropertyName = "NullableStopReasonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicModelSettingsResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableAnthropicModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicModelSettingsVerbosity?), TypeInfoPropertyName = "NullableAnthropicModelSettingsVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicModelSettingsEffort?), TypeInfoPropertyName = "NullableAnthropicModelSettingsEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicThinkingType?), TypeInfoPropertyName = "NullableAnthropicThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalsVariant1Item?), TypeInfoPropertyName = "NullableApprovalsVariant1Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalCreateApprovalsVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableApprovalCreateApprovalsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.ToolCall2, global::Letta.ToolCallDelta>?), TypeInfoPropertyName = "NullableAnyOfToolCall2ToolCallDelta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.ToolCall2>, global::Letta.ToolCallDelta, object>?), TypeInfoPropertyName = "NullableAnyOfIListToolCall2ToolCallDeltaObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalsVariant1Item2?), TypeInfoPropertyName = "NullableApprovalsVariant1Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.LettaAssistantMessageContentUnion>, string>?), TypeInfoPropertyName = "NullableAnyOfIListLettaAssistantMessageContentUnionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaAssistantMessageContentUnion?), TypeInfoPropertyName = "NullableLettaAssistantMessageContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AzureModelSettingsResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableAzureModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.BedrockModelSettingsResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableBedrockModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatGPTOAuthReasoningReasoningEffort?), TypeInfoPropertyName = "NullableChatGPTOAuthReasoningReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType?), TypeInfoPropertyName = "NullableCompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompactionSettingsInputMode?), TypeInfoPropertyName = "NullableCompactionSettingsInputMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ConversationModelSettingsVariant1DiscriminatorProviderType?), TypeInfoPropertyName = "NullableConversationModelSettingsVariant1DiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.MessageCreate, global::Letta.ApprovalCreate, global::Letta.ToolReturnCreate>?), TypeInfoPropertyName = "NullableAnyOfMessageCreateApprovalCreateToolReturnCreate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item>, object>?), TypeInfoPropertyName = "NullableAnyOfStringIListInputVariant2ItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item?), TypeInfoPropertyName = "NullableInputVariant2Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ConversationMessageRequestInputVariant2ItemDiscriminatorType?), TypeInfoPropertyName = "NullableConversationMessageRequestInputVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MessageType?), TypeInfoPropertyName = "NullableMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CreateConversationModelSettingsVariant1DiscriminatorProviderType?), TypeInfoPropertyName = "NullableCreateConversationModelSettingsVariant1DiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.DeepseekModelSettingsResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableDeepseekModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableGoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableGoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GroqModelSettingsResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableGroqModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.HiddenReasoningMessageState?), TypeInfoPropertyName = "NullableHiddenReasoningMessageState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Source?), TypeInfoPropertyName = "NullableSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ImageContentSourceDiscriminatorType?), TypeInfoPropertyName = "NullableImageContentSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item2?), TypeInfoPropertyName = "NullableInputVariant2Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item3?), TypeInfoPropertyName = "NullableInputVariant2Item32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item4?), TypeInfoPropertyName = "NullableInputVariant2Item42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaMessageUnion?), TypeInfoPropertyName = "NullableLettaMessageUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item5?), TypeInfoPropertyName = "NullableInputVariant2Item52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaStreamingResponse?), TypeInfoPropertyName = "NullableLettaStreamingResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ContentVariant1Item?), TypeInfoPropertyName = "NullableContentVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MessageCreateRole?), TypeInfoPropertyName = "NullableMessageCreateRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.LettaMessageContentUnion>, string>?), TypeInfoPropertyName = "NullableAnyOfIListLettaMessageContentUnionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaMessageContentUnion?), TypeInfoPropertyName = "NullableLettaMessageContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenAIModelSettingsResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableOpenAIModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenAIReasoningReasoningEffort?), TypeInfoPropertyName = "NullableOpenAIReasoningReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableOpenRouterModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ReasoningMessageSource?), TypeInfoPropertyName = "NullableReasoningMessageSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SGLangModelSettingsResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableSGLangModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TogetherModelSettingsResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableTogetherModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolReturnMessageStatus?), TypeInfoPropertyName = "NullableToolReturnMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TurnTokenDataRole?), TypeInfoPropertyName = "NullableTurnTokenDataRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UpdateConversationModelSettingsVariant1DiscriminatorProviderType?), TypeInfoPropertyName = "NullableUpdateConversationModelSettingsVariant1DiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.LettaUserMessageContentUnion>, string>?), TypeInfoPropertyName = "NullableAnyOfIListLettaUserMessageContentUnionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaUserMessageContentUnion?), TypeInfoPropertyName = "NullableLettaUserMessageContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.XAIModelSettingsResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableXAIModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ZAIModelSettingsResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableZAIModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ZAIThinkingType?), TypeInfoPropertyName = "NullableZAIThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.LettaToolReturnContentUnion>, string>?), TypeInfoPropertyName = "NullableAnyOfIListLettaToolReturnContentUnionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaToolReturnContentUnion?), TypeInfoPropertyName = "NullableLettaToolReturnContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasLettaMessageToolReturnStatus?), TypeInfoPropertyName = "NullableLettaSchemasLettaMessageToolReturnStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FuncResponseVariant2Item?), TypeInfoPropertyName = "NullableFuncResponseVariant2Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FuncResponseVariant2Item2?), TypeInfoPropertyName = "NullableFuncResponseVariant2Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaMessageUnionDiscriminatorMessageType?), TypeInfoPropertyName = "NullableLettaMessageUnionDiscriminatorMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaMessageContentUnionDiscriminatorType?), TypeInfoPropertyName = "NullableLettaMessageContentUnionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaAssistantMessageContentUnionDiscriminatorType?), TypeInfoPropertyName = "NullableLettaAssistantMessageContentUnionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaToolReturnContentUnionDiscriminatorType?), TypeInfoPropertyName = "NullableLettaToolReturnContentUnionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaUserMessageContentUnionDiscriminatorType?), TypeInfoPropertyName = "NullableLettaUserMessageContentUnionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListConversationsOrder?), TypeInfoPropertyName = "NullableListConversationsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListConversationsOrderBy?), TypeInfoPropertyName = "NullableListConversationsOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListConversationMessagesOrder?), TypeInfoPropertyName = "NullableListConversationMessagesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyMessageResponse?), TypeInfoPropertyName = "NullableModifyMessageResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyGroupMessageResponse?), TypeInfoPropertyName = "NullableModifyGroupMessageResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListMessagesForStepResponseItem?), TypeInfoPropertyName = "NullableListMessagesForStepResponseItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ApprovalsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.List<global::Letta.ToolCall2>, global::Letta.ToolCallDelta, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ToolCall2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ApprovalsVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.List<global::Letta.LettaAssistantMessageContentUnion>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaAssistantMessageContentUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<global::Letta.MessageCreate, global::Letta.ApprovalCreate, global::Letta.ToolReturnCreate>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.List<global::Letta.InputVariant2Item>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.InputVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.MessageType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ClientToolSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ClientSkillSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaMessageUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.TurnTokenData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.List<global::Letta.LettaMessageContentUnion>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaMessageContentUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.SummarizedReasoningContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaSchemasLettaMessageToolReturn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.List<global::Letta.LettaUserMessageContentUnion>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaUserMessageContentUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.List<global::Letta.LettaToolReturnContentUnion>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaToolReturnContentUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaSchemasOpenaiChatCompletionResponseTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaSchemasOpenaiChatCompletionResponseChatCompletionTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Conversation>))]
    internal sealed partial class ConversationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConversationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ConversationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ConversationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Letta.JsonConverters.ModelSettingsVariant1JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant1JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant12JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ApprovalsVariant1ItemJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ApprovalsVariant1Item2JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant13JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant14JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ModelSettingsVariant12JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ModelSettingsVariant13JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ModelSettingsVariant14JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.InputVariant2ItemJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ModelSettingsVariant15JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant15JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ModelSettingsVariant16JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant16JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseSchemaVariant1JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseSchemaVariant12JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant17JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.SourceJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ModelSettingsVariant17JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant18JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant19JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.InputVariant2Item2JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.InputVariant2Item3JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.InputVariant2Item4JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.InputVariant2Item5JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.LettaStreamingResponseJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ContentVariant1ItemJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant110JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant111JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant112JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant113JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant114JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ModelSettingsVariant18JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant115JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ModelSettingsVariant19JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant116JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant117JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ModelSettingsVariant110JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant118JsonConverter());
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
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.MessageCreate, global::Letta.ApprovalCreate, global::Letta.ToolReturnCreate>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item>, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.MessageCreate, global::Letta.ApprovalCreate, global::Letta.ToolReturnCreate>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item2>, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.MessageCreate, global::Letta.ApprovalCreate, global::Letta.ToolReturnCreate>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item3>, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.MessageCreate, global::Letta.ApprovalCreate, global::Letta.ToolReturnCreate>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item4>, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.MessageCreate, global::Letta.ApprovalCreate, global::Letta.ToolReturnCreate>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item5>, object>());
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
                    typeToConvert == typeof(global::Letta.AnthropicModelSettingsResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.AnthropicModelSettingsResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.AnthropicModelSettingsVerbosity)

                    || typeToConvert == typeof(global::Letta.AnthropicModelSettingsVerbosity?)

                    || typeToConvert == typeof(global::Letta.AnthropicModelSettingsEffort)

                    || typeToConvert == typeof(global::Letta.AnthropicModelSettingsEffort?)

                    || typeToConvert == typeof(global::Letta.AnthropicThinkingType)

                    || typeToConvert == typeof(global::Letta.AnthropicThinkingType?)

                    || typeToConvert == typeof(global::Letta.ApprovalCreateApprovalsVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.ApprovalCreateApprovalsVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.AzureModelSettingsResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.AzureModelSettingsResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.BedrockModelSettingsResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.BedrockModelSettingsResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.ChatGPTOAuthReasoningReasoningEffort)

                    || typeToConvert == typeof(global::Letta.ChatGPTOAuthReasoningReasoningEffort?)

                    || typeToConvert == typeof(global::Letta.CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType)

                    || typeToConvert == typeof(global::Letta.CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType?)

                    || typeToConvert == typeof(global::Letta.CompactionSettingsInputMode)

                    || typeToConvert == typeof(global::Letta.CompactionSettingsInputMode?)

                    || typeToConvert == typeof(global::Letta.ConversationModelSettingsVariant1DiscriminatorProviderType)

                    || typeToConvert == typeof(global::Letta.ConversationModelSettingsVariant1DiscriminatorProviderType?)

                    || typeToConvert == typeof(global::Letta.ConversationMessageRequestInputVariant2ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.ConversationMessageRequestInputVariant2ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.CreateConversationModelSettingsVariant1DiscriminatorProviderType)

                    || typeToConvert == typeof(global::Letta.CreateConversationModelSettingsVariant1DiscriminatorProviderType?)

                    || typeToConvert == typeof(global::Letta.DeepseekModelSettingsResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.DeepseekModelSettingsResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.GroqModelSettingsResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.GroqModelSettingsResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.HiddenReasoningMessageState)

                    || typeToConvert == typeof(global::Letta.HiddenReasoningMessageState?)

                    || typeToConvert == typeof(global::Letta.ImageContentSourceDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.ImageContentSourceDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.MessageCreateRole)

                    || typeToConvert == typeof(global::Letta.MessageCreateRole?)

                    || typeToConvert == typeof(global::Letta.MessageType)

                    || typeToConvert == typeof(global::Letta.MessageType?)

                    || typeToConvert == typeof(global::Letta.OpenAIModelSettingsResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.OpenAIModelSettingsResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.OpenAIReasoningReasoningEffort)

                    || typeToConvert == typeof(global::Letta.OpenAIReasoningReasoningEffort?)

                    || typeToConvert == typeof(global::Letta.OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.ReasoningMessageSource)

                    || typeToConvert == typeof(global::Letta.ReasoningMessageSource?)

                    || typeToConvert == typeof(global::Letta.SGLangModelSettingsResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.SGLangModelSettingsResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.StopReasonType)

                    || typeToConvert == typeof(global::Letta.StopReasonType?)

                    || typeToConvert == typeof(global::Letta.TogetherModelSettingsResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.TogetherModelSettingsResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.ToolReturnMessageStatus)

                    || typeToConvert == typeof(global::Letta.ToolReturnMessageStatus?)

                    || typeToConvert == typeof(global::Letta.TurnTokenDataRole)

                    || typeToConvert == typeof(global::Letta.TurnTokenDataRole?)

                    || typeToConvert == typeof(global::Letta.UpdateConversationModelSettingsVariant1DiscriminatorProviderType)

                    || typeToConvert == typeof(global::Letta.UpdateConversationModelSettingsVariant1DiscriminatorProviderType?)

                    || typeToConvert == typeof(global::Letta.XAIModelSettingsResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.XAIModelSettingsResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.ZAIModelSettingsResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.ZAIModelSettingsResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.ZAIThinkingType)

                    || typeToConvert == typeof(global::Letta.ZAIThinkingType?)

                    || typeToConvert == typeof(global::Letta.LettaSchemasLettaMessageToolReturnStatus)

                    || typeToConvert == typeof(global::Letta.LettaSchemasLettaMessageToolReturnStatus?)

                    || typeToConvert == typeof(global::Letta.LettaMessageUnionDiscriminatorMessageType)

                    || typeToConvert == typeof(global::Letta.LettaMessageUnionDiscriminatorMessageType?)

                    || typeToConvert == typeof(global::Letta.LettaMessageContentUnionDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.LettaMessageContentUnionDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.LettaAssistantMessageContentUnionDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.LettaAssistantMessageContentUnionDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.LettaToolReturnContentUnionDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.LettaToolReturnContentUnionDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.LettaUserMessageContentUnionDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.LettaUserMessageContentUnionDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.ListConversationsOrder)

                    || typeToConvert == typeof(global::Letta.ListConversationsOrder?)

                    || typeToConvert == typeof(global::Letta.ListConversationsOrderBy)

                    || typeToConvert == typeof(global::Letta.ListConversationsOrderBy?)

                    || typeToConvert == typeof(global::Letta.ListConversationMessagesOrder)

                    || typeToConvert == typeof(global::Letta.ListConversationMessagesOrder?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Letta.AnthropicModelSettingsResponseFormatVariant1DiscriminatorType))
                {
                    return new global::Letta.JsonConverters.AnthropicModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.AnthropicModelSettingsResponseFormatVariant1DiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.AnthropicModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.AnthropicModelSettingsVerbosity))
                {
                    return new global::Letta.JsonConverters.AnthropicModelSettingsVerbosityJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.AnthropicModelSettingsVerbosity?))
                {
                    return new global::Letta.JsonConverters.AnthropicModelSettingsVerbosityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.AnthropicModelSettingsEffort))
                {
                    return new global::Letta.JsonConverters.AnthropicModelSettingsEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.AnthropicModelSettingsEffort?))
                {
                    return new global::Letta.JsonConverters.AnthropicModelSettingsEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.AnthropicThinkingType))
                {
                    return new global::Letta.JsonConverters.AnthropicThinkingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.AnthropicThinkingType?))
                {
                    return new global::Letta.JsonConverters.AnthropicThinkingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ApprovalCreateApprovalsVariant1ItemDiscriminatorType))
                {
                    return new global::Letta.JsonConverters.ApprovalCreateApprovalsVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ApprovalCreateApprovalsVariant1ItemDiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.ApprovalCreateApprovalsVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType))
                {
                    return new global::Letta.JsonConverters.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.AzureModelSettingsResponseFormatVariant1DiscriminatorType))
                {
                    return new global::Letta.JsonConverters.AzureModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.AzureModelSettingsResponseFormatVariant1DiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.AzureModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.BedrockModelSettingsResponseFormatVariant1DiscriminatorType))
                {
                    return new global::Letta.JsonConverters.BedrockModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.BedrockModelSettingsResponseFormatVariant1DiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.BedrockModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ChatGPTOAuthReasoningReasoningEffort))
                {
                    return new global::Letta.JsonConverters.ChatGPTOAuthReasoningReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ChatGPTOAuthReasoningReasoningEffort?))
                {
                    return new global::Letta.JsonConverters.ChatGPTOAuthReasoningReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType))
                {
                    return new global::Letta.JsonConverters.CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType?))
                {
                    return new global::Letta.JsonConverters.CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.CompactionSettingsInputMode))
                {
                    return new global::Letta.JsonConverters.CompactionSettingsInputModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.CompactionSettingsInputMode?))
                {
                    return new global::Letta.JsonConverters.CompactionSettingsInputModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ConversationModelSettingsVariant1DiscriminatorProviderType))
                {
                    return new global::Letta.JsonConverters.ConversationModelSettingsVariant1DiscriminatorProviderTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ConversationModelSettingsVariant1DiscriminatorProviderType?))
                {
                    return new global::Letta.JsonConverters.ConversationModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ConversationMessageRequestInputVariant2ItemDiscriminatorType))
                {
                    return new global::Letta.JsonConverters.ConversationMessageRequestInputVariant2ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ConversationMessageRequestInputVariant2ItemDiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.ConversationMessageRequestInputVariant2ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.CreateConversationModelSettingsVariant1DiscriminatorProviderType))
                {
                    return new global::Letta.JsonConverters.CreateConversationModelSettingsVariant1DiscriminatorProviderTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.CreateConversationModelSettingsVariant1DiscriminatorProviderType?))
                {
                    return new global::Letta.JsonConverters.CreateConversationModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.DeepseekModelSettingsResponseFormatVariant1DiscriminatorType))
                {
                    return new global::Letta.JsonConverters.DeepseekModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.DeepseekModelSettingsResponseFormatVariant1DiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.DeepseekModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType))
                {
                    return new global::Letta.JsonConverters.GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType))
                {
                    return new global::Letta.JsonConverters.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.GroqModelSettingsResponseFormatVariant1DiscriminatorType))
                {
                    return new global::Letta.JsonConverters.GroqModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.GroqModelSettingsResponseFormatVariant1DiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.GroqModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Letta.MessageCreateRole))
                {
                    return new global::Letta.JsonConverters.MessageCreateRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MessageCreateRole?))
                {
                    return new global::Letta.JsonConverters.MessageCreateRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MessageType))
                {
                    return new global::Letta.JsonConverters.MessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MessageType?))
                {
                    return new global::Letta.JsonConverters.MessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.OpenAIModelSettingsResponseFormatVariant1DiscriminatorType))
                {
                    return new global::Letta.JsonConverters.OpenAIModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.OpenAIModelSettingsResponseFormatVariant1DiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.OpenAIModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.OpenAIReasoningReasoningEffort))
                {
                    return new global::Letta.JsonConverters.OpenAIReasoningReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.OpenAIReasoningReasoningEffort?))
                {
                    return new global::Letta.JsonConverters.OpenAIReasoningReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType))
                {
                    return new global::Letta.JsonConverters.OpenRouterModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.OpenRouterModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ReasoningMessageSource))
                {
                    return new global::Letta.JsonConverters.ReasoningMessageSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ReasoningMessageSource?))
                {
                    return new global::Letta.JsonConverters.ReasoningMessageSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.SGLangModelSettingsResponseFormatVariant1DiscriminatorType))
                {
                    return new global::Letta.JsonConverters.SGLangModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.SGLangModelSettingsResponseFormatVariant1DiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.SGLangModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.StopReasonType))
                {
                    return new global::Letta.JsonConverters.StopReasonTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.StopReasonType?))
                {
                    return new global::Letta.JsonConverters.StopReasonTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.TogetherModelSettingsResponseFormatVariant1DiscriminatorType))
                {
                    return new global::Letta.JsonConverters.TogetherModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.TogetherModelSettingsResponseFormatVariant1DiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.TogetherModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ToolReturnMessageStatus))
                {
                    return new global::Letta.JsonConverters.ToolReturnMessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ToolReturnMessageStatus?))
                {
                    return new global::Letta.JsonConverters.ToolReturnMessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.TurnTokenDataRole))
                {
                    return new global::Letta.JsonConverters.TurnTokenDataRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.TurnTokenDataRole?))
                {
                    return new global::Letta.JsonConverters.TurnTokenDataRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.UpdateConversationModelSettingsVariant1DiscriminatorProviderType))
                {
                    return new global::Letta.JsonConverters.UpdateConversationModelSettingsVariant1DiscriminatorProviderTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.UpdateConversationModelSettingsVariant1DiscriminatorProviderType?))
                {
                    return new global::Letta.JsonConverters.UpdateConversationModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.XAIModelSettingsResponseFormatVariant1DiscriminatorType))
                {
                    return new global::Letta.JsonConverters.XAIModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.XAIModelSettingsResponseFormatVariant1DiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.XAIModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ZAIModelSettingsResponseFormatVariant1DiscriminatorType))
                {
                    return new global::Letta.JsonConverters.ZAIModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ZAIModelSettingsResponseFormatVariant1DiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.ZAIModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ZAIThinkingType))
                {
                    return new global::Letta.JsonConverters.ZAIThinkingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ZAIThinkingType?))
                {
                    return new global::Letta.JsonConverters.ZAIThinkingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LettaSchemasLettaMessageToolReturnStatus))
                {
                    return new global::Letta.JsonConverters.LettaSchemasLettaMessageToolReturnStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LettaSchemasLettaMessageToolReturnStatus?))
                {
                    return new global::Letta.JsonConverters.LettaSchemasLettaMessageToolReturnStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LettaMessageUnionDiscriminatorMessageType))
                {
                    return new global::Letta.JsonConverters.LettaMessageUnionDiscriminatorMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LettaMessageUnionDiscriminatorMessageType?))
                {
                    return new global::Letta.JsonConverters.LettaMessageUnionDiscriminatorMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LettaMessageContentUnionDiscriminatorType))
                {
                    return new global::Letta.JsonConverters.LettaMessageContentUnionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LettaMessageContentUnionDiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.LettaMessageContentUnionDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Letta.ListConversationsOrder))
                {
                    return new global::Letta.JsonConverters.ListConversationsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListConversationsOrder?))
                {
                    return new global::Letta.JsonConverters.ListConversationsOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListConversationsOrderBy))
                {
                    return new global::Letta.JsonConverters.ListConversationsOrderByJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListConversationsOrderBy?))
                {
                    return new global::Letta.JsonConverters.ListConversationsOrderByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListConversationMessagesOrder))
                {
                    return new global::Letta.JsonConverters.ListConversationMessagesOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListConversationMessagesOrder?))
                {
                    return new global::Letta.JsonConverters.ListConversationMessagesOrderNullableJsonConverter();
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
                    0 => new ConversationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}