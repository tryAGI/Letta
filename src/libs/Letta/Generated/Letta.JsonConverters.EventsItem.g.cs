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

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("data")) __score0++;
            if (__jsonProps.Contains("timestamp")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("data")) __score1++;
            if (__jsonProps.Contains("timestamp")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("data")) __score2++;
            if (__jsonProps.Contains("timestamp")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("data")) __score3++;
            if (__jsonProps.Contains("timestamp")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("data")) __score4++;
            if (__jsonProps.Contains("timestamp")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::Letta.MetadataSendTelemetryRequestEventVariant1? sessionStart = default;
            global::Letta.MetadataSendTelemetryRequestEventVariant2? sessionEnd = default;
            global::Letta.MetadataSendTelemetryRequestEventVariant3? toolUsage = default;
            global::Letta.MetadataSendTelemetryRequestEventVariant4? error = default;
            global::Letta.MetadataSendTelemetryRequestEventVariant5? userInput = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.MetadataSendTelemetryRequestEventVariant1).Name}");
                        sessionStart = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.MetadataSendTelemetryRequestEventVariant2).Name}");
                        sessionEnd = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.MetadataSendTelemetryRequestEventVariant3).Name}");
                        toolUsage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.MetadataSendTelemetryRequestEventVariant4).Name}");
                        error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.MetadataSendTelemetryRequestEventVariant5).Name}");
                        userInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (sessionStart == null && sessionEnd == null && toolUsage == null && error == null && userInput == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.MetadataSendTelemetryRequestEventVariant1).Name}");
                    sessionStart = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.MetadataSendTelemetryRequestEventVariant2).Name}");
                    sessionEnd = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.MetadataSendTelemetryRequestEventVariant3).Name}");
                    toolUsage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.MetadataSendTelemetryRequestEventVariant4).Name}");
                    error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.MetadataSendTelemetryRequestEventVariant5).Name}");
                    userInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Letta.EventsItem(
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
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionStart, typeInfo);
            }
            else if (value.IsSessionEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.MetadataSendTelemetryRequestEventVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionEnd, typeInfo);
            }
            else if (value.IsToolUsage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.MetadataSendTelemetryRequestEventVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolUsage, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.MetadataSendTelemetryRequestEventVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
            else if (value.IsUserInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MetadataSendTelemetryRequestEventVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.MetadataSendTelemetryRequestEventVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserInput, typeInfo);
            }
        }
    }
}