
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionDeveloperMessageParam, global::Letta.ChatCompletionSystemMessageParam, global::Letta.ChatCompletionUserMessageParam, global::Letta.ChatCompletionAssistantMessageParam, global::Letta.ChatCompletionToolMessageParam, global::Letta.ChatCompletionFunctionMessageParam>>), TypeInfoPropertyName = "ChatCompletionFunctionMessageParam_ca7935fffee39e82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.ChatCompletionDeveloperMessageParam, global::Letta.ChatCompletionSystemMessageParam, global::Letta.ChatCompletionUserMessageParam, global::Letta.ChatCompletionAssistantMessageParam, global::Letta.ChatCompletionToolMessageParam, global::Letta.ChatCompletionFunctionMessageParam>), TypeInfoPropertyName = "ChatCompletionFunctionMessageParam_1e9257f4f8dba400")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartImageParam, global::Letta.ChatCompletionContentPartInputAudioParam, global::Letta.File>>>), TypeInfoPropertyName = "File_cb3024b51b6c9ac5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartImageParam, global::Letta.ChatCompletionContentPartInputAudioParam, global::Letta.File>>), TypeInfoPropertyName = "File_d8443727f0d0270d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.ChatCompletionDeveloperMessageParam, global::Letta.ChatCompletionSystemMessageParam, global::Letta.ChatCompletionUserMessageParam, global::Letta.ChatCompletionAssistantMessageParam, global::Letta.ChatCompletionToolMessageParam, global::Letta.ChatCompletionFunctionMessageParam>?), TypeInfoPropertyName = "ChatCompletionFunctionMessageParam_cd4d3401d5ca00f1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartImageParam, global::Letta.ChatCompletionContentPartInputAudioParam, global::Letta.File>>>?), TypeInfoPropertyName = "File_e9c6c062abc477cd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartImageParam, global::Letta.ChatCompletionContentPartInputAudioParam, global::Letta.File>?), TypeInfoPropertyName = "File_1e8f4048b580c962")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<global::Letta.ChatCompletionDeveloperMessageParam, global::Letta.ChatCompletionSystemMessageParam, global::Letta.ChatCompletionUserMessageParam, global::Letta.ChatCompletionAssistantMessageParam, global::Letta.ChatCompletionToolMessageParam, global::Letta.ChatCompletionFunctionMessageParam>>), TypeInfoPropertyName = "ChatCompletionFunctionMessageParam_89f40afe39b5fbf2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.List<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartImageParam, global::Letta.ChatCompletionContentPartInputAudioParam, global::Letta.File>>>), TypeInfoPropertyName = "File_113a2a99f9cdcbec")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartImageParam, global::Letta.ChatCompletionContentPartInputAudioParam, global::Letta.File>>), TypeInfoPropertyName = "File_1fcc3a01e189db52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Annotation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnnotationURLCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Audio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Choice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Choice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionServiceTier), TypeInfoPropertyName = "ChatCompletionServiceTier2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FunctionOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenaiTypesChatChatCompletionMessageFunctionToolCallParamFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionSystemMessageParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionUserMessageParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionToolMessageParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.IList<string>, object>), TypeInfoPropertyName = "AnyOfStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartImageParam, global::Letta.ChatCompletionContentPartInputAudioParam, global::Letta.File>), TypeInfoPropertyName = "AnyOfChatCompletionContentPartTextParamChatCompletionContentPartImageParamChatCompletionContentPartInputAudioParamFile2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.File))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChoiceFinishReason), TypeInfoPropertyName = "ChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenaiTypesChatChatCompletionChoiceLogprobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.CompletionTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FileFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ImageURLDetail), TypeInfoPropertyName = "ImageURLDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputAudioFormat), TypeInfoPropertyName = "InputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.OpenaiTypesChatChatCompletionTokenLogprobChatCompletionTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenaiTypesChatChatCompletionTokenLogprobChatCompletionTokenLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.OpenaiTypesChatChatCompletionTokenLogprobTopLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OpenaiTypesChatChatCompletionTokenLogprobTopLogprob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChatCompletionServiceTier?), TypeInfoPropertyName = "NullableChatCompletionServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartRefusalParam>>, object>?), TypeInfoPropertyName = "NullableAnyOfStringIListAnyOfChatCompletionContentPartTextParamChatCompletionContentPartRefusalParamObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartRefusalParam>?), TypeInfoPropertyName = "NullableAnyOfChatCompletionContentPartTextParamChatCompletionContentPartRefusalParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.ChatCompletionMessageFunctionToolCallParam, global::Letta.ChatCompletionMessageCustomToolCallParam>?), TypeInfoPropertyName = "NullableAnyOfChatCompletionMessageFunctionToolCallParamChatCompletionMessageCustomToolCallParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.IList<global::Letta.ChatCompletionContentPartTextParam>>?), TypeInfoPropertyName = "NullableAnyOfStringIListChatCompletionContentPartTextParam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<global::Letta.ChatCompletionMessageFunctionToolCallOutput, global::Letta.ChatCompletionMessageCustomToolCall>?), TypeInfoPropertyName = "NullableAnyOfChatCompletionMessageFunctionToolCallOutputChatCompletionMessageCustomToolCall2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.IList<string>, object>?), TypeInfoPropertyName = "NullableAnyOfStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ChoiceFinishReason?), TypeInfoPropertyName = "NullableChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ImageURLDetail?), TypeInfoPropertyName = "NullableImageURLDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.InputAudioFormat?), TypeInfoPropertyName = "NullableInputAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Choice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.List<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartRefusalParam>>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartRefusalParam>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<global::Letta.ChatCompletionMessageFunctionToolCallParam, global::Letta.ChatCompletionMessageCustomToolCallParam>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.List<global::Letta.ChatCompletionContentPartTextParam>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ChatCompletionContentPartTextParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Annotation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<global::Letta.ChatCompletionMessageFunctionToolCallOutput, global::Letta.ChatCompletionMessageCustomToolCall>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.OpenaiTypesChatChatCompletionTokenLogprobChatCompletionTokenLogprob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.OpenaiTypesChatChatCompletionTokenLogprobTopLogprob>))]
    internal sealed partial class ChatSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ChatSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ChatSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartRefusalParam>>, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartRefusalParam>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ChatCompletionMessageFunctionToolCallParam, global::Letta.ChatCompletionMessageCustomToolCallParam>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.ChatCompletionContentPartTextParam>>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ChatCompletionMessageFunctionToolCallOutput, global::Letta.ChatCompletionMessageCustomToolCall>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ChatCompletionDeveloperMessageParam, global::Letta.ChatCompletionSystemMessageParam, global::Letta.ChatCompletionUserMessageParam, global::Letta.ChatCompletionAssistantMessageParam, global::Letta.ChatCompletionToolMessageParam, global::Letta.ChatCompletionFunctionMessageParam>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.ChatCompletionContentPartTextParam>>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.ChatCompletionContentPartTextParam>>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.AnyOf<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartImageParam, global::Letta.ChatCompletionContentPartInputAudioParam, global::Letta.File>>>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<global::Letta.ChatCompletionContentPartTextParam, global::Letta.ChatCompletionContentPartImageParam, global::Letta.ChatCompletionContentPartInputAudioParam, global::Letta.File>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>());
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
                    typeToConvert == typeof(global::Letta.ChatCompletionServiceTier)

                    || typeToConvert == typeof(global::Letta.ChatCompletionServiceTier?)

                    || typeToConvert == typeof(global::Letta.ChoiceFinishReason)

                    || typeToConvert == typeof(global::Letta.ChoiceFinishReason?)

                    || typeToConvert == typeof(global::Letta.ImageURLDetail)

                    || typeToConvert == typeof(global::Letta.ImageURLDetail?)

                    || typeToConvert == typeof(global::Letta.InputAudioFormat)

                    || typeToConvert == typeof(global::Letta.InputAudioFormat?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Letta.ChatCompletionServiceTier))
                {
                    return new global::Letta.JsonConverters.ChatCompletionServiceTierJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ChatCompletionServiceTier?))
                {
                    return new global::Letta.JsonConverters.ChatCompletionServiceTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ChoiceFinishReason))
                {
                    return new global::Letta.JsonConverters.ChoiceFinishReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ChoiceFinishReason?))
                {
                    return new global::Letta.JsonConverters.ChoiceFinishReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ImageURLDetail))
                {
                    return new global::Letta.JsonConverters.ImageURLDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ImageURLDetail?))
                {
                    return new global::Letta.JsonConverters.ImageURLDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.InputAudioFormat))
                {
                    return new global::Letta.JsonConverters.InputAudioFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.InputAudioFormat?))
                {
                    return new global::Letta.JsonConverters.InputAudioFormatNullableJsonConverter();
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
                    0 => new ChatSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}