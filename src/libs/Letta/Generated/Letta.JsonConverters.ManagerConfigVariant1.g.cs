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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.GroupUpdateManagerConfigVariant1Discriminator>(ref readerCopy, options);

            global::Letta.RoundRobinManagerUpdate? roundRobin = default;
            if (discriminator?.ManagerType == global::Letta.GroupUpdateManagerConfigVariant1DiscriminatorManagerType.RoundRobin)
            {
                roundRobin = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.RoundRobinManagerUpdate>(ref reader, options);
            }
            global::Letta.SupervisorManagerUpdate? supervisor = default;
            if (discriminator?.ManagerType == global::Letta.GroupUpdateManagerConfigVariant1DiscriminatorManagerType.Supervisor)
            {
                supervisor = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.SupervisorManagerUpdate>(ref reader, options);
            }
            global::Letta.DynamicManagerUpdate? dynamic = default;
            if (discriminator?.ManagerType == global::Letta.GroupUpdateManagerConfigVariant1DiscriminatorManagerType.Dynamic)
            {
                dynamic = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.DynamicManagerUpdate>(ref reader, options);
            }
            global::Letta.SleeptimeManagerUpdate? sleeptime = default;
            if (discriminator?.ManagerType == global::Letta.GroupUpdateManagerConfigVariant1DiscriminatorManagerType.Sleeptime)
            {
                sleeptime = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.SleeptimeManagerUpdate>(ref reader, options);
            }
            global::Letta.VoiceSleeptimeManagerUpdate? voiceSleeptime = default;
            if (discriminator?.ManagerType == global::Letta.GroupUpdateManagerConfigVariant1DiscriminatorManagerType.VoiceSleeptime)
            {
                voiceSleeptime = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.VoiceSleeptimeManagerUpdate>(ref reader, options);
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

            if (value.IsRoundRobin)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RoundRobin, typeof(global::Letta.RoundRobinManagerUpdate), options);
            }
            else if (value.IsSupervisor)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Supervisor, typeof(global::Letta.SupervisorManagerUpdate), options);
            }
            else if (value.IsDynamic)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dynamic, typeof(global::Letta.DynamicManagerUpdate), options);
            }
            else if (value.IsSleeptime)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sleeptime, typeof(global::Letta.SleeptimeManagerUpdate), options);
            }
            else if (value.IsVoiceSleeptime)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoiceSleeptime, typeof(global::Letta.VoiceSleeptimeManagerUpdate), options);
            }
        }
    }
}