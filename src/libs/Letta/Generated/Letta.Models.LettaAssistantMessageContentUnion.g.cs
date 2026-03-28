#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct LettaAssistantMessageContentUnion : global::System.IEquatable<LettaAssistantMessageContentUnion>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Letta.LettaAssistantMessageContentUnionDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.TextContent? Text { get; init; }
#else
        public global::Letta.TextContent? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LettaAssistantMessageContentUnion(global::Letta.TextContent value) => new LettaAssistantMessageContentUnion((global::Letta.TextContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.TextContent?(LettaAssistantMessageContentUnion @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public LettaAssistantMessageContentUnion(global::Letta.TextContent? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LettaAssistantMessageContentUnion(
            global::Letta.LettaAssistantMessageContentUnionDiscriminatorType? type,
            global::Letta.TextContent? text
            )
        {
            Type = type;

            Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Letta.TextContent?, TResult>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Letta.TextContent?>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Letta.TextContent),
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
        public bool Equals(LettaAssistantMessageContentUnion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Letta.TextContent?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LettaAssistantMessageContentUnion obj1, LettaAssistantMessageContentUnion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LettaAssistantMessageContentUnion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LettaAssistantMessageContentUnion obj1, LettaAssistantMessageContentUnion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LettaAssistantMessageContentUnion o && Equals(o);
        }
    }
}
