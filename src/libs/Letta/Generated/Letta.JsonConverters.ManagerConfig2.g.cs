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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.GroupSchemaManagerConfigDiscriminator>(ref readerCopy, options);

            global::Letta.RoundRobinManager? roundRobin = default;
            if (discriminator?.ManagerType == global::Letta.GroupSchemaManagerConfigDiscriminatorManagerType.RoundRobin)
            {
                roundRobin = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.RoundRobinManager>(ref reader, options);
            }
            global::Letta.SupervisorManagerSchema? supervisor = default;
            if (discriminator?.ManagerType == global::Letta.GroupSchemaManagerConfigDiscriminatorManagerType.Supervisor)
            {
                supervisor = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.SupervisorManagerSchema>(ref reader, options);
            }
            global::Letta.DynamicManagerSchema? dynamic = default;
            if (discriminator?.ManagerType == global::Letta.GroupSchemaManagerConfigDiscriminatorManagerType.Dynamic)
            {
                dynamic = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.DynamicManagerSchema>(ref reader, options);
            }
            global::Letta.SleeptimeManagerSchema? sleeptime = default;
            if (discriminator?.ManagerType == global::Letta.GroupSchemaManagerConfigDiscriminatorManagerType.Sleeptime)
            {
                sleeptime = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.SleeptimeManagerSchema>(ref reader, options);
            }
            global::Letta.VoiceSleeptimeManagerSchema? voiceSleeptime = default;
            if (discriminator?.ManagerType == global::Letta.GroupSchemaManagerConfigDiscriminatorManagerType.VoiceSleeptime)
            {
                voiceSleeptime = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.VoiceSleeptimeManagerSchema>(ref reader, options);
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

            if (value.IsRoundRobin)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RoundRobin, typeof(global::Letta.RoundRobinManager), options);
            }
            else if (value.IsSupervisor)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Supervisor, typeof(global::Letta.SupervisorManagerSchema), options);
            }
            else if (value.IsDynamic)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dynamic, typeof(global::Letta.DynamicManagerSchema), options);
            }
            else if (value.IsSleeptime)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sleeptime, typeof(global::Letta.SleeptimeManagerSchema), options);
            }
            else if (value.IsVoiceSleeptime)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoiceSleeptime, typeof(global::Letta.VoiceSleeptimeManagerSchema), options);
            }
        }
    }
}