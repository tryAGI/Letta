#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EventsItem : global::System.IEquatable<EventsItem>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.MetadataSendTelemetryRequestEventVariant1? SessionStart { get; init; }
#else
        public global::Letta.MetadataSendTelemetryRequestEventVariant1? SessionStart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionStart))]
#endif
        public bool IsSessionStart => SessionStart != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.MetadataSendTelemetryRequestEventVariant2? SessionEnd { get; init; }
#else
        public global::Letta.MetadataSendTelemetryRequestEventVariant2? SessionEnd { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionEnd))]
#endif
        public bool IsSessionEnd => SessionEnd != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.MetadataSendTelemetryRequestEventVariant3? ToolUsage { get; init; }
#else
        public global::Letta.MetadataSendTelemetryRequestEventVariant3? ToolUsage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolUsage))]
#endif
        public bool IsToolUsage => ToolUsage != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.MetadataSendTelemetryRequestEventVariant4? Error { get; init; }
#else
        public global::Letta.MetadataSendTelemetryRequestEventVariant4? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.MetadataSendTelemetryRequestEventVariant5? UserInput { get; init; }
#else
        public global::Letta.MetadataSendTelemetryRequestEventVariant5? UserInput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserInput))]
#endif
        public bool IsUserInput => UserInput != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventsItem(global::Letta.MetadataSendTelemetryRequestEventVariant1 value) => new EventsItem((global::Letta.MetadataSendTelemetryRequestEventVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.MetadataSendTelemetryRequestEventVariant1?(EventsItem @this) => @this.SessionStart;

        /// <summary>
        /// 
        /// </summary>
        public EventsItem(global::Letta.MetadataSendTelemetryRequestEventVariant1? value)
        {
            SessionStart = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventsItem(global::Letta.MetadataSendTelemetryRequestEventVariant2 value) => new EventsItem((global::Letta.MetadataSendTelemetryRequestEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.MetadataSendTelemetryRequestEventVariant2?(EventsItem @this) => @this.SessionEnd;

        /// <summary>
        /// 
        /// </summary>
        public EventsItem(global::Letta.MetadataSendTelemetryRequestEventVariant2? value)
        {
            SessionEnd = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventsItem(global::Letta.MetadataSendTelemetryRequestEventVariant3 value) => new EventsItem((global::Letta.MetadataSendTelemetryRequestEventVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.MetadataSendTelemetryRequestEventVariant3?(EventsItem @this) => @this.ToolUsage;

        /// <summary>
        /// 
        /// </summary>
        public EventsItem(global::Letta.MetadataSendTelemetryRequestEventVariant3? value)
        {
            ToolUsage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventsItem(global::Letta.MetadataSendTelemetryRequestEventVariant4 value) => new EventsItem((global::Letta.MetadataSendTelemetryRequestEventVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.MetadataSendTelemetryRequestEventVariant4?(EventsItem @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public EventsItem(global::Letta.MetadataSendTelemetryRequestEventVariant4? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EventsItem(global::Letta.MetadataSendTelemetryRequestEventVariant5 value) => new EventsItem((global::Letta.MetadataSendTelemetryRequestEventVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.MetadataSendTelemetryRequestEventVariant5?(EventsItem @this) => @this.UserInput;

        /// <summary>
        /// 
        /// </summary>
        public EventsItem(global::Letta.MetadataSendTelemetryRequestEventVariant5? value)
        {
            UserInput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EventsItem(
            global::Letta.MetadataSendTelemetryRequestEventVariant1? sessionStart,
            global::Letta.MetadataSendTelemetryRequestEventVariant2? sessionEnd,
            global::Letta.MetadataSendTelemetryRequestEventVariant3? toolUsage,
            global::Letta.MetadataSendTelemetryRequestEventVariant4? error,
            global::Letta.MetadataSendTelemetryRequestEventVariant5? userInput
            )
        {
            SessionStart = sessionStart;
            SessionEnd = sessionEnd;
            ToolUsage = toolUsage;
            Error = error;
            UserInput = userInput;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UserInput as object ??
            Error as object ??
            ToolUsage as object ??
            SessionEnd as object ??
            SessionStart as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SessionStart?.ToString() ??
            SessionEnd?.ToString() ??
            ToolUsage?.ToString() ??
            Error?.ToString() ??
            UserInput?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSessionStart && !IsSessionEnd && !IsToolUsage && !IsError && !IsUserInput || !IsSessionStart && IsSessionEnd && !IsToolUsage && !IsError && !IsUserInput || !IsSessionStart && !IsSessionEnd && IsToolUsage && !IsError && !IsUserInput || !IsSessionStart && !IsSessionEnd && !IsToolUsage && IsError && !IsUserInput || !IsSessionStart && !IsSessionEnd && !IsToolUsage && !IsError && IsUserInput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Letta.MetadataSendTelemetryRequestEventVariant1?, TResult>? sessionStart = null,
            global::System.Func<global::Letta.MetadataSendTelemetryRequestEventVariant2?, TResult>? sessionEnd = null,
            global::System.Func<global::Letta.MetadataSendTelemetryRequestEventVariant3?, TResult>? toolUsage = null,
            global::System.Func<global::Letta.MetadataSendTelemetryRequestEventVariant4?, TResult>? error = null,
            global::System.Func<global::Letta.MetadataSendTelemetryRequestEventVariant5?, TResult>? userInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionStart && sessionStart != null)
            {
                return sessionStart(SessionStart!);
            }
            else if (IsSessionEnd && sessionEnd != null)
            {
                return sessionEnd(SessionEnd!);
            }
            else if (IsToolUsage && toolUsage != null)
            {
                return toolUsage(ToolUsage!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }
            else if (IsUserInput && userInput != null)
            {
                return userInput(UserInput!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Letta.MetadataSendTelemetryRequestEventVariant1?>? sessionStart = null,
            global::System.Action<global::Letta.MetadataSendTelemetryRequestEventVariant2?>? sessionEnd = null,
            global::System.Action<global::Letta.MetadataSendTelemetryRequestEventVariant3?>? toolUsage = null,
            global::System.Action<global::Letta.MetadataSendTelemetryRequestEventVariant4?>? error = null,
            global::System.Action<global::Letta.MetadataSendTelemetryRequestEventVariant5?>? userInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionStart)
            {
                sessionStart?.Invoke(SessionStart!);
            }
            else if (IsSessionEnd)
            {
                sessionEnd?.Invoke(SessionEnd!);
            }
            else if (IsToolUsage)
            {
                toolUsage?.Invoke(ToolUsage!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsUserInput)
            {
                userInput?.Invoke(UserInput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SessionStart,
                typeof(global::Letta.MetadataSendTelemetryRequestEventVariant1),
                SessionEnd,
                typeof(global::Letta.MetadataSendTelemetryRequestEventVariant2),
                ToolUsage,
                typeof(global::Letta.MetadataSendTelemetryRequestEventVariant3),
                Error,
                typeof(global::Letta.MetadataSendTelemetryRequestEventVariant4),
                UserInput,
                typeof(global::Letta.MetadataSendTelemetryRequestEventVariant5),
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
        public bool Equals(EventsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Letta.MetadataSendTelemetryRequestEventVariant1?>.Default.Equals(SessionStart, other.SessionStart) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.MetadataSendTelemetryRequestEventVariant2?>.Default.Equals(SessionEnd, other.SessionEnd) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.MetadataSendTelemetryRequestEventVariant3?>.Default.Equals(ToolUsage, other.ToolUsage) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.MetadataSendTelemetryRequestEventVariant4?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.MetadataSendTelemetryRequestEventVariant5?>.Default.Equals(UserInput, other.UserInput) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EventsItem obj1, EventsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EventsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EventsItem obj1, EventsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EventsItem o && Equals(o);
        }
    }
}
