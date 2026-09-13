
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.LettaSchemasMcpUpdateStdioMCPServer, global::Letta.LettaSchemasMcpUpdateSSEMCPServer, global::Letta.LettaSchemasMcpUpdateStreamableHTTPMCPServer>?), TypeInfoPropertyName = "LettaSchemasMcpUpdateStreamableHTTPMCPServer_59793d73c4c9a401")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalRequestMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalsVariant1Item), TypeInfoPropertyName = "ApprovalsVariant1Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalReturn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasLettaMessageToolReturn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalResponseMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalsVariant1Item2), TypeInfoPropertyName = "ApprovalsVariant1Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaAssistantMessageContentUnion), TypeInfoPropertyName = "LettaAssistantMessageContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Base64Image))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaUsageStatistics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.HiddenReasoningMessage))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PipRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MCPServerType), TypeInfoPropertyName = "MCPServerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MCPTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolAnnotations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MCPToolHealth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ContentVariant1Item), TypeInfoPropertyName = "ContentVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaMessageContentUnion), TypeInfoPropertyName = "LettaMessageContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.NpmRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SSEServerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.StdioServerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.StreamableHTTPServerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SummaryMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolType), TypeInfoPropertyName = "ToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.NpmRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaSchemasLettaMessageToolReturn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolReturnMessageStatus), TypeInfoPropertyName = "ToolReturnMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolRunFromSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolSearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolSearchRequestSearchMode), TypeInfoPropertyName = "ToolSearchRequestSearchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaUserMessageContentUnion), TypeInfoPropertyName = "LettaUserMessageContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.LettaToolReturnContentUnion>, string>), TypeInfoPropertyName = "AnyOfIListLettaToolReturnContentUnionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.LettaToolReturnContentUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaToolReturnContentUnion), TypeInfoPropertyName = "LettaToolReturnContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasLettaMessageToolReturnStatus), TypeInfoPropertyName = "LettaSchemasLettaMessageToolReturnStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasMcpUpdateSSEMCPServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasMcpUpdateStdioMCPServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasMcpUpdateStreamableHTTPMCPServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FuncResponseVariant2Item), TypeInfoPropertyName = "FuncResponseVariant2Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FuncResponseVariant2Item2), TypeInfoPropertyName = "FuncResponseVariant2Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaServerRestApiRoutersV1ToolsToolExecuteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaToolReturnContentUnionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaToolReturnContentUnionDiscriminatorType), TypeInfoPropertyName = "LettaToolReturnContentUnionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>), TypeInfoPropertyName = "AnyOfStdioServerConfigSSEServerConfigStreamableHTTPServerConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.LettaSchemasMcpUpdateStdioMCPServer, global::Letta.LettaSchemasMcpUpdateSSEMCPServer, global::Letta.LettaSchemasMcpUpdateStreamableHTTPMCPServer>), TypeInfoPropertyName = "AnyOfLettaSchemasMcpUpdateStdioMCPServerLettaSchemasMcpUpdateSSEMCPServerLettaSchemasMcpUpdateStreamableHTTPMCPServer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListToolsOrder), TypeInfoPropertyName = "ListToolsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ToolSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.SSEServerConfig, global::Letta.StdioServerConfig, global::Letta.StreamableHTTPServerConfig>), TypeInfoPropertyName = "AnyOfSSEServerConfigStdioServerConfigStreamableHTTPServerConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.MCPTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyMessageResponse), TypeInfoPropertyName = "ModifyMessageResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyGroupMessageResponse), TypeInfoPropertyName = "ModifyGroupMessageResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListMessagesForStepResponseItem), TypeInfoPropertyName = "ListMessagesForStepResponseItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalsVariant1Item?), TypeInfoPropertyName = "NullableApprovalsVariant1Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ApprovalsVariant1Item2?), TypeInfoPropertyName = "NullableApprovalsVariant1Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaAssistantMessageContentUnion?), TypeInfoPropertyName = "NullableLettaAssistantMessageContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item?), TypeInfoPropertyName = "NullableInputVariant2Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Source?), TypeInfoPropertyName = "NullableSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ImageContentSourceDiscriminatorType?), TypeInfoPropertyName = "NullableImageContentSourceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item2?), TypeInfoPropertyName = "NullableInputVariant2Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item3?), TypeInfoPropertyName = "NullableInputVariant2Item32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item4?), TypeInfoPropertyName = "NullableInputVariant2Item42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaMessageUnion?), TypeInfoPropertyName = "NullableLettaMessageUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputVariant2Item5?), TypeInfoPropertyName = "NullableInputVariant2Item52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaStreamingResponse?), TypeInfoPropertyName = "NullableLettaStreamingResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MCPServerType?), TypeInfoPropertyName = "NullableMCPServerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ContentVariant1Item?), TypeInfoPropertyName = "NullableContentVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaMessageContentUnion?), TypeInfoPropertyName = "NullableLettaMessageContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolType?), TypeInfoPropertyName = "NullableToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolReturnMessageStatus?), TypeInfoPropertyName = "NullableToolReturnMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ToolSearchRequestSearchMode?), TypeInfoPropertyName = "NullableToolSearchRequestSearchMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaUserMessageContentUnion?), TypeInfoPropertyName = "NullableLettaUserMessageContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.IList<global::Letta.LettaToolReturnContentUnion>, string>?), TypeInfoPropertyName = "NullableAnyOfIListLettaToolReturnContentUnionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaToolReturnContentUnion?), TypeInfoPropertyName = "NullableLettaToolReturnContentUnion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaSchemasLettaMessageToolReturnStatus?), TypeInfoPropertyName = "NullableLettaSchemasLettaMessageToolReturnStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FuncResponseVariant2Item?), TypeInfoPropertyName = "NullableFuncResponseVariant2Item2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FuncResponseVariant2Item2?), TypeInfoPropertyName = "NullableFuncResponseVariant2Item22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaToolReturnContentUnionDiscriminatorType?), TypeInfoPropertyName = "NullableLettaToolReturnContentUnionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>?), TypeInfoPropertyName = "NullableAnyOfStdioServerConfigSSEServerConfigStreamableHTTPServerConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListToolsOrder?), TypeInfoPropertyName = "NullableListToolsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.SSEServerConfig, global::Letta.StdioServerConfig, global::Letta.StreamableHTTPServerConfig>?), TypeInfoPropertyName = "NullableAnyOfSSEServerConfigStdioServerConfigStreamableHTTPServerConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyMessageResponse?), TypeInfoPropertyName = "NullableModifyMessageResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModifyGroupMessageResponse?), TypeInfoPropertyName = "NullableModifyGroupMessageResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListMessagesForStepResponseItem?), TypeInfoPropertyName = "NullableListMessagesForStepResponseItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PipRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.NpmRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaSchemasLettaMessageToolReturn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::System.Collections.Generic.List<global::Letta.LettaToolReturnContentUnion>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.LettaToolReturnContentUnion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ToolSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.MCPTool>))]
    internal sealed partial class ToolsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ToolsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ToolsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaAssistantMessageContentUnion>, string>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaAssistantMessageContentUnion>, string>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item>, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item2>, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item3>, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item4>, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.InputVariant2Item5>, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaMessageContentUnion>, string>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaAssistantMessageContentUnion>, string>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaUserMessageContentUnion>, string>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaUserMessageContentUnion>, string>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaUserMessageContentUnion>, string>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaMessageContentUnion>, string>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Letta.LettaToolReturnContentUnion>, string>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.FuncResponseVariant2Item>, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.FuncResponseVariant2Item2>, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.LettaSchemasMcpUpdateStdioMCPServer, global::Letta.LettaSchemasMcpUpdateSSEMCPServer, global::Letta.LettaSchemasMcpUpdateStreamableHTTPMCPServer>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>());
            options.Converters.Add(new global::Letta.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Letta.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Letta.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Letta.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Letta.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Letta.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.SSEServerConfig, global::Letta.StdioServerConfig, global::Letta.StreamableHTTPServerConfig>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>());
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
                    typeToConvert == typeof(global::Letta.ImageContentSourceDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.ImageContentSourceDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.MCPServerType)

                    || typeToConvert == typeof(global::Letta.MCPServerType?)

                    || typeToConvert == typeof(global::Letta.ToolReturnMessageStatus)

                    || typeToConvert == typeof(global::Letta.ToolReturnMessageStatus?)

                    || typeToConvert == typeof(global::Letta.ToolSearchRequestSearchMode)

                    || typeToConvert == typeof(global::Letta.ToolSearchRequestSearchMode?)

                    || typeToConvert == typeof(global::Letta.ToolType)

                    || typeToConvert == typeof(global::Letta.ToolType?)

                    || typeToConvert == typeof(global::Letta.LettaSchemasLettaMessageToolReturnStatus)

                    || typeToConvert == typeof(global::Letta.LettaSchemasLettaMessageToolReturnStatus?)

                    || typeToConvert == typeof(global::Letta.LettaToolReturnContentUnionDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.LettaToolReturnContentUnionDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.ListToolsOrder)

                    || typeToConvert == typeof(global::Letta.ListToolsOrder?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Letta.ImageContentSourceDiscriminatorType))
                {
                    return new global::Letta.JsonConverters.ImageContentSourceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ImageContentSourceDiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.ImageContentSourceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MCPServerType))
                {
                    return new global::Letta.JsonConverters.MCPServerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MCPServerType?))
                {
                    return new global::Letta.JsonConverters.MCPServerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ToolReturnMessageStatus))
                {
                    return new global::Letta.JsonConverters.ToolReturnMessageStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ToolReturnMessageStatus?))
                {
                    return new global::Letta.JsonConverters.ToolReturnMessageStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ToolSearchRequestSearchMode))
                {
                    return new global::Letta.JsonConverters.ToolSearchRequestSearchModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ToolSearchRequestSearchMode?))
                {
                    return new global::Letta.JsonConverters.ToolSearchRequestSearchModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ToolType))
                {
                    return new global::Letta.JsonConverters.ToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ToolType?))
                {
                    return new global::Letta.JsonConverters.ToolTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LettaSchemasLettaMessageToolReturnStatus))
                {
                    return new global::Letta.JsonConverters.LettaSchemasLettaMessageToolReturnStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LettaSchemasLettaMessageToolReturnStatus?))
                {
                    return new global::Letta.JsonConverters.LettaSchemasLettaMessageToolReturnStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LettaToolReturnContentUnionDiscriminatorType))
                {
                    return new global::Letta.JsonConverters.LettaToolReturnContentUnionDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.LettaToolReturnContentUnionDiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.LettaToolReturnContentUnionDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListToolsOrder))
                {
                    return new global::Letta.JsonConverters.ListToolsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListToolsOrder?))
                {
                    return new global::Letta.JsonConverters.ListToolsOrderNullableJsonConverter();
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
                    0 => new ToolsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}