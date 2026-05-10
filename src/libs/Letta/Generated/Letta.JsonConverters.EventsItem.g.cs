#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class EventsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.EventsItem>
    {
        /// <inheritdoc />
        public override global::Letta.EventsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.MetadataSendTelemetryRequestEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Letta.MetadataSendTelemetryRequestEventVariant1? sessionStart = default;
            if (discriminator?.Type == global::Letta.MetadataSendTelemetryRequestEventDiscriminatorType.SessionStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.MetadataSendTelemetryRequestEventVariant1)}");
                sessionStart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.MetadataSendTelemetryRequestEventVariant2? sessionEnd = default;
            if (discriminator?.Type == global::Letta.MetadataSendTelemetryRequestEventDiscriminatorType.SessionEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.MetadataSendTelemetryRequestEventVariant2)}");
                sessionEnd = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.MetadataSendTelemetryRequestEventVariant3? toolUsage = default;
            if (discriminator?.Type == global::Letta.MetadataSendTelemetryRequestEventDiscriminatorType.ToolUsage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.MetadataSendTelemetryRequestEventVariant3)}");
                toolUsage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.MetadataSendTelemetryRequestEventVariant4? error = default;
            if (discriminator?.Type == global::Letta.MetadataSendTelemetryRequestEventDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.MetadataSendTelemetryRequestEventVariant4)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.MetadataSendTelemetryRequestEventVariant5? userInput = default;
            if (discriminator?.Type == global::Letta.MetadataSendTelemetryRequestEventDiscriminatorType.UserInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.MetadataSendTelemetryRequestEventVariant5)}");
                userInput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Letta.EventsItem(
                discriminator?.Type,
                sessionStart,

                sessionEnd,

                toolUsage,

                error,

                userInput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.EventsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSessionStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.MetadataSendTelemetryRequestEventVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionStart!, typeInfo);
            }
            else if (value.IsSessionEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.MetadataSendTelemetryRequestEventVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionEnd!, typeInfo);
            }
            else if (value.IsToolUsage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.MetadataSendTelemetryRequestEventVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolUsage!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.MetadataSendTelemetryRequestEventVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
            else if (value.IsUserInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.MetadataSendTelemetryRequestEventVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserInput!, typeInfo);
            }
        }
    }
}