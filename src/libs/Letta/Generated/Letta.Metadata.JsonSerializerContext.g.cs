
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendFeedbackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendFeedbackRequestFeature), TypeInfoPropertyName = "MetadataSendFeedbackRequestFeature2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestService), TypeInfoPropertyName = "MetadataSendTelemetryRequestService2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.EventsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EventsItem), TypeInfoPropertyName = "EventsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant1Type), TypeInfoPropertyName = "MetadataSendTelemetryRequestEventVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant1Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant2Type), TypeInfoPropertyName = "MetadataSendTelemetryRequestEventVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant2Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant3Type), TypeInfoPropertyName = "MetadataSendTelemetryRequestEventVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant3Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant4Type), TypeInfoPropertyName = "MetadataSendTelemetryRequestEventVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant4Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant5Type), TypeInfoPropertyName = "MetadataSendTelemetryRequestEventVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant5Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventDiscriminatorType), TypeInfoPropertyName = "MetadataSendTelemetryRequestEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataRetrieveCurrentBalancesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendFeedbackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataGetStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataGetUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataGetUserResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendFeedbackRequestFeature?), TypeInfoPropertyName = "NullableMetadataSendFeedbackRequestFeature2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestService?), TypeInfoPropertyName = "NullableMetadataSendTelemetryRequestService2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EventsItem?), TypeInfoPropertyName = "NullableEventsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant1Type?), TypeInfoPropertyName = "NullableMetadataSendTelemetryRequestEventVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant2Type?), TypeInfoPropertyName = "NullableMetadataSendTelemetryRequestEventVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant3Type?), TypeInfoPropertyName = "NullableMetadataSendTelemetryRequestEventVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant4Type?), TypeInfoPropertyName = "NullableMetadataSendTelemetryRequestEventVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventVariant5Type?), TypeInfoPropertyName = "NullableMetadataSendTelemetryRequestEventVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.MetadataSendTelemetryRequestEventDiscriminatorType?), TypeInfoPropertyName = "NullableMetadataSendTelemetryRequestEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.EventsItem>))]
    internal sealed partial class MetadataSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MetadataSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static MetadataSourceGenerationContext Default { get; } = new(DefaultOptions);

        private MetadataSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Letta.JsonConverters.EventsItemJsonConverter());
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
                    typeToConvert == typeof(global::Letta.MetadataSendFeedbackRequestFeature)

                    || typeToConvert == typeof(global::Letta.MetadataSendFeedbackRequestFeature?)

                    || typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestService)

                    || typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestService?)

                    || typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestEventVariant1Type)

                    || typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestEventVariant1Type?)

                    || typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestEventVariant2Type)

                    || typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestEventVariant2Type?)

                    || typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestEventVariant3Type)

                    || typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestEventVariant3Type?)

                    || typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestEventVariant4Type)

                    || typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestEventVariant4Type?)

                    || typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestEventVariant5Type)

                    || typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestEventVariant5Type?)

                    || typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestEventDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestEventDiscriminatorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Letta.MetadataSendFeedbackRequestFeature))
                {
                    return new global::Letta.JsonConverters.MetadataSendFeedbackRequestFeatureJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MetadataSendFeedbackRequestFeature?))
                {
                    return new global::Letta.JsonConverters.MetadataSendFeedbackRequestFeatureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestService))
                {
                    return new global::Letta.JsonConverters.MetadataSendTelemetryRequestServiceJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestService?))
                {
                    return new global::Letta.JsonConverters.MetadataSendTelemetryRequestServiceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestEventVariant1Type))
                {
                    return new global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestEventVariant1Type?))
                {
                    return new global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestEventVariant2Type))
                {
                    return new global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestEventVariant2Type?))
                {
                    return new global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestEventVariant3Type))
                {
                    return new global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestEventVariant3Type?))
                {
                    return new global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestEventVariant4Type))
                {
                    return new global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant4TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestEventVariant4Type?))
                {
                    return new global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant4TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestEventVariant5Type))
                {
                    return new global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant5TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestEventVariant5Type?))
                {
                    return new global::Letta.JsonConverters.MetadataSendTelemetryRequestEventVariant5TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestEventDiscriminatorType))
                {
                    return new global::Letta.JsonConverters.MetadataSendTelemetryRequestEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.MetadataSendTelemetryRequestEventDiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.MetadataSendTelemetryRequestEventDiscriminatorTypeNullableJsonConverter();
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
                    0 => new MetadataSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}