
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LettaSchemasOpenaiChatCompletionResponseChatCompletionTokenLogprob
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        public global::System.Collections.Generic.IList<long>? Bytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprob")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Logprob { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Letta.LettaSchemasOpenaiChatCompletionResponseTopLogprob> TopLogprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasOpenaiChatCompletionResponseChatCompletionTokenLogprob" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="bytes"></param>
        /// <param name="logprob"></param>
        /// <param name="topLogprobs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LettaSchemasOpenaiChatCompletionResponseChatCompletionTokenLogprob(
            string token,
            double logprob,
            global::System.Collections.Generic.IList<global::Letta.LettaSchemasOpenaiChatCompletionResponseTopLogprob> topLogprobs,
            global::System.Collections.Generic.IList<long>? bytes)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Logprob = logprob;
            this.TopLogprobs = topLogprobs ?? throw new global::System.ArgumentNullException(nameof(topLogprobs));
            this.Bytes = bytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasOpenaiChatCompletionResponseChatCompletionTokenLogprob" /> class.
        /// </summary>
        public LettaSchemasOpenaiChatCompletionResponseChatCompletionTokenLogprob()
        {
        }
    }
}