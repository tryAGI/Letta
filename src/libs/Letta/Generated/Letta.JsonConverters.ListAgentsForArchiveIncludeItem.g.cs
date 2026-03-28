#nullable enable

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListAgentsForArchiveIncludeItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.ListAgentsForArchiveIncludeItem>
    {
        /// <inheritdoc />
        public override global::Letta.ListAgentsForArchiveIncludeItem Read(
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
                        return global::Letta.ListAgentsForArchiveIncludeItemExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Letta.ListAgentsForArchiveIncludeItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Letta.ListAgentsForArchiveIncludeItem);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.ListAgentsForArchiveIncludeItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Letta.ListAgentsForArchiveIncludeItemExtensions.ToValueString(value));
        }
    }
}
