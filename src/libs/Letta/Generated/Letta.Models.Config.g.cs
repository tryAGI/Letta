#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Letta
{
    /// <summary>
    /// The MCP server configuration (Stdio, SSE, or Streamable HTTP)
    /// </summary>
    public readonly partial struct Config : global::System.IEquatable<Config>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Letta.CreateMCPServerRequestConfigDiscriminatorMcpServerType? McpServerType { get; }

        /// <summary>
        /// Create a new Stdio MCP server
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.CreateStdioMCPServer? Stdio { get; init; }
#else
        public global::Letta.CreateStdioMCPServer? Stdio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Stdio))]
#endif
        public bool IsStdio => Stdio != null;

        /// <summary>
        /// Create a new SSE MCP server
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.CreateSSEMCPServer? Sse { get; init; }
#else
        public global::Letta.CreateSSEMCPServer? Sse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sse))]
#endif
        public bool IsSse => Sse != null;

        /// <summary>
        /// Create a new Streamable HTTP MCP server
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.CreateStreamableHTTPMCPServer? StreamableHttp { get; init; }
#else
        public global::Letta.CreateStreamableHTTPMCPServer? StreamableHttp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamableHttp))]
#endif
        public bool IsStreamableHttp => StreamableHttp != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Config(global::Letta.CreateStdioMCPServer value) => new Config((global::Letta.CreateStdioMCPServer?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.CreateStdioMCPServer?(Config @this) => @this.Stdio;

        /// <summary>
        /// 
        /// </summary>
        public Config(global::Letta.CreateStdioMCPServer? value)
        {
            Stdio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Config(global::Letta.CreateSSEMCPServer value) => new Config((global::Letta.CreateSSEMCPServer?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.CreateSSEMCPServer?(Config @this) => @this.Sse;

        /// <summary>
        /// 
        /// </summary>
        public Config(global::Letta.CreateSSEMCPServer? value)
        {
            Sse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Config(global::Letta.CreateStreamableHTTPMCPServer value) => new Config((global::Letta.CreateStreamableHTTPMCPServer?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.CreateStreamableHTTPMCPServer?(Config @this) => @this.StreamableHttp;

        /// <summary>
        /// 
        /// </summary>
        public Config(global::Letta.CreateStreamableHTTPMCPServer? value)
        {
            StreamableHttp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Config(
            global::Letta.CreateMCPServerRequestConfigDiscriminatorMcpServerType? mcpServerType,
            global::Letta.CreateStdioMCPServer? stdio,
            global::Letta.CreateSSEMCPServer? sse,
            global::Letta.CreateStreamableHTTPMCPServer? streamableHttp
            )
        {
            McpServerType = mcpServerType;

            Stdio = stdio;
            Sse = sse;
            StreamableHttp = streamableHttp;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StreamableHttp as object ??
            Sse as object ??
            Stdio as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Stdio?.ToString() ??
            Sse?.ToString() ??
            StreamableHttp?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStdio && !IsSse && !IsStreamableHttp || !IsStdio && IsSse && !IsStreamableHttp || !IsStdio && !IsSse && IsStreamableHttp;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Letta.CreateStdioMCPServer?, TResult>? stdio = null,
            global::System.Func<global::Letta.CreateSSEMCPServer?, TResult>? sse = null,
            global::System.Func<global::Letta.CreateStreamableHTTPMCPServer?, TResult>? streamableHttp = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStdio && stdio != null)
            {
                return stdio(Stdio!);
            }
            else if (IsSse && sse != null)
            {
                return sse(Sse!);
            }
            else if (IsStreamableHttp && streamableHttp != null)
            {
                return streamableHttp(StreamableHttp!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Letta.CreateStdioMCPServer?>? stdio = null,
            global::System.Action<global::Letta.CreateSSEMCPServer?>? sse = null,
            global::System.Action<global::Letta.CreateStreamableHTTPMCPServer?>? streamableHttp = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStdio)
            {
                stdio?.Invoke(Stdio!);
            }
            else if (IsSse)
            {
                sse?.Invoke(Sse!);
            }
            else if (IsStreamableHttp)
            {
                streamableHttp?.Invoke(StreamableHttp!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Stdio,
                typeof(global::Letta.CreateStdioMCPServer),
                Sse,
                typeof(global::Letta.CreateSSEMCPServer),
                StreamableHttp,
                typeof(global::Letta.CreateStreamableHTTPMCPServer),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Config other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Letta.CreateStdioMCPServer?>.Default.Equals(Stdio, other.Stdio) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.CreateSSEMCPServer?>.Default.Equals(Sse, other.Sse) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.CreateStreamableHTTPMCPServer?>.Default.Equals(StreamableHttp, other.StreamableHttp) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Config obj1, Config obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Config>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Config obj1, Config obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Config o && Equals(o);
        }
    }
}
