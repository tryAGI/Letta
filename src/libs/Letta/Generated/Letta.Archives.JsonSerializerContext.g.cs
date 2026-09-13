
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentEnvironmentVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ToolRulesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolRulesVariant1Item), TypeInfoPropertyName = "ToolRulesVariant1Item2_3")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.StopReasonType), TypeInfoPropertyName = "StopReasonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicThinking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "AnthropicModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicModelSettingsVerbosity), TypeInfoPropertyName = "AnthropicModelSettingsVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicModelSettingsEffort), TypeInfoPropertyName = "AnthropicModelSettingsEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicThinkingType), TypeInfoPropertyName = "AnthropicThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.ToolCall2, global::Letta.ToolCallDelta>), TypeInfoPropertyName = "AnyOfToolCall2ToolCallDelta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolCall2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolCallDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.ToolCall2>, global::Letta.ToolCallDelta, object>), TypeInfoPropertyName = "AnyOfIListToolCall2ToolCallDeltaObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ToolCall2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalResponseMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Archive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.VectorDBProvider), TypeInfoPropertyName = "VectorDBProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ArchiveCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ArchiveUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AzureModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AzureModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "AzureModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.BedrockModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.BedrockModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "BedrockModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatGPTOAuthReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatGPTOAuthReasoningReasoningEffort), TypeInfoPropertyName = "ChatGPTOAuthReasoningReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ToolCallNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolCallNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompactionSettingsOutputModelSettingsVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType), TypeInfoPropertyName = "CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompactionSettingsOutputMode), TypeInfoPropertyName = "CompactionSettingsOutputMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolRulesVariant1Item2), TypeInfoPropertyName = "ToolRulesVariant1Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.DeepseekModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.DeepseekModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "DeepseekModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EmbeddingConfigEmbeddingEndpointType), TypeInfoPropertyName = "EmbeddingConfigEmbeddingEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EventMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FileBlock))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ManagerType), TypeInfoPropertyName = "ManagerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.HiddenReasoningMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.IdentityType), TypeInfoPropertyName = "IdentityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.IdentityProperty>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.IdentityProperty))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, int?, double?, bool?, object>), TypeInfoPropertyName = "AnyOfStringInt32DoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.IdentityPropertyType), TypeInfoPropertyName = "IdentityPropertyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolRulesVariant1Item3), TypeInfoPropertyName = "ToolRulesVariant1Item32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LLMConfigModelEndpointType), TypeInfoPropertyName = "LLMConfigModelEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProviderCategory), TypeInfoPropertyName = "ProviderCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LLMConfigReasoningEffort), TypeInfoPropertyName = "LLMConfigReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LLMConfigEffort), TypeInfoPropertyName = "LLMConfigEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LLMConfigCompatibilityType), TypeInfoPropertyName = "LLMConfigCompatibilityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LLMConfigVerbosity), TypeInfoPropertyName = "LLMConfigVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LLMConfigResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LLMConfigResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "LLMConfigResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaErrorMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaPing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaMessageUnion), TypeInfoPropertyName = "LettaMessageUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaStopReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaStreamingResponse), TypeInfoPropertyName = "LettaStreamingResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.UserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ReasoningMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolCallMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolReturnMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PipRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.AgentType?, string, object>), TypeInfoPropertyName = "AnyOfAgentTypeStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.FileBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant110))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.NpmRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenAIReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant111))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenAIModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenAIModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "OpenAIModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenAIReasoningReasoningEffort), TypeInfoPropertyName = "OpenAIReasoningReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant112))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenRouterModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Passage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PassageBatchCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PassageCreateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PassageCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant113))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SGLangModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SGLangModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "SGLangModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SummaryMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant114))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TogetherModelSettingsResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TogetherModelSettingsResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "TogetherModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolType), TypeInfoPropertyName = "ToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.NpmRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolRulesVariant1Item4), TypeInfoPropertyName = "ToolRulesVariant1Item42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant115))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant19))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolRulesVariant1Item5), TypeInfoPropertyName = "ToolRulesVariant1Item52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelSettingsVariant110))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant118))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListArchivesOrder), TypeInfoPropertyName = "ListArchivesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListAgentsForArchiveOrder), TypeInfoPropertyName = "ListAgentsForArchiveOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ListAgentsForArchiveIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListAgentsForArchiveIncludeItem), TypeInfoPropertyName = "ListAgentsForArchiveIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Archive>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AgentState>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Passage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyMessageResponse), TypeInfoPropertyName = "ModifyMessageResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyGroupMessageResponse), TypeInfoPropertyName = "ModifyGroupMessageResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListMessagesForStepResponseItem), TypeInfoPropertyName = "ListMessagesForStepResponseItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolRulesVariant1Item?), TypeInfoPropertyName = "NullableToolRulesVariant1Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentStateToolRulesVariant1ItemDiscriminatorType?), TypeInfoPropertyName = "NullableAgentStateToolRulesVariant1ItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentType?), TypeInfoPropertyName = "NullableAgentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentStateModelSettingsVariant1DiscriminatorProviderType?), TypeInfoPropertyName = "NullableAgentStateModelSettingsVariant1DiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AgentStateResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableAgentStateResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.StopReasonType?), TypeInfoPropertyName = "NullableStopReasonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicModelSettingsResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableAnthropicModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicModelSettingsVerbosity?), TypeInfoPropertyName = "NullableAnthropicModelSettingsVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicModelSettingsEffort?), TypeInfoPropertyName = "NullableAnthropicModelSettingsEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnthropicThinkingType?), TypeInfoPropertyName = "NullableAnthropicThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.ToolCall2, global::Letta.ToolCallDelta>?), TypeInfoPropertyName = "NullableAnyOfToolCall2ToolCallDelta2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.ToolCall2>, global::Letta.ToolCallDelta, object>?), TypeInfoPropertyName = "NullableAnyOfIListToolCall2ToolCallDeltaObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.VectorDBProvider?), TypeInfoPropertyName = "NullableVectorDBProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AzureModelSettingsResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableAzureModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.BedrockModelSettingsResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableBedrockModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatGPTOAuthReasoningReasoningEffort?), TypeInfoPropertyName = "NullableChatGPTOAuthReasoningReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType?), TypeInfoPropertyName = "NullableCompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompactionSettingsOutputMode?), TypeInfoPropertyName = "NullableCompactionSettingsOutputMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolRulesVariant1Item2?), TypeInfoPropertyName = "NullableToolRulesVariant1Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.DeepseekModelSettingsResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableDeepseekModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EmbeddingConfigEmbeddingEndpointType?), TypeInfoPropertyName = "NullableEmbeddingConfigEmbeddingEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableGoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableGoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.GroqModelSettingsResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableGroqModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ManagerType?), TypeInfoPropertyName = "NullableManagerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.IdentityType?), TypeInfoPropertyName = "NullableIdentityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, int?, double?, bool?, object>?), TypeInfoPropertyName = "NullableAnyOfStringInt32DoubleBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.IdentityPropertyType?), TypeInfoPropertyName = "NullableIdentityPropertyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolRulesVariant1Item3?), TypeInfoPropertyName = "NullableToolRulesVariant1Item32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LLMConfigModelEndpointType?), TypeInfoPropertyName = "NullableLLMConfigModelEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProviderCategory?), TypeInfoPropertyName = "NullableProviderCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LLMConfigReasoningEffort?), TypeInfoPropertyName = "NullableLLMConfigReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LLMConfigEffort?), TypeInfoPropertyName = "NullableLLMConfigEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LLMConfigCompatibilityType?), TypeInfoPropertyName = "NullableLLMConfigCompatibilityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LLMConfigVerbosity?), TypeInfoPropertyName = "NullableLLMConfigVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LLMConfigResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableLLMConfigResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaMessageUnion?), TypeInfoPropertyName = "NullableLettaMessageUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaStreamingResponse?), TypeInfoPropertyName = "NullableLettaStreamingResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.AgentType?, string, object>?), TypeInfoPropertyName = "NullableAnyOfAgentTypeStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenAIModelSettingsResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableOpenAIModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenAIReasoningReasoningEffort?), TypeInfoPropertyName = "NullableOpenAIReasoningReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableOpenRouterModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SGLangModelSettingsResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableSGLangModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TogetherModelSettingsResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableTogetherModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolType?), TypeInfoPropertyName = "NullableToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolRulesVariant1Item4?), TypeInfoPropertyName = "NullableToolRulesVariant1Item42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.XAIModelSettingsResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableXAIModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ZAIModelSettingsResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableZAIModelSettingsResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ZAIThinkingType?), TypeInfoPropertyName = "NullableZAIThinkingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolRulesVariant1Item5?), TypeInfoPropertyName = "NullableToolRulesVariant1Item52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListArchivesOrder?), TypeInfoPropertyName = "NullableListArchivesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListAgentsForArchiveOrder?), TypeInfoPropertyName = "NullableListAgentsForArchiveOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListAgentsForArchiveIncludeItem?), TypeInfoPropertyName = "NullableListAgentsForArchiveIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyMessageResponse?), TypeInfoPropertyName = "NullableModifyMessageResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyGroupMessageResponse?), TypeInfoPropertyName = "NullableModifyGroupMessageResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListMessagesForStepResponseItem?), TypeInfoPropertyName = "NullableListMessagesForStepResponseItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ToolRulesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Block>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Source2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AgentEnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Identity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.List<global::Letta.ToolCall2>, global::Letta.ToolCallDelta, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ToolCall2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ToolCallNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.IdentityProperty>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PipRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.FileBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PassageCreateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.NpmRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ListAgentsForArchiveIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Archive>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AgentState>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Passage>))]
    internal sealed partial class ArchivesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ArchivesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ArchivesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ArchivesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Letta.JsonConverters.ToolRulesVariant1ItemJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ModelSettingsVariant1JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant1JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant12JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant13JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant14JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ModelSettingsVariant12JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ModelSettingsVariant13JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ModelSettingsVariant14JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ToolRulesVariant1Item2JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ModelSettingsVariant15JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant15JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ModelSettingsVariant16JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant16JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseSchemaVariant1JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseSchemaVariant12JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant17JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ToolRulesVariant1Item3JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ModelSettingsVariant17JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant18JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant19JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.LettaStreamingResponseJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant110JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant111JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant112JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant113JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant114JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ToolRulesVariant1Item4JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ModelSettingsVariant18JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant115JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ModelSettingsVariant19JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant116JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant117JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ToolRulesVariant1Item5JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ModelSettingsVariant110JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant118JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.LettaMessageUnionJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ModifyMessageResponseJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ModifyGroupMessageResponseJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ListMessagesForStepResponseItemJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ToolCall2, global::Letta.ToolCallDelta>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.ToolCall2>, global::Letta.ToolCallDelta, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.AgentType?, string, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ToolCall2, global::Letta.ToolCallDelta>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.ToolCall2>, global::Letta.ToolCallDelta, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, int?>());
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
                    typeToConvert == typeof(global::Letta.AgentStateToolRulesVariant1ItemDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.AgentStateToolRulesVariant1ItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.AgentStateModelSettingsVariant1DiscriminatorProviderType)

                    || typeToConvert == typeof(global::Letta.AgentStateModelSettingsVariant1DiscriminatorProviderType?)

                    || typeToConvert == typeof(global::Letta.AgentStateResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.AgentStateResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.AgentType)

                    || typeToConvert == typeof(global::Letta.AgentType?)

                    || typeToConvert == typeof(global::Letta.AnthropicModelSettingsResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.AnthropicModelSettingsResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.AnthropicModelSettingsVerbosity)

                    || typeToConvert == typeof(global::Letta.AnthropicModelSettingsVerbosity?)

                    || typeToConvert == typeof(global::Letta.AnthropicModelSettingsEffort)

                    || typeToConvert == typeof(global::Letta.AnthropicModelSettingsEffort?)

                    || typeToConvert == typeof(global::Letta.AnthropicThinkingType)

                    || typeToConvert == typeof(global::Letta.AnthropicThinkingType?)

                    || typeToConvert == typeof(global::Letta.AzureModelSettingsResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.AzureModelSettingsResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.BedrockModelSettingsResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.BedrockModelSettingsResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.ChatGPTOAuthReasoningReasoningEffort)

                    || typeToConvert == typeof(global::Letta.ChatGPTOAuthReasoningReasoningEffort?)

                    || typeToConvert == typeof(global::Letta.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType)

                    || typeToConvert == typeof(global::Letta.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType?)

                    || typeToConvert == typeof(global::Letta.CompactionSettingsOutputMode)

                    || typeToConvert == typeof(global::Letta.CompactionSettingsOutputMode?)

                    || typeToConvert == typeof(global::Letta.DeepseekModelSettingsResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.DeepseekModelSettingsResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.EmbeddingConfigEmbeddingEndpointType)

                    || typeToConvert == typeof(global::Letta.EmbeddingConfigEmbeddingEndpointType?)

                    || typeToConvert == typeof(global::Letta.GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.GroqModelSettingsResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.GroqModelSettingsResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.IdentityPropertyType)

                    || typeToConvert == typeof(global::Letta.IdentityPropertyType?)

                    || typeToConvert == typeof(global::Letta.IdentityType)

                    || typeToConvert == typeof(global::Letta.IdentityType?)

                    || typeToConvert == typeof(global::Letta.LLMConfigModelEndpointType)

                    || typeToConvert == typeof(global::Letta.LLMConfigModelEndpointType?)

                    || typeToConvert == typeof(global::Letta.LLMConfigReasoningEffort)

                    || typeToConvert == typeof(global::Letta.LLMConfigReasoningEffort?)

                    || typeToConvert == typeof(global::Letta.LLMConfigEffort)

                    || typeToConvert == typeof(global::Letta.LLMConfigEffort?)

                    || typeToConvert == typeof(global::Letta.LLMConfigCompatibilityType)

                    || typeToConvert == typeof(global::Letta.LLMConfigCompatibilityType?)

                    || typeToConvert == typeof(global::Letta.LLMConfigVerbosity)

                    || typeToConvert == typeof(global::Letta.LLMConfigVerbosity?)

                    || typeToConvert == typeof(global::Letta.LLMConfigResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.LLMConfigResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.ManagerType)

                    || typeToConvert == typeof(global::Letta.ManagerType?)

                    || typeToConvert == typeof(global::Letta.OpenAIModelSettingsResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.OpenAIModelSettingsResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.OpenAIReasoningReasoningEffort)

                    || typeToConvert == typeof(global::Letta.OpenAIReasoningReasoningEffort?)

                    || typeToConvert == typeof(global::Letta.OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.ProviderCategory)

                    || typeToConvert == typeof(global::Letta.ProviderCategory?)

                    || typeToConvert == typeof(global::Letta.SGLangModelSettingsResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.SGLangModelSettingsResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.StopReasonType)

                    || typeToConvert == typeof(global::Letta.StopReasonType?)

                    || typeToConvert == typeof(global::Letta.TogetherModelSettingsResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.TogetherModelSettingsResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.ToolType)

                    || typeToConvert == typeof(global::Letta.ToolType?)

                    || typeToConvert == typeof(global::Letta.VectorDBProvider)

                    || typeToConvert == typeof(global::Letta.VectorDBProvider?)

                    || typeToConvert == typeof(global::Letta.XAIModelSettingsResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.XAIModelSettingsResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.ZAIModelSettingsResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.ZAIModelSettingsResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.ZAIThinkingType)

                    || typeToConvert == typeof(global::Letta.ZAIThinkingType?)

                    || typeToConvert == typeof(global::Letta.ListArchivesOrder)

                    || typeToConvert == typeof(global::Letta.ListArchivesOrder?)

                    || typeToConvert == typeof(global::Letta.ListAgentsForArchiveOrder)

                    || typeToConvert == typeof(global::Letta.ListAgentsForArchiveOrder?)

                    || typeToConvert == typeof(global::Letta.ListAgentsForArchiveIncludeItem)

                    || typeToConvert == typeof(global::Letta.ListAgentsForArchiveIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Letta.AgentStateToolRulesVariant1ItemDiscriminatorType))
                {
                    return new global::Letta.JsonConverters.AgentStateToolRulesVariant1ItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.AgentStateToolRulesVariant1ItemDiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.AgentStateToolRulesVariant1ItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.AgentStateModelSettingsVariant1DiscriminatorProviderType))
                {
                    return new global::Letta.JsonConverters.AgentStateModelSettingsVariant1DiscriminatorProviderTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.AgentStateModelSettingsVariant1DiscriminatorProviderType?))
                {
                    return new global::Letta.JsonConverters.AgentStateModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.AgentStateResponseFormatVariant1DiscriminatorType))
                {
                    return new global::Letta.JsonConverters.AgentStateResponseFormatVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.AgentStateResponseFormatVariant1DiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.AgentStateResponseFormatVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.AgentType))
                {
                    return new global::Letta.JsonConverters.AgentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.AgentType?))
                {
                    return new global::Letta.JsonConverters.AgentTypeNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::Letta.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType))
                {
                    return new global::Letta.JsonConverters.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType?))
                {
                    return new global::Letta.JsonConverters.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.CompactionSettingsOutputMode))
                {
                    return new global::Letta.JsonConverters.CompactionSettingsOutputModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.CompactionSettingsOutputMode?))
                {
                    return new global::Letta.JsonConverters.CompactionSettingsOutputModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.DeepseekModelSettingsResponseFormatVariant1DiscriminatorType))
                {
                    return new global::Letta.JsonConverters.DeepseekModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.DeepseekModelSettingsResponseFormatVariant1DiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.DeepseekModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.EmbeddingConfigEmbeddingEndpointType))
                {
                    return new global::Letta.JsonConverters.EmbeddingConfigEmbeddingEndpointTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.EmbeddingConfigEmbeddingEndpointType?))
                {
                    return new global::Letta.JsonConverters.EmbeddingConfigEmbeddingEndpointTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Letta.IdentityPropertyType))
                {
                    return new global::Letta.JsonConverters.IdentityPropertyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.IdentityPropertyType?))
                {
                    return new global::Letta.JsonConverters.IdentityPropertyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.IdentityType))
                {
                    return new global::Letta.JsonConverters.IdentityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.IdentityType?))
                {
                    return new global::Letta.JsonConverters.IdentityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LLMConfigModelEndpointType))
                {
                    return new global::Letta.JsonConverters.LLMConfigModelEndpointTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LLMConfigModelEndpointType?))
                {
                    return new global::Letta.JsonConverters.LLMConfigModelEndpointTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LLMConfigReasoningEffort))
                {
                    return new global::Letta.JsonConverters.LLMConfigReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LLMConfigReasoningEffort?))
                {
                    return new global::Letta.JsonConverters.LLMConfigReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LLMConfigEffort))
                {
                    return new global::Letta.JsonConverters.LLMConfigEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LLMConfigEffort?))
                {
                    return new global::Letta.JsonConverters.LLMConfigEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LLMConfigCompatibilityType))
                {
                    return new global::Letta.JsonConverters.LLMConfigCompatibilityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LLMConfigCompatibilityType?))
                {
                    return new global::Letta.JsonConverters.LLMConfigCompatibilityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LLMConfigVerbosity))
                {
                    return new global::Letta.JsonConverters.LLMConfigVerbosityJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LLMConfigVerbosity?))
                {
                    return new global::Letta.JsonConverters.LLMConfigVerbosityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LLMConfigResponseFormatVariant1DiscriminatorType))
                {
                    return new global::Letta.JsonConverters.LLMConfigResponseFormatVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LLMConfigResponseFormatVariant1DiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.LLMConfigResponseFormatVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ManagerType))
                {
                    return new global::Letta.JsonConverters.ManagerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ManagerType?))
                {
                    return new global::Letta.JsonConverters.ManagerTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Letta.ProviderCategory))
                {
                    return new global::Letta.JsonConverters.ProviderCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ProviderCategory?))
                {
                    return new global::Letta.JsonConverters.ProviderCategoryNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Letta.ToolType))
                {
                    return new global::Letta.JsonConverters.ToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ToolType?))
                {
                    return new global::Letta.JsonConverters.ToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.VectorDBProvider))
                {
                    return new global::Letta.JsonConverters.VectorDBProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.VectorDBProvider?))
                {
                    return new global::Letta.JsonConverters.VectorDBProviderNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Letta.ListArchivesOrder))
                {
                    return new global::Letta.JsonConverters.ListArchivesOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListArchivesOrder?))
                {
                    return new global::Letta.JsonConverters.ListArchivesOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListAgentsForArchiveOrder))
                {
                    return new global::Letta.JsonConverters.ListAgentsForArchiveOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListAgentsForArchiveOrder?))
                {
                    return new global::Letta.JsonConverters.ListAgentsForArchiveOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListAgentsForArchiveIncludeItem))
                {
                    return new global::Letta.JsonConverters.ListAgentsForArchiveIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListAgentsForArchiveIncludeItem?))
                {
                    return new global::Letta.JsonConverters.ListAgentsForArchiveIncludeItemNullableJsonConverter();
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
                    0 => new ArchivesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}