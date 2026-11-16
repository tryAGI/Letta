#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Letta
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Config4 : global::System.IEquatable<Config4>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Letta.PipelinesUpdatePipelineResponsePipelineConfigDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1? SlackChannelReader { get; init; }
#else
        public global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1? SlackChannelReader { get; }
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
        public bool TryPickSlackChannelReader(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1? value)
        {
            value = SlackChannelReader;
            return IsSlackChannelReader;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1 PickSlackChannelReader() => SlackChannelReader is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SlackChannelReader' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant2? CustomWebhook { get; init; }
#else
        public global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant2? CustomWebhook { get; }
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
        public bool TryPickCustomWebhook(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant2? value)
        {
            value = CustomWebhook;
            return IsCustomWebhook;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant2 PickCustomWebhook() => CustomWebhook is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomWebhook' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Config4(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1 value) => new Config4((global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1?(Config4 @this) => @this.SlackChannelReader;

        /// <summary>
        ///
        /// </summary>
        public Config4(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1? value)
        {
            SlackChannelReader = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Config4 FromSlackChannelReader(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1? value) => new Config4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Config4(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant2 value) => new Config4((global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant2?(Config4 @this) => @this.CustomWebhook;

        /// <summary>
        ///
        /// </summary>
        public Config4(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant2? value)
        {
            CustomWebhook = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Config4 FromCustomWebhook(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant2? value) => new Config4(value);

        /// <summary>
        ///
        /// </summary>
        public Config4(
            global::Letta.PipelinesUpdatePipelineResponsePipelineConfigDiscriminatorType? type,
            global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1? slackChannelReader,
            global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant2? customWebhook
            )
        {
            Type = type;

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
            global::System.Func<global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1, TResult>? slackChannelReader = null,
            global::System.Func<global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant2, TResult>? customWebhook = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SlackChannelReader is { } __value0 && slackChannelReader != null)
            {
                return slackChannelReader(__value0);
            }
            else if (CustomWebhook is { } __value1 && customWebhook != null)
            {
                return customWebhook(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1>? slackChannelReader = null,

            global::System.Action<global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant2>? customWebhook = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SlackChannelReader is { } __value0)
            {
                slackChannelReader?.Invoke(__value0);
            }
            else if (CustomWebhook is { } __value1)
            {
                customWebhook?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1>? slackChannelReader = null,
            global::System.Action<global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant2>? customWebhook = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SlackChannelReader is { } __value0)
            {
                slackChannelReader?.Invoke(__value0);
            }
            else if (CustomWebhook is { } __value1)
            {
                customWebhook?.Invoke(__value1);
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
                typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1),
                CustomWebhook,
                typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant2),
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
        public bool Equals(Config4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1?>.Default.Equals(SlackChannelReader, other.SlackChannelReader) &&
                global::System.Collections.Generic.EqualityComparer<global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant2?>.Default.Equals(CustomWebhook, other.CustomWebhook)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Config4 obj1, Config4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Config4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Config4 obj1, Config4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Config4 o && Equals(o);
        }
    }
}
