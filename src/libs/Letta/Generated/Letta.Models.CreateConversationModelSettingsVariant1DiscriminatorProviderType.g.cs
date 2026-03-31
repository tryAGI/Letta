
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateConversationModelSettingsVariant1DiscriminatorProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        Azure,
        /// <summary>
        /// 
        /// </summary>
        Baseten,
        /// <summary>
        /// 
        /// </summary>
        Bedrock,
        /// <summary>
        /// 
        /// </summary>
        ChatgptOauth,
        /// <summary>
        /// 
        /// </summary>
        Deepseek,
        /// <summary>
        /// 
        /// </summary>
        GoogleAi,
        /// <summary>
        /// 
        /// </summary>
        GoogleVertex,
        /// <summary>
        /// 
        /// </summary>
        Groq,
        /// <summary>
        /// 
        /// </summary>
        Openai,
        /// <summary>
        /// 
        /// </summary>
        Openrouter,
        /// <summary>
        /// 
        /// </summary>
        Sglang,
        /// <summary>
        /// 
        /// </summary>
        Together,
        /// <summary>
        /// 
        /// </summary>
        Xai,
        /// <summary>
        /// 
        /// </summary>
        Zai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConversationModelSettingsVariant1DiscriminatorProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConversationModelSettingsVariant1DiscriminatorProviderType value)
        {
            return value switch
            {
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.Anthropic => "anthropic",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.Azure => "azure",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.Baseten => "baseten",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.Bedrock => "bedrock",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth => "chatgpt_oauth",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.Deepseek => "deepseek",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.GoogleAi => "google_ai",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.GoogleVertex => "google_vertex",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.Groq => "groq",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.Openai => "openai",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.Openrouter => "openrouter",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.Sglang => "sglang",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.Together => "together",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.Xai => "xai",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.Zai => "zai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConversationModelSettingsVariant1DiscriminatorProviderType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.Anthropic,
                "azure" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.Azure,
                "baseten" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.Baseten,
                "bedrock" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.Bedrock,
                "chatgpt_oauth" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth,
                "deepseek" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.Deepseek,
                "google_ai" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.GoogleAi,
                "google_vertex" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.GoogleVertex,
                "groq" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.Groq,
                "openai" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.Openai,
                "openrouter" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.Openrouter,
                "sglang" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.Sglang,
                "together" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.Together,
                "xai" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.Xai,
                "zai" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.Zai,
                _ => null,
            };
        }
    }
}