#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class Config4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.Config4>
    {
        /// <inheritdoc />
        public override global::Letta.Config4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.UpdateMCPServerRequestConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.UpdateMCPServerRequestConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.UpdateMCPServerRequestConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Letta.LettaSchemasMcpServerUpdateStdioMCPServer? stdio = default;
            if (discriminator?.McpServerType == global::Letta.UpdateMCPServerRequestConfigDiscriminatorMcpServerType.Stdio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.LettaSchemasMcpServerUpdateStdioMCPServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.LettaSchemasMcpServerUpdateStdioMCPServer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.LettaSchemasMcpServerUpdateStdioMCPServer)}");
                stdio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.LettaSchemasMcpServerUpdateSSEMCPServer? sse = default;
            if (discriminator?.McpServerType == global::Letta.UpdateMCPServerRequestConfigDiscriminatorMcpServerType.Sse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.LettaSchemasMcpServerUpdateSSEMCPServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.LettaSchemasMcpServerUpdateSSEMCPServer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.LettaSchemasMcpServerUpdateSSEMCPServer)}");
                sse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer? streamableHttp = default;
            if (discriminator?.McpServerType == global::Letta.UpdateMCPServerRequestConfigDiscriminatorMcpServerType.StreamableHttp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer)}");
                streamableHttp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Letta.Config4(
                discriminator?.McpServerType,
                stdio,

                sse,

                streamableHttp
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.Config4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStdio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.LettaSchemasMcpServerUpdateStdioMCPServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.LettaSchemasMcpServerUpdateStdioMCPServer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.LettaSchemasMcpServerUpdateStdioMCPServer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Stdio, typeInfo);
            }
            else if (value.IsSse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.LettaSchemasMcpServerUpdateSSEMCPServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.LettaSchemasMcpServerUpdateSSEMCPServer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.LettaSchemasMcpServerUpdateSSEMCPServer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sse, typeInfo);
            }
            else if (value.IsStreamableHttp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamableHttp, typeInfo);
            }
        }
    }
}