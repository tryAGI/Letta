#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Letta
{
    /// <summary>
    /// Default Value: {"manager_type":"round_robin"}
    /// </summary>
    public readonly partial struct ManagerConfig : global::System.IEquatable<ManagerConfig>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Letta.GroupCreateManagerConfigDiscriminatorManagerType? ManagerType { get; }

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
        public global::Letta.SupervisorManager? Supervisor { get; init; }
#else
        public global::Letta.SupervisorManager? Supervisor { get; }
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
        public global::Letta.DynamicManager? Dynamic { get; init; }
#else
        public global::Letta.DynamicManager? Dynamic { get; }
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
        public global::Letta.SleeptimeManager? Sleeptime { get; init; }
#else
        public global::Letta.SleeptimeManager? Sleeptime { get; }
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
        public global::Letta.VoiceSleeptimeManager? VoiceSleeptime { get; init; }
#else
        public global::Letta.VoiceSleeptimeManager? VoiceSleeptime { get; }
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
        public static implicit operator ManagerConfig(global::Letta.RoundRobinManager value) => new ManagerConfig((global::Letta.RoundRobinManager?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.RoundRobinManager?(ManagerConfig @this) => @this.RoundRobin;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfig(global::Letta.RoundRobinManager? value)
        {
            RoundRobin = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfig(global::Letta.SupervisorManager value) => new ManagerConfig((global::Letta.SupervisorManager?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.SupervisorManager?(ManagerConfig @this) => @this.Supervisor;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfig(global::Letta.SupervisorManager? value)
        {
            Supervisor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfig(global::Letta.DynamicManager value) => new ManagerConfig((global::Letta.DynamicManager?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.DynamicManager?(ManagerConfig @this) => @this.Dynamic;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfig(global::Letta.DynamicManager? value)
        {
            Dynamic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfig(global::Letta.SleeptimeManager value) => new ManagerConfig((global::Letta.SleeptimeManager?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.SleeptimeManager?(ManagerConfig @this) => @this.Sleeptime;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfig(global::Letta.SleeptimeManager? value)
        {
            Sleeptime = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ManagerConfig(global::Letta.VoiceSleeptimeManager value) => new ManagerConfig((global::Letta.VoiceSleeptimeManager?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.VoiceSleeptimeManager?(ManagerConfig @this) => @this.VoiceSleeptime;

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfig(global::Letta.VoiceSleeptimeManager? value)
        {
            VoiceSleeptime = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ManagerConfig(
            global::Letta.GroupCreateManagerConfigDiscriminatorManagerType? managerType,
            global::Letta.RoundRobinManager? roundRobin,
            global::Letta.SupervisorManager? supervisor,
            global::Letta.DynamicManager? dynamic,
            global::Letta.SleeptimeManager? sleeptime,
            global::Letta.VoiceSleeptimeManager? voiceSleeptime
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
            global::System.Func<global::Letta.SupervisorManager?, TResult>? supervisor = null,
            global::System.Func<global::Letta.DynamicManager?, TResult>? dynamic = null,
            global::System.Func<global::Letta.SleeptimeManager?, TResult>? sleeptime = null,
            global::System.Func<global::Letta.VoiceSleeptimeManager?, TResult>? voiceSleeptime = null,
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
            global::System.Action<global::Letta.SupervisorManager?>? supervisor = null,
            global::System.Action<global::Letta.DynamicManager?>? dynamic = null,
            global::System.Action<global::Letta.SleeptimeManager?>? sleeptime = null,
            global::System.Action<global::Letta.VoiceSleeptimeManager?>? voiceSleeptime = null,
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
                typeof(global::Letta.SupervisorManager),
                Dynamic,
                typeof(global::Letta.DynamicManager),
                Sleeptime,
                typeof(global::Letta.SleeptimeManager),
                VoiceSleeptime,
                typeof(global::Letta.VoiceSleeptimeManager),
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
        public bool Equals(ManagerConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Letta.RoundRobinManager?>.Default.Equals(RoundRobin, other.RoundRobin) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.SupervisorManager?>.Default.Equals(Supervisor, other.Supervisor) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.DynamicManager?>.Default.Equals(Dynamic, other.Dynamic) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.SleeptimeManager?>.Default.Equals(Sleeptime, other.Sleeptime) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.VoiceSleeptimeManager?>.Default.Equals(VoiceSleeptime, other.VoiceSleeptime) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ManagerConfig obj1, ManagerConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ManagerConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ManagerConfig obj1, ManagerConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ManagerConfig o && Equals(o);
        }
    }
}
