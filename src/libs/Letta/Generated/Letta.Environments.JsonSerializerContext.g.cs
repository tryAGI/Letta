
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1, global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2>>), TypeInfoPropertyName = "EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2_496f6ade7a04f230")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1, global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2>), TypeInfoPropertyName = "EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2_9281aa9dcafb0375")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1, global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2>?), TypeInfoPropertyName = "EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2_288214ce22d7fe68")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.OneOf<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1, global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2>>), TypeInfoPropertyName = "EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2_8357cf73f18c2991")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsRegisterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsRegisterRequestMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.OneOf<global::Letta.EnvironmentsSendMessageRequestMessageVariant1, global::Letta.EnvironmentsSendMessageRequestMessageVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<global::Letta.EnvironmentsSendMessageRequestMessageVariant1, global::Letta.EnvironmentsSendMessageRequestMessageVariant2>), TypeInfoPropertyName = "OneOfEnvironmentsSendMessageRequestMessageVariant1EnvironmentsSendMessageRequestMessageVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant1Role), TypeInfoPropertyName = "EnvironmentsSendMessageRequestMessageVariant1Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<string, global::System.Collections.Generic.IList<global::Letta.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item>>), TypeInfoPropertyName = "OneOfStringIListEnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemType), TypeInfoPropertyName = "EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2Type), TypeInfoPropertyName = "EnvironmentsSendMessageRequestMessageVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Type), TypeInfoPropertyName = "EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<string, global::System.Collections.Generic.IList<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2Item>>), TypeInfoPropertyName = "OneOfStringIListEnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType), TypeInfoPropertyName = "EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Status), TypeInfoPropertyName = "EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2Type), TypeInfoPropertyName = "EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsRegisterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsRegisterResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsGetConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsGetConnectionResponseCurrentMode), TypeInfoPropertyName = "EnvironmentsGetConnectionResponseCurrentMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsGetConnectionResponseMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsGetConnectionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsListConnectionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.EnvironmentsListConnectionsResponseConnection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsListConnectionsResponseConnection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsListConnectionsResponseConnectionCurrentMode), TypeInfoPropertyName = "EnvironmentsListConnectionsResponseConnectionCurrentMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsListConnectionsResponseConnectionMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsDeleteEnvironmentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsDeleteEnvironmentResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsDeleteEnvironmentResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<global::Letta.EnvironmentsSendMessageRequestMessageVariant1, global::Letta.EnvironmentsSendMessageRequestMessageVariant2>?), TypeInfoPropertyName = "NullableOneOfEnvironmentsSendMessageRequestMessageVariant1EnvironmentsSendMessageRequestMessageVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant1Role?), TypeInfoPropertyName = "NullableEnvironmentsSendMessageRequestMessageVariant1Role2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<string, global::System.Collections.Generic.IList<global::Letta.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item>>?), TypeInfoPropertyName = "NullableOneOfStringIListEnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemType?), TypeInfoPropertyName = "NullableEnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2Type?), TypeInfoPropertyName = "NullableEnvironmentsSendMessageRequestMessageVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Type?), TypeInfoPropertyName = "NullableEnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<string, global::System.Collections.Generic.IList<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2Item>>?), TypeInfoPropertyName = "NullableOneOfStringIListEnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType?), TypeInfoPropertyName = "NullableEnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Status?), TypeInfoPropertyName = "NullableEnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2Type?), TypeInfoPropertyName = "NullableEnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsGetConnectionResponseCurrentMode?), TypeInfoPropertyName = "NullableEnvironmentsGetConnectionResponseCurrentMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.EnvironmentsListConnectionsResponseConnectionCurrentMode?), TypeInfoPropertyName = "NullableEnvironmentsListConnectionsResponseConnectionCurrentMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.OneOf<global::Letta.EnvironmentsSendMessageRequestMessageVariant1, global::Letta.EnvironmentsSendMessageRequestMessageVariant2>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<string, global::System.Collections.Generic.List<global::Letta.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<string, global::System.Collections.Generic.List<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.EnvironmentsListConnectionsResponseConnection>))]
    internal sealed partial class EnvironmentsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EnvironmentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EnvironmentsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EnvironmentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Letta.JsonConverters.OneOfJsonConverter<global::Letta.EnvironmentsSendMessageRequestMessageVariant1, global::Letta.EnvironmentsSendMessageRequestMessageVariant2>());
            options.Converters.Add(new global::Letta.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item>>());
            options.Converters.Add(new global::Letta.JsonConverters.OneOfJsonConverter<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1, global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2>());
            options.Converters.Add(new global::Letta.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2Item>>());
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
                    typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant1Role)

                    || typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant1Role?)

                    || typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemType)

                    || typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemType?)

                    || typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2Type)

                    || typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2Type?)

                    || typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Type)

                    || typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Type?)

                    || typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType)

                    || typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType?)

                    || typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Status)

                    || typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Status?)

                    || typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2Type)

                    || typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2Type?)

                    || typeToConvert == typeof(global::Letta.EnvironmentsGetConnectionResponseCurrentMode)

                    || typeToConvert == typeof(global::Letta.EnvironmentsGetConnectionResponseCurrentMode?)

                    || typeToConvert == typeof(global::Letta.EnvironmentsListConnectionsResponseConnectionCurrentMode)

                    || typeToConvert == typeof(global::Letta.EnvironmentsListConnectionsResponseConnectionCurrentMode?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant1Role))
                {
                    return new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant1RoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant1Role?))
                {
                    return new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant1RoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemType))
                {
                    return new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemType?))
                {
                    return new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2Type))
                {
                    return new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2Type?))
                {
                    return new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Type))
                {
                    return new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Type?))
                {
                    return new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType))
                {
                    return new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemType?))
                {
                    return new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Status))
                {
                    return new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1StatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1Status?))
                {
                    return new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1StatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2Type))
                {
                    return new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2Type?))
                {
                    return new global::Letta.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.EnvironmentsGetConnectionResponseCurrentMode))
                {
                    return new global::Letta.JsonConverters.EnvironmentsGetConnectionResponseCurrentModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.EnvironmentsGetConnectionResponseCurrentMode?))
                {
                    return new global::Letta.JsonConverters.EnvironmentsGetConnectionResponseCurrentModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.EnvironmentsListConnectionsResponseConnectionCurrentMode))
                {
                    return new global::Letta.JsonConverters.EnvironmentsListConnectionsResponseConnectionCurrentModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.EnvironmentsListConnectionsResponseConnectionCurrentMode?))
                {
                    return new global::Letta.JsonConverters.EnvironmentsListConnectionsResponseConnectionCurrentModeNullableJsonConverter();
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
                    0 => new EnvironmentsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}