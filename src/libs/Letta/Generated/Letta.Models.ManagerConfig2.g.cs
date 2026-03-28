#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Letta
{
    /// <summary>
    /// Default Value: {"manager_type":"round_robin"}
    /// </summary>
    public readonly partial struct ManagerConfig2 : global::System.IEquatable<ManagerConfig2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Letta.GroupSchemaManagerConfigDiscriminatorManagerType? ManagerType { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.RoundRobinManager? RoundRobin { get; init; }
#else
        public global::Letta.RoundRobinManager? RoundRobin { get; }
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
        public global::Letta.SupervisorManagerSchema? Supervisor { get; init; }
#else
        public global::Letta.SupervisorManagerSchema? Supervisor { get; }
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
        public global::Letta.DynamicManagerSchema? Dynamic { get; init; }
#else
        public global::Letta.DynamicManagerSchema? Dynamic { get; }
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
        public global::Letta.SleeptimeManagerSchema? Sleeptime { get; init; }
#else
        public global::Letta.SleeptimeManagerSchema? Sleeptime { get; }
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
        public global::Letta.VoiceSleeptimeManagerSchema? VoiceSleeptime { get; init; }
#else
        public global::Letta.VoiceSleeptimeManagerSchema? VoiceSleeptime { get; }
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
        public static implicit operator ManagerConfig2(global::Letta.RoundRobinManager value) => new ManagerConfig2((global::Letta.RoundRobinManager?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.RoundRobinManager?(ManagerConfig2 @this) => @this.RoundRobin;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfig2(global::Letta.RoundRobinManager? value)
        {
            RoundRobin = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfig2(global::Letta.SupervisorManagerSchema value) => new ManagerConfig2((global::Letta.SupervisorManagerSchema?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.SupervisorManagerSchema?(ManagerConfig2 @this) => @this.Supervisor;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfig2(global::Letta.SupervisorManagerSchema? value)
        {
            Supervisor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfig2(global::Letta.DynamicManagerSchema value) => new ManagerConfig2((global::Letta.DynamicManagerSchema?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.DynamicManagerSchema?(ManagerConfig2 @this) => @this.Dynamic;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfig2(global::Letta.DynamicManagerSchema? value)
        {
            Dynamic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfig2(global::Letta.SleeptimeManagerSchema value) => new ManagerConfig2((global::Letta.SleeptimeManagerSchema?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.SleeptimeManagerSchema?(ManagerConfig2 @this) => @this.Sleeptime;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfig2(global::Letta.SleeptimeManagerSchema? value)
        {
            Sleeptime = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfig2(global::Letta.VoiceSleeptimeManagerSchema value) => new ManagerConfig2((global::Letta.VoiceSleeptimeManagerSchema?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.VoiceSleeptimeManagerSchema?(ManagerConfig2 @this) => @this.VoiceSleeptime;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfig2(global::Letta.VoiceSleeptimeManagerSchema? value)
        {
            VoiceSleeptime = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfig2(
            global::Letta.GroupSchemaManagerConfigDiscriminatorManagerType? managerType,
            global::Letta.RoundRobinManager? roundRobin,
            global::Letta.SupervisorManagerSchema? supervisor,
            global::Letta.DynamicManagerSchema? dynamic,
            global::Letta.SleeptimeManagerSchema? sleeptime,
            global::Letta.VoiceSleeptimeManagerSchema? voiceSleeptime
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
            global::System.Func<global::Letta.RoundRobinManager?, TResult>? roundRobin = null,
            global::System.Func<global::Letta.SupervisorManagerSchema?, TResult>? supervisor = null,
            global::System.Func<global::Letta.DynamicManagerSchema?, TResult>? dynamic = null,
            global::System.Func<global::Letta.SleeptimeManagerSchema?, TResult>? sleeptime = null,
            global::System.Func<global::Letta.VoiceSleeptimeManagerSchema?, TResult>? voiceSleeptime = null,
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
            global::System.Action<global::Letta.RoundRobinManager?>? roundRobin = null,
            global::System.Action<global::Letta.SupervisorManagerSchema?>? supervisor = null,
            global::System.Action<global::Letta.DynamicManagerSchema?>? dynamic = null,
            global::System.Action<global::Letta.SleeptimeManagerSchema?>? sleeptime = null,
            global::System.Action<global::Letta.VoiceSleeptimeManagerSchema?>? voiceSleeptime = null,
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
                typeof(global::Letta.RoundRobinManager),
                Supervisor,
                typeof(global::Letta.SupervisorManagerSchema),
                Dynamic,
                typeof(global::Letta.DynamicManagerSchema),
                Sleeptime,
                typeof(global::Letta.SleeptimeManagerSchema),
                VoiceSleeptime,
                typeof(global::Letta.VoiceSleeptimeManagerSchema),
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
        public bool Equals(ManagerConfig2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Letta.RoundRobinManager?>.Default.Equals(RoundRobin, other.RoundRobin) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.SupervisorManagerSchema?>.Default.Equals(Supervisor, other.Supervisor) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.DynamicManagerSchema?>.Default.Equals(Dynamic, other.Dynamic) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.SleeptimeManagerSchema?>.Default.Equals(Sleeptime, other.Sleeptime) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.VoiceSleeptimeManagerSchema?>.Default.Equals(VoiceSleeptime, other.VoiceSleeptime) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ManagerConfig2 obj1, ManagerConfig2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ManagerConfig2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ManagerConfig2 obj1, ManagerConfig2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ManagerConfig2 o && Equals(o);
        }
    }
}
