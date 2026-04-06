#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class ApprovalsVariant1ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.ApprovalsVariant1Item>
    {
        /// <inheritdoc />
        public override global::Letta.ApprovalsVariant1Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ApprovalCreateApprovalsVariant1ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ApprovalCreateApprovalsVariant1ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ApprovalCreateApprovalsVariant1ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Letta.ApprovalReturn? approval = default;
            if (discriminator?.Type == global::Letta.ApprovalCreateApprovalsVariant1ItemDiscriminatorType.Approval)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ApprovalReturn), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ApprovalReturn> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ApprovalReturn)}");
                approval = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.LettaSchemasLettaMessageToolReturn? tool = default;
            if (discriminator?.Type == global::Letta.ApprovalCreateApprovalsVariant1ItemDiscriminatorType.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.LettaSchemasLettaMessageToolReturn), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.LettaSchemasLettaMessageToolReturn> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.LettaSchemasLettaMessageToolReturn)}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Letta.ApprovalsVariant1Item(
                discriminator?.Type,
                approval,

                tool
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.ApprovalsVariant1Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsApproval)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ApprovalReturn), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ApprovalReturn?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.ApprovalReturn).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Approval!, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.LettaSchemasLettaMessageToolReturn), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.LettaSchemasLettaMessageToolReturn?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.LettaSchemasLettaMessageToolReturn).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool!, typeInfo);
            }
        }
    }
}