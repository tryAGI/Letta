#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ApprovalsVariant1Item2 : global::System.IEquatable<ApprovalsVariant1Item2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Letta.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.ApprovalReturn? Approval { get; init; }
#else
        public global::Letta.ApprovalReturn? Approval { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Approval))]
#endif
        public bool IsApproval => Approval != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.LettaSchemasLettaMessageToolReturn? Tool { get; init; }
#else
        public global::Letta.LettaSchemasLettaMessageToolReturn? Tool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tool))]
#endif
        public bool IsTool => Tool != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApprovalsVariant1Item2(global::Letta.ApprovalReturn value) => new ApprovalsVariant1Item2((global::Letta.ApprovalReturn?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.ApprovalReturn?(ApprovalsVariant1Item2 @this) => @this.Approval;

        /// <summary>
        /// 
        /// </summary>
        public ApprovalsVariant1Item2(global::Letta.ApprovalReturn? value)
        {
            Approval = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ApprovalsVariant1Item2(global::Letta.LettaSchemasLettaMessageToolReturn value) => new ApprovalsVariant1Item2((global::Letta.LettaSchemasLettaMessageToolReturn?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.LettaSchemasLettaMessageToolReturn?(ApprovalsVariant1Item2 @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public ApprovalsVariant1Item2(global::Letta.LettaSchemasLettaMessageToolReturn? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ApprovalsVariant1Item2(
            global::Letta.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType? type,
            global::Letta.ApprovalReturn? approval,
            global::Letta.LettaSchemasLettaMessageToolReturn? tool
            )
        {
            Type = type;

            Approval = approval;
            Tool = tool;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Tool as object ??
            Approval as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Approval?.ToString() ??
            Tool?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApproval && !IsTool || !IsApproval && IsTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Letta.ApprovalReturn?, TResult>? approval = null,
            global::System.Func<global::Letta.LettaSchemasLettaMessageToolReturn?, TResult>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApproval && approval != null)
            {
                return approval(Approval!);
            }
            else if (IsTool && tool != null)
            {
                return tool(Tool!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Letta.ApprovalReturn?>? approval = null,
            global::System.Action<global::Letta.LettaSchemasLettaMessageToolReturn?>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApproval)
            {
                approval?.Invoke(Approval!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Approval,
                typeof(global::Letta.ApprovalReturn),
                Tool,
                typeof(global::Letta.LettaSchemasLettaMessageToolReturn),
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
        public bool Equals(ApprovalsVariant1Item2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Letta.ApprovalReturn?>.Default.Equals(Approval, other.Approval) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.LettaSchemasLettaMessageToolReturn?>.Default.Equals(Tool, other.Tool) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ApprovalsVariant1Item2 obj1, ApprovalsVariant1Item2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ApprovalsVariant1Item2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ApprovalsVariant1Item2 obj1, ApprovalsVariant1Item2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ApprovalsVariant1Item2 o && Equals(o);
        }
    }
}
