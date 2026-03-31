#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ModelSettingsVariant19 : global::System.IEquatable<ModelSettingsVariant19>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Letta.UpdateConversationModelSettingsVariant1DiscriminatorProviderType? ProviderType { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.OpenAIModelSettings? Openai { get; init; }
#else
        public global::Letta.OpenAIModelSettings? Openai { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Openai))]
#endif
        public bool IsOpenai => Openai != null;

        /// <summary>
        /// SGLang model configuration (OpenAI-compatible runtime with SGLang-specific parsing).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.SGLangModelSettings? Sglang { get; init; }
#else
        public global::Letta.SGLangModelSettings? Sglang { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sglang))]
#endif
        public bool IsSglang => Sglang != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.AnthropicModelSettings? Anthropic { get; init; }
#else
        public global::Letta.AnthropicModelSettings? Anthropic { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Anthropic))]
#endif
        public bool IsAnthropic => Anthropic != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.GoogleAIModelSettings? GoogleAi { get; init; }
#else
        public global::Letta.GoogleAIModelSettings? GoogleAi { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleAi))]
#endif
        public bool IsGoogleAi => GoogleAi != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.GoogleVertexModelSettings? GoogleVertex { get; init; }
#else
        public global::Letta.GoogleVertexModelSettings? GoogleVertex { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleVertex))]
#endif
        public bool IsGoogleVertex => GoogleVertex != null;

        /// <summary>
        /// Azure OpenAI model configuration (OpenAI-compatible).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.AzureModelSettings? Azure { get; init; }
#else
        public global::Letta.AzureModelSettings? Azure { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Azure))]
#endif
        public bool IsAzure => Azure != null;

        /// <summary>
        /// xAI model configuration (OpenAI-compatible).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.XAIModelSettings? Xai { get; init; }
#else
        public global::Letta.XAIModelSettings? Xai { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Xai))]
#endif
        public bool IsXai => Xai != null;

        /// <summary>
        /// Z.ai (ZhipuAI) model configuration (OpenAI-compatible).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.ZAIModelSettings? Zai { get; init; }
#else
        public global::Letta.ZAIModelSettings? Zai { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Zai))]
#endif
        public bool IsZai => Zai != null;

        /// <summary>
        /// Groq model configuration (OpenAI-compatible).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.GroqModelSettings? Groq { get; init; }
#else
        public global::Letta.GroqModelSettings? Groq { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Groq))]
#endif
        public bool IsGroq => Groq != null;

        /// <summary>
        /// Deepseek model configuration (OpenAI-compatible).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.DeepseekModelSettings? Deepseek { get; init; }
#else
        public global::Letta.DeepseekModelSettings? Deepseek { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Deepseek))]
#endif
        public bool IsDeepseek => Deepseek != null;

        /// <summary>
        /// Together AI model configuration (OpenAI-compatible).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.TogetherModelSettings? Together { get; init; }
#else
        public global::Letta.TogetherModelSettings? Together { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Together))]
#endif
        public bool IsTogether => Together != null;

        /// <summary>
        /// AWS Bedrock model configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.BedrockModelSettings? Bedrock { get; init; }
#else
        public global::Letta.BedrockModelSettings? Bedrock { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Bedrock))]
#endif
        public bool IsBedrock => Bedrock != null;

        /// <summary>
        /// Baseten model configuration (OpenAI-compatible).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.BasetenModelSettings? Baseten { get; init; }
#else
        public global::Letta.BasetenModelSettings? Baseten { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Baseten))]
#endif
        public bool IsBaseten => Baseten != null;

        /// <summary>
        /// OpenRouter model configuration (OpenAI-compatible).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.OpenRouterModelSettings? Openrouter { get; init; }
#else
        public global::Letta.OpenRouterModelSettings? Openrouter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Openrouter))]
#endif
        public bool IsOpenrouter => Openrouter != null;

        /// <summary>
        /// ChatGPT OAuth model configuration (uses ChatGPT backend API).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.ChatGPTOAuthModelSettings? ChatgptOauth { get; init; }
#else
        public global::Letta.ChatGPTOAuthModelSettings? ChatgptOauth { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatgptOauth))]
#endif
        public bool IsChatgptOauth => ChatgptOauth != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant19(global::Letta.OpenAIModelSettings value) => new ModelSettingsVariant19((global::Letta.OpenAIModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.OpenAIModelSettings?(ModelSettingsVariant19 @this) => @this.Openai;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant19(global::Letta.OpenAIModelSettings? value)
        {
            Openai = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant19(global::Letta.SGLangModelSettings value) => new ModelSettingsVariant19((global::Letta.SGLangModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.SGLangModelSettings?(ModelSettingsVariant19 @this) => @this.Sglang;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant19(global::Letta.SGLangModelSettings? value)
        {
            Sglang = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant19(global::Letta.AnthropicModelSettings value) => new ModelSettingsVariant19((global::Letta.AnthropicModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.AnthropicModelSettings?(ModelSettingsVariant19 @this) => @this.Anthropic;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant19(global::Letta.AnthropicModelSettings? value)
        {
            Anthropic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant19(global::Letta.GoogleAIModelSettings value) => new ModelSettingsVariant19((global::Letta.GoogleAIModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.GoogleAIModelSettings?(ModelSettingsVariant19 @this) => @this.GoogleAi;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant19(global::Letta.GoogleAIModelSettings? value)
        {
            GoogleAi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant19(global::Letta.GoogleVertexModelSettings value) => new ModelSettingsVariant19((global::Letta.GoogleVertexModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.GoogleVertexModelSettings?(ModelSettingsVariant19 @this) => @this.GoogleVertex;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant19(global::Letta.GoogleVertexModelSettings? value)
        {
            GoogleVertex = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant19(global::Letta.AzureModelSettings value) => new ModelSettingsVariant19((global::Letta.AzureModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.AzureModelSettings?(ModelSettingsVariant19 @this) => @this.Azure;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant19(global::Letta.AzureModelSettings? value)
        {
            Azure = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant19(global::Letta.XAIModelSettings value) => new ModelSettingsVariant19((global::Letta.XAIModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.XAIModelSettings?(ModelSettingsVariant19 @this) => @this.Xai;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant19(global::Letta.XAIModelSettings? value)
        {
            Xai = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant19(global::Letta.ZAIModelSettings value) => new ModelSettingsVariant19((global::Letta.ZAIModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.ZAIModelSettings?(ModelSettingsVariant19 @this) => @this.Zai;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant19(global::Letta.ZAIModelSettings? value)
        {
            Zai = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant19(global::Letta.GroqModelSettings value) => new ModelSettingsVariant19((global::Letta.GroqModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.GroqModelSettings?(ModelSettingsVariant19 @this) => @this.Groq;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant19(global::Letta.GroqModelSettings? value)
        {
            Groq = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant19(global::Letta.DeepseekModelSettings value) => new ModelSettingsVariant19((global::Letta.DeepseekModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.DeepseekModelSettings?(ModelSettingsVariant19 @this) => @this.Deepseek;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant19(global::Letta.DeepseekModelSettings? value)
        {
            Deepseek = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant19(global::Letta.TogetherModelSettings value) => new ModelSettingsVariant19((global::Letta.TogetherModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.TogetherModelSettings?(ModelSettingsVariant19 @this) => @this.Together;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant19(global::Letta.TogetherModelSettings? value)
        {
            Together = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant19(global::Letta.BedrockModelSettings value) => new ModelSettingsVariant19((global::Letta.BedrockModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.BedrockModelSettings?(ModelSettingsVariant19 @this) => @this.Bedrock;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant19(global::Letta.BedrockModelSettings? value)
        {
            Bedrock = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant19(global::Letta.BasetenModelSettings value) => new ModelSettingsVariant19((global::Letta.BasetenModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.BasetenModelSettings?(ModelSettingsVariant19 @this) => @this.Baseten;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant19(global::Letta.BasetenModelSettings? value)
        {
            Baseten = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant19(global::Letta.OpenRouterModelSettings value) => new ModelSettingsVariant19((global::Letta.OpenRouterModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.OpenRouterModelSettings?(ModelSettingsVariant19 @this) => @this.Openrouter;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant19(global::Letta.OpenRouterModelSettings? value)
        {
            Openrouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelSettingsVariant19(global::Letta.ChatGPTOAuthModelSettings value) => new ModelSettingsVariant19((global::Letta.ChatGPTOAuthModelSettings?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.ChatGPTOAuthModelSettings?(ModelSettingsVariant19 @this) => @this.ChatgptOauth;

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant19(global::Letta.ChatGPTOAuthModelSettings? value)
        {
            ChatgptOauth = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ModelSettingsVariant19(
            global::Letta.UpdateConversationModelSettingsVariant1DiscriminatorProviderType? providerType,
            global::Letta.OpenAIModelSettings? openai,
            global::Letta.SGLangModelSettings? sglang,
            global::Letta.AnthropicModelSettings? anthropic,
            global::Letta.GoogleAIModelSettings? googleAi,
            global::Letta.GoogleVertexModelSettings? googleVertex,
            global::Letta.AzureModelSettings? azure,
            global::Letta.XAIModelSettings? xai,
            global::Letta.ZAIModelSettings? zai,
            global::Letta.GroqModelSettings? groq,
            global::Letta.DeepseekModelSettings? deepseek,
            global::Letta.TogetherModelSettings? together,
            global::Letta.BedrockModelSettings? bedrock,
            global::Letta.BasetenModelSettings? baseten,
            global::Letta.OpenRouterModelSettings? openrouter,
            global::Letta.ChatGPTOAuthModelSettings? chatgptOauth
            )
        {
            ProviderType = providerType;

            Openai = openai;
            Sglang = sglang;
            Anthropic = anthropic;
            GoogleAi = googleAi;
            GoogleVertex = googleVertex;
            Azure = azure;
            Xai = xai;
            Zai = zai;
            Groq = groq;
            Deepseek = deepseek;
            Together = together;
            Bedrock = bedrock;
            Baseten = baseten;
            Openrouter = openrouter;
            ChatgptOauth = chatgptOauth;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatgptOauth as object ??
            Openrouter as object ??
            Baseten as object ??
            Bedrock as object ??
            Together as object ??
            Deepseek as object ??
            Groq as object ??
            Zai as object ??
            Xai as object ??
            Azure as object ??
            GoogleVertex as object ??
            GoogleAi as object ??
            Anthropic as object ??
            Sglang as object ??
            Openai as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Openai?.ToString() ??
            Sglang?.ToString() ??
            Anthropic?.ToString() ??
            GoogleAi?.ToString() ??
            GoogleVertex?.ToString() ??
            Azure?.ToString() ??
            Xai?.ToString() ??
            Zai?.ToString() ??
            Groq?.ToString() ??
            Deepseek?.ToString() ??
            Together?.ToString() ??
            Bedrock?.ToString() ??
            Baseten?.ToString() ??
            Openrouter?.ToString() ??
            ChatgptOauth?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenai && !IsSglang && !IsAnthropic && !IsGoogleAi && !IsGoogleVertex && !IsAzure && !IsXai && !IsZai && !IsGroq && !IsDeepseek && !IsTogether && !IsBedrock && !IsBaseten && !IsOpenrouter && !IsChatgptOauth || !IsOpenai && IsSglang && !IsAnthropic && !IsGoogleAi && !IsGoogleVertex && !IsAzure && !IsXai && !IsZai && !IsGroq && !IsDeepseek && !IsTogether && !IsBedrock && !IsBaseten && !IsOpenrouter && !IsChatgptOauth || !IsOpenai && !IsSglang && IsAnthropic && !IsGoogleAi && !IsGoogleVertex && !IsAzure && !IsXai && !IsZai && !IsGroq && !IsDeepseek && !IsTogether && !IsBedrock && !IsBaseten && !IsOpenrouter && !IsChatgptOauth || !IsOpenai && !IsSglang && !IsAnthropic && IsGoogleAi && !IsGoogleVertex && !IsAzure && !IsXai && !IsZai && !IsGroq && !IsDeepseek && !IsTogether && !IsBedrock && !IsBaseten && !IsOpenrouter && !IsChatgptOauth || !IsOpenai && !IsSglang && !IsAnthropic && !IsGoogleAi && IsGoogleVertex && !IsAzure && !IsXai && !IsZai && !IsGroq && !IsDeepseek && !IsTogether && !IsBedrock && !IsBaseten && !IsOpenrouter && !IsChatgptOauth || !IsOpenai && !IsSglang && !IsAnthropic && !IsGoogleAi && !IsGoogleVertex && IsAzure && !IsXai && !IsZai && !IsGroq && !IsDeepseek && !IsTogether && !IsBedrock && !IsBaseten && !IsOpenrouter && !IsChatgptOauth || !IsOpenai && !IsSglang && !IsAnthropic && !IsGoogleAi && !IsGoogleVertex && !IsAzure && IsXai && !IsZai && !IsGroq && !IsDeepseek && !IsTogether && !IsBedrock && !IsBaseten && !IsOpenrouter && !IsChatgptOauth || !IsOpenai && !IsSglang && !IsAnthropic && !IsGoogleAi && !IsGoogleVertex && !IsAzure && !IsXai && IsZai && !IsGroq && !IsDeepseek && !IsTogether && !IsBedrock && !IsBaseten && !IsOpenrouter && !IsChatgptOauth || !IsOpenai && !IsSglang && !IsAnthropic && !IsGoogleAi && !IsGoogleVertex && !IsAzure && !IsXai && !IsZai && IsGroq && !IsDeepseek && !IsTogether && !IsBedrock && !IsBaseten && !IsOpenrouter && !IsChatgptOauth || !IsOpenai && !IsSglang && !IsAnthropic && !IsGoogleAi && !IsGoogleVertex && !IsAzure && !IsXai && !IsZai && !IsGroq && IsDeepseek && !IsTogether && !IsBedrock && !IsBaseten && !IsOpenrouter && !IsChatgptOauth || !IsOpenai && !IsSglang && !IsAnthropic && !IsGoogleAi && !IsGoogleVertex && !IsAzure && !IsXai && !IsZai && !IsGroq && !IsDeepseek && IsTogether && !IsBedrock && !IsBaseten && !IsOpenrouter && !IsChatgptOauth || !IsOpenai && !IsSglang && !IsAnthropic && !IsGoogleAi && !IsGoogleVertex && !IsAzure && !IsXai && !IsZai && !IsGroq && !IsDeepseek && !IsTogether && IsBedrock && !IsBaseten && !IsOpenrouter && !IsChatgptOauth || !IsOpenai && !IsSglang && !IsAnthropic && !IsGoogleAi && !IsGoogleVertex && !IsAzure && !IsXai && !IsZai && !IsGroq && !IsDeepseek && !IsTogether && !IsBedrock && IsBaseten && !IsOpenrouter && !IsChatgptOauth || !IsOpenai && !IsSglang && !IsAnthropic && !IsGoogleAi && !IsGoogleVertex && !IsAzure && !IsXai && !IsZai && !IsGroq && !IsDeepseek && !IsTogether && !IsBedrock && !IsBaseten && IsOpenrouter && !IsChatgptOauth || !IsOpenai && !IsSglang && !IsAnthropic && !IsGoogleAi && !IsGoogleVertex && !IsAzure && !IsXai && !IsZai && !IsGroq && !IsDeepseek && !IsTogether && !IsBedrock && !IsBaseten && !IsOpenrouter && IsChatgptOauth;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Letta.OpenAIModelSettings?, TResult>? openai = null,
            global::System.Func<global::Letta.SGLangModelSettings?, TResult>? sglang = null,
            global::System.Func<global::Letta.AnthropicModelSettings?, TResult>? anthropic = null,
            global::System.Func<global::Letta.GoogleAIModelSettings?, TResult>? googleAi = null,
            global::System.Func<global::Letta.GoogleVertexModelSettings?, TResult>? googleVertex = null,
            global::System.Func<global::Letta.AzureModelSettings?, TResult>? azure = null,
            global::System.Func<global::Letta.XAIModelSettings?, TResult>? xai = null,
            global::System.Func<global::Letta.ZAIModelSettings?, TResult>? zai = null,
            global::System.Func<global::Letta.GroqModelSettings?, TResult>? groq = null,
            global::System.Func<global::Letta.DeepseekModelSettings?, TResult>? deepseek = null,
            global::System.Func<global::Letta.TogetherModelSettings?, TResult>? together = null,
            global::System.Func<global::Letta.BedrockModelSettings?, TResult>? bedrock = null,
            global::System.Func<global::Letta.BasetenModelSettings?, TResult>? baseten = null,
            global::System.Func<global::Letta.OpenRouterModelSettings?, TResult>? openrouter = null,
            global::System.Func<global::Letta.ChatGPTOAuthModelSettings?, TResult>? chatgptOauth = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenai && openai != null)
            {
                return openai(Openai!);
            }
            else if (IsSglang && sglang != null)
            {
                return sglang(Sglang!);
            }
            else if (IsAnthropic && anthropic != null)
            {
                return anthropic(Anthropic!);
            }
            else if (IsGoogleAi && googleAi != null)
            {
                return googleAi(GoogleAi!);
            }
            else if (IsGoogleVertex && googleVertex != null)
            {
                return googleVertex(GoogleVertex!);
            }
            else if (IsAzure && azure != null)
            {
                return azure(Azure!);
            }
            else if (IsXai && xai != null)
            {
                return xai(Xai!);
            }
            else if (IsZai && zai != null)
            {
                return zai(Zai!);
            }
            else if (IsGroq && groq != null)
            {
                return groq(Groq!);
            }
            else if (IsDeepseek && deepseek != null)
            {
                return deepseek(Deepseek!);
            }
            else if (IsTogether && together != null)
            {
                return together(Together!);
            }
            else if (IsBedrock && bedrock != null)
            {
                return bedrock(Bedrock!);
            }
            else if (IsBaseten && baseten != null)
            {
                return baseten(Baseten!);
            }
            else if (IsOpenrouter && openrouter != null)
            {
                return openrouter(Openrouter!);
            }
            else if (IsChatgptOauth && chatgptOauth != null)
            {
                return chatgptOauth(ChatgptOauth!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Letta.OpenAIModelSettings?>? openai = null,
            global::System.Action<global::Letta.SGLangModelSettings?>? sglang = null,
            global::System.Action<global::Letta.AnthropicModelSettings?>? anthropic = null,
            global::System.Action<global::Letta.GoogleAIModelSettings?>? googleAi = null,
            global::System.Action<global::Letta.GoogleVertexModelSettings?>? googleVertex = null,
            global::System.Action<global::Letta.AzureModelSettings?>? azure = null,
            global::System.Action<global::Letta.XAIModelSettings?>? xai = null,
            global::System.Action<global::Letta.ZAIModelSettings?>? zai = null,
            global::System.Action<global::Letta.GroqModelSettings?>? groq = null,
            global::System.Action<global::Letta.DeepseekModelSettings?>? deepseek = null,
            global::System.Action<global::Letta.TogetherModelSettings?>? together = null,
            global::System.Action<global::Letta.BedrockModelSettings?>? bedrock = null,
            global::System.Action<global::Letta.BasetenModelSettings?>? baseten = null,
            global::System.Action<global::Letta.OpenRouterModelSettings?>? openrouter = null,
            global::System.Action<global::Letta.ChatGPTOAuthModelSettings?>? chatgptOauth = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenai)
            {
                openai?.Invoke(Openai!);
            }
            else if (IsSglang)
            {
                sglang?.Invoke(Sglang!);
            }
            else if (IsAnthropic)
            {
                anthropic?.Invoke(Anthropic!);
            }
            else if (IsGoogleAi)
            {
                googleAi?.Invoke(GoogleAi!);
            }
            else if (IsGoogleVertex)
            {
                googleVertex?.Invoke(GoogleVertex!);
            }
            else if (IsAzure)
            {
                azure?.Invoke(Azure!);
            }
            else if (IsXai)
            {
                xai?.Invoke(Xai!);
            }
            else if (IsZai)
            {
                zai?.Invoke(Zai!);
            }
            else if (IsGroq)
            {
                groq?.Invoke(Groq!);
            }
            else if (IsDeepseek)
            {
                deepseek?.Invoke(Deepseek!);
            }
            else if (IsTogether)
            {
                together?.Invoke(Together!);
            }
            else if (IsBedrock)
            {
                bedrock?.Invoke(Bedrock!);
            }
            else if (IsBaseten)
            {
                baseten?.Invoke(Baseten!);
            }
            else if (IsOpenrouter)
            {
                openrouter?.Invoke(Openrouter!);
            }
            else if (IsChatgptOauth)
            {
                chatgptOauth?.Invoke(ChatgptOauth!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Openai,
                typeof(global::Letta.OpenAIModelSettings),
                Sglang,
                typeof(global::Letta.SGLangModelSettings),
                Anthropic,
                typeof(global::Letta.AnthropicModelSettings),
                GoogleAi,
                typeof(global::Letta.GoogleAIModelSettings),
                GoogleVertex,
                typeof(global::Letta.GoogleVertexModelSettings),
                Azure,
                typeof(global::Letta.AzureModelSettings),
                Xai,
                typeof(global::Letta.XAIModelSettings),
                Zai,
                typeof(global::Letta.ZAIModelSettings),
                Groq,
                typeof(global::Letta.GroqModelSettings),
                Deepseek,
                typeof(global::Letta.DeepseekModelSettings),
                Together,
                typeof(global::Letta.TogetherModelSettings),
                Bedrock,
                typeof(global::Letta.BedrockModelSettings),
                Baseten,
                typeof(global::Letta.BasetenModelSettings),
                Openrouter,
                typeof(global::Letta.OpenRouterModelSettings),
                ChatgptOauth,
                typeof(global::Letta.ChatGPTOAuthModelSettings),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ModelSettingsVariant19 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Letta.OpenAIModelSettings?>.Default.Equals(Openai, other.Openai) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.SGLangModelSettings?>.Default.Equals(Sglang, other.Sglang) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.AnthropicModelSettings?>.Default.Equals(Anthropic, other.Anthropic) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.GoogleAIModelSettings?>.Default.Equals(GoogleAi, other.GoogleAi) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.GoogleVertexModelSettings?>.Default.Equals(GoogleVertex, other.GoogleVertex) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.AzureModelSettings?>.Default.Equals(Azure, other.Azure) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.XAIModelSettings?>.Default.Equals(Xai, other.Xai) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.ZAIModelSettings?>.Default.Equals(Zai, other.Zai) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.GroqModelSettings?>.Default.Equals(Groq, other.Groq) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.DeepseekModelSettings?>.Default.Equals(Deepseek, other.Deepseek) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.TogetherModelSettings?>.Default.Equals(Together, other.Together) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.BedrockModelSettings?>.Default.Equals(Bedrock, other.Bedrock) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.BasetenModelSettings?>.Default.Equals(Baseten, other.Baseten) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.OpenRouterModelSettings?>.Default.Equals(Openrouter, other.Openrouter) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.ChatGPTOAuthModelSettings?>.Default.Equals(ChatgptOauth, other.ChatgptOauth) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ModelSettingsVariant19 obj1, ModelSettingsVariant19 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ModelSettingsVariant19>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ModelSettingsVariant19 obj1, ModelSettingsVariant19 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelSettingsVariant19 o && Equals(o);
        }
    }
}
