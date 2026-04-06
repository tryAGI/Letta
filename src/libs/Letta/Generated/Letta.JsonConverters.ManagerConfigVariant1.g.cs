#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class ManagerConfigVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.ManagerConfigVariant1>
    {
        /// <inheritdoc />
        public override global::Letta.ManagerConfigVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.GroupUpdateManagerConfigVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.GroupUpdateManagerConfigVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.GroupUpdateManagerConfigVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Letta.RoundRobinManagerUpdate? roundRobin = default;
            if (discriminator?.ManagerType == global::Letta.GroupUpdateManagerConfigVariant1DiscriminatorManagerType.RoundRobin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.RoundRobinManagerUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.RoundRobinManagerUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.RoundRobinManagerUpdate)}");
                roundRobin = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.SupervisorManagerUpdate? supervisor = default;
            if (discriminator?.ManagerType == global::Letta.GroupUpdateManagerConfigVariant1DiscriminatorManagerType.Supervisor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.SupervisorManagerUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.SupervisorManagerUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.SupervisorManagerUpdate)}");
                supervisor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.DynamicManagerUpdate? dynamic = default;
            if (discriminator?.ManagerType == global::Letta.GroupUpdateManagerConfigVariant1DiscriminatorManagerType.Dynamic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.DynamicManagerUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.DynamicManagerUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.DynamicManagerUpdate)}");
                dynamic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.SleeptimeManagerUpdate? sleeptime = default;
            if (discriminator?.ManagerType == global::Letta.GroupUpdateManagerConfigVariant1DiscriminatorManagerType.Sleeptime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.SleeptimeManagerUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.SleeptimeManagerUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.SleeptimeManagerUpdate)}");
                sleeptime = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.VoiceSleeptimeManagerUpdate? voiceSleeptime = default;
            if (discriminator?.ManagerType == global::Letta.GroupUpdateManagerConfigVariant1DiscriminatorManagerType.VoiceSleeptime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.VoiceSleeptimeManagerUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.VoiceSleeptimeManagerUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.VoiceSleeptimeManagerUpdate)}");
                voiceSleeptime = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Letta.ManagerConfigVariant1(
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
            global::Letta.ManagerConfigVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRoundRobin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.RoundRobinManagerUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.RoundRobinManagerUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.RoundRobinManagerUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RoundRobin!, typeInfo);
            }
            else if (value.IsSupervisor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.SupervisorManagerUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.SupervisorManagerUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.SupervisorManagerUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Supervisor!, typeInfo);
            }
            else if (value.IsDynamic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.DynamicManagerUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.DynamicManagerUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.DynamicManagerUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dynamic!, typeInfo);
            }
            else if (value.IsSleeptime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.SleeptimeManagerUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.SleeptimeManagerUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.SleeptimeManagerUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sleeptime!, typeInfo);
            }
            else if (value.IsVoiceSleeptime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.VoiceSleeptimeManagerUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.VoiceSleeptimeManagerUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.VoiceSleeptimeManagerUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoiceSleeptime!, typeInfo);
            }
        }
    }
}