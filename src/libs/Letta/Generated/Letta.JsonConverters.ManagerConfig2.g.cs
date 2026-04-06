#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class ManagerConfig2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.ManagerConfig2>
    {
        /// <inheritdoc />
        public override global::Letta.ManagerConfig2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.GroupSchemaManagerConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.GroupSchemaManagerConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.GroupSchemaManagerConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Letta.RoundRobinManager? roundRobin = default;
            if (discriminator?.ManagerType == global::Letta.GroupSchemaManagerConfigDiscriminatorManagerType.RoundRobin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.RoundRobinManager), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.RoundRobinManager> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.RoundRobinManager)}");
                roundRobin = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.SupervisorManagerSchema? supervisor = default;
            if (discriminator?.ManagerType == global::Letta.GroupSchemaManagerConfigDiscriminatorManagerType.Supervisor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.SupervisorManagerSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.SupervisorManagerSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.SupervisorManagerSchema)}");
                supervisor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.DynamicManagerSchema? dynamic = default;
            if (discriminator?.ManagerType == global::Letta.GroupSchemaManagerConfigDiscriminatorManagerType.Dynamic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.DynamicManagerSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.DynamicManagerSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.DynamicManagerSchema)}");
                dynamic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.SleeptimeManagerSchema? sleeptime = default;
            if (discriminator?.ManagerType == global::Letta.GroupSchemaManagerConfigDiscriminatorManagerType.Sleeptime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.SleeptimeManagerSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.SleeptimeManagerSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.SleeptimeManagerSchema)}");
                sleeptime = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.VoiceSleeptimeManagerSchema? voiceSleeptime = default;
            if (discriminator?.ManagerType == global::Letta.GroupSchemaManagerConfigDiscriminatorManagerType.VoiceSleeptime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.VoiceSleeptimeManagerSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.VoiceSleeptimeManagerSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.VoiceSleeptimeManagerSchema)}");
                voiceSleeptime = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Letta.ManagerConfig2(
                discriminator?.ManagerType,
                roundRobin,

                supervisor,

                dynamic,

                sleeptime,

                voiceSleeptime
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.ManagerConfig2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRoundRobin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.RoundRobinManager), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.RoundRobinManager?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.RoundRobinManager).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RoundRobin!, typeInfo);
            }
            else if (value.IsSupervisor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.SupervisorManagerSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.SupervisorManagerSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.SupervisorManagerSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Supervisor!, typeInfo);
            }
            else if (value.IsDynamic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.DynamicManagerSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.DynamicManagerSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.DynamicManagerSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dynamic!, typeInfo);
            }
            else if (value.IsSleeptime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.SleeptimeManagerSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.SleeptimeManagerSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.SleeptimeManagerSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sleeptime!, typeInfo);
            }
            else if (value.IsVoiceSleeptime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.VoiceSleeptimeManagerSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.VoiceSleeptimeManagerSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.VoiceSleeptimeManagerSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoiceSleeptime!, typeInfo);
            }
        }
    }
}