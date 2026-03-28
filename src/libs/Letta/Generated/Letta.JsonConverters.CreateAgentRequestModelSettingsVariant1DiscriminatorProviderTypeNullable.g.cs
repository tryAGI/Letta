#nullable enable

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateAgentRequestModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType?>
    {
        /// <inheritdoc />
        public override global::Letta.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType? Read(
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
                        return global::Letta.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Letta.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Letta.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Letta.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
