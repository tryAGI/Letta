
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
            typeof(global::Letta.JsonConverters.AgentStateToolRulesVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.AgentStateToolRulesVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentStateModelSettingsVariant1DiscriminatorProviderTypeJsonConverter),

            typeof(global::Letta.JsonConverters.AgentStateModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentStateResponseFormatVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.AgentStateResponseFormatVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentTypeJsonConverter),

            typeof(global::Letta.JsonConverters.AgentTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AnthropicModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.AnthropicModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AnthropicModelSettingsVerbosity2JsonConverter),

            typeof(global::Letta.JsonConverters.AnthropicModelSettingsVerbosity2NullableJsonConverter),

            typeof(global::Letta.JsonConverters.AnthropicModelSettingsEffort2JsonConverter),

            typeof(global::Letta.JsonConverters.AnthropicModelSettingsEffort2NullableJsonConverter),

            typeof(global::Letta.JsonConverters.AnthropicThinkingTypeJsonConverter),

            typeof(global::Letta.JsonConverters.AnthropicThinkingTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ApprovalCreateApprovalsVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.ApprovalCreateApprovalsVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AzureModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.AzureModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.BedrockModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.BedrockModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ChatCompletionServiceTier2JsonConverter),

            typeof(global::Letta.JsonConverters.ChatCompletionServiceTier2NullableJsonConverter),

            typeof(global::Letta.JsonConverters.ChatGPTOAuthReasoningReasoningEffortJsonConverter),

            typeof(global::Letta.JsonConverters.ChatGPTOAuthReasoningReasoningEffortNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ChoiceFinishReasonJsonConverter),

            typeof(global::Letta.JsonConverters.ChoiceFinishReasonNullableJsonConverter),

            typeof(global::Letta.JsonConverters.CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderTypeJsonConverter),

            typeof(global::Letta.JsonConverters.CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.CompactionSettingsInputModeJsonConverter),

            typeof(global::Letta.JsonConverters.CompactionSettingsInputModeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderTypeJsonConverter),

            typeof(global::Letta.JsonConverters.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.CompactionSettingsOutputModeJsonConverter),

            typeof(global::Letta.JsonConverters.CompactionSettingsOutputModeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ComparisonOperatorJsonConverter),

            typeof(global::Letta.JsonConverters.ComparisonOperatorNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ConversationModelSettingsVariant1DiscriminatorProviderTypeJsonConverter),

            typeof(global::Letta.JsonConverters.ConversationModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ConversationMessageRequestInputVariant2ItemDiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.ConversationMessageRequestInputVariant2ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.CreateAgentRequestToolRulesVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.CreateAgentRequestToolRulesVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderTypeJsonConverter),

            typeof(global::Letta.JsonConverters.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.CreateAgentRequestResponseFormatVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.CreateAgentRequestResponseFormatVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.CreateConversationModelSettingsVariant1DiscriminatorProviderTypeJsonConverter),

            typeof(global::Letta.JsonConverters.CreateConversationModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.CreateMCPServerRequestConfigDiscriminatorMcpServerTypeJsonConverter),

            typeof(global::Letta.JsonConverters.CreateMCPServerRequestConfigDiscriminatorMcpServerTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.DeepseekModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.DeepseekModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.DuplicateFileHandlingJsonConverter),

            typeof(global::Letta.JsonConverters.DuplicateFileHandlingNullableJsonConverter),

            typeof(global::Letta.JsonConverters.EmbeddingConfigEmbeddingEndpointTypeJsonConverter),

            typeof(global::Letta.JsonConverters.EmbeddingConfigEmbeddingEndpointTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.EmbeddingModelEmbeddingEndpointTypeJsonConverter),

            typeof(global::Letta.JsonConverters.EmbeddingModelEmbeddingEndpointTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.FeedbackTypeJsonConverter),

            typeof(global::Letta.JsonConverters.FeedbackTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.FileProcessingStatusJsonConverter),

            typeof(global::Letta.JsonConverters.FileProcessingStatusNullableJsonConverter),

            typeof(global::Letta.JsonConverters.GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.GroqModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.GroqModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.GroupCreateManagerConfigDiscriminatorManagerTypeJsonConverter),

            typeof(global::Letta.JsonConverters.GroupCreateManagerConfigDiscriminatorManagerTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.GroupSchemaManagerConfigDiscriminatorManagerTypeJsonConverter),

            typeof(global::Letta.JsonConverters.GroupSchemaManagerConfigDiscriminatorManagerTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.GroupUpdateManagerConfigVariant1DiscriminatorManagerTypeJsonConverter),

            typeof(global::Letta.JsonConverters.GroupUpdateManagerConfigVariant1DiscriminatorManagerTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.HiddenReasoningMessageStateJsonConverter),

            typeof(global::Letta.JsonConverters.HiddenReasoningMessageStateNullableJsonConverter),

            typeof(global::Letta.JsonConverters.IdentityPropertyTypeJsonConverter),

            typeof(global::Letta.JsonConverters.IdentityPropertyTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.IdentityTypeJsonConverter),

            typeof(global::Letta.JsonConverters.IdentityTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ImageContentSourceDiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.ImageContentSourceDiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ImageURLDetailJsonConverter),

            typeof(global::Letta.JsonConverters.ImageURLDetailNullableJsonConverter),

            typeof(global::Letta.JsonConverters.InputAudioFormatJsonConverter),

            typeof(global::Letta.JsonConverters.InputAudioFormatNullableJsonConverter),

            typeof(global::Letta.JsonConverters.InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderTypeJsonConverter),

            typeof(global::Letta.JsonConverters.InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.InternalTemplateAgentCreateResponseFormatVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.InternalTemplateAgentCreateResponseFormatVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerTypeJsonConverter),

            typeof(global::Letta.JsonConverters.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.JobStatusJsonConverter),

            typeof(global::Letta.JsonConverters.JobStatusNullableJsonConverter),

            typeof(global::Letta.JsonConverters.JobTypeJsonConverter),

            typeof(global::Letta.JsonConverters.JobTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.LLMConfigModelEndpointTypeJsonConverter),

            typeof(global::Letta.JsonConverters.LLMConfigModelEndpointTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.LLMConfigReasoningEffort2JsonConverter),

            typeof(global::Letta.JsonConverters.LLMConfigReasoningEffort2NullableJsonConverter),

            typeof(global::Letta.JsonConverters.LLMConfigEffort2JsonConverter),

            typeof(global::Letta.JsonConverters.LLMConfigEffort2NullableJsonConverter),

            typeof(global::Letta.JsonConverters.LLMConfigCompatibilityType2JsonConverter),

            typeof(global::Letta.JsonConverters.LLMConfigCompatibilityType2NullableJsonConverter),

            typeof(global::Letta.JsonConverters.LLMConfigVerbosity2JsonConverter),

            typeof(global::Letta.JsonConverters.LLMConfigVerbosity2NullableJsonConverter),

            typeof(global::Letta.JsonConverters.LLMConfigResponseFormatVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.LLMConfigResponseFormatVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.LettaAsyncRequestInputVariant2ItemDiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.LettaAsyncRequestInputVariant2ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.LettaBatchRequestInputVariant2ItemDiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.LettaBatchRequestInputVariant2ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.LettaRequestInputVariant2ItemDiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.LettaRequestInputVariant2ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.LettaStreamingRequestInputVariant2ItemDiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.LettaStreamingRequestInputVariant2ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.LettaStreamingResponseDiscriminatorMessageTypeJsonConverter),

            typeof(global::Letta.JsonConverters.LettaStreamingResponseDiscriminatorMessageTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.MCPServerTypeJsonConverter),

            typeof(global::Letta.JsonConverters.MCPServerTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ManagerTypeJsonConverter),

            typeof(global::Letta.JsonConverters.ManagerTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.MessageContentVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.MessageContentVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.MessageCreateRoleJsonConverter),

            typeof(global::Letta.JsonConverters.MessageCreateRoleNullableJsonConverter),

            typeof(global::Letta.JsonConverters.MessageRoleJsonConverter),

            typeof(global::Letta.JsonConverters.MessageRoleNullableJsonConverter),

            typeof(global::Letta.JsonConverters.MessageSearchRequestSearchModeJsonConverter),

            typeof(global::Letta.JsonConverters.MessageSearchRequestSearchModeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.MessageTypeJsonConverter),

            typeof(global::Letta.JsonConverters.MessageTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ModalSandboxConfigLanguageJsonConverter),

            typeof(global::Letta.JsonConverters.ModalSandboxConfigLanguageNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ModelModelEndpointTypeJsonConverter),

            typeof(global::Letta.JsonConverters.ModelModelEndpointTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ModelReasoningEffort2JsonConverter),

            typeof(global::Letta.JsonConverters.ModelReasoningEffort2NullableJsonConverter),

            typeof(global::Letta.JsonConverters.ModelEffort2JsonConverter),

            typeof(global::Letta.JsonConverters.ModelEffort2NullableJsonConverter),

            typeof(global::Letta.JsonConverters.ModelCompatibilityType2JsonConverter),

            typeof(global::Letta.JsonConverters.ModelCompatibilityType2NullableJsonConverter),

            typeof(global::Letta.JsonConverters.ModelVerbosity2JsonConverter),

            typeof(global::Letta.JsonConverters.ModelVerbosity2NullableJsonConverter),

            typeof(global::Letta.JsonConverters.ModelResponseFormatVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.ModelResponseFormatVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.OpenAIModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.OpenAIModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.OpenAIReasoningReasoningEffortJsonConverter),

            typeof(global::Letta.JsonConverters.OpenAIReasoningReasoningEffortNullableJsonConverter),

            typeof(global::Letta.JsonConverters.OpenRouterModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.OpenRouterModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PassageSearchRequestTagMatchModeJsonConverter),

            typeof(global::Letta.JsonConverters.PassageSearchRequestTagMatchModeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ProviderCategoryJsonConverter),

            typeof(global::Letta.JsonConverters.ProviderCategoryNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ProviderTypeJsonConverter),

            typeof(global::Letta.JsonConverters.ProviderTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ReasoningMessageSourceJsonConverter),

            typeof(global::Letta.JsonConverters.ReasoningMessageSourceNullableJsonConverter),

            typeof(global::Letta.JsonConverters.RunStatusJsonConverter),

            typeof(global::Letta.JsonConverters.RunStatusNullableJsonConverter),

            typeof(global::Letta.JsonConverters.SandboxTypeJsonConverter),

            typeof(global::Letta.JsonConverters.SandboxTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.SearchAllMessagesRequestSearchModeJsonConverter),

            typeof(global::Letta.JsonConverters.SearchAllMessagesRequestSearchModeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.StepFeedback2JsonConverter),

            typeof(global::Letta.JsonConverters.StepFeedback2NullableJsonConverter),

            typeof(global::Letta.JsonConverters.StepStatus2JsonConverter),

            typeof(global::Letta.JsonConverters.StepStatus2NullableJsonConverter),

            typeof(global::Letta.JsonConverters.StopReasonTypeJsonConverter),

            typeof(global::Letta.JsonConverters.StopReasonTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.TogetherModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.TogetherModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ToolExecutionResultStatusJsonConverter),

            typeof(global::Letta.JsonConverters.ToolExecutionResultStatusNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ToolReturnMessageStatusJsonConverter),

            typeof(global::Letta.JsonConverters.ToolReturnMessageStatusNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ToolSearchRequestSearchModeJsonConverter),

            typeof(global::Letta.JsonConverters.ToolSearchRequestSearchModeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ToolTypeJsonConverter),

            typeof(global::Letta.JsonConverters.ToolTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.TurnTokenDataRoleJsonConverter),

            typeof(global::Letta.JsonConverters.TurnTokenDataRoleNullableJsonConverter),

            typeof(global::Letta.JsonConverters.UpdateAgentToolRulesVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.UpdateAgentToolRulesVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.UpdateAgentModelSettingsVariant1DiscriminatorProviderTypeJsonConverter),

            typeof(global::Letta.JsonConverters.UpdateAgentModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.UpdateAgentResponseFormatVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.UpdateAgentResponseFormatVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.UpdateConversationModelSettingsVariant1DiscriminatorProviderTypeJsonConverter),

            typeof(global::Letta.JsonConverters.UpdateConversationModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.UpdateMCPServerRequestConfigDiscriminatorMcpServerTypeJsonConverter),

            typeof(global::Letta.JsonConverters.UpdateMCPServerRequestConfigDiscriminatorMcpServerTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.VectorDBProviderJsonConverter),

            typeof(global::Letta.JsonConverters.VectorDBProviderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.XAIModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.XAIModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ZAIModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.ZAIModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ZAIThinkingTypeJsonConverter),

            typeof(global::Letta.JsonConverters.ZAIThinkingTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderTypeJsonConverter),

            typeof(global::Letta.JsonConverters.LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.LettaSchemasAgentFileAgentSchemaResponseFormatVariant1DiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.LettaSchemasAgentFileAgentSchemaResponseFormatVariant1DiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.LettaSchemasLettaMessageToolReturnStatusJsonConverter),

            typeof(global::Letta.JsonConverters.LettaSchemasLettaMessageToolReturnStatusNullableJsonConverter),

            typeof(global::Letta.JsonConverters.LettaSchemasMessageToolReturnInputStatusJsonConverter),

            typeof(global::Letta.JsonConverters.LettaSchemasMessageToolReturnInputStatusNullableJsonConverter),

            typeof(global::Letta.JsonConverters.LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.LettaSchemasMessageToolReturnOutputStatusJsonConverter),

            typeof(global::Letta.JsonConverters.LettaSchemasMessageToolReturnOutputStatusNullableJsonConverter),

            typeof(global::Letta.JsonConverters.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.LettaMessageUnionDiscriminatorMessageTypeJsonConverter),

            typeof(global::Letta.JsonConverters.LettaMessageUnionDiscriminatorMessageTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.LettaMessageContentUnionDiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.LettaMessageContentUnionDiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.LettaAssistantMessageContentUnionDiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.LettaAssistantMessageContentUnionDiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.LettaToolReturnContentUnionDiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.LettaToolReturnContentUnionDiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.LettaUserMessageContentUnionDiscriminatorTypeJsonConverter),

            typeof(global::Letta.JsonConverters.LettaUserMessageContentUnionDiscriminatorTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant1FieldJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant1FieldNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant2FieldJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant2FieldNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant2OperatorJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant2OperatorNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant3FieldJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant3FieldNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant3OperatorJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant3OperatorNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant4FieldJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant4FieldNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant4OperatorJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant4OperatorNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant5FieldJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant5FieldNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant5OperatorJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant5OperatorNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant6FieldJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant6FieldNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant6OperatorJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant6OperatorNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestCombinatorJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestCombinatorNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSortByJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSortByNullableJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRoleJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRoleNullableJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRoleJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRoleNullableJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesCreateTemplateNoProjectRequestVariant1TypeJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesCreateTemplateNoProjectRequestVariant1TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesCreateTemplateNoProjectRequestVariant2TypeJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesCreateTemplateNoProjectRequestVariant2TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategyJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategyNullableJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesSaveTemplateVersionRequestBlockReconciliationStrategyJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesSaveTemplateVersionRequestBlockReconciliationStrategyNullableJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesCreateTemplateRequestVariant1TypeJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesCreateTemplateRequestVariant1TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesCreateTemplateRequestVariant2TypeJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesCreateTemplateRequestVariant2TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1TypeJsonConverter),

            typeof(global::Letta.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1AccesJsonConverter),

            typeof(global::Letta.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1AccesNullableJsonConverter),

            typeof(global::Letta.JsonConverters.MetadataSendFeedbackRequestFeatureJsonConverter),

            typeof(global::Letta.JsonConverters.MetadataSendFeedbackRequestFeatureNullableJsonConverter),

            typeof(global::Letta.JsonConverters.MetadataSendTelemetryRequestServiceJsonConverter),

            typeof(global::Letta.JsonConverters.MetadataSendTelemetryRequestServiceNullableJsonConverter),

            typeof(global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant1TypeJsonConverter),

            typeof(global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant1TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant2TypeJsonConverter),

            typeof(global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant2TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant3TypeJsonConverter),

            typeof(global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant3TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant4TypeJsonConverter),

            typeof(global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant4TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant5TypeJsonConverter),

            typeof(global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant5TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1TypeJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceTypeJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2TypeJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageRoleJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageRoleNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageTypeJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageTypeJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1TypeJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2TypeJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesCreatePipelineRequestIntegrationTypeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesCreatePipelineRequestIntegrationTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesCreatePipelineRequestProducerConfigVariant1TypeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesCreatePipelineRequestProducerConfigVariant1TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesCreatePipelineRequestProducerConfigVariant2TypeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesCreatePipelineRequestProducerConfigVariant2TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1TypeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2TypeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesPreviewPipelineRequestIntegrationTypeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesPreviewPipelineRequestIntegrationTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesPreviewPipelineRequestProducerConfigVariant1TypeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesPreviewPipelineRequestProducerConfigVariant1TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesPreviewPipelineRequestProducerConfigVariant2TypeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesPreviewPipelineRequestProducerConfigVariant2TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant1RoleJsonConverter),

            typeof(global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant1RoleNullableJsonConverter),

            typeof(global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemTypeJsonConverter),

            typeof(global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2TypeJsonConverter),

            typeof(global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1TypeJsonConverter),

            typeof(global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemTypeJsonConverter),

            typeof(global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1StatusJsonConverter),

            typeof(global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1StatusNullableJsonConverter),

            typeof(global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2TypeJsonConverter),

            typeof(global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.EnvironmentsSendModeChangeRequestModeJsonConverter),

            typeof(global::Letta.JsonConverters.EnvironmentsSendModeChangeRequestModeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListArchivesOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListArchivesOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListAgentsForArchiveOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListAgentsForArchiveOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListAgentsForArchiveIncludeItemJsonConverter),

            typeof(global::Letta.JsonConverters.ListAgentsForArchiveIncludeItemNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListToolsOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListToolsOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListFoldersOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListFoldersOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListAgentsForFolderOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListAgentsForFolderOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListFolderPassagesOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListFolderPassagesOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListFilesForFolderOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListFilesForFolderOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListAgentsIncludeItemJsonConverter),

            typeof(global::Letta.JsonConverters.ListAgentsIncludeItemNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListAgentsOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListAgentsOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListAgentsOrderByJsonConverter),

            typeof(global::Letta.JsonConverters.ListAgentsOrderByNullableJsonConverter),

            typeof(global::Letta.JsonConverters.RetrieveAgentIncludeItemJsonConverter),

            typeof(global::Letta.JsonConverters.RetrieveAgentIncludeItemNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListToolsForAgentOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListToolsForAgentOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListAgentSourcesOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListAgentSourcesOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListFoldersForAgentOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListFoldersForAgentOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListFilesForAgentOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListFilesForAgentOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListCoreMemoryBlocksOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListCoreMemoryBlocksOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.SearchArchivalMemoryTagMatchModeJsonConverter),

            typeof(global::Letta.JsonConverters.SearchArchivalMemoryTagMatchModeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListMessagesOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListMessagesOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListGroupsForAgentOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListGroupsForAgentOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListConversationsOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListConversationsOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListConversationsOrderByJsonConverter),

            typeof(global::Letta.JsonConverters.ListConversationsOrderByNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListConversationMessagesOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListConversationMessagesOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListGroupsOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListGroupsOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListGroupMessagesOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListGroupMessagesOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListIdentitiesOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListIdentitiesOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListAgentsForIdentityOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListAgentsForIdentityOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListAgentsForIdentityIncludeItemJsonConverter),

            typeof(global::Letta.JsonConverters.ListAgentsForIdentityIncludeItemNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListBlocksForIdentityOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListBlocksForIdentityOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListInternalBlocksOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListInternalBlocksOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListAgentsForInternalBlockOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListAgentsForInternalBlockOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListInternalRunsOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListInternalRunsOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListInternalRunsOrderByJsonConverter),

            typeof(global::Letta.JsonConverters.ListInternalRunsOrderByNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListInternalRunsDurationOperator2JsonConverter),

            typeof(global::Letta.JsonConverters.ListInternalRunsDurationOperator2NullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListBlocksOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListBlocksOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListAgentsForBlockOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListAgentsForBlockOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListAgentsForBlockIncludeItemJsonConverter),

            typeof(global::Letta.JsonConverters.ListAgentsForBlockIncludeItemNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListJobsOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListJobsOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListProvidersOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListProvidersOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListRunsOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListRunsOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListMessagesForRunOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListMessagesForRunOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListStepsForRunOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListStepsForRunOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListStepsOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListStepsOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListStepsFeedback2JsonConverter),

            typeof(global::Letta.JsonConverters.ListStepsFeedback2NullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListMessagesForStepOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListMessagesForStepOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListTagsOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListTagsOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListAllMessagesOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListAllMessagesOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListBatchesOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListBatchesOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListMessagesForBatchOrderJsonConverter),

            typeof(global::Letta.JsonConverters.ListMessagesForBatchOrderNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant1FieldJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant1FieldNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant2FieldJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant2FieldNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant2OperatorJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant2OperatorNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant3FieldJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant3FieldNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant3OperatorJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant3OperatorNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant4FieldJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant4FieldNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant4OperatorJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant4OperatorNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant5FieldJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant5FieldNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant5OperatorJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant5OperatorNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant6FieldJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant6FieldNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant6OperatorJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant6OperatorNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsCombinatorJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsCountDeployedAgentsCombinatorNullableJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesListTemplatesSortByJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesListTemplatesSortByNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ModifyMessageResponseDiscriminatorMessageTypeJsonConverter),

            typeof(global::Letta.JsonConverters.ModifyMessageResponseDiscriminatorMessageTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ModifyGroupMessageResponseDiscriminatorMessageTypeJsonConverter),

            typeof(global::Letta.JsonConverters.ModifyGroupMessageResponseDiscriminatorMessageTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ListMessagesForStepResponseItemDiscriminatorMessageTypeJsonConverter),

            typeof(global::Letta.JsonConverters.ListMessagesForStepResponseItemDiscriminatorMessageTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.SearchAllMessagesResponseItemDiscriminatorMessageTypeJsonConverter),

            typeof(global::Letta.JsonConverters.SearchAllMessagesResponseItemDiscriminatorMessageTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsGetAgentVariablesResponseMessageJsonConverter),

            typeof(global::Letta.JsonConverters.AgentsGetAgentVariablesResponseMessageNullableJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1TypeJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant2TypeJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant2TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3TypeJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4TypeJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5TypeJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6TypeJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7TypeJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8TypeJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9TypeJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentAgentTypeJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentAgentTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevelJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevelNullableJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffortJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffortNullableJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseTypeJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyVersionJsonConverter),

            typeof(global::Letta.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyVersionNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1TypeJsonConverter),

            typeof(global::Letta.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1AccesJsonConverter),

            typeof(global::Letta.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1AccesNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyVersionJsonConverter),

            typeof(global::Letta.JsonConverters.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyVersionNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1TypeJsonConverter),

            typeof(global::Letta.JsonConverters.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1AccesJsonConverter),

            typeof(global::Letta.JsonConverters.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1AccesNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1TypeJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2SourceTypeJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2SourceTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2TypeJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageRoleJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageRoleNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageTypeJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageTypeJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1TypeJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2TypeJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1TypeJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2SourceTypeJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2SourceTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2TypeJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRoleJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRoleNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageTypeJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageTypeJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1TypeJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant2TypeJsonConverter),

            typeof(global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant2TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.FeedsSubscribeAgentResponseMergeStrategyJsonConverter),

            typeof(global::Letta.JsonConverters.FeedsSubscribeAgentResponseMergeStrategyNullableJsonConverter),

            typeof(global::Letta.JsonConverters.FeedsSubscribeAgentResponseErrorCodeJsonConverter),

            typeof(global::Letta.JsonConverters.FeedsSubscribeAgentResponseErrorCodeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.FeedsUpdateSubscriptionResponseMergeStrategyJsonConverter),

            typeof(global::Letta.JsonConverters.FeedsUpdateSubscriptionResponseMergeStrategyNullableJsonConverter),

            typeof(global::Letta.JsonConverters.FeedsBackfillSubscriptionResponseErrorCodeJsonConverter),

            typeof(global::Letta.JsonConverters.FeedsBackfillSubscriptionResponseErrorCodeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.FeedsListSubscriptionHistoryResponseRunTypeJsonConverter),

            typeof(global::Letta.JsonConverters.FeedsListSubscriptionHistoryResponseRunTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.FeedsListSubscriptionHistoryResponseRunStatusJsonConverter),

            typeof(global::Letta.JsonConverters.FeedsListSubscriptionHistoryResponseRunStatusNullableJsonConverter),

            typeof(global::Letta.JsonConverters.FeedsListSubscriptionHistoryResponseErrorCodeJsonConverter),

            typeof(global::Letta.JsonConverters.FeedsListSubscriptionHistoryResponseErrorCodeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.FeedsListSubscriptionsResponseSubscriptionMergeStrategyJsonConverter),

            typeof(global::Letta.JsonConverters.FeedsListSubscriptionsResponseSubscriptionMergeStrategyNullableJsonConverter),

            typeof(global::Letta.JsonConverters.MemoryFilesListDirectoryResponseEntrieTypeJsonConverter),

            typeof(global::Letta.JsonConverters.MemoryFilesListDirectoryResponseEntrieTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesCreatePipelineResponsePipelineIntegrationTypeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesCreatePipelineResponsePipelineIntegrationTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesCreatePipelineResponsePipelineConfigVariant1TypeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesCreatePipelineResponsePipelineConfigVariant1TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesCreatePipelineResponsePipelineConfigVariant2TypeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesCreatePipelineResponsePipelineConfigVariant2TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesCreatePipelineResponseErrorCodeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesCreatePipelineResponseErrorCodeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesListPipelinesResponsePipelineIntegrationTypeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesListPipelinesResponsePipelineIntegrationTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesListPipelinesResponsePipelineConfigVariant1TypeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesListPipelinesResponsePipelineConfigVariant1TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesListPipelinesResponsePipelineConfigVariant2TypeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesListPipelinesResponsePipelineConfigVariant2TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesGetPipelineResponsePipelineIntegrationTypeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesGetPipelineResponsePipelineIntegrationTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesGetPipelineResponsePipelineConfigVariant1TypeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesGetPipelineResponsePipelineConfigVariant1TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesGetPipelineResponsePipelineConfigVariant2TypeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesGetPipelineResponsePipelineConfigVariant2TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesGetPipelineResponseErrorCodeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesGetPipelineResponseErrorCodeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesUpdatePipelineResponsePipelineIntegrationTypeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesUpdatePipelineResponsePipelineIntegrationTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesUpdatePipelineResponsePipelineConfigVariant1TypeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesUpdatePipelineResponsePipelineConfigVariant1TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesUpdatePipelineResponsePipelineConfigVariant2TypeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesUpdatePipelineResponsePipelineConfigVariant2TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesUpdatePipelineResponseErrorCodeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesUpdatePipelineResponseErrorCodeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesDeletePipelineResponseErrorCodeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesDeletePipelineResponseErrorCodeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationTypeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationTypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1TypeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2TypeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2TypeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponseErrorCodeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponseErrorCodeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponseErrorCode2JsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponseErrorCode2NullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesPreviewPipelineResponseErrorCodeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesPreviewPipelineResponseErrorCodeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesSyncPipelineResponseErrorCodeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesSyncPipelineResponseErrorCodeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesSyncPipelineResponseErrorCode2JsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesSyncPipelineResponseErrorCode2NullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesListPipelineSyncHistoryResponseRunStatusJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesListPipelineSyncHistoryResponseRunStatusNullableJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesListPipelineSyncHistoryResponseErrorCodeJsonConverter),

            typeof(global::Letta.JsonConverters.PipelinesListPipelineSyncHistoryResponseErrorCodeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.EnvironmentsGetConnectionResponseCurrentModeJsonConverter),

            typeof(global::Letta.JsonConverters.EnvironmentsGetConnectionResponseCurrentModeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.EnvironmentsListConnectionsResponseConnectionCurrentModeJsonConverter),

            typeof(global::Letta.JsonConverters.EnvironmentsListConnectionsResponseConnectionCurrentModeNullableJsonConverter),

            typeof(global::Letta.JsonConverters.ToolRulesVariant1ItemJsonConverter),

            typeof(global::Letta.JsonConverters.ModelSettingsVariant1JsonConverter),

            typeof(global::Letta.JsonConverters.ResponseFormatVariant1JsonConverter),

            typeof(global::Letta.JsonConverters.ResponseFormatVariant12JsonConverter),

            typeof(global::Letta.JsonConverters.ApprovalsVariant1ItemJsonConverter),

            typeof(global::Letta.JsonConverters.ApprovalsVariant1Item2JsonConverter),

            typeof(global::Letta.JsonConverters.ResponseFormatVariant13JsonConverter),

            typeof(global::Letta.JsonConverters.ResponseFormatVariant14JsonConverter),

            typeof(global::Letta.JsonConverters.ModelSettingsVariant12JsonConverter),

            typeof(global::Letta.JsonConverters.ModelSettingsVariant13JsonConverter),

            typeof(global::Letta.JsonConverters.ModelSettingsVariant14JsonConverter),

            typeof(global::Letta.JsonConverters.InputVariant2ItemJsonConverter),

            typeof(global::Letta.JsonConverters.ToolRulesVariant1Item2JsonConverter),

            typeof(global::Letta.JsonConverters.ModelSettingsVariant15JsonConverter),

            typeof(global::Letta.JsonConverters.ResponseFormatVariant15JsonConverter),

            typeof(global::Letta.JsonConverters.ModelSettingsVariant16JsonConverter),

            typeof(global::Letta.JsonConverters.ConfigJsonConverter),

            typeof(global::Letta.JsonConverters.ResponseFormatVariant16JsonConverter),

            typeof(global::Letta.JsonConverters.ResponseSchemaVariant1JsonConverter),

            typeof(global::Letta.JsonConverters.ResponseSchemaVariant12JsonConverter),

            typeof(global::Letta.JsonConverters.ResponseFormatVariant17JsonConverter),

            typeof(global::Letta.JsonConverters.ManagerConfigJsonConverter),

            typeof(global::Letta.JsonConverters.ManagerConfig2JsonConverter),

            typeof(global::Letta.JsonConverters.ManagerConfigVariant1JsonConverter),

            typeof(global::Letta.JsonConverters.SourceJsonConverter),

            typeof(global::Letta.JsonConverters.ToolRulesVariant1Item3JsonConverter),

            typeof(global::Letta.JsonConverters.ModelSettingsVariant17JsonConverter),

            typeof(global::Letta.JsonConverters.ResponseFormatVariant18JsonConverter),

            typeof(global::Letta.JsonConverters.ManagerConfig3JsonConverter),

            typeof(global::Letta.JsonConverters.ResponseFormatVariant19JsonConverter),

            typeof(global::Letta.JsonConverters.InputVariant2Item2JsonConverter),

            typeof(global::Letta.JsonConverters.InputVariant2Item3JsonConverter),

            typeof(global::Letta.JsonConverters.InputVariant2Item4JsonConverter),

            typeof(global::Letta.JsonConverters.InputVariant2Item5JsonConverter),

            typeof(global::Letta.JsonConverters.LettaStreamingResponseJsonConverter),

            typeof(global::Letta.JsonConverters.ContentVariant1ItemJsonConverter),

            typeof(global::Letta.JsonConverters.ResponseFormatVariant110JsonConverter),

            typeof(global::Letta.JsonConverters.ResponseFormatVariant111JsonConverter),

            typeof(global::Letta.JsonConverters.ResponseFormatVariant112JsonConverter),

            typeof(global::Letta.JsonConverters.ResponseFormatVariant113JsonConverter),

            typeof(global::Letta.JsonConverters.ToolRulesVariant1Item4JsonConverter),

            typeof(global::Letta.JsonConverters.ModelSettingsVariant18JsonConverter),

            typeof(global::Letta.JsonConverters.ResponseFormatVariant114JsonConverter),

            typeof(global::Letta.JsonConverters.ModelSettingsVariant19JsonConverter),

            typeof(global::Letta.JsonConverters.Config4JsonConverter),

            typeof(global::Letta.JsonConverters.ResponseFormatVariant115JsonConverter),

            typeof(global::Letta.JsonConverters.ResponseFormatVariant116JsonConverter),

            typeof(global::Letta.JsonConverters.ToolRulesVariant1Item5JsonConverter),

            typeof(global::Letta.JsonConverters.ModelSettingsVariant110JsonConverter),

            typeof(global::Letta.JsonConverters.ResponseFormatVariant117JsonConverter),

            typeof(global::Letta.JsonConverters.FuncResponseVariant2ItemJsonConverter),

            typeof(global::Letta.JsonConverters.FuncResponseVariant2Item2JsonConverter),

            typeof(global::Letta.JsonConverters.LettaMessageUnionJsonConverter),

            typeof(global::Letta.JsonConverters.LettaMessageContentUnionJsonConverter),

            typeof(global::Letta.JsonConverters.LettaAssistantMessageContentUnionJsonConverter),

            typeof(global::Letta.JsonConverters.LettaToolReturnContentUnionJsonConverter),

            typeof(global::Letta.JsonConverters.LettaUserMessageContentUnionJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesCreateTemplateNoProjectRequestJsonConverter),

            typeof(global::Letta.JsonConverters.TemplatesCreateTemplateRequestJsonConverter),

            typeof(global::Letta.JsonConverters.PolicyItemJsonConverter),

            typeof(global::Letta.JsonConverters.EventsItemJsonConverter),

            typeof(global::Letta.JsonConverters.ProducerConfigJsonConverter),

            typeof(global::Letta.JsonConverters.ProducerConfig2JsonConverter),

            typeof(global::Letta.JsonConverters.ProducerConfig3JsonConverter),

            typeof(global::Letta.JsonConverters.ModifyMessageResponseJsonConverter),

            typeof(global::Letta.JsonConverters.ModifyGroupMessageResponseJsonConverter),

            typeof(global::Letta.JsonConverters.ListMessagesForStepResponseItemJsonConverter),

            typeof(global::Letta.JsonConverters.SearchAllMessagesResponseItemJsonConverter),

            typeof(global::Letta.JsonConverters.DataItemJsonConverter),

            typeof(global::Letta.JsonConverters.DataItem2JsonConverter),

            typeof(global::Letta.JsonConverters.Config5JsonConverter),

            typeof(global::Letta.JsonConverters.Config6JsonConverter),

            typeof(global::Letta.JsonConverters.Config7JsonConverter),

            typeof(global::Letta.JsonConverters.Config8JsonConverter),

            typeof(global::Letta.JsonConverters.Config9JsonConverter),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ToolCall2, global::Letta.ToolCallDelta>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.ToolCall2>, global::Letta.ToolCallDelta, object>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaAssistantMessageContentUnion>, string>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaAssistantMessageContentUnion>, string>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartRefusalParam>>, object>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartRefusalParam>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ChatCompletionMessageFunctionToolCallParam, global::Letta.ChatCompletionMessageCustomToolCallParam>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.ChatCompletionContentPartTextParam>>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ChatCompletionMessageFunctionToolCallOutput, global::Letta.ChatCompletionMessageCustomToolCall>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ChatCompletionDeveloperMessageParam, global::Letta.ChatCompletionSystemMessageParam, global::Letta.ChatCompletionUserMessageParam, global::Letta.ChatCompletionAssistantMessageParam, global::Letta.ChatCompletionToolMessageParam, global::Letta.ChatCompletionFunctionMessageParam>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.ChatCompletionContentPartTextParam>>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.ChatCompletionContentPartTextParam>>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartImageParam, global::Letta.ChatCompletionContentPartInputAudioParam, global::Letta.File>>>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartImageParam, global::Letta.ChatCompletionContentPartInputAudioParam, global::Letta.File>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.MessageCreate, global::Letta.ApprovalCreate, global::Letta.ToolReturnCreate>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item>, object>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.MessageCreate, global::Letta.ApprovalCreate, global::Letta.ToolReturnCreate>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item2>, object>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.MessageCreate, global::Letta.ApprovalCreate, global::Letta.ToolReturnCreate>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item3>, object>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.MessageCreate, global::Letta.ApprovalCreate, global::Letta.ToolReturnCreate>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item4>, object>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.MessageCreate, global::Letta.ApprovalCreate, global::Letta.ToolReturnCreate>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item5>, object>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.AgentType?, string, object>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ApprovalReturn, global::Letta.LettaSchemasMessageToolReturnOutput>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaMessageContentUnion>, string>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.LocalSandboxConfig, global::Letta.E2BSandboxConfig, global::Letta.ModalSandboxConfig>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.LocalSandboxConfig, global::Letta.E2BSandboxConfig, global::Letta.ModalSandboxConfig>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ToolCall2, global::Letta.ToolCallDelta>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.ToolCall2>, global::Letta.ToolCallDelta, object>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaAssistantMessageContentUnion>, string>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaUserMessageContentUnion>, string>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaUserMessageContentUnion>, string>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaUserMessageContentUnion>, string>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaMessageContentUnion>, string>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ApprovalReturn, global::Letta.LettaSchemasMessageToolReturnInput>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaToolReturnContentUnion>, string>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.FuncResponseVariant2Item>, object>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.FuncResponseVariant2Item2>, object>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.BaseToolRuleSchema, global::Letta.ChildToolRuleSchema, global::Letta.MaxCountPerStepToolRuleSchema, global::Letta.ConditionalToolRuleSchema>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.LettaSchemasMcpUpdateStdioMCPServer, global::Letta.LettaSchemasMcpUpdateSSEMCPServer, global::Letta.LettaSchemasMcpUpdateStreamableHTTPMCPServer>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.UpdateSystemMessage, global::Letta.UpdateUserMessage, global::Letta.UpdateReasoningMessage, global::Letta.UpdateAssistantMessage>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.LettaRequest, global::Letta.LettaStreamingRequest>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.UpdateSystemMessage, global::Letta.UpdateUserMessage, global::Letta.UpdateReasoningMessage, global::Letta.UpdateAssistantMessage>),

            typeof(global::Letta.JsonConverters.OneOfJsonConverter<global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant1, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant2, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant3, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant4, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant5, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant6>),

            typeof(global::Letta.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2>>, string>),

            typeof(global::Letta.JsonConverters.OneOfJsonConverter<global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2>),

            typeof(global::Letta.JsonConverters.OneOfJsonConverter<global::Letta.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1, global::Letta.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2>),

            typeof(global::Letta.JsonConverters.OneOfJsonConverter<global::Letta.EnvironmentsSendMessageRequestMessageVariant1, global::Letta.EnvironmentsSendMessageRequestMessageVariant2>),

            typeof(global::Letta.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item>>),

            typeof(global::Letta.JsonConverters.OneOfJsonConverter<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1, global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2>),

            typeof(global::Letta.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2Item>>),

            typeof(global::Letta.JsonConverters.OneOfJsonConverter<global::Letta.AgentsCountDeployedAgentsSearchItemVariant1, global::Letta.AgentsCountDeployedAgentsSearchItemVariant2, global::Letta.AgentsCountDeployedAgentsSearchItemVariant3, global::Letta.AgentsCountDeployedAgentsSearchItemVariant4, global::Letta.AgentsCountDeployedAgentsSearchItemVariant5, global::Letta.AgentsCountDeployedAgentsSearchItemVariant6>),

            typeof(global::Letta.JsonConverters.OneOfJsonConverter<string, double?>),

            typeof(global::Letta.JsonConverters.OneOfJsonConverter<string, double?>),

            typeof(global::Letta.JsonConverters.OneOfJsonConverter<string, double?>),

            typeof(global::Letta.JsonConverters.OneOfJsonConverter<string, double?>),

            typeof(global::Letta.JsonConverters.OneOfJsonConverter<string, double?>),

            typeof(global::Letta.JsonConverters.OneOfJsonConverter<string, double?>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.SSEServerConfig, global::Letta.StdioServerConfig, global::Letta.StreamableHTTPServerConfig>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioMCPServer, global::Letta.SSEMCPServer, global::Letta.StreamableHTTPMCPServer>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioMCPServer, global::Letta.SSEMCPServer, global::Letta.StreamableHTTPMCPServer>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioMCPServer, global::Letta.SSEMCPServer, global::Letta.StreamableHTTPMCPServer>),

            typeof(global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioMCPServer, global::Letta.SSEMCPServer, global::Letta.StreamableHTTPMCPServer>),

            typeof(global::Letta.JsonConverters.OneOfJsonConverter<global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant2, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9>),

            typeof(global::Letta.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2>>, string>),

            typeof(global::Letta.JsonConverters.OneOfJsonConverter<global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2>),

            typeof(global::Letta.JsonConverters.OneOfJsonConverter<global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1, global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2>),

            typeof(global::Letta.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2>>, string>),

            typeof(global::Letta.JsonConverters.OneOfJsonConverter<global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2>),

            typeof(global::Letta.JsonConverters.OneOfJsonConverter<global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1, global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant2>),

            typeof(global::Letta.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentEnvironmentVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentFileAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentFileSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaSchemasAgentFileAgentSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasAgentFileAgentSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.GroupSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GroupSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.BlockSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.BlockSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.FileSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FileSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.SourceSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SourceSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaSchemasAgentFileToolSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasAgentFileToolSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.MCPServerSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MCPServerSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.SkillSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SkillSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ToolRulesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolRulesVariant1Item), TypeInfoPropertyName = "ToolRulesVariant1Item6")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChildToolRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InitToolRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TerminalToolRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ConditionalToolRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ContinueToolRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.RequiredBeforeExitToolRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MaxCountPerStepToolRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ParentToolRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.RequiresApprovalToolRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentStateToolRulesVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentStateToolRulesVariant1ItemDiscriminatorType), TypeInfoPropertyName = "AgentStateToolRulesVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentType), TypeInfoPropertyName = "AgentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LLMConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EmbeddingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenAIModelSettings))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenRouterModelSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatGPTOAuthModelSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentStateModelSettingsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentStateModelSettingsVariant1DiscriminatorProviderType), TypeInfoPropertyName = "AgentStateModelSettingsVariant1DiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompactionSettingsOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TextResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.JsonSchemaResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.JsonObjectResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentStateResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentStateResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "AgentStateResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Memory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Block>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Block))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Source2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Source2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AgentEnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Identity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Identity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalRequestMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Group))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.StopReasonType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Annotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnnotationURLCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicThinking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "AnthropicModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicModelSettingsVerbosity2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicModelSettingsEffort2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicThinkingType), TypeInfoPropertyName = "AnthropicThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ApprovalsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalsVariant1Item), TypeInfoPropertyName = "ApprovalsVariant1Item3")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ArchivalMemorySearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ArchivalMemorySearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ArchivalMemorySearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Archive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.VectorDBProvider), TypeInfoPropertyName = "VectorDBProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ArchiveCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ArchiveUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.LettaAssistantMessageContentUnion>, string>), TypeInfoPropertyName = "AnyOfIListLettaAssistantMessageContentUnionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaAssistantMessageContentUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaAssistantMessageContentUnion), TypeInfoPropertyName = "LettaAssistantMessageContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AssistantMessageListResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Audio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AuthRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AuthResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AzureModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AzureModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "AzureModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Base64Image))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.BaseToolRuleSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.BatchJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.JobStatus), TypeInfoPropertyName = "JobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.JobType), TypeInfoPropertyName = "JobType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.BedrockModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.BedrockModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "BedrockModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.BillingContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.BlockResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.BlockUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.BodyExportAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSerializeSchemasPydanticAgentSchemaAgentSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.BodyImportAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.BodyUploadFileToFolder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.BodyUploadFileToSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CancelAgentRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Choice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Choice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionServiceTier2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompletionUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionAssistantMessageParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartRefusalParam>>, object>), TypeInfoPropertyName = "AnyOfStringIListAnyOfChatCompletionContentPartTextParamChatCompletionContentPartRefusalParamObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartRefusalParam>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartRefusalParam>), TypeInfoPropertyName = "AnyOfChatCompletionContentPartTextParamChatCompletionContentPartRefusalParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionContentPartTextParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionContentPartRefusalParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FunctionCallInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionMessageFunctionToolCallParam, global::Letta.ChatCompletionMessageCustomToolCallParam>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.ChatCompletionMessageFunctionToolCallParam, global::Letta.ChatCompletionMessageCustomToolCallParam>), TypeInfoPropertyName = "AnyOfChatCompletionMessageFunctionToolCallParamChatCompletionMessageCustomToolCallParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionMessageFunctionToolCallParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionMessageCustomToolCallParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionContentPartImageParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ImageURL))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionContentPartInputAudioParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionDeveloperMessageParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.ChatCompletionContentPartTextParam>>), TypeInfoPropertyName = "AnyOfStringIListChatCompletionContentPartTextParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ChatCompletionContentPartTextParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionFunctionMessageParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Annotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FunctionCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionMessageFunctionToolCallOutput, global::Letta.ChatCompletionMessageCustomToolCall>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.ChatCompletionMessageFunctionToolCallOutput, global::Letta.ChatCompletionMessageCustomToolCall>), TypeInfoPropertyName = "AnyOfChatCompletionMessageFunctionToolCallOutputChatCompletionMessageCustomToolCall2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionMessageFunctionToolCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionMessageCustomToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CustomOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CustomInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionMessageFunctionToolCallInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenaiTypesChatChatCompletionMessageFunctionToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FunctionOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenaiTypesChatChatCompletionMessageFunctionToolCallParamFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionDeveloperMessageParam, global::Letta.ChatCompletionSystemMessageParam, global::Letta.ChatCompletionUserMessageParam, global::Letta.ChatCompletionAssistantMessageParam, global::Letta.ChatCompletionToolMessageParam, global::Letta.ChatCompletionFunctionMessageParam>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.ChatCompletionDeveloperMessageParam, global::Letta.ChatCompletionSystemMessageParam, global::Letta.ChatCompletionUserMessageParam, global::Letta.ChatCompletionAssistantMessageParam, global::Letta.ChatCompletionToolMessageParam, global::Letta.ChatCompletionFunctionMessageParam>), TypeInfoPropertyName = "AnyOfChatCompletionDeveloperMessageParamChatCompletionSystemMessageParamChatCompletionUserMessageParamChatCompletionAssistantMessageParamChatCompletionToolMessageParamChatCompletionFunctionMessageParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionSystemMessageParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionUserMessageParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionToolMessageParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.IList<string>, object>), TypeInfoPropertyName = "AnyOfStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartImageParam, global::Letta.ChatCompletionContentPartInputAudioParam, global::Letta.File>>>), TypeInfoPropertyName = "AnyOfStringIListAnyOfChatCompletionContentPartTextParamChatCompletionContentPartImageParamChatCompletionContentPartInputAudioParamFile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartImageParam, global::Letta.ChatCompletionContentPartInputAudioParam, global::Letta.File>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartImageParam, global::Letta.ChatCompletionContentPartInputAudioParam, global::Letta.File>), TypeInfoPropertyName = "AnyOfChatCompletionContentPartTextParamChatCompletionContentPartImageParamChatCompletionContentPartInputAudioParamFile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.File))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatGPTOAuthReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatGPTOAuthReasoningReasoningEffort), TypeInfoPropertyName = "ChatGPTOAuthReasoningReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ToolCallNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolCallNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChildToolRuleSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChoiceFinishReason), TypeInfoPropertyName = "ChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenaiTypesChatChatCompletionChoiceLogprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientToolSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CodeInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompactionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompactionSettingsInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompactionSettingsInputModelSettingsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType), TypeInfoPropertyName = "CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompactionSettingsInputMode), TypeInfoPropertyName = "CompactionSettingsInputMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompactionSettingsOutputModelSettingsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType), TypeInfoPropertyName = "CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompactionSettingsOutputMode), TypeInfoPropertyName = "CompactionSettingsOutputMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompactionStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ComparisonOperator), TypeInfoPropertyName = "ComparisonOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompletionTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ConditionalToolRuleSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ContextWindowOverview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.FunctionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FunctionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Message))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item), TypeInfoPropertyName = "InputVariant2Item6")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CoreMemoryBlockSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CreateAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.CreateBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CreateBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ToolRulesVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolRulesVariant1Item2), TypeInfoPropertyName = "ToolRulesVariant1Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CreateAgentRequestToolRulesVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CreateAgentRequestToolRulesVariant1ItemDiscriminatorType), TypeInfoPropertyName = "CreateAgentRequestToolRulesVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.MessageCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CreateAgentRequestModelSettingsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType), TypeInfoPropertyName = "CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CreateAgentRequestResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CreateAgentRequestResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "CreateAgentRequestResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CreateArchivalMemory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CreateBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaBatchRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CreateConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CreateConversationModelSettingsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CreateConversationModelSettingsVariant1DiscriminatorProviderType), TypeInfoPropertyName = "CreateConversationModelSettingsVariant1DiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CreateMCPServerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Config), TypeInfoPropertyName = "Config2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CreateStdioMCPServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CreateSSEMCPServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CreateStreamableHTTPMCPServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CreateMCPServerRequestConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CreateMCPServerRequestConfigDiscriminatorMcpServerType), TypeInfoPropertyName = "CreateMCPServerRequestConfigDiscriminatorMcpServerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.DeepseekModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.DeepseekModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "DeepseekModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.DeleteDeploymentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.DeploymentEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.DuplicateFileHandling), TypeInfoPropertyName = "DuplicateFileHandling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.DynamicManager))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.DynamicManagerSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.DynamicManagerUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.E2BSandboxConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EmbeddingConfigEmbeddingEndpointType), TypeInfoPropertyName = "EmbeddingConfigEmbeddingEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EmbeddingModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProviderType), TypeInfoPropertyName = "ProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EmbeddingModelEmbeddingEndpointType), TypeInfoPropertyName = "EmbeddingModelEmbeddingEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EventMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ExportAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedbackType), TypeInfoPropertyName = "FeedbackType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FileFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FileAgentSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FileBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FileMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FileProcessingStatus), TypeInfoPropertyName = "FileProcessingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FileStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Folder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FunctionDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GeminiThinkingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GenerateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GenerateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaUsageStatistics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GenerateToolInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GenerateToolOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseSchemaVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GoogleAIModelSettingsResponseSchemaVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType), TypeInfoPropertyName = "GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseSchemaVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GoogleVertexModelSettingsResponseSchemaVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType), TypeInfoPropertyName = "GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GroqModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GroqModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "GroqModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ManagerType), TypeInfoPropertyName = "ManagerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GroupCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ManagerConfig), TypeInfoPropertyName = "ManagerConfig4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.RoundRobinManager))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SupervisorManager))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SleeptimeManager))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.VoiceSleeptimeManager))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GroupCreateManagerConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GroupCreateManagerConfigDiscriminatorManagerType), TypeInfoPropertyName = "GroupCreateManagerConfigDiscriminatorManagerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ManagerConfig2), TypeInfoPropertyName = "ManagerConfig22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SupervisorManagerSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SleeptimeManagerSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.VoiceSleeptimeManagerSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GroupSchemaManagerConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GroupSchemaManagerConfigDiscriminatorManagerType), TypeInfoPropertyName = "GroupSchemaManagerConfigDiscriminatorManagerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GroupUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ManagerConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.RoundRobinManagerUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SupervisorManagerUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SleeptimeManagerUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.VoiceSleeptimeManagerUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GroupUpdateManagerConfigVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GroupUpdateManagerConfigVariant1DiscriminatorManagerType), TypeInfoPropertyName = "GroupUpdateManagerConfigVariant1DiscriminatorManagerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Health))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.HiddenReasoningMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.HiddenReasoningMessageState), TypeInfoPropertyName = "HiddenReasoningMessageState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.IdentityType), TypeInfoPropertyName = "IdentityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.IdentityProperty>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.IdentityProperty))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.IdentityCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, int?, double?, bool?, object>), TypeInfoPropertyName = "AnyOfStringInt32DoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.IdentityPropertyType), TypeInfoPropertyName = "IdentityPropertyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.IdentityUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.IdentityUpsert))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Source), TypeInfoPropertyName = "Source3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UrlImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ImageContentSourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ImageContentSourceDiscriminatorType), TypeInfoPropertyName = "ImageContentSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ImageURLDetail), TypeInfoPropertyName = "ImageURLDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ImportedAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputAudioFormat), TypeInfoPropertyName = "InputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InternalTemplateAgentCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ToolRulesVariant1Item3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolRulesVariant1Item3), TypeInfoPropertyName = "ToolRulesVariant1Item32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType), TypeInfoPropertyName = "InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InternalTemplateAgentCreateModelSettingsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType), TypeInfoPropertyName = "InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InternalTemplateAgentCreateResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InternalTemplateAgentCreateResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "InternalTemplateAgentCreateResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InternalTemplateBlockCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InternalTemplateGroupCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ManagerConfig3), TypeInfoPropertyName = "ManagerConfig32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InternalTemplateGroupCreateManagerConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType), TypeInfoPropertyName = "InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Job))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LLMConfigModelEndpointType), TypeInfoPropertyName = "LLMConfigModelEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProviderCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LLMConfigReasoningEffort2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LLMConfigEffort2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LLMConfigCompatibilityType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LLMConfigVerbosity2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LLMConfigResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LLMConfigResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "LLMConfigResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaAsyncRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item2>, object>), TypeInfoPropertyName = "AnyOfStringIListInputVariant2Item2Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.InputVariant2Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item2), TypeInfoPropertyName = "InputVariant2Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaAsyncRequestInputVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaAsyncRequestInputVariant2ItemDiscriminatorType), TypeInfoPropertyName = "LettaAsyncRequestInputVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaBatchMessages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item3>, object>), TypeInfoPropertyName = "AnyOfStringIListInputVariant2Item3Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.InputVariant2Item3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item3), TypeInfoPropertyName = "InputVariant2Item32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaBatchRequestInputVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaBatchRequestInputVariant2ItemDiscriminatorType), TypeInfoPropertyName = "LettaBatchRequestInputVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaErrorMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaPing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item4>, object>), TypeInfoPropertyName = "AnyOfStringIListInputVariant2Item4Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.InputVariant2Item4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item4), TypeInfoPropertyName = "InputVariant2Item42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaRequestInputVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaRequestInputVariant2ItemDiscriminatorType), TypeInfoPropertyName = "LettaRequestInputVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaRequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaMessageUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaMessageUnion), TypeInfoPropertyName = "LettaMessageUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaStopReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasOpenaiChatCompletionResponseChoiceLogprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.TurnTokenData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TurnTokenData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaStreamingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item5>, object>), TypeInfoPropertyName = "AnyOfStringIListInputVariant2Item5Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.InputVariant2Item5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item5), TypeInfoPropertyName = "InputVariant2Item52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaStreamingRequestInputVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaStreamingRequestInputVariant2ItemDiscriminatorType), TypeInfoPropertyName = "LettaStreamingRequestInputVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaStreamingResponse), TypeInfoPropertyName = "LettaStreamingResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ReasoningMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolCallMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolReturnMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaStreamingResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaStreamingResponseDiscriminatorMessageType), TypeInfoPropertyName = "LettaStreamingResponseDiscriminatorMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListDeploymentEntitiesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.DeploymentEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LocalSandboxConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PipRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MCPServerType), TypeInfoPropertyName = "MCPServerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MCPTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolAnnotations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MCPToolHealth2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MaxCountPerStepToolRuleSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.AgentType?, string, object>), TypeInfoPropertyName = "AnyOfAgentTypeStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.FileBlock>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MessageCreateRole), TypeInfoPropertyName = "MessageCreateRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.LettaMessageContentUnion>, string>), TypeInfoPropertyName = "AnyOfIListLettaMessageContentUnionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaMessageContentUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaMessageContentUnion), TypeInfoPropertyName = "LettaMessageContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MessageSearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MessageSearchRequestSearchMode), TypeInfoPropertyName = "MessageSearchRequestSearchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.MessageRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MessageSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModalSandboxConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModalSandboxConfigLanguage), TypeInfoPropertyName = "ModalSandboxConfigLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelModelEndpointType), TypeInfoPropertyName = "ModelModelEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelReasoningEffort2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelEffort2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelCompatibilityType2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelVerbosity2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant110))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "ModelResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyApprovalRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyFeedbackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.NpmRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenAIReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant111))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenAIModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenAIModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "OpenAIModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenAIReasoningReasoningEffort), TypeInfoPropertyName = "OpenAIReasoningReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant112))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenRouterModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Organization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OrganizationCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OrganizationSourcesStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.SourceStats>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SourceStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OrganizationUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PaginatedAgentFiles))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AgentFileAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ParameterProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ParametersSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Letta.ParameterProperties>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Passage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PassageBatchCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PassageCreateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PassageCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PassageSearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PassageSearchRequestTagMatchMode), TypeInfoPropertyName = "PassageSearchRequestTagMatchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PassageSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Provider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProviderCheck))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProviderCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProviderTrace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProviderUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ReasoningMessageSource), TypeInfoPropertyName = "ReasoningMessageSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ReasoningMessageListResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResetMessagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.RetrieveStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Run))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.RunStatus), TypeInfoPropertyName = "RunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.RunMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SSEMCPServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SSEServerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SandboxConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SandboxType), TypeInfoPropertyName = "SandboxType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SandboxConfigCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.LocalSandboxConfig, global::Letta.E2BSandboxConfig, global::Letta.ModalSandboxConfig>), TypeInfoPropertyName = "AnyOfLocalSandboxConfigE2BSandboxConfigModalSandboxConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SandboxConfigUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SandboxEnvironmentVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SandboxEnvironmentVariableCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SandboxEnvironmentVariableUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SearchAllMessagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SearchAllMessagesRequestSearchMode), TypeInfoPropertyName = "SearchAllMessagesRequestSearchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SourceCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.FileStats>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SourceUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.StdioMCPServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.StdioServerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Step))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.StepFeedback2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.StepStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.StepMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.StreamableHTTPMCPServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.StreamableHTTPServerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.SummarizedReasoningContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SummarizedReasoningContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SummaryMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SystemMessageListResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TagSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant113))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TogetherModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TogetherModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "TogetherModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolType), TypeInfoPropertyName = "ToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.NpmRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolEnvVarSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolExecutionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolExecutionResultStatus), TypeInfoPropertyName = "ToolExecutionResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolJSONSchema3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaSchemasLettaMessageToolReturn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolReturnMessageStatus), TypeInfoPropertyName = "ToolReturnMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolRunFromSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolSearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolSearchRequestSearchMode), TypeInfoPropertyName = "ToolSearchRequestSearchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TurnTokenDataRole), TypeInfoPropertyName = "TurnTokenDataRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UpdateAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ToolRulesVariant1Item4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolRulesVariant1Item4), TypeInfoPropertyName = "ToolRulesVariant1Item42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UpdateAgentToolRulesVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UpdateAgentToolRulesVariant1ItemDiscriminatorType), TypeInfoPropertyName = "UpdateAgentToolRulesVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UpdateAgentModelSettingsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UpdateAgentModelSettingsVariant1DiscriminatorProviderType), TypeInfoPropertyName = "UpdateAgentModelSettingsVariant1DiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant114))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UpdateAgentResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UpdateAgentResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "UpdateAgentResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UpdateAssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UpdateConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UpdateConversationModelSettingsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UpdateConversationModelSettingsVariant1DiscriminatorProviderType), TypeInfoPropertyName = "UpdateConversationModelSettingsVariant1DiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UpdateMCPServerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Config4), TypeInfoPropertyName = "Config42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasMcpServerUpdateStdioMCPServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasMcpServerUpdateSSEMCPServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UpdateMCPServerRequestConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UpdateMCPServerRequestConfigDiscriminatorMcpServerType), TypeInfoPropertyName = "UpdateMCPServerRequestConfigDiscriminatorMcpServerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UpdateReasoningMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UpdateSystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UpdateUserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.LettaUserMessageContentUnion>, string>), TypeInfoPropertyName = "AnyOfIListLettaUserMessageContentUnionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaUserMessageContentUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaUserMessageContentUnion), TypeInfoPropertyName = "LettaUserMessageContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UsageStatistics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UsageStatisticsPromptTokenDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UsageStatisticsCompletionTokenDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UserCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UserMessageListResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UserUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant115))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.XAIModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.XAIModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "XAIModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant116))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ZAIModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ZAIModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "ZAIModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ZAIThinking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ZAIThinkingType), TypeInfoPropertyName = "ZAIThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ToolRulesVariant1Item5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolRulesVariant1Item5), TypeInfoPropertyName = "ToolRulesVariant1Item52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType), TypeInfoPropertyName = "LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant110))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasAgentFileAgentSchemaModelSettingsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType), TypeInfoPropertyName = "LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant117))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasAgentFileAgentSchemaResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasAgentFileAgentSchemaResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "LettaSchemasAgentFileAgentSchemaResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaSchemasAgentFileMessageSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasAgentFileMessageSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.FileAgentSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ChatCompletionMessageFunctionToolCallInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaSchemasMessageToolReturnInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasMessageToolReturnInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ApprovalReturn, global::Letta.LettaSchemasMessageToolReturnInput>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.ApprovalReturn, global::Letta.LettaSchemasMessageToolReturnInput>), TypeInfoPropertyName = "AnyOfApprovalReturnLettaSchemasMessageToolReturnInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.LettaToolReturnContentUnion>, string>), TypeInfoPropertyName = "AnyOfIListLettaToolReturnContentUnionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaToolReturnContentUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaToolReturnContentUnion), TypeInfoPropertyName = "LettaToolReturnContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasLettaMessageToolReturnStatus), TypeInfoPropertyName = "LettaSchemasLettaMessageToolReturnStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasMcpUpdateSSEMCPServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasMcpUpdateStdioMCPServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasMcpUpdateStreamableHTTPMCPServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasMcpServerToolExecuteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasMessageToolReturnInputStatus), TypeInfoPropertyName = "LettaSchemasMessageToolReturnInputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.FuncResponseVariant2Item>, object>), TypeInfoPropertyName = "AnyOfStringIListFuncResponseVariant2ItemObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.FuncResponseVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FuncResponseVariant2Item), TypeInfoPropertyName = "FuncResponseVariant2Item3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorType), TypeInfoPropertyName = "LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasMessageToolReturnOutputStatus), TypeInfoPropertyName = "LettaSchemasMessageToolReturnOutputStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.FuncResponseVariant2Item2>, object>), TypeInfoPropertyName = "AnyOfStringIListFuncResponseVariant2Item2Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.FuncResponseVariant2Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FuncResponseVariant2Item2), TypeInfoPropertyName = "FuncResponseVariant2Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType), TypeInfoPropertyName = "LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasOpenaiChatCompletionResponseChatCompletionTokenLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaSchemasOpenaiChatCompletionResponseTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasOpenaiChatCompletionResponseTopLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaSchemasOpenaiChatCompletionResponseChatCompletionTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.CoreMemoryBlockSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaSerializeSchemasPydanticAgentSchemaMessageSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSerializeSchemasPydanticAgentSchemaMessageSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.TagSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ToolEnvVarSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.BaseToolRuleSchema, global::Letta.ChildToolRuleSchema, global::Letta.MaxCountPerStepToolRuleSchema, global::Letta.ConditionalToolRuleSchema>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.BaseToolRuleSchema, global::Letta.ChildToolRuleSchema, global::Letta.MaxCountPerStepToolRuleSchema, global::Letta.ConditionalToolRuleSchema>), TypeInfoPropertyName = "AnyOfBaseToolRuleSchemaChildToolRuleSchemaMaxCountPerStepToolRuleSchemaConditionalToolRuleSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaSerializeSchemasPydanticAgentSchemaToolSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSerializeSchemasPydanticAgentSchemaToolSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaServerRestApiRoutersV1AgentsCompactionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaServerRestApiRoutersV1ConversationsCompactionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaServerRestApiRoutersV1ToolsToolExecuteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.OpenaiTypesChatChatCompletionTokenLogprobChatCompletionTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenaiTypesChatChatCompletionTokenLogprobChatCompletionTokenLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.OpenaiTypesChatChatCompletionTokenLogprobTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenaiTypesChatChatCompletionTokenLogprobTopLogprob))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>), TypeInfoPropertyName = "AnyOfStdioServerConfigSSEServerConfigStreamableHTTPServerConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.LettaSchemasMcpUpdateStdioMCPServer, global::Letta.LettaSchemasMcpUpdateSSEMCPServer, global::Letta.LettaSchemasMcpUpdateStreamableHTTPMCPServer>), TypeInfoPropertyName = "AnyOfLettaSchemasMcpUpdateStdioMCPServerLettaSchemasMcpUpdateSSEMCPServerLettaSchemasMcpUpdateStreamableHTTPMCPServer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.UpdateSystemMessage, global::Letta.UpdateUserMessage, global::Letta.UpdateReasoningMessage, global::Letta.UpdateAssistantMessage>), TypeInfoPropertyName = "AnyOfUpdateSystemMessageUpdateUserMessageUpdateReasoningMessageUpdateAssistantMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.LettaRequest, global::Letta.LettaStreamingRequest>), TypeInfoPropertyName = "AnyOfLettaRequestLettaStreamingRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.InternalTemplateBlockCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsSearchDeployedAgentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant1, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant2, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant3, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant4, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant5, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant6>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant1, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant2, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant3, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant4, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant5, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant6>), TypeInfoPropertyName = "OneOfAgentsSearchDeployedAgentsRequestSearchItemVariant1AgentsSearchDeployedAgentsRequestSearchItemVariant2AgentsSearchDeployedAgentsRequestSearchItemVariant3AgentsSearchDeployedAgentsRequestSearchItemVariant4AgentsSearchDeployedAgentsRequestSearchItemVariant5AgentsSearchDeployedAgentsRequestSearchItemVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant1Field), TypeInfoPropertyName = "AgentsSearchDeployedAgentsRequestSearchItemVariant1Field2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant2Field), TypeInfoPropertyName = "AgentsSearchDeployedAgentsRequestSearchItemVariant2Field2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant2Operator), TypeInfoPropertyName = "AgentsSearchDeployedAgentsRequestSearchItemVariant2Operator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant3Field), TypeInfoPropertyName = "AgentsSearchDeployedAgentsRequestSearchItemVariant3Field2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant3Operator), TypeInfoPropertyName = "AgentsSearchDeployedAgentsRequestSearchItemVariant3Operator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant4Field), TypeInfoPropertyName = "AgentsSearchDeployedAgentsRequestSearchItemVariant4Field2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant4Operator), TypeInfoPropertyName = "AgentsSearchDeployedAgentsRequestSearchItemVariant4Operator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant5Field), TypeInfoPropertyName = "AgentsSearchDeployedAgentsRequestSearchItemVariant5Field2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant5Operator), TypeInfoPropertyName = "AgentsSearchDeployedAgentsRequestSearchItemVariant5Operator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant6Field), TypeInfoPropertyName = "AgentsSearchDeployedAgentsRequestSearchItemVariant6Field2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant6Operator), TypeInfoPropertyName = "AgentsSearchDeployedAgentsRequestSearchItemVariant6Operator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsSearchDeployedAgentsRequestCombinator), TypeInfoPropertyName = "AgentsSearchDeployedAgentsRequestCombinator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsSearchDeployedAgentsRequestSortBy), TypeInfoPropertyName = "AgentsSearchDeployedAgentsRequestSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateAgentsFromTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRole), TypeInfoPropertyName = "TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateAgentsFromTemplateNoProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRole), TypeInfoPropertyName = "TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateTemplateNoProjectRequest), TypeInfoPropertyName = "TemplatesCreateTemplateNoProjectRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateTemplateNoProjectRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateTemplateNoProjectRequestVariant1Type), TypeInfoPropertyName = "TemplatesCreateTemplateNoProjectRequestVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateTemplateNoProjectRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateTemplateNoProjectRequestVariant2Type), TypeInfoPropertyName = "TemplatesCreateTemplateNoProjectRequestVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateTemplateNoProjectRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesSaveTemplateVersionNoProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategy), TypeInfoPropertyName = "TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesSaveTemplateVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesSaveTemplateVersionRequestBlockReconciliationStrategy), TypeInfoPropertyName = "TemplatesSaveTemplateVersionRequestBlockReconciliationStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesForkTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateTemplateRequest), TypeInfoPropertyName = "TemplatesCreateTemplateRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateTemplateRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateTemplateRequestVariant1Type), TypeInfoPropertyName = "TemplatesCreateTemplateRequestVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateTemplateRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateTemplateRequestVariant2Type), TypeInfoPropertyName = "TemplatesCreateTemplateRequestVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateTemplateRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesUpdateCurrentTemplateFromAgentFileNoProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesRenameTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesUpdateTemplateDescriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesMigrateDeploymentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesRollbackTemplateNoProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesRollbackTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesUpdateCurrentTemplateFromAgentFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientSideAccessTokensCreateClientSideAccessTokenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PolicyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PolicyItem), TypeInfoPropertyName = "PolicyItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Type), TypeInfoPropertyName = "ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces), TypeInfoPropertyName = "ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProjectsCreateProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendFeedbackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendFeedbackRequestFeature), TypeInfoPropertyName = "MetadataSendFeedbackRequestFeature2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestService), TypeInfoPropertyName = "MetadataSendTelemetryRequestService2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.EventsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EventsItem), TypeInfoPropertyName = "EventsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant1Type), TypeInfoPropertyName = "MetadataSendTelemetryRequestEventVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant1Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant2Type), TypeInfoPropertyName = "MetadataSendTelemetryRequestEventVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant2Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant3Type), TypeInfoPropertyName = "MetadataSendTelemetryRequestEventVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant3Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant4Type), TypeInfoPropertyName = "MetadataSendTelemetryRequestEventVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant4Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant5Type), TypeInfoPropertyName = "MetadataSendTelemetryRequestEventVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant5Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesScheduleAgentMessageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2>>, string>), TypeInfoPropertyName = "OneOfIListOneOfScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2>), TypeInfoPropertyName = "OneOfScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1Type), TypeInfoPropertyName = "ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2Source))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceType), TypeInfoPropertyName = "ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2Type), TypeInfoPropertyName = "ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageRole), TypeInfoPropertyName = "ScheduledMessagesScheduleAgentMessageRequestMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageType), TypeInfoPropertyName = "ScheduledMessagesScheduleAgentMessageRequestMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType), TypeInfoPropertyName = "ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<global::Letta.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1, global::Letta.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2>), TypeInfoPropertyName = "OneOfScheduledMessagesScheduleAgentMessageRequestScheduleVariant1ScheduledMessagesScheduleAgentMessageRequestScheduleVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1Type), TypeInfoPropertyName = "ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2Type), TypeInfoPropertyName = "ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsCreateFeedRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsPublishMessagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.FeedsPublishMessagesRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsPublishMessagesRequestMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsSubscribeAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsUpdateSubscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsUnsubscribeAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsBackfillSubscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsUpdateAllSubscriptionsCronRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineRequestIntegrationType), TypeInfoPropertyName = "PipelinesCreatePipelineRequestIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProducerConfig), TypeInfoPropertyName = "ProducerConfig4")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant1Type), TypeInfoPropertyName = "PipelinesCreatePipelineRequestProducerConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant1Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant1DataChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant2Type), TypeInfoPropertyName = "PipelinesCreatePipelineRequestProducerConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProducerConfig2), TypeInfoPropertyName = "ProducerConfig22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Type), TypeInfoPropertyName = "PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1DataChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2Type), TypeInfoPropertyName = "PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineRequestIntegrationType), TypeInfoPropertyName = "PipelinesPreviewPipelineRequestIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProducerConfig3), TypeInfoPropertyName = "ProducerConfig32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1Type), TypeInfoPropertyName = "PipelinesPreviewPipelineRequestProducerConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1DataChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant2Type), TypeInfoPropertyName = "PipelinesPreviewPipelineRequestProducerConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsRegisterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsRegisterRequestMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.EnvironmentsSendMessageRequestMessageVariant1, global::Letta.EnvironmentsSendMessageRequestMessageVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<global::Letta.EnvironmentsSendMessageRequestMessageVariant1, global::Letta.EnvironmentsSendMessageRequestMessageVariant2>), TypeInfoPropertyName = "OneOfEnvironmentsSendMessageRequestMessageVariant1EnvironmentsSendMessageRequestMessageVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant1Role), TypeInfoPropertyName = "EnvironmentsSendMessageRequestMessageVariant1Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<string, global::System.Collections.Generic.IList<global::Letta.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item>>), TypeInfoPropertyName = "OneOfStringIListEnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemType), TypeInfoPropertyName = "EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2Type), TypeInfoPropertyName = "EnvironmentsSendMessageRequestMessageVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1, global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1, global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2>), TypeInfoPropertyName = "OneOfEnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Type), TypeInfoPropertyName = "EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<string, global::System.Collections.Generic.IList<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2Item>>), TypeInfoPropertyName = "OneOfStringIListEnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType), TypeInfoPropertyName = "EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Status), TypeInfoPropertyName = "EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2Type), TypeInfoPropertyName = "EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendModeChangeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendModeChangeRequestMode), TypeInfoPropertyName = "EnvironmentsSendModeChangeRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListArchivesOrder), TypeInfoPropertyName = "ListArchivesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListAgentsForArchiveOrder), TypeInfoPropertyName = "ListAgentsForArchiveOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ListAgentsForArchiveIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListAgentsForArchiveIncludeItem), TypeInfoPropertyName = "ListAgentsForArchiveIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListToolsOrder), TypeInfoPropertyName = "ListToolsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListFoldersOrder), TypeInfoPropertyName = "ListFoldersOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListAgentsForFolderOrder), TypeInfoPropertyName = "ListAgentsForFolderOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListFolderPassagesOrder), TypeInfoPropertyName = "ListFolderPassagesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListFilesForFolderOrder), TypeInfoPropertyName = "ListFilesForFolderOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ListAgentsIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListAgentsIncludeItem), TypeInfoPropertyName = "ListAgentsIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListAgentsOrder), TypeInfoPropertyName = "ListAgentsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListAgentsOrderBy), TypeInfoPropertyName = "ListAgentsOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.RetrieveAgentIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.RetrieveAgentIncludeItem), TypeInfoPropertyName = "RetrieveAgentIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListToolsForAgentOrder), TypeInfoPropertyName = "ListToolsForAgentOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListAgentSourcesOrder), TypeInfoPropertyName = "ListAgentSourcesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListFoldersForAgentOrder), TypeInfoPropertyName = "ListFoldersForAgentOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListFilesForAgentOrder), TypeInfoPropertyName = "ListFilesForAgentOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListCoreMemoryBlocksOrder), TypeInfoPropertyName = "ListCoreMemoryBlocksOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SearchArchivalMemoryTagMatchMode), TypeInfoPropertyName = "SearchArchivalMemoryTagMatchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListMessagesOrder), TypeInfoPropertyName = "ListMessagesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListGroupsForAgentOrder), TypeInfoPropertyName = "ListGroupsForAgentOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListConversationsOrder), TypeInfoPropertyName = "ListConversationsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListConversationsOrderBy), TypeInfoPropertyName = "ListConversationsOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListConversationMessagesOrder), TypeInfoPropertyName = "ListConversationMessagesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListGroupsOrder), TypeInfoPropertyName = "ListGroupsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListGroupMessagesOrder), TypeInfoPropertyName = "ListGroupMessagesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListIdentitiesOrder), TypeInfoPropertyName = "ListIdentitiesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListAgentsForIdentityOrder), TypeInfoPropertyName = "ListAgentsForIdentityOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ListAgentsForIdentityIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListAgentsForIdentityIncludeItem), TypeInfoPropertyName = "ListAgentsForIdentityIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListBlocksForIdentityOrder), TypeInfoPropertyName = "ListBlocksForIdentityOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListInternalBlocksOrder), TypeInfoPropertyName = "ListInternalBlocksOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListAgentsForInternalBlockOrder), TypeInfoPropertyName = "ListAgentsForInternalBlockOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListInternalRunsOrder), TypeInfoPropertyName = "ListInternalRunsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListInternalRunsOrderBy), TypeInfoPropertyName = "ListInternalRunsOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListInternalRunsDurationOperator2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ProviderCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListBlocksOrder), TypeInfoPropertyName = "ListBlocksOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListAgentsForBlockOrder), TypeInfoPropertyName = "ListAgentsForBlockOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ListAgentsForBlockIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListAgentsForBlockIncludeItem), TypeInfoPropertyName = "ListAgentsForBlockIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListJobsOrder), TypeInfoPropertyName = "ListJobsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListProvidersOrder), TypeInfoPropertyName = "ListProvidersOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListRunsOrder), TypeInfoPropertyName = "ListRunsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListMessagesForRunOrder), TypeInfoPropertyName = "ListMessagesForRunOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListStepsForRunOrder), TypeInfoPropertyName = "ListStepsForRunOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListStepsOrder), TypeInfoPropertyName = "ListStepsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListStepsFeedback2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListMessagesForStepOrder), TypeInfoPropertyName = "ListMessagesForStepOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListTagsOrder), TypeInfoPropertyName = "ListTagsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListAllMessagesOrder), TypeInfoPropertyName = "ListAllMessagesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListBatchesOrder), TypeInfoPropertyName = "ListBatchesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListMessagesForBatchOrder), TypeInfoPropertyName = "ListMessagesForBatchOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.AgentsCountDeployedAgentsSearchItemVariant1, global::Letta.AgentsCountDeployedAgentsSearchItemVariant2, global::Letta.AgentsCountDeployedAgentsSearchItemVariant3, global::Letta.AgentsCountDeployedAgentsSearchItemVariant4, global::Letta.AgentsCountDeployedAgentsSearchItemVariant5, global::Letta.AgentsCountDeployedAgentsSearchItemVariant6>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<global::Letta.AgentsCountDeployedAgentsSearchItemVariant1, global::Letta.AgentsCountDeployedAgentsSearchItemVariant2, global::Letta.AgentsCountDeployedAgentsSearchItemVariant3, global::Letta.AgentsCountDeployedAgentsSearchItemVariant4, global::Letta.AgentsCountDeployedAgentsSearchItemVariant5, global::Letta.AgentsCountDeployedAgentsSearchItemVariant6>), TypeInfoPropertyName = "OneOfAgentsCountDeployedAgentsSearchItemVariant1AgentsCountDeployedAgentsSearchItemVariant2AgentsCountDeployedAgentsSearchItemVariant3AgentsCountDeployedAgentsSearchItemVariant4AgentsCountDeployedAgentsSearchItemVariant5AgentsCountDeployedAgentsSearchItemVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsCountDeployedAgentsSearchItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsCountDeployedAgentsSearchItemVariant1Field), TypeInfoPropertyName = "AgentsCountDeployedAgentsSearchItemVariant1Field2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsCountDeployedAgentsSearchItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsCountDeployedAgentsSearchItemVariant2Field), TypeInfoPropertyName = "AgentsCountDeployedAgentsSearchItemVariant2Field2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsCountDeployedAgentsSearchItemVariant2Operator), TypeInfoPropertyName = "AgentsCountDeployedAgentsSearchItemVariant2Operator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsCountDeployedAgentsSearchItemVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsCountDeployedAgentsSearchItemVariant3Field), TypeInfoPropertyName = "AgentsCountDeployedAgentsSearchItemVariant3Field2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsCountDeployedAgentsSearchItemVariant3Operator), TypeInfoPropertyName = "AgentsCountDeployedAgentsSearchItemVariant3Operator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsCountDeployedAgentsSearchItemVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsCountDeployedAgentsSearchItemVariant4Field), TypeInfoPropertyName = "AgentsCountDeployedAgentsSearchItemVariant4Field2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsCountDeployedAgentsSearchItemVariant4Operator), TypeInfoPropertyName = "AgentsCountDeployedAgentsSearchItemVariant4Operator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsCountDeployedAgentsSearchItemVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsCountDeployedAgentsSearchItemVariant5Field), TypeInfoPropertyName = "AgentsCountDeployedAgentsSearchItemVariant5Field2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsCountDeployedAgentsSearchItemVariant5Operator), TypeInfoPropertyName = "AgentsCountDeployedAgentsSearchItemVariant5Operator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsCountDeployedAgentsSearchItemVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsCountDeployedAgentsSearchItemVariant6Field), TypeInfoPropertyName = "AgentsCountDeployedAgentsSearchItemVariant6Field2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsCountDeployedAgentsSearchItemVariant6Operator), TypeInfoPropertyName = "AgentsCountDeployedAgentsSearchItemVariant6Operator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsCountDeployedAgentsCombinator), TypeInfoPropertyName = "AgentsCountDeployedAgentsCombinator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<string, double?>), TypeInfoPropertyName = "OneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesListTemplatesSortBy), TypeInfoPropertyName = "TemplatesListTemplatesSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Archive>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AgentState>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Passage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ToolSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.SSEServerConfig, global::Letta.StdioServerConfig, global::Letta.StreamableHTTPServerConfig>), TypeInfoPropertyName = "AnyOfSSEServerConfigStdioServerConfigStreamableHTTPServerConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.MCPTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.FileMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Folder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.BlockResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyMessageResponse), TypeInfoPropertyName = "ModifyMessageResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyMessageResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyMessageResponseDiscriminatorMessageType), TypeInfoPropertyName = "ModifyMessageResponseDiscriminatorMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.MessageSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Group>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Conversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyGroupMessageResponse), TypeInfoPropertyName = "ModifyGroupMessageResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyGroupMessageResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyGroupMessageResponseDiscriminatorMessageType), TypeInfoPropertyName = "ModifyGroupMessageResponseDiscriminatorMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Run>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.EmbeddingModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.StdioMCPServer, global::Letta.SSEMCPServer, global::Letta.StreamableHTTPMCPServer>), TypeInfoPropertyName = "AnyOfStdioMCPServerSSEMCPServerStreamableHTTPMCPServer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.StdioMCPServer, global::Letta.SSEMCPServer, global::Letta.StreamableHTTPMCPServer>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Job>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Provider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Step>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ListMessagesForStepResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListMessagesForStepResponseItem), TypeInfoPropertyName = "ListMessagesForStepResponseItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListMessagesForStepResponseItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListMessagesForStepResponseItemDiscriminatorMessageType), TypeInfoPropertyName = "ListMessagesForStepResponseItemDiscriminatorMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.SearchAllMessagesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SearchAllMessagesResponseItem), TypeInfoPropertyName = "SearchAllMessagesResponseItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SearchAllMessagesResponseItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SearchAllMessagesResponseItemDiscriminatorMessageType), TypeInfoPropertyName = "SearchAllMessagesResponseItemDiscriminatorMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.BatchJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PassageSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsSearchDeployedAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsCountDeployedAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsGetAgentVariablesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsGetAgentVariablesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentsGetAgentVariablesResponseMessage), TypeInfoPropertyName = "AgentsGetAgentVariablesResponseMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateAgentsFromTemplateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateAgentsFromTemplateNoProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateAgentsFromTemplateNoProjectResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesListTemplatesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.TemplatesListTemplatesResponseTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesListTemplatesResponseTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateTemplateNoProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateTemplateNoProjectResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesSaveTemplateVersionNoProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesSaveTemplateVersionNoProjectResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesSaveTemplateVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesSaveTemplateVersionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesDeleteTemplateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesDeleteTemplateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.TemplatesGetTemplateSnapshotResponseAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentMemoryVariables))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.TemplatesGetTemplateSnapshotResponseAgentMemoryVariablesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentMemoryVariablesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolVariables))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolVariablesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolVariablesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant2, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant2, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9>), TypeInfoPropertyName = "OneOfTemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant2TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1Type), TypeInfoPropertyName = "TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1ChildArgNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1ChildArgNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant2Type), TypeInfoPropertyName = "TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3Type), TypeInfoPropertyName = "TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4Type), TypeInfoPropertyName = "TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5Type), TypeInfoPropertyName = "TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6Type), TypeInfoPropertyName = "TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7Type), TypeInfoPropertyName = "TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8Type), TypeInfoPropertyName = "TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9Type), TypeInfoPropertyName = "TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentAgentType), TypeInfoPropertyName = "TemplatesGetTemplateSnapshotResponseAgentAgentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevel), TypeInfoPropertyName = "TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffort), TypeInfoPropertyName = "TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.TemplatesGetTemplateSnapshotResponseBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.TemplatesGetTemplateSnapshotResponseRelationship>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseRelationship))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesGetTemplateSnapshotResponseType), TypeInfoPropertyName = "TemplatesGetTemplateSnapshotResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesSetCurrentTemplateFromSnapshotResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesSetCurrentTemplateFromSnapshotResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesSetCurrentTemplateFromSnapshotResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesSetCurrentTemplateFromSnapshotResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesForkTemplateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesForkTemplateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateTemplateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesCreateTemplateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesDeleteTemplateNoProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesDeleteTemplateNoProjectResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesUpdateCurrentTemplateFromAgentFileNoProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesUpdateCurrentTemplateFromAgentFileNoProjectResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesUpdateCurrentTemplateFromAgentFileNoProjectResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesUpdateCurrentTemplateFromAgentFileNoProjectResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesRenameTemplateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesRenameTemplateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesRenameTemplateResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesRenameTemplateResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesUpdateTemplateDescriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesUpdateTemplateDescriptionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesUpdateTemplateDescriptionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesListTemplateVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.TemplatesListTemplateVersionsResponseVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesListTemplateVersionsResponseVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesListTemplateVersionsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesMigrateDeploymentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesMigrateDeploymentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesMigrateDeploymentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesMigrateDeploymentResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesRollbackTemplateNoProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesRollbackTemplateNoProjectResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesRollbackTemplateNoProjectResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesRollbackTemplateNoProjectResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesRollbackTemplateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesRollbackTemplateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesRollbackTemplateResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesRollbackTemplateResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesUpdateCurrentTemplateFromAgentFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesUpdateCurrentTemplateFromAgentFileResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesUpdateCurrentTemplateFromAgentFileResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesUpdateCurrentTemplateFromAgentFileResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesLegacyMigrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesLegacyMigrationResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TemplatesLegacyMigrationResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientSideAccessTokensCreateClientSideAccessTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyVersion), TypeInfoPropertyName = "ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.DataItem), TypeInfoPropertyName = "DataItem3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Type), TypeInfoPropertyName = "ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Acces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Acces), TypeInfoPropertyName = "ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Acces2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientSideAccessTokensCreateClientSideAccessTokenResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyVersion), TypeInfoPropertyName = "ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.DataItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.DataItem2), TypeInfoPropertyName = "DataItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Type), TypeInfoPropertyName = "ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Acces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Acces), TypeInfoPropertyName = "ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Acces2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ClientSideAccessTokensDeleteClientSideAccessTokenResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProjectsListProjectsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ProjectsListProjectsResponseProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProjectsListProjectsResponseProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProjectsCreateProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProjectsDeleteProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataRetrieveCurrentBalancesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendFeedbackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataGetStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataGetUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataGetUserResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesScheduleAgentMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesListScheduledMessagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2>>, string>), TypeInfoPropertyName = "OneOfIListOneOfScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2>), TypeInfoPropertyName = "OneOfScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1Type), TypeInfoPropertyName = "ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2Source))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2SourceType), TypeInfoPropertyName = "ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2SourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2Type), TypeInfoPropertyName = "ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageRole), TypeInfoPropertyName = "ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageType), TypeInfoPropertyName = "ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType), TypeInfoPropertyName = "ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1, global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2>), TypeInfoPropertyName = "OneOfScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1Type), TypeInfoPropertyName = "ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2Type), TypeInfoPropertyName = "ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesDeleteScheduledMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesRetrieveScheduledMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2>>, string>), TypeInfoPropertyName = "OneOfIListOneOfScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2String2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2>), TypeInfoPropertyName = "OneOfScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1Type), TypeInfoPropertyName = "ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2Source))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2SourceType), TypeInfoPropertyName = "ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2SourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2Type), TypeInfoPropertyName = "ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRole), TypeInfoPropertyName = "ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageType), TypeInfoPropertyName = "ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType), TypeInfoPropertyName = "ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1, global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant2>), TypeInfoPropertyName = "OneOfScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1Type), TypeInfoPropertyName = "ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant2Type), TypeInfoPropertyName = "ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsCreateFeedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListFeedsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.FeedsListFeedsResponseFeed>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListFeedsResponseFeed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsGetFeedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsDeleteFeedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsPublishMessagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListMessagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.FeedsListMessagesResponseMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListMessagesResponseMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsGetMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsGetMessageResponseMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsGetMessageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsSubscribeAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsSubscribeAgentResponseMergeStrategy), TypeInfoPropertyName = "FeedsSubscribeAgentResponseMergeStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsSubscribeAgentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsSubscribeAgentResponseErrorCode), TypeInfoPropertyName = "FeedsSubscribeAgentResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsUpdateSubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsUpdateSubscriptionResponseMergeStrategy), TypeInfoPropertyName = "FeedsUpdateSubscriptionResponseMergeStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsDeleteSubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsUnsubscribeAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsTriggerSubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsTriggerSubscriptionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsBackfillSubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsBackfillSubscriptionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsBackfillSubscriptionResponseErrorCode), TypeInfoPropertyName = "FeedsBackfillSubscriptionResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListSubscriptionHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.FeedsListSubscriptionHistoryResponseRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListSubscriptionHistoryResponseRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListSubscriptionHistoryResponseRunType), TypeInfoPropertyName = "FeedsListSubscriptionHistoryResponseRunType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListSubscriptionHistoryResponseRunStatus), TypeInfoPropertyName = "FeedsListSubscriptionHistoryResponseRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListSubscriptionHistoryResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListSubscriptionHistoryResponseErrorCode), TypeInfoPropertyName = "FeedsListSubscriptionHistoryResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsUpdateAllSubscriptionsCronResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsUpdateAllSubscriptionsCronResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListSubscriptionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.FeedsListSubscriptionsResponseSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListSubscriptionsResponseSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListSubscriptionsResponseSubscriptionMergeStrategy), TypeInfoPropertyName = "FeedsListSubscriptionsResponseSubscriptionMergeStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MemoryFilesListDirectoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.MemoryFilesListDirectoryResponseEntrie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MemoryFilesListDirectoryResponseEntrie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MemoryFilesListDirectoryResponseEntrieType), TypeInfoPropertyName = "MemoryFilesListDirectoryResponseEntrieType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MemoryFilesListDirectoryResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MemoryFilesListDirectoryResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MemoryFilesGetFileHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.MemoryFilesGetFileHistoryResponseCommit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MemoryFilesGetFileHistoryResponseCommit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MemoryFilesGetFileHistoryResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MemoryFilesGetFileHistoryResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MemoryFilesReadFileContentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MemoryFilesReadFileContentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MemoryFilesReadFileContentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponsePipeline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineIntegrationType), TypeInfoPropertyName = "PipelinesCreatePipelineResponsePipelineIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Config5), TypeInfoPropertyName = "Config52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant1Type), TypeInfoPropertyName = "PipelinesCreatePipelineResponsePipelineConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant1Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant1DataChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant2Type), TypeInfoPropertyName = "PipelinesCreatePipelineResponsePipelineConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponseErrorCode), TypeInfoPropertyName = "PipelinesCreatePipelineResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PipelinesListPipelinesResponsePipeline>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponsePipeline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponsePipelineIntegrationType), TypeInfoPropertyName = "PipelinesListPipelinesResponsePipelineIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Config6), TypeInfoPropertyName = "Config62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1Type), TypeInfoPropertyName = "PipelinesListPipelinesResponsePipelineConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1DataChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2Type), TypeInfoPropertyName = "PipelinesListPipelinesResponsePipelineConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCountPipelinesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponsePipeline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponsePipelineIntegrationType), TypeInfoPropertyName = "PipelinesGetPipelineResponsePipelineIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Config7), TypeInfoPropertyName = "Config72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant1Type), TypeInfoPropertyName = "PipelinesGetPipelineResponsePipelineConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant1Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant1DataChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant2Type), TypeInfoPropertyName = "PipelinesGetPipelineResponsePipelineConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponseErrorCode), TypeInfoPropertyName = "PipelinesGetPipelineResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponsePipeline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineIntegrationType), TypeInfoPropertyName = "PipelinesUpdatePipelineResponsePipelineIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Config8), TypeInfoPropertyName = "Config82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1Type), TypeInfoPropertyName = "PipelinesUpdatePipelineResponsePipelineConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1DataChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant2Type), TypeInfoPropertyName = "PipelinesUpdatePipelineResponsePipelineConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponseErrorCode), TypeInfoPropertyName = "PipelinesUpdatePipelineResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesDeletePipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesDeletePipelineResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesDeletePipelineResponseErrorCode), TypeInfoPropertyName = "PipelinesDeletePipelineResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipeline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationType), TypeInfoPropertyName = "PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Config9), TypeInfoPropertyName = "Config92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1Type), TypeInfoPropertyName = "PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1DataChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2Type), TypeInfoPropertyName = "PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponseErrorCode), TypeInfoPropertyName = "PipelinesUpdatePipelineProducerConfigResponseErrorCode3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponseErrorCode2), TypeInfoPropertyName = "PipelinesUpdatePipelineProducerConfigResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineResponseErrorCode), TypeInfoPropertyName = "PipelinesPreviewPipelineResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesSyncPipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesSyncPipelineResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesSyncPipelineResponseErrorCode), TypeInfoPropertyName = "PipelinesSyncPipelineResponseErrorCode3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesSyncPipelineResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesSyncPipelineResponseErrorCode2), TypeInfoPropertyName = "PipelinesSyncPipelineResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelineSyncHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PipelinesListPipelineSyncHistoryResponseRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelineSyncHistoryResponseRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelineSyncHistoryResponseRunStatus), TypeInfoPropertyName = "PipelinesListPipelineSyncHistoryResponseRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelineSyncHistoryResponseRunError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelineSyncHistoryResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelineSyncHistoryResponseErrorCode), TypeInfoPropertyName = "PipelinesListPipelineSyncHistoryResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsRegisterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsRegisterResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsGetConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsGetConnectionResponseCurrentMode), TypeInfoPropertyName = "EnvironmentsGetConnectionResponseCurrentMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsGetConnectionResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsGetConnectionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsListConnectionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.EnvironmentsListConnectionsResponseConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsListConnectionsResponseConnection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsListConnectionsResponseConnectionCurrentMode), TypeInfoPropertyName = "EnvironmentsListConnectionsResponseConnectionCurrentMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsListConnectionsResponseConnectionMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendModeChangeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendModeChangeResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsDeleteEnvironmentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsDeleteEnvironmentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsDeleteEnvironmentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaSchemasAgentFileAgentSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.GroupSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.BlockSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.FileSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.SourceSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaSchemasAgentFileToolSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.MCPServerSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.SkillSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ToolRulesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Block>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Source2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AgentEnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Identity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ApprovalsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.List<global::Letta.ToolCall2>, global::Letta.ToolCallDelta, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ToolCall2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ApprovalsVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ArchivalMemorySearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.List<global::Letta.LettaAssistantMessageContentUnion>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaAssistantMessageContentUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Choice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.List<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartRefusalParam>>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartRefusalParam>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<global::Letta.ChatCompletionMessageFunctionToolCallParam, global::Letta.ChatCompletionMessageCustomToolCallParam>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.List<global::Letta.ChatCompletionContentPartTextParam>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ChatCompletionContentPartTextParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Annotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<global::Letta.ChatCompletionMessageFunctionToolCallOutput, global::Letta.ChatCompletionMessageCustomToolCall>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<global::Letta.ChatCompletionDeveloperMessageParam, global::Letta.ChatCompletionSystemMessageParam, global::Letta.ChatCompletionUserMessageParam, global::Letta.ChatCompletionAssistantMessageParam, global::Letta.ChatCompletionToolMessageParam, global::Letta.ChatCompletionFunctionMessageParam>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.List<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartImageParam, global::Letta.ChatCompletionContentPartInputAudioParam, global::Letta.File>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartImageParam, global::Letta.ChatCompletionContentPartInputAudioParam, global::Letta.File>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ToolCallNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.FunctionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<global::Letta.MessageCreate, global::Letta.ApprovalCreate, global::Letta.ToolReturnCreate>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.List<global::Letta.InputVariant2Item>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.InputVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.MessageType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ClientToolSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.CreateBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ToolRulesVariant1Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.MessageCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaBatchRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.IdentityProperty>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ToolRulesVariant1Item3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.List<global::Letta.InputVariant2Item2>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.InputVariant2Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.List<global::Letta.InputVariant2Item3>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.InputVariant2Item3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.List<global::Letta.InputVariant2Item4>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.InputVariant2Item4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaMessageUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.TurnTokenData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.List<global::Letta.InputVariant2Item5>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.InputVariant2Item5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.DeploymentEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PipRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.FileBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ContentVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ChatCompletionMessageFunctionToolCallOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaSchemasMessageToolReturnOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<global::Letta.ApprovalReturn, global::Letta.LettaSchemasMessageToolReturnOutput>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.List<global::Letta.LettaMessageContentUnion>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaMessageContentUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.MessageRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.SourceStats>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AgentFileAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PassageCreateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.FileStats>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.SummarizedReasoningContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.NpmRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaSchemasLettaMessageToolReturn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ToolRulesVariant1Item4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.List<global::Letta.LettaUserMessageContentUnion>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaUserMessageContentUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ToolRulesVariant1Item5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaSchemasAgentFileMessageSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.FileAgentSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ChatCompletionMessageFunctionToolCallInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaSchemasMessageToolReturnInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<global::Letta.ApprovalReturn, global::Letta.LettaSchemasMessageToolReturnInput>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.List<global::Letta.LettaToolReturnContentUnion>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaToolReturnContentUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.List<global::Letta.FuncResponseVariant2Item>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.FuncResponseVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.List<global::Letta.FuncResponseVariant2Item2>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.FuncResponseVariant2Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaSchemasOpenaiChatCompletionResponseTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaSchemasOpenaiChatCompletionResponseChatCompletionTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.CoreMemoryBlockSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaSerializeSchemasPydanticAgentSchemaMessageSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.TagSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ToolEnvVarSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<global::Letta.BaseToolRuleSchema, global::Letta.ChildToolRuleSchema, global::Letta.MaxCountPerStepToolRuleSchema, global::Letta.ConditionalToolRuleSchema>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaSerializeSchemasPydanticAgentSchemaToolSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.OpenaiTypesChatChatCompletionTokenLogprobChatCompletionTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.OpenaiTypesChatChatCompletionTokenLogprobTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.InternalTemplateBlockCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.OneOf<global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant1, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant2, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant3, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant4, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant5, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant6>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PolicyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.EventsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<global::System.Collections.Generic.List<global::Letta.OneOf<global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2>>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.OneOf<global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.FeedsPublishMessagesRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.OneOf<global::Letta.EnvironmentsSendMessageRequestMessageVariant1, global::Letta.EnvironmentsSendMessageRequestMessageVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<string, global::System.Collections.Generic.List<global::Letta.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.OneOf<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1, global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<string, global::System.Collections.Generic.List<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ListAgentsForArchiveIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ListAgentsIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.RetrieveAgentIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ListAgentsForIdentityIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ProviderCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ListAgentsForBlockIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.OneOf<global::Letta.AgentsCountDeployedAgentsSearchItemVariant1, global::Letta.AgentsCountDeployedAgentsSearchItemVariant2, global::Letta.AgentsCountDeployedAgentsSearchItemVariant3, global::Letta.AgentsCountDeployedAgentsSearchItemVariant4, global::Letta.AgentsCountDeployedAgentsSearchItemVariant5, global::Letta.AgentsCountDeployedAgentsSearchItemVariant6>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Archive>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AgentState>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Passage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ToolSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.MCPTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.FileMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Folder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.BlockResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.MessageSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Group>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Conversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Run>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.EmbeddingModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<global::Letta.StdioMCPServer, global::Letta.SSEMCPServer, global::Letta.StreamableHTTPMCPServer>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Job>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Provider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Step>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ListMessagesForStepResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.SearchAllMessagesResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.BatchJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PassageSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.TemplatesListTemplatesResponseTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.TemplatesGetTemplateSnapshotResponseAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.TemplatesGetTemplateSnapshotResponseAgentMemoryVariablesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolVariablesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.OneOf<global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant2, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1ChildArgNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.TemplatesGetTemplateSnapshotResponseBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.TemplatesGetTemplateSnapshotResponseRelationship>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.TemplatesListTemplateVersionsResponseVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.DataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Acces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.DataItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Acces>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ProjectsListProjectsResponseProject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<global::System.Collections.Generic.List<global::Letta.OneOf<global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2>>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.OneOf<global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<global::System.Collections.Generic.List<global::Letta.OneOf<global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2>>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.OneOf<global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.FeedsListFeedsResponseFeed>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.FeedsListMessagesResponseMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.FeedsListSubscriptionHistoryResponseRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.FeedsListSubscriptionsResponseSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.MemoryFilesListDirectoryResponseEntrie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.MemoryFilesGetFileHistoryResponseCommit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PipelinesListPipelinesResponsePipeline>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PipelinesListPipelineSyncHistoryResponseRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.EnvironmentsListConnectionsResponseConnection>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}