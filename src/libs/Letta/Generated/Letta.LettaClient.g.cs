
#nullable enable

namespace Letta
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class LettaClient : global::Letta.ILettaClient, global::System.IDisposable
    {
        /// <summary>
        /// Letta Cloud
        /// </summary>
        public const string DefaultBaseUrl = "https://app.letta.com";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Letta.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::Letta.JsonConverters.AgentStateToolRulesVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.AgentStateToolRulesVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentStateModelSettingsVariant1DiscriminatorProviderTypeJsonConverter(),
                    new global::Letta.JsonConverters.AgentStateModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentStateResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.AgentStateResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentTypeJsonConverter(),
                    new global::Letta.JsonConverters.AgentTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.AnthropicModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.AnthropicModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.AnthropicModelSettingsVerbosity2JsonConverter(),
                    new global::Letta.JsonConverters.AnthropicModelSettingsVerbosity2NullableJsonConverter(),
                    new global::Letta.JsonConverters.AnthropicModelSettingsEffort2JsonConverter(),
                    new global::Letta.JsonConverters.AnthropicModelSettingsEffort2NullableJsonConverter(),
                    new global::Letta.JsonConverters.AnthropicThinkingTypeJsonConverter(),
                    new global::Letta.JsonConverters.AnthropicThinkingTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ApprovalCreateApprovalsVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.ApprovalCreateApprovalsVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.AzureModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.AzureModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.BedrockModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.BedrockModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ChatCompletionServiceTier2JsonConverter(),
                    new global::Letta.JsonConverters.ChatCompletionServiceTier2NullableJsonConverter(),
                    new global::Letta.JsonConverters.ChatGPTOAuthReasoningReasoningEffortJsonConverter(),
                    new global::Letta.JsonConverters.ChatGPTOAuthReasoningReasoningEffortNullableJsonConverter(),
                    new global::Letta.JsonConverters.ChoiceFinishReasonJsonConverter(),
                    new global::Letta.JsonConverters.ChoiceFinishReasonNullableJsonConverter(),
                    new global::Letta.JsonConverters.CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderTypeJsonConverter(),
                    new global::Letta.JsonConverters.CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.CompactionSettingsInputModeJsonConverter(),
                    new global::Letta.JsonConverters.CompactionSettingsInputModeNullableJsonConverter(),
                    new global::Letta.JsonConverters.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderTypeJsonConverter(),
                    new global::Letta.JsonConverters.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.CompactionSettingsOutputModeJsonConverter(),
                    new global::Letta.JsonConverters.CompactionSettingsOutputModeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ComparisonOperatorJsonConverter(),
                    new global::Letta.JsonConverters.ComparisonOperatorNullableJsonConverter(),
                    new global::Letta.JsonConverters.ConversationModelSettingsVariant1DiscriminatorProviderTypeJsonConverter(),
                    new global::Letta.JsonConverters.ConversationModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ConversationMessageRequestInputVariant2ItemDiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.ConversationMessageRequestInputVariant2ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.CreateAgentRequestToolRulesVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.CreateAgentRequestToolRulesVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderTypeJsonConverter(),
                    new global::Letta.JsonConverters.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.CreateAgentRequestResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.CreateAgentRequestResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.CreateConversationModelSettingsVariant1DiscriminatorProviderTypeJsonConverter(),
                    new global::Letta.JsonConverters.CreateConversationModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.CreateMCPServerRequestConfigDiscriminatorMcpServerTypeJsonConverter(),
                    new global::Letta.JsonConverters.CreateMCPServerRequestConfigDiscriminatorMcpServerTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.DeepseekModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.DeepseekModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.DuplicateFileHandlingJsonConverter(),
                    new global::Letta.JsonConverters.DuplicateFileHandlingNullableJsonConverter(),
                    new global::Letta.JsonConverters.EmbeddingConfigEmbeddingEndpointTypeJsonConverter(),
                    new global::Letta.JsonConverters.EmbeddingConfigEmbeddingEndpointTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.EmbeddingModelEmbeddingEndpointTypeJsonConverter(),
                    new global::Letta.JsonConverters.EmbeddingModelEmbeddingEndpointTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.FeedbackTypeJsonConverter(),
                    new global::Letta.JsonConverters.FeedbackTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.FileProcessingStatusJsonConverter(),
                    new global::Letta.JsonConverters.FileProcessingStatusNullableJsonConverter(),
                    new global::Letta.JsonConverters.GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.GroqModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.GroqModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.GroupCreateManagerConfigDiscriminatorManagerTypeJsonConverter(),
                    new global::Letta.JsonConverters.GroupCreateManagerConfigDiscriminatorManagerTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.GroupSchemaManagerConfigDiscriminatorManagerTypeJsonConverter(),
                    new global::Letta.JsonConverters.GroupSchemaManagerConfigDiscriminatorManagerTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.GroupUpdateManagerConfigVariant1DiscriminatorManagerTypeJsonConverter(),
                    new global::Letta.JsonConverters.GroupUpdateManagerConfigVariant1DiscriminatorManagerTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.HiddenReasoningMessageStateJsonConverter(),
                    new global::Letta.JsonConverters.HiddenReasoningMessageStateNullableJsonConverter(),
                    new global::Letta.JsonConverters.IdentityPropertyTypeJsonConverter(),
                    new global::Letta.JsonConverters.IdentityPropertyTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.IdentityTypeJsonConverter(),
                    new global::Letta.JsonConverters.IdentityTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ImageContentSourceDiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.ImageContentSourceDiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ImageURLDetailJsonConverter(),
                    new global::Letta.JsonConverters.ImageURLDetailNullableJsonConverter(),
                    new global::Letta.JsonConverters.InputAudioFormatJsonConverter(),
                    new global::Letta.JsonConverters.InputAudioFormatNullableJsonConverter(),
                    new global::Letta.JsonConverters.InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderTypeJsonConverter(),
                    new global::Letta.JsonConverters.InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.InternalTemplateAgentCreateResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.InternalTemplateAgentCreateResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerTypeJsonConverter(),
                    new global::Letta.JsonConverters.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.JobStatusJsonConverter(),
                    new global::Letta.JsonConverters.JobStatusNullableJsonConverter(),
                    new global::Letta.JsonConverters.JobTypeJsonConverter(),
                    new global::Letta.JsonConverters.JobTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.LLMConfigModelEndpointTypeJsonConverter(),
                    new global::Letta.JsonConverters.LLMConfigModelEndpointTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.LLMConfigReasoningEffort2JsonConverter(),
                    new global::Letta.JsonConverters.LLMConfigReasoningEffort2NullableJsonConverter(),
                    new global::Letta.JsonConverters.LLMConfigEffort2JsonConverter(),
                    new global::Letta.JsonConverters.LLMConfigEffort2NullableJsonConverter(),
                    new global::Letta.JsonConverters.LLMConfigCompatibilityType2JsonConverter(),
                    new global::Letta.JsonConverters.LLMConfigCompatibilityType2NullableJsonConverter(),
                    new global::Letta.JsonConverters.LLMConfigVerbosity2JsonConverter(),
                    new global::Letta.JsonConverters.LLMConfigVerbosity2NullableJsonConverter(),
                    new global::Letta.JsonConverters.LLMConfigResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.LLMConfigResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.LettaAsyncRequestInputVariant2ItemDiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.LettaAsyncRequestInputVariant2ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.LettaBatchRequestInputVariant2ItemDiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.LettaBatchRequestInputVariant2ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.LettaRequestInputVariant2ItemDiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.LettaRequestInputVariant2ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.LettaStreamingRequestInputVariant2ItemDiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.LettaStreamingRequestInputVariant2ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.LettaStreamingResponseDiscriminatorMessageTypeJsonConverter(),
                    new global::Letta.JsonConverters.LettaStreamingResponseDiscriminatorMessageTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.MCPServerTypeJsonConverter(),
                    new global::Letta.JsonConverters.MCPServerTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ManagerTypeJsonConverter(),
                    new global::Letta.JsonConverters.ManagerTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.MessageContentVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.MessageContentVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.MessageCreateRoleJsonConverter(),
                    new global::Letta.JsonConverters.MessageCreateRoleNullableJsonConverter(),
                    new global::Letta.JsonConverters.MessageRoleJsonConverter(),
                    new global::Letta.JsonConverters.MessageRoleNullableJsonConverter(),
                    new global::Letta.JsonConverters.MessageSearchRequestSearchModeJsonConverter(),
                    new global::Letta.JsonConverters.MessageSearchRequestSearchModeNullableJsonConverter(),
                    new global::Letta.JsonConverters.MessageTypeJsonConverter(),
                    new global::Letta.JsonConverters.MessageTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ModalSandboxConfigLanguageJsonConverter(),
                    new global::Letta.JsonConverters.ModalSandboxConfigLanguageNullableJsonConverter(),
                    new global::Letta.JsonConverters.ModelModelEndpointTypeJsonConverter(),
                    new global::Letta.JsonConverters.ModelModelEndpointTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ModelReasoningEffort2JsonConverter(),
                    new global::Letta.JsonConverters.ModelReasoningEffort2NullableJsonConverter(),
                    new global::Letta.JsonConverters.ModelEffort2JsonConverter(),
                    new global::Letta.JsonConverters.ModelEffort2NullableJsonConverter(),
                    new global::Letta.JsonConverters.ModelCompatibilityType2JsonConverter(),
                    new global::Letta.JsonConverters.ModelCompatibilityType2NullableJsonConverter(),
                    new global::Letta.JsonConverters.ModelVerbosity2JsonConverter(),
                    new global::Letta.JsonConverters.ModelVerbosity2NullableJsonConverter(),
                    new global::Letta.JsonConverters.ModelResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.ModelResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.OpenAIModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.OpenAIModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.OpenAIReasoningReasoningEffortJsonConverter(),
                    new global::Letta.JsonConverters.OpenAIReasoningReasoningEffortNullableJsonConverter(),
                    new global::Letta.JsonConverters.OpenRouterModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.OpenRouterModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PassageSearchRequestTagMatchModeJsonConverter(),
                    new global::Letta.JsonConverters.PassageSearchRequestTagMatchModeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ProviderCategoryJsonConverter(),
                    new global::Letta.JsonConverters.ProviderCategoryNullableJsonConverter(),
                    new global::Letta.JsonConverters.ProviderTypeJsonConverter(),
                    new global::Letta.JsonConverters.ProviderTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ReasoningMessageSourceJsonConverter(),
                    new global::Letta.JsonConverters.ReasoningMessageSourceNullableJsonConverter(),
                    new global::Letta.JsonConverters.RunStatusJsonConverter(),
                    new global::Letta.JsonConverters.RunStatusNullableJsonConverter(),
                    new global::Letta.JsonConverters.SGLangModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.SGLangModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.SandboxTypeJsonConverter(),
                    new global::Letta.JsonConverters.SandboxTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.SearchAllMessagesRequestSearchModeJsonConverter(),
                    new global::Letta.JsonConverters.SearchAllMessagesRequestSearchModeNullableJsonConverter(),
                    new global::Letta.JsonConverters.StepFeedback2JsonConverter(),
                    new global::Letta.JsonConverters.StepFeedback2NullableJsonConverter(),
                    new global::Letta.JsonConverters.StepStatus2JsonConverter(),
                    new global::Letta.JsonConverters.StepStatus2NullableJsonConverter(),
                    new global::Letta.JsonConverters.StopReasonTypeJsonConverter(),
                    new global::Letta.JsonConverters.StopReasonTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.TogetherModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.TogetherModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ToolExecutionResultStatusJsonConverter(),
                    new global::Letta.JsonConverters.ToolExecutionResultStatusNullableJsonConverter(),
                    new global::Letta.JsonConverters.ToolReturnMessageStatusJsonConverter(),
                    new global::Letta.JsonConverters.ToolReturnMessageStatusNullableJsonConverter(),
                    new global::Letta.JsonConverters.ToolSearchRequestSearchModeJsonConverter(),
                    new global::Letta.JsonConverters.ToolSearchRequestSearchModeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ToolTypeJsonConverter(),
                    new global::Letta.JsonConverters.ToolTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.TurnTokenDataRoleJsonConverter(),
                    new global::Letta.JsonConverters.TurnTokenDataRoleNullableJsonConverter(),
                    new global::Letta.JsonConverters.UpdateAgentToolRulesVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.UpdateAgentToolRulesVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.UpdateAgentModelSettingsVariant1DiscriminatorProviderTypeJsonConverter(),
                    new global::Letta.JsonConverters.UpdateAgentModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.UpdateAgentResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.UpdateAgentResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.UpdateConversationModelSettingsVariant1DiscriminatorProviderTypeJsonConverter(),
                    new global::Letta.JsonConverters.UpdateConversationModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.UpdateMCPServerRequestConfigDiscriminatorMcpServerTypeJsonConverter(),
                    new global::Letta.JsonConverters.UpdateMCPServerRequestConfigDiscriminatorMcpServerTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.VectorDBProviderJsonConverter(),
                    new global::Letta.JsonConverters.VectorDBProviderNullableJsonConverter(),
                    new global::Letta.JsonConverters.XAIModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.XAIModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ZAIModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.ZAIModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ZAIThinkingTypeJsonConverter(),
                    new global::Letta.JsonConverters.ZAIThinkingTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderTypeJsonConverter(),
                    new global::Letta.JsonConverters.LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.LettaSchemasAgentFileAgentSchemaResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.LettaSchemasAgentFileAgentSchemaResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.LettaSchemasLettaMessageToolReturnStatusJsonConverter(),
                    new global::Letta.JsonConverters.LettaSchemasLettaMessageToolReturnStatusNullableJsonConverter(),
                    new global::Letta.JsonConverters.LettaSchemasMessageToolReturnInputStatusJsonConverter(),
                    new global::Letta.JsonConverters.LettaSchemasMessageToolReturnInputStatusNullableJsonConverter(),
                    new global::Letta.JsonConverters.LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.LettaSchemasMessageToolReturnOutputStatusJsonConverter(),
                    new global::Letta.JsonConverters.LettaSchemasMessageToolReturnOutputStatusNullableJsonConverter(),
                    new global::Letta.JsonConverters.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.LettaMessageUnionDiscriminatorMessageTypeJsonConverter(),
                    new global::Letta.JsonConverters.LettaMessageUnionDiscriminatorMessageTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.LettaMessageContentUnionDiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.LettaMessageContentUnionDiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.LettaAssistantMessageContentUnionDiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.LettaAssistantMessageContentUnionDiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.LettaToolReturnContentUnionDiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.LettaToolReturnContentUnionDiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.LettaUserMessageContentUnionDiscriminatorTypeJsonConverter(),
                    new global::Letta.JsonConverters.LettaUserMessageContentUnionDiscriminatorTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant1FieldJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant1FieldNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant2FieldJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant2FieldNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant2OperatorJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant2OperatorNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant3FieldJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant3FieldNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant3OperatorJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant3OperatorNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant4FieldJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant4FieldNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant4OperatorJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant4OperatorNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant5FieldJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant5FieldNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant5OperatorJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant5OperatorNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant6FieldJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant6FieldNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant6OperatorJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant6OperatorNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestCombinatorJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestCombinatorNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSortByJsonConverter(),
                    new global::Letta.JsonConverters.AgentsSearchDeployedAgentsRequestSortByNullableJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRoleJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRoleNullableJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRoleJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRoleNullableJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesCreateTemplateNoProjectRequestVariant1TypeJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesCreateTemplateNoProjectRequestVariant1TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesCreateTemplateNoProjectRequestVariant2TypeJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesCreateTemplateNoProjectRequestVariant2TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategyJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategyNullableJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesSaveTemplateVersionRequestBlockReconciliationStrategyJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesSaveTemplateVersionRequestBlockReconciliationStrategyNullableJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesCreateTemplateRequestVariant1TypeJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesCreateTemplateRequestVariant1TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesCreateTemplateRequestVariant2TypeJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesCreateTemplateRequestVariant2TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1TypeJsonConverter(),
                    new global::Letta.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1AccesJsonConverter(),
                    new global::Letta.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1AccesNullableJsonConverter(),
                    new global::Letta.JsonConverters.MetadataSendFeedbackRequestFeatureJsonConverter(),
                    new global::Letta.JsonConverters.MetadataSendFeedbackRequestFeatureNullableJsonConverter(),
                    new global::Letta.JsonConverters.MetadataSendTelemetryRequestServiceJsonConverter(),
                    new global::Letta.JsonConverters.MetadataSendTelemetryRequestServiceNullableJsonConverter(),
                    new global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant1TypeJsonConverter(),
                    new global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant1TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant2TypeJsonConverter(),
                    new global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant2TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant3TypeJsonConverter(),
                    new global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant3TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant4TypeJsonConverter(),
                    new global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant4TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant5TypeJsonConverter(),
                    new global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant5TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1TypeJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceTypeJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2TypeJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageRoleJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageRoleNullableJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageTypeJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageTypeJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1TypeJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2TypeJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesCreatePipelineRequestIntegrationTypeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesCreatePipelineRequestIntegrationTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesCreatePipelineRequestProducerConfigVariant1TypeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesCreatePipelineRequestProducerConfigVariant1TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesCreatePipelineRequestProducerConfigVariant2TypeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesCreatePipelineRequestProducerConfigVariant2TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1TypeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2TypeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesPreviewPipelineRequestIntegrationTypeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesPreviewPipelineRequestIntegrationTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesPreviewPipelineRequestProducerConfigVariant1TypeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesPreviewPipelineRequestProducerConfigVariant1TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesPreviewPipelineRequestProducerConfigVariant2TypeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesPreviewPipelineRequestProducerConfigVariant2TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant1RoleJsonConverter(),
                    new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant1RoleNullableJsonConverter(),
                    new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemTypeJsonConverter(),
                    new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2TypeJsonConverter(),
                    new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1TypeJsonConverter(),
                    new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemTypeJsonConverter(),
                    new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1StatusJsonConverter(),
                    new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1StatusNullableJsonConverter(),
                    new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2TypeJsonConverter(),
                    new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListArchivesOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListArchivesOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListAgentsForArchiveOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListAgentsForArchiveOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListAgentsForArchiveIncludeItemJsonConverter(),
                    new global::Letta.JsonConverters.ListAgentsForArchiveIncludeItemNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListToolsOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListToolsOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListFoldersOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListFoldersOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListAgentsForFolderOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListAgentsForFolderOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListFolderPassagesOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListFolderPassagesOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListFilesForFolderOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListFilesForFolderOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListAgentsIncludeItemJsonConverter(),
                    new global::Letta.JsonConverters.ListAgentsIncludeItemNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListAgentsOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListAgentsOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListAgentsOrderByJsonConverter(),
                    new global::Letta.JsonConverters.ListAgentsOrderByNullableJsonConverter(),
                    new global::Letta.JsonConverters.RetrieveAgentIncludeItemJsonConverter(),
                    new global::Letta.JsonConverters.RetrieveAgentIncludeItemNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListToolsForAgentOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListToolsForAgentOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListAgentSourcesOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListAgentSourcesOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListFoldersForAgentOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListFoldersForAgentOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListFilesForAgentOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListFilesForAgentOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListCoreMemoryBlocksOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListCoreMemoryBlocksOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.SearchArchivalMemoryTagMatchModeJsonConverter(),
                    new global::Letta.JsonConverters.SearchArchivalMemoryTagMatchModeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListMessagesOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListMessagesOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListGroupsForAgentOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListGroupsForAgentOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListConversationsOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListConversationsOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListConversationsOrderByJsonConverter(),
                    new global::Letta.JsonConverters.ListConversationsOrderByNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListConversationMessagesOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListConversationMessagesOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListGroupsOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListGroupsOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListGroupMessagesOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListGroupMessagesOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListIdentitiesOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListIdentitiesOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListAgentsForIdentityOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListAgentsForIdentityOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListAgentsForIdentityIncludeItemJsonConverter(),
                    new global::Letta.JsonConverters.ListAgentsForIdentityIncludeItemNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListBlocksForIdentityOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListBlocksForIdentityOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListInternalBlocksOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListInternalBlocksOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListAgentsForInternalBlockOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListAgentsForInternalBlockOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListInternalRunsOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListInternalRunsOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListInternalRunsOrderByJsonConverter(),
                    new global::Letta.JsonConverters.ListInternalRunsOrderByNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListInternalRunsDurationOperator2JsonConverter(),
                    new global::Letta.JsonConverters.ListInternalRunsDurationOperator2NullableJsonConverter(),
                    new global::Letta.JsonConverters.ListBlocksOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListBlocksOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListAgentsForBlockOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListAgentsForBlockOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListAgentsForBlockIncludeItemJsonConverter(),
                    new global::Letta.JsonConverters.ListAgentsForBlockIncludeItemNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListJobsOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListJobsOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListProvidersOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListProvidersOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListRunsOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListRunsOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListMessagesForRunOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListMessagesForRunOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListStepsForRunOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListStepsForRunOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListStepsOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListStepsOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListStepsFeedback2JsonConverter(),
                    new global::Letta.JsonConverters.ListStepsFeedback2NullableJsonConverter(),
                    new global::Letta.JsonConverters.ListMessagesForStepOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListMessagesForStepOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListTagsOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListTagsOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListAllMessagesOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListAllMessagesOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListBatchesOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListBatchesOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListMessagesForBatchOrderJsonConverter(),
                    new global::Letta.JsonConverters.ListMessagesForBatchOrderNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant1FieldJsonConverter(),
                    new global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant1FieldNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant2FieldJsonConverter(),
                    new global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant2FieldNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant2OperatorJsonConverter(),
                    new global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant2OperatorNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant3FieldJsonConverter(),
                    new global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant3FieldNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant3OperatorJsonConverter(),
                    new global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant3OperatorNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant4FieldJsonConverter(),
                    new global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant4FieldNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant4OperatorJsonConverter(),
                    new global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant4OperatorNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant5FieldJsonConverter(),
                    new global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant5FieldNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant5OperatorJsonConverter(),
                    new global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant5OperatorNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant6FieldJsonConverter(),
                    new global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant6FieldNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant6OperatorJsonConverter(),
                    new global::Letta.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant6OperatorNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsCountDeployedAgentsCombinatorJsonConverter(),
                    new global::Letta.JsonConverters.AgentsCountDeployedAgentsCombinatorNullableJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesListTemplatesSortByJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesListTemplatesSortByNullableJsonConverter(),
                    new global::Letta.JsonConverters.ModifyMessageResponseDiscriminatorMessageTypeJsonConverter(),
                    new global::Letta.JsonConverters.ModifyMessageResponseDiscriminatorMessageTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ModifyGroupMessageResponseDiscriminatorMessageTypeJsonConverter(),
                    new global::Letta.JsonConverters.ModifyGroupMessageResponseDiscriminatorMessageTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ListMessagesForStepResponseItemDiscriminatorMessageTypeJsonConverter(),
                    new global::Letta.JsonConverters.ListMessagesForStepResponseItemDiscriminatorMessageTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.SearchAllMessagesResponseItemDiscriminatorMessageTypeJsonConverter(),
                    new global::Letta.JsonConverters.SearchAllMessagesResponseItemDiscriminatorMessageTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.AgentsGetAgentVariablesResponseMessageJsonConverter(),
                    new global::Letta.JsonConverters.AgentsGetAgentVariablesResponseMessageNullableJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1TypeJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant2TypeJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant2TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3TypeJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4TypeJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5TypeJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6TypeJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7TypeJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8TypeJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9TypeJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentAgentTypeJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentAgentTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevelJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevelNullableJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffortJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffortNullableJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseTypeJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesGetTemplateSnapshotResponseTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyVersionJsonConverter(),
                    new global::Letta.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyVersionNullableJsonConverter(),
                    new global::Letta.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1TypeJsonConverter(),
                    new global::Letta.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1AccesJsonConverter(),
                    new global::Letta.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1AccesNullableJsonConverter(),
                    new global::Letta.JsonConverters.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyVersionJsonConverter(),
                    new global::Letta.JsonConverters.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyVersionNullableJsonConverter(),
                    new global::Letta.JsonConverters.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1TypeJsonConverter(),
                    new global::Letta.JsonConverters.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1AccesJsonConverter(),
                    new global::Letta.JsonConverters.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1AccesNullableJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1TypeJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2SourceTypeJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2SourceTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2TypeJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageRoleJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageRoleNullableJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageTypeJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageTypeJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1TypeJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2TypeJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1TypeJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2SourceTypeJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2SourceTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2TypeJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRoleJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRoleNullableJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageTypeJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageTypeJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1TypeJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant2TypeJsonConverter(),
                    new global::Letta.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant2TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.FeedsSubscribeAgentResponseMergeStrategyJsonConverter(),
                    new global::Letta.JsonConverters.FeedsSubscribeAgentResponseMergeStrategyNullableJsonConverter(),
                    new global::Letta.JsonConverters.FeedsSubscribeAgentResponseErrorCodeJsonConverter(),
                    new global::Letta.JsonConverters.FeedsSubscribeAgentResponseErrorCodeNullableJsonConverter(),
                    new global::Letta.JsonConverters.FeedsUpdateSubscriptionResponseMergeStrategyJsonConverter(),
                    new global::Letta.JsonConverters.FeedsUpdateSubscriptionResponseMergeStrategyNullableJsonConverter(),
                    new global::Letta.JsonConverters.FeedsBackfillSubscriptionResponseErrorCodeJsonConverter(),
                    new global::Letta.JsonConverters.FeedsBackfillSubscriptionResponseErrorCodeNullableJsonConverter(),
                    new global::Letta.JsonConverters.FeedsListSubscriptionHistoryResponseRunTypeJsonConverter(),
                    new global::Letta.JsonConverters.FeedsListSubscriptionHistoryResponseRunTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.FeedsListSubscriptionHistoryResponseRunStatusJsonConverter(),
                    new global::Letta.JsonConverters.FeedsListSubscriptionHistoryResponseRunStatusNullableJsonConverter(),
                    new global::Letta.JsonConverters.FeedsListSubscriptionHistoryResponseErrorCodeJsonConverter(),
                    new global::Letta.JsonConverters.FeedsListSubscriptionHistoryResponseErrorCodeNullableJsonConverter(),
                    new global::Letta.JsonConverters.FeedsListSubscriptionsResponseSubscriptionMergeStrategyJsonConverter(),
                    new global::Letta.JsonConverters.FeedsListSubscriptionsResponseSubscriptionMergeStrategyNullableJsonConverter(),
                    new global::Letta.JsonConverters.MemoryFilesListDirectoryResponseEntrieTypeJsonConverter(),
                    new global::Letta.JsonConverters.MemoryFilesListDirectoryResponseEntrieTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesCreatePipelineResponsePipelineIntegrationTypeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesCreatePipelineResponsePipelineIntegrationTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesCreatePipelineResponsePipelineConfigVariant1TypeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesCreatePipelineResponsePipelineConfigVariant1TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesCreatePipelineResponsePipelineConfigVariant2TypeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesCreatePipelineResponsePipelineConfigVariant2TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesCreatePipelineResponseErrorCodeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesCreatePipelineResponseErrorCodeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesListPipelinesResponsePipelineIntegrationTypeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesListPipelinesResponsePipelineIntegrationTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesListPipelinesResponsePipelineConfigVariant1TypeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesListPipelinesResponsePipelineConfigVariant1TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesListPipelinesResponsePipelineConfigVariant2TypeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesListPipelinesResponsePipelineConfigVariant2TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesGetPipelineResponsePipelineIntegrationTypeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesGetPipelineResponsePipelineIntegrationTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesGetPipelineResponsePipelineConfigVariant1TypeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesGetPipelineResponsePipelineConfigVariant1TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesGetPipelineResponsePipelineConfigVariant2TypeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesGetPipelineResponsePipelineConfigVariant2TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesGetPipelineResponseErrorCodeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesGetPipelineResponseErrorCodeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesUpdatePipelineResponsePipelineIntegrationTypeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesUpdatePipelineResponsePipelineIntegrationTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesUpdatePipelineResponsePipelineConfigVariant1TypeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesUpdatePipelineResponsePipelineConfigVariant1TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesUpdatePipelineResponsePipelineConfigVariant2TypeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesUpdatePipelineResponsePipelineConfigVariant2TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesUpdatePipelineResponseErrorCodeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesUpdatePipelineResponseErrorCodeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesDeletePipelineResponseErrorCodeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesDeletePipelineResponseErrorCodeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationTypeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationTypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1TypeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2TypeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2TypeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponseErrorCodeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponseErrorCodeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponseErrorCode2JsonConverter(),
                    new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponseErrorCode2NullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesPreviewPipelineResponseErrorCodeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesPreviewPipelineResponseErrorCodeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesSyncPipelineResponseErrorCodeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesSyncPipelineResponseErrorCodeNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesSyncPipelineResponseErrorCode2JsonConverter(),
                    new global::Letta.JsonConverters.PipelinesSyncPipelineResponseErrorCode2NullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesListPipelineSyncHistoryResponseRunStatusJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesListPipelineSyncHistoryResponseRunStatusNullableJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesListPipelineSyncHistoryResponseErrorCodeJsonConverter(),
                    new global::Letta.JsonConverters.PipelinesListPipelineSyncHistoryResponseErrorCodeNullableJsonConverter(),
                    new global::Letta.JsonConverters.EnvironmentsGetConnectionResponseCurrentModeJsonConverter(),
                    new global::Letta.JsonConverters.EnvironmentsGetConnectionResponseCurrentModeNullableJsonConverter(),
                    new global::Letta.JsonConverters.EnvironmentsListConnectionsResponseConnectionCurrentModeJsonConverter(),
                    new global::Letta.JsonConverters.EnvironmentsListConnectionsResponseConnectionCurrentModeNullableJsonConverter(),
                    new global::Letta.JsonConverters.SandboxesListSandboxesResponseSandboxeCurrentModeJsonConverter(),
                    new global::Letta.JsonConverters.SandboxesListSandboxesResponseSandboxeCurrentModeNullableJsonConverter(),
                    new global::Letta.JsonConverters.ToolRulesVariant1ItemJsonConverter(),
                    new global::Letta.JsonConverters.ModelSettingsVariant1JsonConverter(),
                    new global::Letta.JsonConverters.ResponseFormatVariant1JsonConverter(),
                    new global::Letta.JsonConverters.ResponseFormatVariant12JsonConverter(),
                    new global::Letta.JsonConverters.ApprovalsVariant1ItemJsonConverter(),
                    new global::Letta.JsonConverters.ApprovalsVariant1Item2JsonConverter(),
                    new global::Letta.JsonConverters.ResponseFormatVariant13JsonConverter(),
                    new global::Letta.JsonConverters.ResponseFormatVariant14JsonConverter(),
                    new global::Letta.JsonConverters.ModelSettingsVariant12JsonConverter(),
                    new global::Letta.JsonConverters.ModelSettingsVariant13JsonConverter(),
                    new global::Letta.JsonConverters.ModelSettingsVariant14JsonConverter(),
                    new global::Letta.JsonConverters.InputVariant2ItemJsonConverter(),
                    new global::Letta.JsonConverters.ToolRulesVariant1Item2JsonConverter(),
                    new global::Letta.JsonConverters.ModelSettingsVariant15JsonConverter(),
                    new global::Letta.JsonConverters.ResponseFormatVariant15JsonConverter(),
                    new global::Letta.JsonConverters.ModelSettingsVariant16JsonConverter(),
                    new global::Letta.JsonConverters.ConfigJsonConverter(),
                    new global::Letta.JsonConverters.ResponseFormatVariant16JsonConverter(),
                    new global::Letta.JsonConverters.ResponseSchemaVariant1JsonConverter(),
                    new global::Letta.JsonConverters.ResponseSchemaVariant12JsonConverter(),
                    new global::Letta.JsonConverters.ResponseFormatVariant17JsonConverter(),
                    new global::Letta.JsonConverters.ManagerConfigJsonConverter(),
                    new global::Letta.JsonConverters.ManagerConfig2JsonConverter(),
                    new global::Letta.JsonConverters.ManagerConfigVariant1JsonConverter(),
                    new global::Letta.JsonConverters.SourceJsonConverter(),
                    new global::Letta.JsonConverters.ToolRulesVariant1Item3JsonConverter(),
                    new global::Letta.JsonConverters.ModelSettingsVariant17JsonConverter(),
                    new global::Letta.JsonConverters.ResponseFormatVariant18JsonConverter(),
                    new global::Letta.JsonConverters.ManagerConfig3JsonConverter(),
                    new global::Letta.JsonConverters.ResponseFormatVariant19JsonConverter(),
                    new global::Letta.JsonConverters.InputVariant2Item2JsonConverter(),
                    new global::Letta.JsonConverters.InputVariant2Item3JsonConverter(),
                    new global::Letta.JsonConverters.InputVariant2Item4JsonConverter(),
                    new global::Letta.JsonConverters.InputVariant2Item5JsonConverter(),
                    new global::Letta.JsonConverters.LettaStreamingResponseJsonConverter(),
                    new global::Letta.JsonConverters.ContentVariant1ItemJsonConverter(),
                    new global::Letta.JsonConverters.ResponseFormatVariant110JsonConverter(),
                    new global::Letta.JsonConverters.ResponseFormatVariant111JsonConverter(),
                    new global::Letta.JsonConverters.ResponseFormatVariant112JsonConverter(),
                    new global::Letta.JsonConverters.ResponseFormatVariant113JsonConverter(),
                    new global::Letta.JsonConverters.ResponseFormatVariant114JsonConverter(),
                    new global::Letta.JsonConverters.ToolRulesVariant1Item4JsonConverter(),
                    new global::Letta.JsonConverters.ModelSettingsVariant18JsonConverter(),
                    new global::Letta.JsonConverters.ResponseFormatVariant115JsonConverter(),
                    new global::Letta.JsonConverters.ModelSettingsVariant19JsonConverter(),
                    new global::Letta.JsonConverters.Config4JsonConverter(),
                    new global::Letta.JsonConverters.ResponseFormatVariant116JsonConverter(),
                    new global::Letta.JsonConverters.ResponseFormatVariant117JsonConverter(),
                    new global::Letta.JsonConverters.ToolRulesVariant1Item5JsonConverter(),
                    new global::Letta.JsonConverters.ModelSettingsVariant110JsonConverter(),
                    new global::Letta.JsonConverters.ResponseFormatVariant118JsonConverter(),
                    new global::Letta.JsonConverters.FuncResponseVariant2ItemJsonConverter(),
                    new global::Letta.JsonConverters.FuncResponseVariant2Item2JsonConverter(),
                    new global::Letta.JsonConverters.LettaMessageUnionJsonConverter(),
                    new global::Letta.JsonConverters.LettaMessageContentUnionJsonConverter(),
                    new global::Letta.JsonConverters.LettaAssistantMessageContentUnionJsonConverter(),
                    new global::Letta.JsonConverters.LettaToolReturnContentUnionJsonConverter(),
                    new global::Letta.JsonConverters.LettaUserMessageContentUnionJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesCreateTemplateNoProjectRequestJsonConverter(),
                    new global::Letta.JsonConverters.TemplatesCreateTemplateRequestJsonConverter(),
                    new global::Letta.JsonConverters.PolicyItemJsonConverter(),
                    new global::Letta.JsonConverters.EventsItemJsonConverter(),
                    new global::Letta.JsonConverters.ProducerConfigJsonConverter(),
                    new global::Letta.JsonConverters.ProducerConfig2JsonConverter(),
                    new global::Letta.JsonConverters.ProducerConfig3JsonConverter(),
                    new global::Letta.JsonConverters.ModifyMessageResponseJsonConverter(),
                    new global::Letta.JsonConverters.ModifyGroupMessageResponseJsonConverter(),
                    new global::Letta.JsonConverters.ListMessagesForStepResponseItemJsonConverter(),
                    new global::Letta.JsonConverters.SearchAllMessagesResponseItemJsonConverter(),
                    new global::Letta.JsonConverters.DataItemJsonConverter(),
                    new global::Letta.JsonConverters.DataItem2JsonConverter(),
                    new global::Letta.JsonConverters.Config5JsonConverter(),
                    new global::Letta.JsonConverters.Config6JsonConverter(),
                    new global::Letta.JsonConverters.Config7JsonConverter(),
                    new global::Letta.JsonConverters.Config8JsonConverter(),
                    new global::Letta.JsonConverters.Config9JsonConverter(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ToolCall2, global::Letta.ToolCallDelta>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.ToolCall2>, global::Letta.ToolCallDelta, object>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaAssistantMessageContentUnion>, string>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaAssistantMessageContentUnion>, string>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartRefusalParam>>, object>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartRefusalParam>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ChatCompletionMessageFunctionToolCallParam, global::Letta.ChatCompletionMessageCustomToolCallParam>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.ChatCompletionContentPartTextParam>>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ChatCompletionMessageFunctionToolCallOutput, global::Letta.ChatCompletionMessageCustomToolCall>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ChatCompletionDeveloperMessageParam, global::Letta.ChatCompletionSystemMessageParam, global::Letta.ChatCompletionUserMessageParam, global::Letta.ChatCompletionAssistantMessageParam, global::Letta.ChatCompletionToolMessageParam, global::Letta.ChatCompletionFunctionMessageParam>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.ChatCompletionContentPartTextParam>>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.ChatCompletionContentPartTextParam>>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartImageParam, global::Letta.ChatCompletionContentPartInputAudioParam, global::Letta.File>>>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartImageParam, global::Letta.ChatCompletionContentPartInputAudioParam, global::Letta.File>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.MessageCreate, global::Letta.ApprovalCreate, global::Letta.ToolReturnCreate>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item>, object>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.MessageCreate, global::Letta.ApprovalCreate, global::Letta.ToolReturnCreate>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item2>, object>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.MessageCreate, global::Letta.ApprovalCreate, global::Letta.ToolReturnCreate>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item3>, object>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.MessageCreate, global::Letta.ApprovalCreate, global::Letta.ToolReturnCreate>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item4>, object>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.MessageCreate, global::Letta.ApprovalCreate, global::Letta.ToolReturnCreate>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item5>, object>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.AgentType?, string, object>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ApprovalReturn, global::Letta.LettaSchemasMessageToolReturnOutput>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaMessageContentUnion>, string>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.LocalSandboxConfig, global::Letta.E2BSandboxConfig, global::Letta.ModalSandboxConfig>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.LocalSandboxConfig, global::Letta.E2BSandboxConfig, global::Letta.ModalSandboxConfig>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ToolCall2, global::Letta.ToolCallDelta>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.ToolCall2>, global::Letta.ToolCallDelta, object>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaAssistantMessageContentUnion>, string>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaUserMessageContentUnion>, string>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaUserMessageContentUnion>, string>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaUserMessageContentUnion>, string>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<string, int?>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaMessageContentUnion>, string>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ApprovalReturn, global::Letta.LettaSchemasMessageToolReturnInput>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaToolReturnContentUnion>, string>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.FuncResponseVariant2Item>, object>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.FuncResponseVariant2Item2>, object>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.BaseToolRuleSchema, global::Letta.ChildToolRuleSchema, global::Letta.MaxCountPerStepToolRuleSchema, global::Letta.ConditionalToolRuleSchema>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.LettaSchemasMcpUpdateStdioMCPServer, global::Letta.LettaSchemasMcpUpdateSSEMCPServer, global::Letta.LettaSchemasMcpUpdateStreamableHTTPMCPServer>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.UpdateSystemMessage, global::Letta.UpdateUserMessage, global::Letta.UpdateReasoningMessage, global::Letta.UpdateAssistantMessage>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.LettaRequest, global::Letta.LettaStreamingRequest>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.UpdateSystemMessage, global::Letta.UpdateUserMessage, global::Letta.UpdateReasoningMessage, global::Letta.UpdateAssistantMessage>(),
                    new global::Letta.JsonConverters.OneOfJsonConverter<global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant1, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant2, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant3, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant4, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant5, global::Letta.AgentsSearchDeployedAgentsRequestSearchItemVariant6>(),
                    new global::Letta.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2>>, string>(),
                    new global::Letta.JsonConverters.OneOfJsonConverter<global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2>(),
                    new global::Letta.JsonConverters.OneOfJsonConverter<global::Letta.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1, global::Letta.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2>(),
                    new global::Letta.JsonConverters.OneOfJsonConverter<global::Letta.EnvironmentsSendMessageRequestMessageVariant1, global::Letta.EnvironmentsSendMessageRequestMessageVariant2>(),
                    new global::Letta.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item>>(),
                    new global::Letta.JsonConverters.OneOfJsonConverter<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1, global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2>(),
                    new global::Letta.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2Item>>(),
                    new global::Letta.JsonConverters.OneOfJsonConverter<global::Letta.AgentsCountDeployedAgentsSearchItemVariant1, global::Letta.AgentsCountDeployedAgentsSearchItemVariant2, global::Letta.AgentsCountDeployedAgentsSearchItemVariant3, global::Letta.AgentsCountDeployedAgentsSearchItemVariant4, global::Letta.AgentsCountDeployedAgentsSearchItemVariant5, global::Letta.AgentsCountDeployedAgentsSearchItemVariant6>(),
                    new global::Letta.JsonConverters.OneOfJsonConverter<string, double?>(),
                    new global::Letta.JsonConverters.OneOfJsonConverter<string, double?>(),
                    new global::Letta.JsonConverters.OneOfJsonConverter<string, double?>(),
                    new global::Letta.JsonConverters.OneOfJsonConverter<string, double?>(),
                    new global::Letta.JsonConverters.OneOfJsonConverter<string, double?>(),
                    new global::Letta.JsonConverters.OneOfJsonConverter<string, double?>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.SSEServerConfig, global::Letta.StdioServerConfig, global::Letta.StreamableHTTPServerConfig>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioMCPServer, global::Letta.SSEMCPServer, global::Letta.StreamableHTTPMCPServer>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioMCPServer, global::Letta.SSEMCPServer, global::Letta.StreamableHTTPMCPServer>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioMCPServer, global::Letta.SSEMCPServer, global::Letta.StreamableHTTPMCPServer>(),
                    new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioMCPServer, global::Letta.SSEMCPServer, global::Letta.StreamableHTTPMCPServer>(),
                    new global::Letta.JsonConverters.OneOfJsonConverter<global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant2, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8, global::Letta.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9>(),
                    new global::Letta.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2>>, string>(),
                    new global::Letta.JsonConverters.OneOfJsonConverter<global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2>(),
                    new global::Letta.JsonConverters.OneOfJsonConverter<global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1, global::Letta.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2>(),
                    new global::Letta.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2>>, string>(),
                    new global::Letta.JsonConverters.OneOfJsonConverter<global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1, global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2>(),
                    new global::Letta.JsonConverters.OneOfJsonConverter<global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1, global::Letta.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant2>(),
                    new global::Letta.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AgentsClient Agents => new AgentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ArchivesClient Archives => new ArchivesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public BlocksClient Blocks => new BlocksClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ChatClient Chat => new ChatClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ClientSideAccessTokensClient ClientSideAccessTokens => new ClientSideAccessTokensClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ConversationsClient Conversations => new ConversationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DeviceStorageClient DeviceStorage => new DeviceStorageClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsClient Embeddings => new EmbeddingsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EnvironmentsClient Environments => new EnvironmentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FeedsClient Feeds => new FeedsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FoldersClient Folders => new FoldersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public HealthClient Health => new HealthClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public InternalAgentsClient InternalAgents => new InternalAgentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public InternalBlocksClient InternalBlocks => new InternalBlocksClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public InternalRunsClient InternalRuns => new InternalRunsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public InternalTemplatesClient InternalTemplates => new InternalTemplatesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public JobsClient Jobs => new JobsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public McpServersClient McpServers => new McpServersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MemoryFilesClient MemoryFiles => new MemoryFilesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MessagesClient Messages => new MessagesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MetadataClient Metadata => new MetadataClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PassagesClient Passages => new PassagesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PipelinesClient Pipelines => new PipelinesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects => new ProjectsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProvidersClient Providers => new ProvidersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RunsClient Runs => new RunsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SandboxesClient Sandboxes => new SandboxesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ScheduledMessagesClient ScheduledMessages => new ScheduledMessagesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StepsClient Steps => new StepsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TagClient Tag => new TagClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TemplatesClient Templates => new TemplatesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ToolsClient Tools => new ToolsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the LettaClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public LettaClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Letta.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Letta.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}