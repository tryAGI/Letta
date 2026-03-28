#nullable enable

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public sealed class EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType>
    {
        /// <inheritdoc />
        public override global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType Read(
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
                        return global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemTypeExtensions.ToValueString(value));
        }
    }
}
