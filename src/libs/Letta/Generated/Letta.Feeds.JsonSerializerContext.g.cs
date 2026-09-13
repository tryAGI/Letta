
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Letta
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsCreateFeedRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsPublishMessagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.FeedsPublishMessagesRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsPublishMessagesRequestMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsSubscribeAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsUpdateSubscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsUnsubscribeAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsBackfillSubscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsUpdateAllSubscriptionsCronRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<string, double?>), TypeInfoPropertyName = "OneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsCreateFeedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListFeedsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.FeedsListFeedsResponseFeed>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListFeedsResponseFeed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsGetFeedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsDeleteFeedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsPublishMessagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListMessagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.FeedsListMessagesResponseMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListMessagesResponseMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsGetMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsGetMessageResponseMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsGetMessageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsSubscribeAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsSubscribeAgentResponseMergeStrategy), TypeInfoPropertyName = "FeedsSubscribeAgentResponseMergeStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsSubscribeAgentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsSubscribeAgentResponseErrorCode), TypeInfoPropertyName = "FeedsSubscribeAgentResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsUpdateSubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsUpdateSubscriptionResponseMergeStrategy), TypeInfoPropertyName = "FeedsUpdateSubscriptionResponseMergeStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsDeleteSubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsUnsubscribeAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsTriggerSubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsTriggerSubscriptionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsBackfillSubscriptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsBackfillSubscriptionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsBackfillSubscriptionResponseErrorCode), TypeInfoPropertyName = "FeedsBackfillSubscriptionResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListSubscriptionHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.FeedsListSubscriptionHistoryResponseRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListSubscriptionHistoryResponseRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListSubscriptionHistoryResponseRunType), TypeInfoPropertyName = "FeedsListSubscriptionHistoryResponseRunType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListSubscriptionHistoryResponseRunStatus), TypeInfoPropertyName = "FeedsListSubscriptionHistoryResponseRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListSubscriptionHistoryResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListSubscriptionHistoryResponseErrorCode), TypeInfoPropertyName = "FeedsListSubscriptionHistoryResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsUpdateAllSubscriptionsCronResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsUpdateAllSubscriptionsCronResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListSubscriptionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.FeedsListSubscriptionsResponseSubscription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListSubscriptionsResponseSubscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListSubscriptionsResponseSubscriptionMergeStrategy), TypeInfoPropertyName = "FeedsListSubscriptionsResponseSubscriptionMergeStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<string, double?>?), TypeInfoPropertyName = "NullableOneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsSubscribeAgentResponseMergeStrategy?), TypeInfoPropertyName = "NullableFeedsSubscribeAgentResponseMergeStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsSubscribeAgentResponseErrorCode?), TypeInfoPropertyName = "NullableFeedsSubscribeAgentResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsUpdateSubscriptionResponseMergeStrategy?), TypeInfoPropertyName = "NullableFeedsUpdateSubscriptionResponseMergeStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsBackfillSubscriptionResponseErrorCode?), TypeInfoPropertyName = "NullableFeedsBackfillSubscriptionResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListSubscriptionHistoryResponseRunType?), TypeInfoPropertyName = "NullableFeedsListSubscriptionHistoryResponseRunType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListSubscriptionHistoryResponseRunStatus?), TypeInfoPropertyName = "NullableFeedsListSubscriptionHistoryResponseRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListSubscriptionHistoryResponseErrorCode?), TypeInfoPropertyName = "NullableFeedsListSubscriptionHistoryResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FeedsListSubscriptionsResponseSubscriptionMergeStrategy?), TypeInfoPropertyName = "NullableFeedsListSubscriptionsResponseSubscriptionMergeStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.FeedsPublishMessagesRequestMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.FeedsListFeedsResponseFeed>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.FeedsListMessagesResponseMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.FeedsListSubscriptionHistoryResponseRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.FeedsListSubscriptionsResponseSubscription>))]
    internal sealed partial class FeedsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FeedsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static FeedsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private FeedsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>());
            options.Converters.Add(new global::Letta.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Letta.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Letta.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Letta.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Letta.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Letta.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Letta.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Letta.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Letta.FeedsSubscribeAgentResponseMergeStrategy)

                    || typeToConvert == typeof(global::Letta.FeedsSubscribeAgentResponseMergeStrategy?)

                    || typeToConvert == typeof(global::Letta.FeedsSubscribeAgentResponseErrorCode)

                    || typeToConvert == typeof(global::Letta.FeedsSubscribeAgentResponseErrorCode?)

                    || typeToConvert == typeof(global::Letta.FeedsUpdateSubscriptionResponseMergeStrategy)

                    || typeToConvert == typeof(global::Letta.FeedsUpdateSubscriptionResponseMergeStrategy?)

                    || typeToConvert == typeof(global::Letta.FeedsBackfillSubscriptionResponseErrorCode)

                    || typeToConvert == typeof(global::Letta.FeedsBackfillSubscriptionResponseErrorCode?)

                    || typeToConvert == typeof(global::Letta.FeedsListSubscriptionHistoryResponseRunType)

                    || typeToConvert == typeof(global::Letta.FeedsListSubscriptionHistoryResponseRunType?)

                    || typeToConvert == typeof(global::Letta.FeedsListSubscriptionHistoryResponseRunStatus)

                    || typeToConvert == typeof(global::Letta.FeedsListSubscriptionHistoryResponseRunStatus?)

                    || typeToConvert == typeof(global::Letta.FeedsListSubscriptionHistoryResponseErrorCode)

                    || typeToConvert == typeof(global::Letta.FeedsListSubscriptionHistoryResponseErrorCode?)

                    || typeToConvert == typeof(global::Letta.FeedsListSubscriptionsResponseSubscriptionMergeStrategy)

                    || typeToConvert == typeof(global::Letta.FeedsListSubscriptionsResponseSubscriptionMergeStrategy?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Letta.FeedsSubscribeAgentResponseMergeStrategy))
                {
                    return new global::Letta.JsonConverters.FeedsSubscribeAgentResponseMergeStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.FeedsSubscribeAgentResponseMergeStrategy?))
                {
                    return new global::Letta.JsonConverters.FeedsSubscribeAgentResponseMergeStrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.FeedsSubscribeAgentResponseErrorCode))
                {
                    return new global::Letta.JsonConverters.FeedsSubscribeAgentResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.FeedsSubscribeAgentResponseErrorCode?))
                {
                    return new global::Letta.JsonConverters.FeedsSubscribeAgentResponseErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.FeedsUpdateSubscriptionResponseMergeStrategy))
                {
                    return new global::Letta.JsonConverters.FeedsUpdateSubscriptionResponseMergeStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.FeedsUpdateSubscriptionResponseMergeStrategy?))
                {
                    return new global::Letta.JsonConverters.FeedsUpdateSubscriptionResponseMergeStrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.FeedsBackfillSubscriptionResponseErrorCode))
                {
                    return new global::Letta.JsonConverters.FeedsBackfillSubscriptionResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.FeedsBackfillSubscriptionResponseErrorCode?))
                {
                    return new global::Letta.JsonConverters.FeedsBackfillSubscriptionResponseErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.FeedsListSubscriptionHistoryResponseRunType))
                {
                    return new global::Letta.JsonConverters.FeedsListSubscriptionHistoryResponseRunTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.FeedsListSubscriptionHistoryResponseRunType?))
                {
                    return new global::Letta.JsonConverters.FeedsListSubscriptionHistoryResponseRunTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.FeedsListSubscriptionHistoryResponseRunStatus))
                {
                    return new global::Letta.JsonConverters.FeedsListSubscriptionHistoryResponseRunStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.FeedsListSubscriptionHistoryResponseRunStatus?))
                {
                    return new global::Letta.JsonConverters.FeedsListSubscriptionHistoryResponseRunStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.FeedsListSubscriptionHistoryResponseErrorCode))
                {
                    return new global::Letta.JsonConverters.FeedsListSubscriptionHistoryResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.FeedsListSubscriptionHistoryResponseErrorCode?))
                {
                    return new global::Letta.JsonConverters.FeedsListSubscriptionHistoryResponseErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.FeedsListSubscriptionsResponseSubscriptionMergeStrategy))
                {
                    return new global::Letta.JsonConverters.FeedsListSubscriptionsResponseSubscriptionMergeStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.FeedsListSubscriptionsResponseSubscriptionMergeStrategy?))
                {
                    return new global::Letta.JsonConverters.FeedsListSubscriptionsResponseSubscriptionMergeStrategyNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new FeedsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}