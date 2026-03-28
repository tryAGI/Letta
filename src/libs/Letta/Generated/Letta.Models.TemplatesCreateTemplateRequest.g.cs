#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Letta
{
    /// <summary>
    /// The type of template to create, currently only agent templates are supported
    /// </summary>
    public readonly partial struct TemplatesCreateTemplateRequest : global::System.IEquatable<TemplatesCreateTemplateRequest>
    {
        /// <summary>
        /// Create a template from an existing agent
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.TemplatesCreateTemplateRequestVariant1? Agent { get; init; }
#else
        public global::Letta.TemplatesCreateTemplateRequestVariant1? Agent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Agent))]
#endif
        public bool IsAgent => Agent != null;

        /// <summary>
        /// Create a template from an uploaded agent file
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.TemplatesCreateTemplateRequestVariant2? AgentFile { get; init; }
#else
        public global::Letta.TemplatesCreateTemplateRequestVariant2? AgentFile { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentFile))]
#endif
        public bool IsAgentFile => AgentFile != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TemplatesCreateTemplateRequest(global::Letta.TemplatesCreateTemplateRequestVariant1 value) => new TemplatesCreateTemplateRequest((global::Letta.TemplatesCreateTemplateRequestVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.TemplatesCreateTemplateRequestVariant1?(TemplatesCreateTemplateRequest @this) => @this.Agent;

        /// <summary>
        /// 
        /// </summary>
        public TemplatesCreateTemplateRequest(global::Letta.TemplatesCreateTemplateRequestVariant1? value)
        {
            Agent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TemplatesCreateTemplateRequest(global::Letta.TemplatesCreateTemplateRequestVariant2 value) => new TemplatesCreateTemplateRequest((global::Letta.TemplatesCreateTemplateRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.TemplatesCreateTemplateRequestVariant2?(TemplatesCreateTemplateRequest @this) => @this.AgentFile;

        /// <summary>
        /// 
        /// </summary>
        public TemplatesCreateTemplateRequest(global::Letta.TemplatesCreateTemplateRequestVariant2? value)
        {
            AgentFile = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TemplatesCreateTemplateRequest(
            global::Letta.TemplatesCreateTemplateRequestVariant1? agent,
            global::Letta.TemplatesCreateTemplateRequestVariant2? agentFile
            )
        {
            Agent = agent;
            AgentFile = agentFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AgentFile as object ??
            Agent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Agent?.ToString() ??
            AgentFile?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgent && !IsAgentFile || !IsAgent && IsAgentFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Letta.TemplatesCreateTemplateRequestVariant1?, TResult>? agent = null,
            global::System.Func<global::Letta.TemplatesCreateTemplateRequestVariant2?, TResult>? agentFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgent && agent != null)
            {
                return agent(Agent!);
            }
            else if (IsAgentFile && agentFile != null)
            {
                return agentFile(AgentFile!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Letta.TemplatesCreateTemplateRequestVariant1?>? agent = null,
            global::System.Action<global::Letta.TemplatesCreateTemplateRequestVariant2?>? agentFile = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgent)
            {
                agent?.Invoke(Agent!);
            }
            else if (IsAgentFile)
            {
                agentFile?.Invoke(AgentFile!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Agent,
                typeof(global::Letta.TemplatesCreateTemplateRequestVariant1),
                AgentFile,
                typeof(global::Letta.TemplatesCreateTemplateRequestVariant2),
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
        public bool Equals(TemplatesCreateTemplateRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Letta.TemplatesCreateTemplateRequestVariant1?>.Default.Equals(Agent, other.Agent) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.TemplatesCreateTemplateRequestVariant2?>.Default.Equals(AgentFile, other.AgentFile) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TemplatesCreateTemplateRequest obj1, TemplatesCreateTemplateRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TemplatesCreateTemplateRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TemplatesCreateTemplateRequest obj1, TemplatesCreateTemplateRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TemplatesCreateTemplateRequest o && Equals(o);
        }
    }
}
