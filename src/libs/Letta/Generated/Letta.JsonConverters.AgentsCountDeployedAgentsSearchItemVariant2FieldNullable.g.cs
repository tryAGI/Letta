#nullable enable

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentsCountDeployedAgentsSearchItemVariant2FieldNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.AgentsCountDeployedAgentsSearchItemVariant2Field?>
    {
        /// <inheritdoc />
        public override global::Letta.AgentsCountDeployedAgentsSearchItemVariant2Field? Read(
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
                        return global::Letta.AgentsCountDeployedAgentsSearchItemVariant2FieldExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Letta.AgentsCountDeployedAgentsSearchItemVariant2Field)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Letta.AgentsCountDeployedAgentsSearchItemVariant2Field?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.AgentsCountDeployedAgentsSearchItemVariant2Field? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Letta.AgentsCountDeployedAgentsSearchItemVariant2FieldExtensions.ToValueString(value.Value));
            }
        }
    }
}
