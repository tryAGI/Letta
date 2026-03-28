#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class ConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.Config>
    {
        /// <inheritdoc />
        public override global::Letta.Config Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.CreateMCPServerRequestConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.CreateMCPServerRequestConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.CreateMCPServerRequestConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Letta.CreateStdioMCPServer? stdio = default;
            if (discriminator?.McpServerType == global::Letta.CreateMCPServerRequestConfigDiscriminatorMcpServerType.Stdio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.CreateStdioMCPServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.CreateStdioMCPServer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.CreateStdioMCPServer)}");
                stdio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.CreateSSEMCPServer? sse = default;
            if (discriminator?.McpServerType == global::Letta.CreateMCPServerRequestConfigDiscriminatorMcpServerType.Sse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.CreateSSEMCPServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.CreateSSEMCPServer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.CreateSSEMCPServer)}");
                sse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.CreateStreamableHTTPMCPServer? streamableHttp = default;
            if (discriminator?.McpServerType == global::Letta.CreateMCPServerRequestConfigDiscriminatorMcpServerType.StreamableHttp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.CreateStreamableHTTPMCPServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.CreateStreamableHTTPMCPServer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.CreateStreamableHTTPMCPServer)}");
                streamableHttp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Letta.Config(
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
            global::Letta.Config value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStdio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.CreateStdioMCPServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.CreateStdioMCPServer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.CreateStdioMCPServer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Stdio, typeInfo);
            }
            else if (value.IsSse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.CreateSSEMCPServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.CreateSSEMCPServer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.CreateSSEMCPServer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sse, typeInfo);
            }
            else if (value.IsStreamableHttp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.CreateStreamableHTTPMCPServer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.CreateStreamableHTTPMCPServer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.CreateStreamableHTTPMCPServer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamableHttp, typeInfo);
            }
        }
    }
}