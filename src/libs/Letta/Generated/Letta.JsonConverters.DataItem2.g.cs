#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class DataItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.DataItem2>
    {
        /// <inheritdoc />
        public override global::Letta.DataItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1? agent = default;
            if (discriminator?.Type == global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemDiscriminatorType.Agent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1)}");
                agent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Letta.DataItem2(
                discriminator?.Type,
                agent
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.DataItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Agent!, typeInfo);
            }
        }
    }
}