#nullable enable

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public sealed class FeedsSubscribeAgentResponseMergeStrategyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.FeedsSubscribeAgentResponseMergeStrategy>
    {
        /// <inheritdoc />
        public override global::Letta.FeedsSubscribeAgentResponseMergeStrategy Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Letta.FeedsSubscribeAgentResponseMergeStrategyExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Letta.FeedsSubscribeAgentResponseMergeStrategy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Letta.FeedsSubscribeAgentResponseMergeStrategy);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.FeedsSubscribeAgentResponseMergeStrategy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Letta.FeedsSubscribeAgentResponseMergeStrategyExtensions.ToValueString(value));
        }
    }
}
