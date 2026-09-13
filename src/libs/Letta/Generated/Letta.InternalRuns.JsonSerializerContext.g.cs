
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.StopReasonType), TypeInfoPropertyName = "StopReasonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ComparisonOperator), TypeInfoPropertyName = "ComparisonOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.MessageType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MessageType), TypeInfoPropertyName = "MessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.LettaRequestConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Run))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.RunStatus), TypeInfoPropertyName = "RunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListInternalRunsOrder), TypeInfoPropertyName = "ListInternalRunsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListInternalRunsOrderBy), TypeInfoPropertyName = "ListInternalRunsOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListInternalRunsDurationOperator), TypeInfoPropertyName = "ListInternalRunsDurationOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Run>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.StopReasonType?), TypeInfoPropertyName = "NullableStopReasonType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ComparisonOperator?), TypeInfoPropertyName = "NullableComparisonOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MessageType?), TypeInfoPropertyName = "NullableMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.RunStatus?), TypeInfoPropertyName = "NullableRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListInternalRunsOrder?), TypeInfoPropertyName = "NullableListInternalRunsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListInternalRunsOrderBy?), TypeInfoPropertyName = "NullableListInternalRunsOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListInternalRunsDurationOperator?), TypeInfoPropertyName = "NullableListInternalRunsDurationOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.MessageType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Run>))]
    internal sealed partial class InternalRunsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InternalRunsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static InternalRunsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private InternalRunsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Letta.ComparisonOperator)

                    || typeToConvert == typeof(global::Letta.ComparisonOperator?)

                    || typeToConvert == typeof(global::Letta.MessageType)

                    || typeToConvert == typeof(global::Letta.MessageType?)

                    || typeToConvert == typeof(global::Letta.RunStatus)

                    || typeToConvert == typeof(global::Letta.RunStatus?)

                    || typeToConvert == typeof(global::Letta.StopReasonType)

                    || typeToConvert == typeof(global::Letta.StopReasonType?)

                    || typeToConvert == typeof(global::Letta.ListInternalRunsOrder)

                    || typeToConvert == typeof(global::Letta.ListInternalRunsOrder?)

                    || typeToConvert == typeof(global::Letta.ListInternalRunsOrderBy)

                    || typeToConvert == typeof(global::Letta.ListInternalRunsOrderBy?)

                    || typeToConvert == typeof(global::Letta.ListInternalRunsDurationOperator)

                    || typeToConvert == typeof(global::Letta.ListInternalRunsDurationOperator?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Letta.ComparisonOperator))
                {
                    return new global::Letta.JsonConverters.ComparisonOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ComparisonOperator?))
                {
                    return new global::Letta.JsonConverters.ComparisonOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MessageType))
                {
                    return new global::Letta.JsonConverters.MessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MessageType?))
                {
                    return new global::Letta.JsonConverters.MessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.RunStatus))
                {
                    return new global::Letta.JsonConverters.RunStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.RunStatus?))
                {
                    return new global::Letta.JsonConverters.RunStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.StopReasonType))
                {
                    return new global::Letta.JsonConverters.StopReasonTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.StopReasonType?))
                {
                    return new global::Letta.JsonConverters.StopReasonTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListInternalRunsOrder))
                {
                    return new global::Letta.JsonConverters.ListInternalRunsOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListInternalRunsOrder?))
                {
                    return new global::Letta.JsonConverters.ListInternalRunsOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListInternalRunsOrderBy))
                {
                    return new global::Letta.JsonConverters.ListInternalRunsOrderByJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListInternalRunsOrderBy?))
                {
                    return new global::Letta.JsonConverters.ListInternalRunsOrderByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListInternalRunsDurationOperator))
                {
                    return new global::Letta.JsonConverters.ListInternalRunsDurationOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListInternalRunsDurationOperator?))
                {
                    return new global::Letta.JsonConverters.ListInternalRunsDurationOperatorNullableJsonConverter();
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
                    0 => new InternalRunsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}