
#nullable enable

namespace Letta
{
    /// <summary>
    /// SGLang model configuration (OpenAI-compatible runtime with SGLang-specific parsing).
    /// </summary>
    public sealed partial class SGLangModelSettings
    {
        /// <summary>
        /// The maximum number of tokens the model can generate.<br/>
        /// Default Value: 4096
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// Whether to enable parallel tool calling.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// The type of the provider.<br/>
        /// Default Value: sglang
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_type")]
        public string? ProviderType { get; set; }

        /// <summary>
        /// The temperature of the model.<br/>
        /// Default Value: 0.7F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// The reasoning configuration for the model.<br/>
        /// Default Value: {"reasoning_effort":"high"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::Letta.OpenAIReasoning? Reasoning { get; set; }

        /// <summary>
        /// The response format for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::Letta.ResponseFormatVariant113? ResponseFormat { get; set; }

        /// <summary>
        /// Enable strict mode for tool calling. When true, tool outputs are guaranteed to match JSON schemas.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// SGLang tool call parser name (for example 'glm47', 'qwen25', or 'hermes').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_parser")]
        public string? ToolCallParser { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SGLangModelSettings" /> class.
        /// </summary>
        /// <param name="maxOutputTokens">
        /// The maximum number of tokens the model can generate.<br/>
        /// Default Value: 4096
        /// </param>
        /// <param name="parallelToolCalls">
        /// Whether to enable parallel tool calling.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="providerType">
        /// The type of the provider.<br/>
        /// Default Value: sglang
        /// </param>
        /// <param name="temperature">
        /// The temperature of the model.<br/>
        /// Default Value: 0.7F
        /// </param>
        /// <param name="reasoning">
        /// The reasoning configuration for the model.<br/>
        /// Default Value: {"reasoning_effort":"high"}
        /// </param>
        /// <param name="responseFormat">
        /// The response format for the model.
        /// </param>
        /// <param name="strict">
        /// Enable strict mode for tool calling. When true, tool outputs are guaranteed to match JSON schemas.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="toolCallParser">
        /// SGLang tool call parser name (for example 'glm47', 'qwen25', or 'hermes').
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SGLangModelSettings(
            int? maxOutputTokens,
            bool? parallelToolCalls,
            string? providerType,
            double? temperature,
            global::Letta.OpenAIReasoning? reasoning,
            global::Letta.ResponseFormatVariant113? responseFormat,
            bool? strict,
            string? toolCallParser)
        {
            this.MaxOutputTokens = maxOutputTokens;
            this.ParallelToolCalls = parallelToolCalls;
            this.ProviderType = providerType;
            this.Temperature = temperature;
            this.Reasoning = reasoning;
            this.ResponseFormat = responseFormat;
            this.Strict = strict;
            this.ToolCallParser = toolCallParser;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SGLangModelSettings" /> class.
        /// </summary>
        public SGLangModelSettings()
        {
        }
    }
}