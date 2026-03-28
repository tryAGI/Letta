#nullable enable

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public sealed class ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1AccesNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Acces?>
    {
        /// <inheritdoc />
        public override global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Acces? Read(
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
                        return global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1AccesExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Acces)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Acces?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Acces? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1AccesExtensions.ToValueString(value.Value));
            }
        }
    }
}
