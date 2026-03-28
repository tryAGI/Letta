#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Config6 : global::System.IEquatable<Config6>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1? SlackChannelReader { get; init; }
#else
        public global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1? SlackChannelReader { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SlackChannelReader))]
#endif
        public bool IsSlackChannelReader => SlackChannelReader != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2? CustomWebhook { get; init; }
#else
        public global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2? CustomWebhook { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomWebhook))]
#endif
        public bool IsCustomWebhook => CustomWebhook != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Config6(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1 value) => new Config6((global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1?(Config6 @this) => @this.SlackChannelReader;

        /// <summary>
        /// 
        /// </summary>
        public Config6(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1? value)
        {
            SlackChannelReader = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Config6(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2 value) => new Config6((global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2?(Config6 @this) => @this.CustomWebhook;

        /// <summary>
        /// 
        /// </summary>
        public Config6(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2? value)
        {
            CustomWebhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Config6(
            global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1? slackChannelReader,
            global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2? customWebhook
            )
        {
            SlackChannelReader = slackChannelReader;
            CustomWebhook = customWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CustomWebhook as object ??
            SlackChannelReader as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SlackChannelReader?.ToString() ??
            CustomWebhook?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSlackChannelReader && !IsCustomWebhook || !IsSlackChannelReader && IsCustomWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1?, TResult>? slackChannelReader = null,
            global::System.Func<global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2?, TResult>? customWebhook = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSlackChannelReader && slackChannelReader != null)
            {
                return slackChannelReader(SlackChannelReader!);
            }
            else if (IsCustomWebhook && customWebhook != null)
            {
                return customWebhook(CustomWebhook!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1?>? slackChannelReader = null,
            global::System.Action<global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2?>? customWebhook = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSlackChannelReader)
            {
                slackChannelReader?.Invoke(SlackChannelReader!);
            }
            else if (IsCustomWebhook)
            {
                customWebhook?.Invoke(CustomWebhook!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SlackChannelReader,
                typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1),
                CustomWebhook,
                typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2),
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
        public bool Equals(Config6 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1?>.Default.Equals(SlackChannelReader, other.SlackChannelReader) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2?>.Default.Equals(CustomWebhook, other.CustomWebhook) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Config6 obj1, Config6 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Config6>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Config6 obj1, Config6 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Config6 o && Equals(o);
        }
    }
}
