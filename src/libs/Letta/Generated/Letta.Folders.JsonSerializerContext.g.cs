
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EmbeddingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.BodyUploadFileToFolder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.DuplicateFileHandling), TypeInfoPropertyName = "DuplicateFileHandling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EmbeddingConfigEmbeddingEndpointType), TypeInfoPropertyName = "EmbeddingConfigEmbeddingEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FileMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FileProcessingStatus), TypeInfoPropertyName = "FileProcessingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FileStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Folder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OrganizationSourcesStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.SourceStats>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SourceStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Passage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SourceCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.FileStats>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.SourceUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListFoldersOrder), TypeInfoPropertyName = "ListFoldersOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListAgentsForFolderOrder), TypeInfoPropertyName = "ListAgentsForFolderOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListFolderPassagesOrder), TypeInfoPropertyName = "ListFolderPassagesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListFilesForFolderOrder), TypeInfoPropertyName = "ListFilesForFolderOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Passage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.FileMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.Folder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.DuplicateFileHandling?), TypeInfoPropertyName = "NullableDuplicateFileHandling2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EmbeddingConfigEmbeddingEndpointType?), TypeInfoPropertyName = "NullableEmbeddingConfigEmbeddingEndpointType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.FileProcessingStatus?), TypeInfoPropertyName = "NullableFileProcessingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListFoldersOrder?), TypeInfoPropertyName = "NullableListFoldersOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListAgentsForFolderOrder?), TypeInfoPropertyName = "NullableListAgentsForFolderOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListFolderPassagesOrder?), TypeInfoPropertyName = "NullableListFolderPassagesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ListFilesForFolderOrder?), TypeInfoPropertyName = "NullableListFilesForFolderOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.SourceStats>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.FileStats>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Passage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.FileMetadata>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.Folder>))]
    internal sealed partial class FoldersSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FoldersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static FoldersSourceGenerationContext Default { get; } = new(DefaultOptions);

        private FoldersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Letta.DuplicateFileHandling)

                    || typeToConvert == typeof(global::Letta.DuplicateFileHandling?)

                    || typeToConvert == typeof(global::Letta.EmbeddingConfigEmbeddingEndpointType)

                    || typeToConvert == typeof(global::Letta.EmbeddingConfigEmbeddingEndpointType?)

                    || typeToConvert == typeof(global::Letta.FileProcessingStatus)

                    || typeToConvert == typeof(global::Letta.FileProcessingStatus?)

                    || typeToConvert == typeof(global::Letta.ListFoldersOrder)

                    || typeToConvert == typeof(global::Letta.ListFoldersOrder?)

                    || typeToConvert == typeof(global::Letta.ListAgentsForFolderOrder)

                    || typeToConvert == typeof(global::Letta.ListAgentsForFolderOrder?)

                    || typeToConvert == typeof(global::Letta.ListFolderPassagesOrder)

                    || typeToConvert == typeof(global::Letta.ListFolderPassagesOrder?)

                    || typeToConvert == typeof(global::Letta.ListFilesForFolderOrder)

                    || typeToConvert == typeof(global::Letta.ListFilesForFolderOrder?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Letta.DuplicateFileHandling))
                {
                    return new global::Letta.JsonConverters.DuplicateFileHandlingJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.DuplicateFileHandling?))
                {
                    return new global::Letta.JsonConverters.DuplicateFileHandlingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.EmbeddingConfigEmbeddingEndpointType))
                {
                    return new global::Letta.JsonConverters.EmbeddingConfigEmbeddingEndpointTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.EmbeddingConfigEmbeddingEndpointType?))
                {
                    return new global::Letta.JsonConverters.EmbeddingConfigEmbeddingEndpointTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.FileProcessingStatus))
                {
                    return new global::Letta.JsonConverters.FileProcessingStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.FileProcessingStatus?))
                {
                    return new global::Letta.JsonConverters.FileProcessingStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListFoldersOrder))
                {
                    return new global::Letta.JsonConverters.ListFoldersOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListFoldersOrder?))
                {
                    return new global::Letta.JsonConverters.ListFoldersOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListAgentsForFolderOrder))
                {
                    return new global::Letta.JsonConverters.ListAgentsForFolderOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListAgentsForFolderOrder?))
                {
                    return new global::Letta.JsonConverters.ListAgentsForFolderOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListFolderPassagesOrder))
                {
                    return new global::Letta.JsonConverters.ListFolderPassagesOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListFolderPassagesOrder?))
                {
                    return new global::Letta.JsonConverters.ListFolderPassagesOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListFilesForFolderOrder))
                {
                    return new global::Letta.JsonConverters.ListFilesForFolderOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.ListFilesForFolderOrder?))
                {
                    return new global::Letta.JsonConverters.ListFilesForFolderOrderNullableJsonConverter();
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
                    0 => new FoldersSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}