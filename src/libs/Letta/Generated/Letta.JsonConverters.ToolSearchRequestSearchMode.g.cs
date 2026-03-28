#nullable enable

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public sealed class ToolSearchRequestSearchModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.ToolSearchRequestSearchMode>
    {
        /// <inheritdoc />
        public override global::Letta.ToolSearchRequestSearchMode Read(
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
                        return global::Letta.ToolSearchRequestSearchModeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Letta.ToolSearchRequestSearchMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Letta.ToolSearchRequestSearchMode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.ToolSearchRequestSearchMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Letta.ToolSearchRequestSearchModeExtensions.ToValueString(value));
        }
    }
}
