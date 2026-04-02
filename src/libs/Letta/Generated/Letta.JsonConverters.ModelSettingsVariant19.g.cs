#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class ModelSettingsVariant19JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.ModelSettingsVariant19>
    {
        /// <inheritdoc />
        public override global::Letta.ModelSettingsVariant19 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.UpdateConversationModelSettingsVariant1Discriminator>(ref readerCopy, options);

            global::Letta.OpenAIModelSettings? openai = default;
            if (discriminator?.ProviderType == global::Letta.UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Openai)
            {
                openai = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.OpenAIModelSettings>(ref reader, options);
            }
            global::Letta.SGLangModelSettings? sglang = default;
            if (discriminator?.ProviderType == global::Letta.UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Sglang)
            {
                sglang = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.SGLangModelSettings>(ref reader, options);
            }
            global::Letta.AnthropicModelSettings? anthropic = default;
            if (discriminator?.ProviderType == global::Letta.UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Anthropic)
            {
                anthropic = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.AnthropicModelSettings>(ref reader, options);
            }
            global::Letta.GoogleAIModelSettings? googleAi = default;
            if (discriminator?.ProviderType == global::Letta.UpdateConversationModelSettingsVariant1DiscriminatorProviderType.GoogleAi)
            {
                googleAi = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.GoogleAIModelSettings>(ref reader, options);
            }
            global::Letta.GoogleVertexModelSettings? googleVertex = default;
            if (discriminator?.ProviderType == global::Letta.UpdateConversationModelSettingsVariant1DiscriminatorProviderType.GoogleVertex)
            {
                googleVertex = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.GoogleVertexModelSettings>(ref reader, options);
            }
            global::Letta.AzureModelSettings? azure = default;
            if (discriminator?.ProviderType == global::Letta.UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Azure)
            {
                azure = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.AzureModelSettings>(ref reader, options);
            }
            global::Letta.XAIModelSettings? xai = default;
            if (discriminator?.ProviderType == global::Letta.UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Xai)
            {
                xai = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.XAIModelSettings>(ref reader, options);
            }
            global::Letta.ZAIModelSettings? zai = default;
            if (discriminator?.ProviderType == global::Letta.UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Zai)
            {
                zai = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ZAIModelSettings>(ref reader, options);
            }
            global::Letta.GroqModelSettings? groq = default;
            if (discriminator?.ProviderType == global::Letta.UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Groq)
            {
                groq = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.GroqModelSettings>(ref reader, options);
            }
            global::Letta.DeepseekModelSettings? deepseek = default;
            if (discriminator?.ProviderType == global::Letta.UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Deepseek)
            {
                deepseek = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.DeepseekModelSettings>(ref reader, options);
            }
            global::Letta.TogetherModelSettings? together = default;
            if (discriminator?.ProviderType == global::Letta.UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Together)
            {
                together = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.TogetherModelSettings>(ref reader, options);
            }
            global::Letta.BedrockModelSettings? bedrock = default;
            if (discriminator?.ProviderType == global::Letta.UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Bedrock)
            {
                bedrock = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.BedrockModelSettings>(ref reader, options);
            }
            global::Letta.BasetenModelSettings? baseten = default;
            if (discriminator?.ProviderType == global::Letta.UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Baseten)
            {
                baseten = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.BasetenModelSettings>(ref reader, options);
            }
            global::Letta.OpenRouterModelSettings? openrouter = default;
            if (discriminator?.ProviderType == global::Letta.UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Openrouter)
            {
                openrouter = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.OpenRouterModelSettings>(ref reader, options);
            }
            global::Letta.ChatGPTOAuthModelSettings? chatgptOauth = default;
            if (discriminator?.ProviderType == global::Letta.UpdateConversationModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth)
            {
                chatgptOauth = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ChatGPTOAuthModelSettings>(ref reader, options);
            }

            var __value = new global::Letta.ModelSettingsVariant19(
                discriminator?.ProviderType,
                openai,

                sglang,

                anthropic,

                googleAi,

                googleVertex,

                azure,

                xai,

                zai,

                groq,

                deepseek,

                together,

                bedrock,

                baseten,

                openrouter,

                chatgptOauth
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.ModelSettingsVariant19 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsOpenai)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Openai, typeof(global::Letta.OpenAIModelSettings), options);
            }
            else if (value.IsSglang)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sglang, typeof(global::Letta.SGLangModelSettings), options);
            }
            else if (value.IsAnthropic)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Anthropic, typeof(global::Letta.AnthropicModelSettings), options);
            }
            else if (value.IsGoogleAi)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleAi, typeof(global::Letta.GoogleAIModelSettings), options);
            }
            else if (value.IsGoogleVertex)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleVertex, typeof(global::Letta.GoogleVertexModelSettings), options);
            }
            else if (value.IsAzure)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Azure, typeof(global::Letta.AzureModelSettings), options);
            }
            else if (value.IsXai)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Xai, typeof(global::Letta.XAIModelSettings), options);
            }
            else if (value.IsZai)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Zai, typeof(global::Letta.ZAIModelSettings), options);
            }
            else if (value.IsGroq)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Groq, typeof(global::Letta.GroqModelSettings), options);
            }
            else if (value.IsDeepseek)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Deepseek, typeof(global::Letta.DeepseekModelSettings), options);
            }
            else if (value.IsTogether)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Together, typeof(global::Letta.TogetherModelSettings), options);
            }
            else if (value.IsBedrock)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bedrock, typeof(global::Letta.BedrockModelSettings), options);
            }
            else if (value.IsBaseten)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Baseten, typeof(global::Letta.BasetenModelSettings), options);
            }
            else if (value.IsOpenrouter)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Openrouter, typeof(global::Letta.OpenRouterModelSettings), options);
            }
            else if (value.IsChatgptOauth)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatgptOauth, typeof(global::Letta.ChatGPTOAuthModelSettings), options);
            }
        }
    }
}