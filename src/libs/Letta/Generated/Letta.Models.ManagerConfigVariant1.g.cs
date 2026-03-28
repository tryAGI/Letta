#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ManagerConfigVariant1 : global::System.IEquatable<ManagerConfigVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Letta.GroupUpdateManagerConfigVariant1DiscriminatorManagerType? ManagerType { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.RoundRobinManagerUpdate? RoundRobin { get; init; }
#else
        public global::Letta.RoundRobinManagerUpdate? RoundRobin { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RoundRobin))]
#endif
        public bool IsRoundRobin => RoundRobin != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.SupervisorManagerUpdate? Supervisor { get; init; }
#else
        public global::Letta.SupervisorManagerUpdate? Supervisor { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Supervisor))]
#endif
        public bool IsSupervisor => Supervisor != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.DynamicManagerUpdate? Dynamic { get; init; }
#else
        public global::Letta.DynamicManagerUpdate? Dynamic { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dynamic))]
#endif
        public bool IsDynamic => Dynamic != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.SleeptimeManagerUpdate? Sleeptime { get; init; }
#else
        public global::Letta.SleeptimeManagerUpdate? Sleeptime { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sleeptime))]
#endif
        public bool IsSleeptime => Sleeptime != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.VoiceSleeptimeManagerUpdate? VoiceSleeptime { get; init; }
#else
        public global::Letta.VoiceSleeptimeManagerUpdate? VoiceSleeptime { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VoiceSleeptime))]
#endif
        public bool IsVoiceSleeptime => VoiceSleeptime != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfigVariant1(global::Letta.RoundRobinManagerUpdate value) => new ManagerConfigVariant1((global::Letta.RoundRobinManagerUpdate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.RoundRobinManagerUpdate?(ManagerConfigVariant1 @this) => @this.RoundRobin;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfigVariant1(global::Letta.RoundRobinManagerUpdate? value)
        {
            RoundRobin = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfigVariant1(global::Letta.SupervisorManagerUpdate value) => new ManagerConfigVariant1((global::Letta.SupervisorManagerUpdate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.SupervisorManagerUpdate?(ManagerConfigVariant1 @this) => @this.Supervisor;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfigVariant1(global::Letta.SupervisorManagerUpdate? value)
        {
            Supervisor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfigVariant1(global::Letta.DynamicManagerUpdate value) => new ManagerConfigVariant1((global::Letta.DynamicManagerUpdate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.DynamicManagerUpdate?(ManagerConfigVariant1 @this) => @this.Dynamic;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfigVariant1(global::Letta.DynamicManagerUpdate? value)
        {
            Dynamic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfigVariant1(global::Letta.SleeptimeManagerUpdate value) => new ManagerConfigVariant1((global::Letta.SleeptimeManagerUpdate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.SleeptimeManagerUpdate?(ManagerConfigVariant1 @this) => @this.Sleeptime;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfigVariant1(global::Letta.SleeptimeManagerUpdate? value)
        {
            Sleeptime = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfigVariant1(global::Letta.VoiceSleeptimeManagerUpdate value) => new ManagerConfigVariant1((global::Letta.VoiceSleeptimeManagerUpdate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.VoiceSleeptimeManagerUpdate?(ManagerConfigVariant1 @this) => @this.VoiceSleeptime;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfigVariant1(global::Letta.VoiceSleeptimeManagerUpdate? value)
        {
            VoiceSleeptime = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfigVariant1(
            global::Letta.GroupUpdateManagerConfigVariant1DiscriminatorManagerType? managerType,
            global::Letta.RoundRobinManagerUpdate? roundRobin,
            global::Letta.SupervisorManagerUpdate? supervisor,
            global::Letta.DynamicManagerUpdate? dynamic,
            global::Letta.SleeptimeManagerUpdate? sleeptime,
            global::Letta.VoiceSleeptimeManagerUpdate? voiceSleeptime
            )
        {
            ManagerType = managerType;

            RoundRobin = roundRobin;
            Supervisor = supervisor;
            Dynamic = dynamic;
            Sleeptime = sleeptime;
            VoiceSleeptime = voiceSleeptime;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VoiceSleeptime as object ??
            Sleeptime as object ??
            Dynamic as object ??
            Supervisor as object ??
            RoundRobin as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RoundRobin?.ToString() ??
            Supervisor?.ToString() ??
            Dynamic?.ToString() ??
            Sleeptime?.ToString() ??
            VoiceSleeptime?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRoundRobin && !IsSupervisor && !IsDynamic && !IsSleeptime && !IsVoiceSleeptime || !IsRoundRobin && IsSupervisor && !IsDynamic && !IsSleeptime && !IsVoiceSleeptime || !IsRoundRobin && !IsSupervisor && IsDynamic && !IsSleeptime && !IsVoiceSleeptime || !IsRoundRobin && !IsSupervisor && !IsDynamic && IsSleeptime && !IsVoiceSleeptime || !IsRoundRobin && !IsSupervisor && !IsDynamic && !IsSleeptime && IsVoiceSleeptime;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Letta.RoundRobinManagerUpdate?, TResult>? roundRobin = null,
            global::System.Func<global::Letta.SupervisorManagerUpdate?, TResult>? supervisor = null,
            global::System.Func<global::Letta.DynamicManagerUpdate?, TResult>? dynamic = null,
            global::System.Func<global::Letta.SleeptimeManagerUpdate?, TResult>? sleeptime = null,
            global::System.Func<global::Letta.VoiceSleeptimeManagerUpdate?, TResult>? voiceSleeptime = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRoundRobin && roundRobin != null)
            {
                return roundRobin(RoundRobin!);
            }
            else if (IsSupervisor && supervisor != null)
            {
                return supervisor(Supervisor!);
            }
            else if (IsDynamic && dynamic != null)
            {
                return dynamic(Dynamic!);
            }
            else if (IsSleeptime && sleeptime != null)
            {
                return sleeptime(Sleeptime!);
            }
            else if (IsVoiceSleeptime && voiceSleeptime != null)
            {
                return voiceSleeptime(VoiceSleeptime!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Letta.RoundRobinManagerUpdate?>? roundRobin = null,
            global::System.Action<global::Letta.SupervisorManagerUpdate?>? supervisor = null,
            global::System.Action<global::Letta.DynamicManagerUpdate?>? dynamic = null,
            global::System.Action<global::Letta.SleeptimeManagerUpdate?>? sleeptime = null,
            global::System.Action<global::Letta.VoiceSleeptimeManagerUpdate?>? voiceSleeptime = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRoundRobin)
            {
                roundRobin?.Invoke(RoundRobin!);
            }
            else if (IsSupervisor)
            {
                supervisor?.Invoke(Supervisor!);
            }
            else if (IsDynamic)
            {
                dynamic?.Invoke(Dynamic!);
            }
            else if (IsSleeptime)
            {
                sleeptime?.Invoke(Sleeptime!);
            }
            else if (IsVoiceSleeptime)
            {
                voiceSleeptime?.Invoke(VoiceSleeptime!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RoundRobin,
                typeof(global::Letta.RoundRobinManagerUpdate),
                Supervisor,
                typeof(global::Letta.SupervisorManagerUpdate),
                Dynamic,
                typeof(global::Letta.DynamicManagerUpdate),
                Sleeptime,
                typeof(global::Letta.SleeptimeManagerUpdate),
                VoiceSleeptime,
                typeof(global::Letta.VoiceSleeptimeManagerUpdate),
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
        public bool Equals(ManagerConfigVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Letta.RoundRobinManagerUpdate?>.Default.Equals(RoundRobin, other.RoundRobin) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.SupervisorManagerUpdate?>.Default.Equals(Supervisor, other.Supervisor) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.DynamicManagerUpdate?>.Default.Equals(Dynamic, other.Dynamic) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.SleeptimeManagerUpdate?>.Default.Equals(Sleeptime, other.Sleeptime) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.VoiceSleeptimeManagerUpdate?>.Default.Equals(VoiceSleeptime, other.VoiceSleeptime) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ManagerConfigVariant1 obj1, ManagerConfigVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ManagerConfigVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ManagerConfigVariant1 obj1, ManagerConfigVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ManagerConfigVariant1 o && Equals(o);
        }
    }
}
