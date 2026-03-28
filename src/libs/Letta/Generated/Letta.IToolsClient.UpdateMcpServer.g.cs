#nullable enable

namespace Letta
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Update Mcp Server<br/>
        /// Update an existing MCP server configuration
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Letta.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.AnyOf<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>> UpdateMcpServerAsync(
            string mcpServerName,

            global::Letta.AnyOf<global::Letta.LettaSchemasMcpUpdateStdioMCPServer, global::Letta.LettaSchemasMcpUpdateSSEMCPServer, global::Letta.LettaSchemasMcpUpdateStreamableHTTPMCPServer> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Mcp Server<br/>
        /// Update an existing MCP server configuration
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Letta.AnyOf<global::Letta.StdioServerConfig, global::Letta.SSEServerConfig, global::Letta.StreamableHTTPServerConfig>> UpdateMcpServerAsync(
            string mcpServerName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}