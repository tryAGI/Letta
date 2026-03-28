#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class ModelSettingsVariant15JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.ModelSettingsVariant15>
    {
        /// <inheritdoc />
        public override global::Letta.ModelSettingsVariant15 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.CreateAgentRequestModelSettingsVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.CreateAgentRequestModelSettingsVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.CreateAgentRequestModelSettingsVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Letta.OpenAIModelSettings? openai = default;
            if (discriminator?.ProviderType == global::Letta.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Openai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.OpenAIModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.OpenAIModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.OpenAIModelSettings)}");
                openai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.AnthropicModelSettings? anthropic = default;
            if (discriminator?.ProviderType == global::Letta.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Anthropic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.AnthropicModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.AnthropicModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.AnthropicModelSettings)}");
                anthropic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.GoogleAIModelSettings? googleAi = default;
            if (discriminator?.ProviderType == global::Letta.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.GoogleAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.GoogleAIModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.GoogleAIModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.GoogleAIModelSettings)}");
                googleAi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.GoogleVertexModelSettings? googleVertex = default;
            if (discriminator?.ProviderType == global::Letta.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.GoogleVertex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.GoogleVertexModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.GoogleVertexModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.GoogleVertexModelSettings)}");
                googleVertex = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.AzureModelSettings? azure = default;
            if (discriminator?.ProviderType == global::Letta.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Azure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.AzureModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.AzureModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.AzureModelSettings)}");
                azure = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.XAIModelSettings? xai = default;
            if (discriminator?.ProviderType == global::Letta.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Xai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.XAIModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.XAIModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.XAIModelSettings)}");
                xai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ZAIModelSettings? zai = default;
            if (discriminator?.ProviderType == global::Letta.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Zai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ZAIModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ZAIModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ZAIModelSettings)}");
                zai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.GroqModelSettings? groq = default;
            if (discriminator?.ProviderType == global::Letta.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Groq)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.GroqModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.GroqModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.GroqModelSettings)}");
                groq = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.DeepseekModelSettings? deepseek = default;
            if (discriminator?.ProviderType == global::Letta.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Deepseek)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.DeepseekModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.DeepseekModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.DeepseekModelSettings)}");
                deepseek = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.TogetherModelSettings? together = default;
            if (discriminator?.ProviderType == global::Letta.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Together)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.TogetherModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.TogetherModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.TogetherModelSettings)}");
                together = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.BedrockModelSettings? bedrock = default;
            if (discriminator?.ProviderType == global::Letta.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Bedrock)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.BedrockModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.BedrockModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.BedrockModelSettings)}");
                bedrock = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.OpenRouterModelSettings? openrouter = default;
            if (discriminator?.ProviderType == global::Letta.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Openrouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.OpenRouterModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.OpenRouterModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.OpenRouterModelSettings)}");
                openrouter = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ChatGPTOAuthModelSettings? chatgptOauth = default;
            if (discriminator?.ProviderType == global::Letta.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ChatGPTOAuthModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ChatGPTOAuthModelSettings> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ChatGPTOAuthModelSettings)}");
                chatgptOauth = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Letta.ModelSettingsVariant15(
                discriminator?.ProviderType,
                openai,

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

                openrouter,

                chatgptOauth
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.ModelSettingsVariant15 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOpenai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.OpenAIModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.OpenAIModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.OpenAIModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Openai, typeInfo);
            }
            else if (value.IsAnthropic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.AnthropicModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.AnthropicModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.AnthropicModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Anthropic, typeInfo);
            }
            else if (value.IsGoogleAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.GoogleAIModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.GoogleAIModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.GoogleAIModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleAi, typeInfo);
            }
            else if (value.IsGoogleVertex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.GoogleVertexModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.GoogleVertexModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.GoogleVertexModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleVertex, typeInfo);
            }
            else if (value.IsAzure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.AzureModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.AzureModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.AzureModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Azure, typeInfo);
            }
            else if (value.IsXai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.XAIModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.XAIModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.XAIModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Xai, typeInfo);
            }
            else if (value.IsZai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ZAIModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ZAIModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.ZAIModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Zai, typeInfo);
            }
            else if (value.IsGroq)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.GroqModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.GroqModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.GroqModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Groq, typeInfo);
            }
            else if (value.IsDeepseek)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.DeepseekModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.DeepseekModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.DeepseekModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Deepseek, typeInfo);
            }
            else if (value.IsTogether)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.TogetherModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.TogetherModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.TogetherModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Together, typeInfo);
            }
            else if (value.IsBedrock)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.BedrockModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.BedrockModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.BedrockModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bedrock, typeInfo);
            }
            else if (value.IsOpenrouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.OpenRouterModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.OpenRouterModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.OpenRouterModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Openrouter, typeInfo);
            }
            else if (value.IsChatgptOauth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ChatGPTOAuthModelSettings), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ChatGPTOAuthModelSettings?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.ChatGPTOAuthModelSettings).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatgptOauth, typeInfo);
            }
        }
    }
}