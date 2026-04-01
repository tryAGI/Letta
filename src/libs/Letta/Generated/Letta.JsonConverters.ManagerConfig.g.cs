#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class ManagerConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.ManagerConfig>
    {
        /// <inheritdoc />
        public override global::Letta.ManagerConfig Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.GroupCreateManagerConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.GroupCreateManagerConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.GroupCreateManagerConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Letta.RoundRobinManager? roundRobin = default;
            if (discriminator?.ManagerType == global::Letta.GroupCreateManagerConfigDiscriminatorManagerType.RoundRobin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.RoundRobinManager), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.RoundRobinManager> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.RoundRobinManager)}");
                roundRobin = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.SupervisorManager? supervisor = default;
            if (discriminator?.ManagerType == global::Letta.GroupCreateManagerConfigDiscriminatorManagerType.Supervisor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.SupervisorManager), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.SupervisorManager> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.SupervisorManager)}");
                supervisor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.DynamicManager? dynamic = default;
            if (discriminator?.ManagerType == global::Letta.GroupCreateManagerConfigDiscriminatorManagerType.Dynamic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.DynamicManager), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.DynamicManager> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.DynamicManager)}");
                dynamic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.SleeptimeManager? sleeptime = default;
            if (discriminator?.ManagerType == global::Letta.GroupCreateManagerConfigDiscriminatorManagerType.Sleeptime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.SleeptimeManager), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.SleeptimeManager> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.SleeptimeManager)}");
                sleeptime = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.VoiceSleeptimeManager? voiceSleeptime = default;
            if (discriminator?.ManagerType == global::Letta.GroupCreateManagerConfigDiscriminatorManagerType.VoiceSleeptime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.VoiceSleeptimeManager), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.VoiceSleeptimeManager> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.VoiceSleeptimeManager)}");
                voiceSleeptime = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Letta.ManagerConfig(
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
            global::Letta.ManagerConfig value,
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
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.SupervisorManager), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.SupervisorManager?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.SupervisorManager).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Supervisor!, typeInfo);
            }
            else if (value.IsDynamic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.DynamicManager), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.DynamicManager?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.DynamicManager).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dynamic!, typeInfo);
            }
            else if (value.IsSleeptime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.SleeptimeManager), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.SleeptimeManager?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.SleeptimeManager).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sleeptime!, typeInfo);
            }
            else if (value.IsVoiceSleeptime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.VoiceSleeptimeManager), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.VoiceSleeptimeManager?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.VoiceSleeptimeManager).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoiceSleeptime!, typeInfo);
            }
        }
    }
}