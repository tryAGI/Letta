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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.CreateMCPServerRequestConfigDiscriminator>(ref readerCopy, options);

            global::Letta.CreateStdioMCPServer? stdio = default;
            if (discriminator?.McpServerType == global::Letta.CreateMCPServerRequestConfigDiscriminatorMcpServerType.Stdio)
            {
                stdio = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.CreateStdioMCPServer>(ref reader, options);
            }
            global::Letta.CreateSSEMCPServer? sse = default;
            if (discriminator?.McpServerType == global::Letta.CreateMCPServerRequestConfigDiscriminatorMcpServerType.Sse)
            {
                sse = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.CreateSSEMCPServer>(ref reader, options);
            }
            global::Letta.CreateStreamableHTTPMCPServer? streamableHttp = default;
            if (discriminator?.McpServerType == global::Letta.CreateMCPServerRequestConfigDiscriminatorMcpServerType.StreamableHttp)
            {
                streamableHttp = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.CreateStreamableHTTPMCPServer>(ref reader, options);
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

            if (value.IsStdio)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Stdio, typeof(global::Letta.CreateStdioMCPServer), options);
            }
            else if (value.IsSse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sse, typeof(global::Letta.CreateSSEMCPServer), options);
            }
            else if (value.IsStreamableHttp)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamableHttp, typeof(global::Letta.CreateStreamableHTTPMCPServer), options);
            }
        }
    }
}