#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolRulesVariant1Item : global::System.IEquatable<ToolRulesVariant1Item>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Letta.AgentStateToolRulesVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// A ToolRule represents a tool that can be invoked by the agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.ChildToolRule? ConstrainChildTools { get; init; }
#else
        public global::Letta.ChildToolRule? ConstrainChildTools { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConstrainChildTools))]
#endif
        public bool IsConstrainChildTools => ConstrainChildTools != null;

        /// <summary>
        /// Represents the initial tool rule configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.InitToolRule? RunFirst { get; init; }
#else
        public global::Letta.InitToolRule? RunFirst { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunFirst))]
#endif
        public bool IsRunFirst => RunFirst != null;

        /// <summary>
        /// Represents a terminal tool rule configuration where if this tool gets called, it must end the agent loop.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.TerminalToolRule? ExitLoop { get; init; }
#else
        public global::Letta.TerminalToolRule? ExitLoop { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExitLoop))]
#endif
        public bool IsExitLoop => ExitLoop != null;

        /// <summary>
        /// A ToolRule that conditionally maps to different child tools based on the output.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.ConditionalToolRule? Conditional { get; init; }
#else
        public global::Letta.ConditionalToolRule? Conditional { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Conditional))]
#endif
        public bool IsConditional => Conditional != null;

        /// <summary>
        /// Represents a tool rule configuration where if this tool gets called, it must continue the agent loop.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.ContinueToolRule? ContinueLoop { get; init; }
#else
        public global::Letta.ContinueToolRule? ContinueLoop { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContinueLoop))]
#endif
        public bool IsContinueLoop => ContinueLoop != null;

        /// <summary>
        /// Represents a tool rule configuration where this tool must be called before the agent loop can exit.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.RequiredBeforeExitToolRule? RequiredBeforeExit { get; init; }
#else
        public global::Letta.RequiredBeforeExitToolRule? RequiredBeforeExit { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequiredBeforeExit))]
#endif
        public bool IsRequiredBeforeExit => RequiredBeforeExit != null;

        /// <summary>
        /// Represents a tool rule configuration which constrains the total number of times this tool can be invoked in a single step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.MaxCountPerStepToolRule? MaxCountPerStep { get; init; }
#else
        public global::Letta.MaxCountPerStepToolRule? MaxCountPerStep { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MaxCountPerStep))]
#endif
        public bool IsMaxCountPerStep => MaxCountPerStep != null;

        /// <summary>
        /// A ToolRule that only allows a child tool to be called if the parent has been called.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.ParentToolRule? ParentLastTool { get; init; }
#else
        public global::Letta.ParentToolRule? ParentLastTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ParentLastTool))]
#endif
        public bool IsParentLastTool => ParentLastTool != null;

        /// <summary>
        /// Represents a tool rule configuration which requires approval before the tool can be invoked.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.RequiresApprovalToolRule? RequiresApproval { get; init; }
#else
        public global::Letta.RequiresApprovalToolRule? RequiresApproval { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequiresApproval))]
#endif
        public bool IsRequiresApproval => RequiresApproval != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolRulesVariant1Item(global::Letta.ChildToolRule value) => new ToolRulesVariant1Item((global::Letta.ChildToolRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.ChildToolRule?(ToolRulesVariant1Item @this) => @this.ConstrainChildTools;

        /// <summary>
        /// 
        /// </summary>
        public ToolRulesVariant1Item(global::Letta.ChildToolRule? value)
        {
            ConstrainChildTools = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolRulesVariant1Item(global::Letta.InitToolRule value) => new ToolRulesVariant1Item((global::Letta.InitToolRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.InitToolRule?(ToolRulesVariant1Item @this) => @this.RunFirst;

        /// <summary>
        /// 
        /// </summary>
        public ToolRulesVariant1Item(global::Letta.InitToolRule? value)
        {
            RunFirst = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolRulesVariant1Item(global::Letta.TerminalToolRule value) => new ToolRulesVariant1Item((global::Letta.TerminalToolRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.TerminalToolRule?(ToolRulesVariant1Item @this) => @this.ExitLoop;

        /// <summary>
        /// 
        /// </summary>
        public ToolRulesVariant1Item(global::Letta.TerminalToolRule? value)
        {
            ExitLoop = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolRulesVariant1Item(global::Letta.ConditionalToolRule value) => new ToolRulesVariant1Item((global::Letta.ConditionalToolRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.ConditionalToolRule?(ToolRulesVariant1Item @this) => @this.Conditional;

        /// <summary>
        /// 
        /// </summary>
        public ToolRulesVariant1Item(global::Letta.ConditionalToolRule? value)
        {
            Conditional = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolRulesVariant1Item(global::Letta.ContinueToolRule value) => new ToolRulesVariant1Item((global::Letta.ContinueToolRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.ContinueToolRule?(ToolRulesVariant1Item @this) => @this.ContinueLoop;

        /// <summary>
        /// 
        /// </summary>
        public ToolRulesVariant1Item(global::Letta.ContinueToolRule? value)
        {
            ContinueLoop = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolRulesVariant1Item(global::Letta.RequiredBeforeExitToolRule value) => new ToolRulesVariant1Item((global::Letta.RequiredBeforeExitToolRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.RequiredBeforeExitToolRule?(ToolRulesVariant1Item @this) => @this.RequiredBeforeExit;

        /// <summary>
        /// 
        /// </summary>
        public ToolRulesVariant1Item(global::Letta.RequiredBeforeExitToolRule? value)
        {
            RequiredBeforeExit = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolRulesVariant1Item(global::Letta.MaxCountPerStepToolRule value) => new ToolRulesVariant1Item((global::Letta.MaxCountPerStepToolRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.MaxCountPerStepToolRule?(ToolRulesVariant1Item @this) => @this.MaxCountPerStep;

        /// <summary>
        /// 
        /// </summary>
        public ToolRulesVariant1Item(global::Letta.MaxCountPerStepToolRule? value)
        {
            MaxCountPerStep = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolRulesVariant1Item(global::Letta.ParentToolRule value) => new ToolRulesVariant1Item((global::Letta.ParentToolRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.ParentToolRule?(ToolRulesVariant1Item @this) => @this.ParentLastTool;

        /// <summary>
        /// 
        /// </summary>
        public ToolRulesVariant1Item(global::Letta.ParentToolRule? value)
        {
            ParentLastTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolRulesVariant1Item(global::Letta.RequiresApprovalToolRule value) => new ToolRulesVariant1Item((global::Letta.RequiresApprovalToolRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.RequiresApprovalToolRule?(ToolRulesVariant1Item @this) => @this.RequiresApproval;

        /// <summary>
        /// 
        /// </summary>
        public ToolRulesVariant1Item(global::Letta.RequiresApprovalToolRule? value)
        {
            RequiresApproval = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolRulesVariant1Item(
            global::Letta.AgentStateToolRulesVariant1ItemDiscriminatorType? type,
            global::Letta.ChildToolRule? constrainChildTools,
            global::Letta.InitToolRule? runFirst,
            global::Letta.TerminalToolRule? exitLoop,
            global::Letta.ConditionalToolRule? conditional,
            global::Letta.ContinueToolRule? continueLoop,
            global::Letta.RequiredBeforeExitToolRule? requiredBeforeExit,
            global::Letta.MaxCountPerStepToolRule? maxCountPerStep,
            global::Letta.ParentToolRule? parentLastTool,
            global::Letta.RequiresApprovalToolRule? requiresApproval
            )
        {
            Type = type;

            ConstrainChildTools = constrainChildTools;
            RunFirst = runFirst;
            ExitLoop = exitLoop;
            Conditional = conditional;
            ContinueLoop = continueLoop;
            RequiredBeforeExit = requiredBeforeExit;
            MaxCountPerStep = maxCountPerStep;
            ParentLastTool = parentLastTool;
            RequiresApproval = requiresApproval;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RequiresApproval as object ??
            ParentLastTool as object ??
            MaxCountPerStep as object ??
            RequiredBeforeExit as object ??
            ContinueLoop as object ??
            Conditional as object ??
            ExitLoop as object ??
            RunFirst as object ??
            ConstrainChildTools as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ConstrainChildTools?.ToString() ??
            RunFirst?.ToString() ??
            ExitLoop?.ToString() ??
            Conditional?.ToString() ??
            ContinueLoop?.ToString() ??
            RequiredBeforeExit?.ToString() ??
            MaxCountPerStep?.ToString() ??
            ParentLastTool?.ToString() ??
            RequiresApproval?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConstrainChildTools && !IsRunFirst && !IsExitLoop && !IsConditional && !IsContinueLoop && !IsRequiredBeforeExit && !IsMaxCountPerStep && !IsParentLastTool && !IsRequiresApproval || !IsConstrainChildTools && IsRunFirst && !IsExitLoop && !IsConditional && !IsContinueLoop && !IsRequiredBeforeExit && !IsMaxCountPerStep && !IsParentLastTool && !IsRequiresApproval || !IsConstrainChildTools && !IsRunFirst && IsExitLoop && !IsConditional && !IsContinueLoop && !IsRequiredBeforeExit && !IsMaxCountPerStep && !IsParentLastTool && !IsRequiresApproval || !IsConstrainChildTools && !IsRunFirst && !IsExitLoop && IsConditional && !IsContinueLoop && !IsRequiredBeforeExit && !IsMaxCountPerStep && !IsParentLastTool && !IsRequiresApproval || !IsConstrainChildTools && !IsRunFirst && !IsExitLoop && !IsConditional && IsContinueLoop && !IsRequiredBeforeExit && !IsMaxCountPerStep && !IsParentLastTool && !IsRequiresApproval || !IsConstrainChildTools && !IsRunFirst && !IsExitLoop && !IsConditional && !IsContinueLoop && IsRequiredBeforeExit && !IsMaxCountPerStep && !IsParentLastTool && !IsRequiresApproval || !IsConstrainChildTools && !IsRunFirst && !IsExitLoop && !IsConditional && !IsContinueLoop && !IsRequiredBeforeExit && IsMaxCountPerStep && !IsParentLastTool && !IsRequiresApproval || !IsConstrainChildTools && !IsRunFirst && !IsExitLoop && !IsConditional && !IsContinueLoop && !IsRequiredBeforeExit && !IsMaxCountPerStep && IsParentLastTool && !IsRequiresApproval || !IsConstrainChildTools && !IsRunFirst && !IsExitLoop && !IsConditional && !IsContinueLoop && !IsRequiredBeforeExit && !IsMaxCountPerStep && !IsParentLastTool && IsRequiresApproval;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Letta.ChildToolRule?, TResult>? constrainChildTools = null,
            global::System.Func<global::Letta.InitToolRule?, TResult>? runFirst = null,
            global::System.Func<global::Letta.TerminalToolRule?, TResult>? exitLoop = null,
            global::System.Func<global::Letta.ConditionalToolRule?, TResult>? conditional = null,
            global::System.Func<global::Letta.ContinueToolRule?, TResult>? continueLoop = null,
            global::System.Func<global::Letta.RequiredBeforeExitToolRule?, TResult>? requiredBeforeExit = null,
            global::System.Func<global::Letta.MaxCountPerStepToolRule?, TResult>? maxCountPerStep = null,
            global::System.Func<global::Letta.ParentToolRule?, TResult>? parentLastTool = null,
            global::System.Func<global::Letta.RequiresApprovalToolRule?, TResult>? requiresApproval = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConstrainChildTools && constrainChildTools != null)
            {
                return constrainChildTools(ConstrainChildTools!);
            }
            else if (IsRunFirst && runFirst != null)
            {
                return runFirst(RunFirst!);
            }
            else if (IsExitLoop && exitLoop != null)
            {
                return exitLoop(ExitLoop!);
            }
            else if (IsConditional && conditional != null)
            {
                return conditional(Conditional!);
            }
            else if (IsContinueLoop && continueLoop != null)
            {
                return continueLoop(ContinueLoop!);
            }
            else if (IsRequiredBeforeExit && requiredBeforeExit != null)
            {
                return requiredBeforeExit(RequiredBeforeExit!);
            }
            else if (IsMaxCountPerStep && maxCountPerStep != null)
            {
                return maxCountPerStep(MaxCountPerStep!);
            }
            else if (IsParentLastTool && parentLastTool != null)
            {
                return parentLastTool(ParentLastTool!);
            }
            else if (IsRequiresApproval && requiresApproval != null)
            {
                return requiresApproval(RequiresApproval!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Letta.ChildToolRule?>? constrainChildTools = null,
            global::System.Action<global::Letta.InitToolRule?>? runFirst = null,
            global::System.Action<global::Letta.TerminalToolRule?>? exitLoop = null,
            global::System.Action<global::Letta.ConditionalToolRule?>? conditional = null,
            global::System.Action<global::Letta.ContinueToolRule?>? continueLoop = null,
            global::System.Action<global::Letta.RequiredBeforeExitToolRule?>? requiredBeforeExit = null,
            global::System.Action<global::Letta.MaxCountPerStepToolRule?>? maxCountPerStep = null,
            global::System.Action<global::Letta.ParentToolRule?>? parentLastTool = null,
            global::System.Action<global::Letta.RequiresApprovalToolRule?>? requiresApproval = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConstrainChildTools)
            {
                constrainChildTools?.Invoke(ConstrainChildTools!);
            }
            else if (IsRunFirst)
            {
                runFirst?.Invoke(RunFirst!);
            }
            else if (IsExitLoop)
            {
                exitLoop?.Invoke(ExitLoop!);
            }
            else if (IsConditional)
            {
                conditional?.Invoke(Conditional!);
            }
            else if (IsContinueLoop)
            {
                continueLoop?.Invoke(ContinueLoop!);
            }
            else if (IsRequiredBeforeExit)
            {
                requiredBeforeExit?.Invoke(RequiredBeforeExit!);
            }
            else if (IsMaxCountPerStep)
            {
                maxCountPerStep?.Invoke(MaxCountPerStep!);
            }
            else if (IsParentLastTool)
            {
                parentLastTool?.Invoke(ParentLastTool!);
            }
            else if (IsRequiresApproval)
            {
                requiresApproval?.Invoke(RequiresApproval!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ConstrainChildTools,
                typeof(global::Letta.ChildToolRule),
                RunFirst,
                typeof(global::Letta.InitToolRule),
                ExitLoop,
                typeof(global::Letta.TerminalToolRule),
                Conditional,
                typeof(global::Letta.ConditionalToolRule),
                ContinueLoop,
                typeof(global::Letta.ContinueToolRule),
                RequiredBeforeExit,
                typeof(global::Letta.RequiredBeforeExitToolRule),
                MaxCountPerStep,
                typeof(global::Letta.MaxCountPerStepToolRule),
                ParentLastTool,
                typeof(global::Letta.ParentToolRule),
                RequiresApproval,
                typeof(global::Letta.RequiresApprovalToolRule),
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
        public bool Equals(ToolRulesVariant1Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Letta.ChildToolRule?>.Default.Equals(ConstrainChildTools, other.ConstrainChildTools) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.InitToolRule?>.Default.Equals(RunFirst, other.RunFirst) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.TerminalToolRule?>.Default.Equals(ExitLoop, other.ExitLoop) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.ConditionalToolRule?>.Default.Equals(Conditional, other.Conditional) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.ContinueToolRule?>.Default.Equals(ContinueLoop, other.ContinueLoop) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.RequiredBeforeExitToolRule?>.Default.Equals(RequiredBeforeExit, other.RequiredBeforeExit) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.MaxCountPerStepToolRule?>.Default.Equals(MaxCountPerStep, other.MaxCountPerStep) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.ParentToolRule?>.Default.Equals(ParentLastTool, other.ParentLastTool) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.RequiresApprovalToolRule?>.Default.Equals(RequiresApproval, other.RequiresApproval) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolRulesVariant1Item obj1, ToolRulesVariant1Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolRulesVariant1Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolRulesVariant1Item obj1, ToolRulesVariant1Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolRulesVariant1Item o && Equals(o);
        }
    }
}
