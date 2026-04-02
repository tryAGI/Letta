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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.GroupCreateManagerConfigDiscriminator>(ref readerCopy, options);

            global::Letta.RoundRobinManager? roundRobin = default;
            if (discriminator?.ManagerType == global::Letta.GroupCreateManagerConfigDiscriminatorManagerType.RoundRobin)
            {
                roundRobin = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.RoundRobinManager>(ref reader, options);
            }
            global::Letta.SupervisorManager? supervisor = default;
            if (discriminator?.ManagerType == global::Letta.GroupCreateManagerConfigDiscriminatorManagerType.Supervisor)
            {
                supervisor = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.SupervisorManager>(ref reader, options);
            }
            global::Letta.DynamicManager? dynamic = default;
            if (discriminator?.ManagerType == global::Letta.GroupCreateManagerConfigDiscriminatorManagerType.Dynamic)
            {
                dynamic = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.DynamicManager>(ref reader, options);
            }
            global::Letta.SleeptimeManager? sleeptime = default;
            if (discriminator?.ManagerType == global::Letta.GroupCreateManagerConfigDiscriminatorManagerType.Sleeptime)
            {
                sleeptime = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.SleeptimeManager>(ref reader, options);
            }
            global::Letta.VoiceSleeptimeManager? voiceSleeptime = default;
            if (discriminator?.ManagerType == global::Letta.GroupCreateManagerConfigDiscriminatorManagerType.VoiceSleeptime)
            {
                voiceSleeptime = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.VoiceSleeptimeManager>(ref reader, options);
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

            if (value.IsRoundRobin)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RoundRobin, typeof(global::Letta.RoundRobinManager), options);
            }
            else if (value.IsSupervisor)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Supervisor, typeof(global::Letta.SupervisorManager), options);
            }
            else if (value.IsDynamic)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dynamic, typeof(global::Letta.DynamicManager), options);
            }
            else if (value.IsSleeptime)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sleeptime, typeof(global::Letta.SleeptimeManager), options);
            }
            else if (value.IsVoiceSleeptime)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoiceSleeptime, typeof(global::Letta.VoiceSleeptimeManager), options);
            }
        }
    }
}