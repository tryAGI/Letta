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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.UpdateMCPServerRequestConfigDiscriminator>(ref readerCopy, options);

            global::Letta.LettaSchemasMcpServerUpdateStdioMCPServer? stdio = default;
            if (discriminator?.McpServerType == global::Letta.UpdateMCPServerRequestConfigDiscriminatorMcpServerType.Stdio)
            {
                stdio = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.LettaSchemasMcpServerUpdateStdioMCPServer>(ref reader, options);
            }
            global::Letta.LettaSchemasMcpServerUpdateSSEMCPServer? sse = default;
            if (discriminator?.McpServerType == global::Letta.UpdateMCPServerRequestConfigDiscriminatorMcpServerType.Sse)
            {
                sse = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.LettaSchemasMcpServerUpdateSSEMCPServer>(ref reader, options);
            }
            global::Letta.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer? streamableHttp = default;
            if (discriminator?.McpServerType == global::Letta.UpdateMCPServerRequestConfigDiscriminatorMcpServerType.StreamableHttp)
            {
                streamableHttp = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer>(ref reader, options);
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

            if (value.IsStdio)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Stdio, typeof(global::Letta.LettaSchemasMcpServerUpdateStdioMCPServer), options);
            }
            else if (value.IsSse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sse, typeof(global::Letta.LettaSchemasMcpServerUpdateSSEMCPServer), options);
            }
            else if (value.IsStreamableHttp)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamableHttp, typeof(global::Letta.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer), options);
            }
        }
    }
}