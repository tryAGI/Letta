#nullable enable

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public sealed class InternalTemplateGroupCreateManagerConfigDiscriminatorManagerTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType?>
    {
        /// <inheritdoc />
        public override global::Letta.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType? Read(
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
                        return global::Letta.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Letta.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Letta.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Letta.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
