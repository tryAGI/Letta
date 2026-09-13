
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.TextResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.JsonSchemaResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.JsonObjectResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EmbeddingModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProviderType), TypeInfoPropertyName = "ProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EmbeddingModelEmbeddingEndpointType), TypeInfoPropertyName = "EmbeddingModelEmbeddingEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseSchemaVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseSchemaVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProviderCategory), TypeInfoPropertyName = "ProviderCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelModelEndpointType), TypeInfoPropertyName = "ModelModelEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelReasoningEffort), TypeInfoPropertyName = "ModelReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelEffort), TypeInfoPropertyName = "ModelEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelCompatibilityType), TypeInfoPropertyName = "ModelCompatibilityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelVerbosity), TypeInfoPropertyName = "ModelVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant110))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelResponseFormatVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelResponseFormatVariant1DiscriminatorType), TypeInfoPropertyName = "ModelResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant111))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant112))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant113))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant114))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant115))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant116))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant117))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ResponseFormatVariant118))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ProviderCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.EmbeddingModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProviderType?), TypeInfoPropertyName = "NullableProviderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EmbeddingModelEmbeddingEndpointType?), TypeInfoPropertyName = "NullableEmbeddingModelEmbeddingEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProviderCategory?), TypeInfoPropertyName = "NullableProviderCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelModelEndpointType?), TypeInfoPropertyName = "NullableModelModelEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelReasoningEffort?), TypeInfoPropertyName = "NullableModelReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelEffort?), TypeInfoPropertyName = "NullableModelEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelCompatibilityType?), TypeInfoPropertyName = "NullableModelCompatibilityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelVerbosity?), TypeInfoPropertyName = "NullableModelVerbosity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ModelResponseFormatVariant1DiscriminatorType?), TypeInfoPropertyName = "NullableModelResponseFormatVariant1DiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ProviderCategory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.EmbeddingModel>))]
    internal sealed partial class ModelsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ModelsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ModelsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant1JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant12JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant13JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant14JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant15JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant16JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseSchemaVariant1JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseSchemaVariant12JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant17JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant18JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant19JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant110JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant111JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant112JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant113JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant114JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant115JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant116JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant117JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ResponseFormatVariant118JsonConverter());
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
                    typeToConvert == typeof(global::Letta.EmbeddingModelEmbeddingEndpointType)

                    || typeToConvert == typeof(global::Letta.EmbeddingModelEmbeddingEndpointType?)

                    || typeToConvert == typeof(global::Letta.ModelModelEndpointType)

                    || typeToConvert == typeof(global::Letta.ModelModelEndpointType?)

                    || typeToConvert == typeof(global::Letta.ModelReasoningEffort)

                    || typeToConvert == typeof(global::Letta.ModelReasoningEffort?)

                    || typeToConvert == typeof(global::Letta.ModelEffort)

                    || typeToConvert == typeof(global::Letta.ModelEffort?)

                    || typeToConvert == typeof(global::Letta.ModelCompatibilityType)

                    || typeToConvert == typeof(global::Letta.ModelCompatibilityType?)

                    || typeToConvert == typeof(global::Letta.ModelVerbosity)

                    || typeToConvert == typeof(global::Letta.ModelVerbosity?)

                    || typeToConvert == typeof(global::Letta.ModelResponseFormatVariant1DiscriminatorType)

                    || typeToConvert == typeof(global::Letta.ModelResponseFormatVariant1DiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.ProviderCategory)

                    || typeToConvert == typeof(global::Letta.ProviderCategory?)

                    || typeToConvert == typeof(global::Letta.ProviderType)

                    || typeToConvert == typeof(global::Letta.ProviderType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Letta.EmbeddingModelEmbeddingEndpointType))
                {
                    return new global::Letta.JsonConverters.EmbeddingModelEmbeddingEndpointTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.EmbeddingModelEmbeddingEndpointType?))
                {
                    return new global::Letta.JsonConverters.EmbeddingModelEmbeddingEndpointTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ModelModelEndpointType))
                {
                    return new global::Letta.JsonConverters.ModelModelEndpointTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ModelModelEndpointType?))
                {
                    return new global::Letta.JsonConverters.ModelModelEndpointTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ModelReasoningEffort))
                {
                    return new global::Letta.JsonConverters.ModelReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ModelReasoningEffort?))
                {
                    return new global::Letta.JsonConverters.ModelReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ModelEffort))
                {
                    return new global::Letta.JsonConverters.ModelEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ModelEffort?))
                {
                    return new global::Letta.JsonConverters.ModelEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ModelCompatibilityType))
                {
                    return new global::Letta.JsonConverters.ModelCompatibilityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ModelCompatibilityType?))
                {
                    return new global::Letta.JsonConverters.ModelCompatibilityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ModelVerbosity))
                {
                    return new global::Letta.JsonConverters.ModelVerbosityJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ModelVerbosity?))
                {
                    return new global::Letta.JsonConverters.ModelVerbosityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ModelResponseFormatVariant1DiscriminatorType))
                {
                    return new global::Letta.JsonConverters.ModelResponseFormatVariant1DiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ModelResponseFormatVariant1DiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.ModelResponseFormatVariant1DiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ProviderCategory))
                {
                    return new global::Letta.JsonConverters.ProviderCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ProviderCategory?))
                {
                    return new global::Letta.JsonConverters.ProviderCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ProviderType))
                {
                    return new global::Letta.JsonConverters.ProviderTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ProviderType?))
                {
                    return new global::Letta.JsonConverters.ProviderTypeNullableJsonConverter();
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
                    0 => new ModelsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}