
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineRequestIntegrationType), TypeInfoPropertyName = "PipelinesCreatePipelineRequestIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProducerConfig), TypeInfoPropertyName = "ProducerConfig2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant1Type), TypeInfoPropertyName = "PipelinesCreatePipelineRequestProducerConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant1Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant1DataChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant2Type), TypeInfoPropertyName = "PipelinesCreatePipelineRequestProducerConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigDiscriminatorType), TypeInfoPropertyName = "PipelinesCreatePipelineRequestProducerConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProducerConfig2), TypeInfoPropertyName = "ProducerConfig22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Type), TypeInfoPropertyName = "PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1DataChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2Type), TypeInfoPropertyName = "PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigDiscriminatorType), TypeInfoPropertyName = "PipelinesUpdatePipelineProducerConfigRequestProducerConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineRequestIntegrationType), TypeInfoPropertyName = "PipelinesPreviewPipelineRequestIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProducerConfig3), TypeInfoPropertyName = "ProducerConfig32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1Type), TypeInfoPropertyName = "PipelinesPreviewPipelineRequestProducerConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1DataChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant2Type), TypeInfoPropertyName = "PipelinesPreviewPipelineRequestProducerConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigDiscriminatorType), TypeInfoPropertyName = "PipelinesPreviewPipelineRequestProducerConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<string, double?>), TypeInfoPropertyName = "OneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponsePipeline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineIntegrationType), TypeInfoPropertyName = "PipelinesCreatePipelineResponsePipelineIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Config5), TypeInfoPropertyName = "Config52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant1Type), TypeInfoPropertyName = "PipelinesCreatePipelineResponsePipelineConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant1Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant1DataChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant2Type), TypeInfoPropertyName = "PipelinesCreatePipelineResponsePipelineConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigDiscriminatorType), TypeInfoPropertyName = "PipelinesCreatePipelineResponsePipelineConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponseErrorCode), TypeInfoPropertyName = "PipelinesCreatePipelineResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PipelinesListPipelinesResponsePipeline>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponsePipeline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponsePipelineIntegrationType), TypeInfoPropertyName = "PipelinesListPipelinesResponsePipelineIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Config6), TypeInfoPropertyName = "Config62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1Type), TypeInfoPropertyName = "PipelinesListPipelinesResponsePipelineConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1DataChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2Type), TypeInfoPropertyName = "PipelinesListPipelinesResponsePipelineConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigDiscriminatorType), TypeInfoPropertyName = "PipelinesListPipelinesResponsePipelineConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCountPipelinesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponsePipeline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponsePipelineIntegrationType), TypeInfoPropertyName = "PipelinesGetPipelineResponsePipelineIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Config7), TypeInfoPropertyName = "Config72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant1Type), TypeInfoPropertyName = "PipelinesGetPipelineResponsePipelineConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant1Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant1DataChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant2Type), TypeInfoPropertyName = "PipelinesGetPipelineResponsePipelineConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigDiscriminatorType), TypeInfoPropertyName = "PipelinesGetPipelineResponsePipelineConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponseErrorCode), TypeInfoPropertyName = "PipelinesGetPipelineResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponsePipeline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineIntegrationType), TypeInfoPropertyName = "PipelinesUpdatePipelineResponsePipelineIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Config8), TypeInfoPropertyName = "Config82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1Type), TypeInfoPropertyName = "PipelinesUpdatePipelineResponsePipelineConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1DataChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant2Type), TypeInfoPropertyName = "PipelinesUpdatePipelineResponsePipelineConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigDiscriminatorType), TypeInfoPropertyName = "PipelinesUpdatePipelineResponsePipelineConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponseErrorCode), TypeInfoPropertyName = "PipelinesUpdatePipelineResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesDeletePipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesDeletePipelineResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesDeletePipelineResponseErrorCode), TypeInfoPropertyName = "PipelinesDeletePipelineResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipeline))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationType), TypeInfoPropertyName = "PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Config9), TypeInfoPropertyName = "Config92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1Type), TypeInfoPropertyName = "PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1DataChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2Type), TypeInfoPropertyName = "PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminatorType), TypeInfoPropertyName = "PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponseErrorCode), TypeInfoPropertyName = "PipelinesUpdatePipelineProducerConfigResponseErrorCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponseErrorCode2), TypeInfoPropertyName = "PipelinesUpdatePipelineProducerConfigResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineResponseErrorCode), TypeInfoPropertyName = "PipelinesPreviewPipelineResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesSyncPipelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesSyncPipelineResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesSyncPipelineResponseErrorCode), TypeInfoPropertyName = "PipelinesSyncPipelineResponseErrorCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesSyncPipelineResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesSyncPipelineResponseErrorCode2), TypeInfoPropertyName = "PipelinesSyncPipelineResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelineSyncHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Letta.PipelinesListPipelineSyncHistoryResponseRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelineSyncHistoryResponseRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelineSyncHistoryResponseRunStatus), TypeInfoPropertyName = "PipelinesListPipelineSyncHistoryResponseRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelineSyncHistoryResponseRunError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelineSyncHistoryResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelineSyncHistoryResponseErrorCode), TypeInfoPropertyName = "PipelinesListPipelineSyncHistoryResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineRequestIntegrationType?), TypeInfoPropertyName = "NullablePipelinesCreatePipelineRequestIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProducerConfig?), TypeInfoPropertyName = "NullableProducerConfig2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant1Type?), TypeInfoPropertyName = "NullablePipelinesCreatePipelineRequestProducerConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant2Type?), TypeInfoPropertyName = "NullablePipelinesCreatePipelineRequestProducerConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigDiscriminatorType?), TypeInfoPropertyName = "NullablePipelinesCreatePipelineRequestProducerConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProducerConfig2?), TypeInfoPropertyName = "NullableProducerConfig22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Type?), TypeInfoPropertyName = "NullablePipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2Type?), TypeInfoPropertyName = "NullablePipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigDiscriminatorType?), TypeInfoPropertyName = "NullablePipelinesUpdatePipelineProducerConfigRequestProducerConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineRequestIntegrationType?), TypeInfoPropertyName = "NullablePipelinesPreviewPipelineRequestIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.ProducerConfig3?), TypeInfoPropertyName = "NullableProducerConfig32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1Type?), TypeInfoPropertyName = "NullablePipelinesPreviewPipelineRequestProducerConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant2Type?), TypeInfoPropertyName = "NullablePipelinesPreviewPipelineRequestProducerConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigDiscriminatorType?), TypeInfoPropertyName = "NullablePipelinesPreviewPipelineRequestProducerConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.OneOf<string, double?>?), TypeInfoPropertyName = "NullableOneOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineIntegrationType?), TypeInfoPropertyName = "NullablePipelinesCreatePipelineResponsePipelineIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Config5?), TypeInfoPropertyName = "NullableConfig52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant1Type?), TypeInfoPropertyName = "NullablePipelinesCreatePipelineResponsePipelineConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant2Type?), TypeInfoPropertyName = "NullablePipelinesCreatePipelineResponsePipelineConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigDiscriminatorType?), TypeInfoPropertyName = "NullablePipelinesCreatePipelineResponsePipelineConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesCreatePipelineResponseErrorCode?), TypeInfoPropertyName = "NullablePipelinesCreatePipelineResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponsePipelineIntegrationType?), TypeInfoPropertyName = "NullablePipelinesListPipelinesResponsePipelineIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Config6?), TypeInfoPropertyName = "NullableConfig62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1Type?), TypeInfoPropertyName = "NullablePipelinesListPipelinesResponsePipelineConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2Type?), TypeInfoPropertyName = "NullablePipelinesListPipelinesResponsePipelineConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigDiscriminatorType?), TypeInfoPropertyName = "NullablePipelinesListPipelinesResponsePipelineConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponsePipelineIntegrationType?), TypeInfoPropertyName = "NullablePipelinesGetPipelineResponsePipelineIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Config7?), TypeInfoPropertyName = "NullableConfig72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant1Type?), TypeInfoPropertyName = "NullablePipelinesGetPipelineResponsePipelineConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant2Type?), TypeInfoPropertyName = "NullablePipelinesGetPipelineResponsePipelineConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigDiscriminatorType?), TypeInfoPropertyName = "NullablePipelinesGetPipelineResponsePipelineConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesGetPipelineResponseErrorCode?), TypeInfoPropertyName = "NullablePipelinesGetPipelineResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineIntegrationType?), TypeInfoPropertyName = "NullablePipelinesUpdatePipelineResponsePipelineIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Config8?), TypeInfoPropertyName = "NullableConfig82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1Type?), TypeInfoPropertyName = "NullablePipelinesUpdatePipelineResponsePipelineConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant2Type?), TypeInfoPropertyName = "NullablePipelinesUpdatePipelineResponsePipelineConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigDiscriminatorType?), TypeInfoPropertyName = "NullablePipelinesUpdatePipelineResponsePipelineConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineResponseErrorCode?), TypeInfoPropertyName = "NullablePipelinesUpdatePipelineResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesDeletePipelineResponseErrorCode?), TypeInfoPropertyName = "NullablePipelinesDeletePipelineResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationType?), TypeInfoPropertyName = "NullablePipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.Config9?), TypeInfoPropertyName = "NullableConfig92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1Type?), TypeInfoPropertyName = "NullablePipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2Type?), TypeInfoPropertyName = "NullablePipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminatorType?), TypeInfoPropertyName = "NullablePipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponseErrorCode?), TypeInfoPropertyName = "NullablePipelinesUpdatePipelineProducerConfigResponseErrorCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponseErrorCode2?), TypeInfoPropertyName = "NullablePipelinesUpdatePipelineProducerConfigResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesPreviewPipelineResponseErrorCode?), TypeInfoPropertyName = "NullablePipelinesPreviewPipelineResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesSyncPipelineResponseErrorCode?), TypeInfoPropertyName = "NullablePipelinesSyncPipelineResponseErrorCode2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesSyncPipelineResponseErrorCode2?), TypeInfoPropertyName = "NullablePipelinesSyncPipelineResponseErrorCode22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelineSyncHistoryResponseRunStatus?), TypeInfoPropertyName = "NullablePipelinesListPipelineSyncHistoryResponseRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Letta.PipelinesListPipelineSyncHistoryResponseErrorCode?), TypeInfoPropertyName = "NullablePipelinesListPipelineSyncHistoryResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PipelinesListPipelinesResponsePipeline>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1DataChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Letta.PipelinesListPipelineSyncHistoryResponseRun>))]
    internal sealed partial class PipelinesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PipelinesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static PipelinesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private PipelinesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Letta.JsonConverters.ProducerConfigJsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ProducerConfig2JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.ProducerConfig3JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.Config5JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.Config6JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.Config7JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.Config8JsonConverter());
            options.Converters.Add(new global::Letta.JsonConverters.Config9JsonConverter());
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
                    typeToConvert == typeof(global::Letta.PipelinesCreatePipelineRequestIntegrationType)

                    || typeToConvert == typeof(global::Letta.PipelinesCreatePipelineRequestIntegrationType?)

                    || typeToConvert == typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant1Type)

                    || typeToConvert == typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant1Type?)

                    || typeToConvert == typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant2Type)

                    || typeToConvert == typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant2Type?)

                    || typeToConvert == typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Type)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Type?)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2Type)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2Type?)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.PipelinesPreviewPipelineRequestIntegrationType)

                    || typeToConvert == typeof(global::Letta.PipelinesPreviewPipelineRequestIntegrationType?)

                    || typeToConvert == typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1Type)

                    || typeToConvert == typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1Type?)

                    || typeToConvert == typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant2Type)

                    || typeToConvert == typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant2Type?)

                    || typeToConvert == typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.PipelinesCreatePipelineResponsePipelineIntegrationType)

                    || typeToConvert == typeof(global::Letta.PipelinesCreatePipelineResponsePipelineIntegrationType?)

                    || typeToConvert == typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant1Type)

                    || typeToConvert == typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant1Type?)

                    || typeToConvert == typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant2Type)

                    || typeToConvert == typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant2Type?)

                    || typeToConvert == typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.PipelinesCreatePipelineResponseErrorCode)

                    || typeToConvert == typeof(global::Letta.PipelinesCreatePipelineResponseErrorCode?)

                    || typeToConvert == typeof(global::Letta.PipelinesListPipelinesResponsePipelineIntegrationType)

                    || typeToConvert == typeof(global::Letta.PipelinesListPipelinesResponsePipelineIntegrationType?)

                    || typeToConvert == typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1Type)

                    || typeToConvert == typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1Type?)

                    || typeToConvert == typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2Type)

                    || typeToConvert == typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2Type?)

                    || typeToConvert == typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.PipelinesGetPipelineResponsePipelineIntegrationType)

                    || typeToConvert == typeof(global::Letta.PipelinesGetPipelineResponsePipelineIntegrationType?)

                    || typeToConvert == typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant1Type)

                    || typeToConvert == typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant1Type?)

                    || typeToConvert == typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant2Type)

                    || typeToConvert == typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant2Type?)

                    || typeToConvert == typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.PipelinesGetPipelineResponseErrorCode)

                    || typeToConvert == typeof(global::Letta.PipelinesGetPipelineResponseErrorCode?)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineIntegrationType)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineIntegrationType?)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1Type)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1Type?)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant2Type)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant2Type?)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineResponseErrorCode)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineResponseErrorCode?)

                    || typeToConvert == typeof(global::Letta.PipelinesDeletePipelineResponseErrorCode)

                    || typeToConvert == typeof(global::Letta.PipelinesDeletePipelineResponseErrorCode?)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationType)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationType?)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1Type)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1Type?)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2Type)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2Type?)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminatorType)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminatorType?)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponseErrorCode)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponseErrorCode?)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponseErrorCode2)

                    || typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponseErrorCode2?)

                    || typeToConvert == typeof(global::Letta.PipelinesPreviewPipelineResponseErrorCode)

                    || typeToConvert == typeof(global::Letta.PipelinesPreviewPipelineResponseErrorCode?)

                    || typeToConvert == typeof(global::Letta.PipelinesSyncPipelineResponseErrorCode)

                    || typeToConvert == typeof(global::Letta.PipelinesSyncPipelineResponseErrorCode?)

                    || typeToConvert == typeof(global::Letta.PipelinesSyncPipelineResponseErrorCode2)

                    || typeToConvert == typeof(global::Letta.PipelinesSyncPipelineResponseErrorCode2?)

                    || typeToConvert == typeof(global::Letta.PipelinesListPipelineSyncHistoryResponseRunStatus)

                    || typeToConvert == typeof(global::Letta.PipelinesListPipelineSyncHistoryResponseRunStatus?)

                    || typeToConvert == typeof(global::Letta.PipelinesListPipelineSyncHistoryResponseErrorCode)

                    || typeToConvert == typeof(global::Letta.PipelinesListPipelineSyncHistoryResponseErrorCode?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Letta.PipelinesCreatePipelineRequestIntegrationType))
                {
                    return new global::Letta.JsonConverters.PipelinesCreatePipelineRequestIntegrationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesCreatePipelineRequestIntegrationType?))
                {
                    return new global::Letta.JsonConverters.PipelinesCreatePipelineRequestIntegrationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant1Type))
                {
                    return new global::Letta.JsonConverters.PipelinesCreatePipelineRequestProducerConfigVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant1Type?))
                {
                    return new global::Letta.JsonConverters.PipelinesCreatePipelineRequestProducerConfigVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant2Type))
                {
                    return new global::Letta.JsonConverters.PipelinesCreatePipelineRequestProducerConfigVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigVariant2Type?))
                {
                    return new global::Letta.JsonConverters.PipelinesCreatePipelineRequestProducerConfigVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigDiscriminatorType))
                {
                    return new global::Letta.JsonConverters.PipelinesCreatePipelineRequestProducerConfigDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesCreatePipelineRequestProducerConfigDiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.PipelinesCreatePipelineRequestProducerConfigDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Type))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1Type?))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2Type))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2Type?))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigDiscriminatorType))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigRequestProducerConfigDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigRequestProducerConfigDiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigRequestProducerConfigDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesPreviewPipelineRequestIntegrationType))
                {
                    return new global::Letta.JsonConverters.PipelinesPreviewPipelineRequestIntegrationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesPreviewPipelineRequestIntegrationType?))
                {
                    return new global::Letta.JsonConverters.PipelinesPreviewPipelineRequestIntegrationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1Type))
                {
                    return new global::Letta.JsonConverters.PipelinesPreviewPipelineRequestProducerConfigVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant1Type?))
                {
                    return new global::Letta.JsonConverters.PipelinesPreviewPipelineRequestProducerConfigVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant2Type))
                {
                    return new global::Letta.JsonConverters.PipelinesPreviewPipelineRequestProducerConfigVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigVariant2Type?))
                {
                    return new global::Letta.JsonConverters.PipelinesPreviewPipelineRequestProducerConfigVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigDiscriminatorType))
                {
                    return new global::Letta.JsonConverters.PipelinesPreviewPipelineRequestProducerConfigDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesPreviewPipelineRequestProducerConfigDiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.PipelinesPreviewPipelineRequestProducerConfigDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesCreatePipelineResponsePipelineIntegrationType))
                {
                    return new global::Letta.JsonConverters.PipelinesCreatePipelineResponsePipelineIntegrationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesCreatePipelineResponsePipelineIntegrationType?))
                {
                    return new global::Letta.JsonConverters.PipelinesCreatePipelineResponsePipelineIntegrationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant1Type))
                {
                    return new global::Letta.JsonConverters.PipelinesCreatePipelineResponsePipelineConfigVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant1Type?))
                {
                    return new global::Letta.JsonConverters.PipelinesCreatePipelineResponsePipelineConfigVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant2Type))
                {
                    return new global::Letta.JsonConverters.PipelinesCreatePipelineResponsePipelineConfigVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigVariant2Type?))
                {
                    return new global::Letta.JsonConverters.PipelinesCreatePipelineResponsePipelineConfigVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigDiscriminatorType))
                {
                    return new global::Letta.JsonConverters.PipelinesCreatePipelineResponsePipelineConfigDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesCreatePipelineResponsePipelineConfigDiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.PipelinesCreatePipelineResponsePipelineConfigDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesCreatePipelineResponseErrorCode))
                {
                    return new global::Letta.JsonConverters.PipelinesCreatePipelineResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesCreatePipelineResponseErrorCode?))
                {
                    return new global::Letta.JsonConverters.PipelinesCreatePipelineResponseErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesListPipelinesResponsePipelineIntegrationType))
                {
                    return new global::Letta.JsonConverters.PipelinesListPipelinesResponsePipelineIntegrationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesListPipelinesResponsePipelineIntegrationType?))
                {
                    return new global::Letta.JsonConverters.PipelinesListPipelinesResponsePipelineIntegrationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1Type))
                {
                    return new global::Letta.JsonConverters.PipelinesListPipelinesResponsePipelineConfigVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant1Type?))
                {
                    return new global::Letta.JsonConverters.PipelinesListPipelinesResponsePipelineConfigVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2Type))
                {
                    return new global::Letta.JsonConverters.PipelinesListPipelinesResponsePipelineConfigVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigVariant2Type?))
                {
                    return new global::Letta.JsonConverters.PipelinesListPipelinesResponsePipelineConfigVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigDiscriminatorType))
                {
                    return new global::Letta.JsonConverters.PipelinesListPipelinesResponsePipelineConfigDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesListPipelinesResponsePipelineConfigDiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.PipelinesListPipelinesResponsePipelineConfigDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesGetPipelineResponsePipelineIntegrationType))
                {
                    return new global::Letta.JsonConverters.PipelinesGetPipelineResponsePipelineIntegrationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesGetPipelineResponsePipelineIntegrationType?))
                {
                    return new global::Letta.JsonConverters.PipelinesGetPipelineResponsePipelineIntegrationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant1Type))
                {
                    return new global::Letta.JsonConverters.PipelinesGetPipelineResponsePipelineConfigVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant1Type?))
                {
                    return new global::Letta.JsonConverters.PipelinesGetPipelineResponsePipelineConfigVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant2Type))
                {
                    return new global::Letta.JsonConverters.PipelinesGetPipelineResponsePipelineConfigVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigVariant2Type?))
                {
                    return new global::Letta.JsonConverters.PipelinesGetPipelineResponsePipelineConfigVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigDiscriminatorType))
                {
                    return new global::Letta.JsonConverters.PipelinesGetPipelineResponsePipelineConfigDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesGetPipelineResponsePipelineConfigDiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.PipelinesGetPipelineResponsePipelineConfigDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesGetPipelineResponseErrorCode))
                {
                    return new global::Letta.JsonConverters.PipelinesGetPipelineResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesGetPipelineResponseErrorCode?))
                {
                    return new global::Letta.JsonConverters.PipelinesGetPipelineResponseErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineIntegrationType))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineResponsePipelineIntegrationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineIntegrationType?))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineResponsePipelineIntegrationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1Type))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineResponsePipelineConfigVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant1Type?))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineResponsePipelineConfigVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant2Type))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineResponsePipelineConfigVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigVariant2Type?))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineResponsePipelineConfigVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigDiscriminatorType))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineResponsePipelineConfigDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineResponsePipelineConfigDiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineResponsePipelineConfigDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineResponseErrorCode))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineResponseErrorCode?))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineResponseErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesDeletePipelineResponseErrorCode))
                {
                    return new global::Letta.JsonConverters.PipelinesDeletePipelineResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesDeletePipelineResponseErrorCode?))
                {
                    return new global::Letta.JsonConverters.PipelinesDeletePipelineResponseErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationType))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationType?))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1Type))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1Type?))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2Type))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2Type?))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminatorType))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminatorType?))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponseErrorCode))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponseErrorCode?))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponseErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponseErrorCode2))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponseErrorCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesUpdatePipelineProducerConfigResponseErrorCode2?))
                {
                    return new global::Letta.JsonConverters.PipelinesUpdatePipelineProducerConfigResponseErrorCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesPreviewPipelineResponseErrorCode))
                {
                    return new global::Letta.JsonConverters.PipelinesPreviewPipelineResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesPreviewPipelineResponseErrorCode?))
                {
                    return new global::Letta.JsonConverters.PipelinesPreviewPipelineResponseErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesSyncPipelineResponseErrorCode))
                {
                    return new global::Letta.JsonConverters.PipelinesSyncPipelineResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesSyncPipelineResponseErrorCode?))
                {
                    return new global::Letta.JsonConverters.PipelinesSyncPipelineResponseErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesSyncPipelineResponseErrorCode2))
                {
                    return new global::Letta.JsonConverters.PipelinesSyncPipelineResponseErrorCode2JsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesSyncPipelineResponseErrorCode2?))
                {
                    return new global::Letta.JsonConverters.PipelinesSyncPipelineResponseErrorCode2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesListPipelineSyncHistoryResponseRunStatus))
                {
                    return new global::Letta.JsonConverters.PipelinesListPipelineSyncHistoryResponseRunStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesListPipelineSyncHistoryResponseRunStatus?))
                {
                    return new global::Letta.JsonConverters.PipelinesListPipelineSyncHistoryResponseRunStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesListPipelineSyncHistoryResponseErrorCode))
                {
                    return new global::Letta.JsonConverters.PipelinesListPipelineSyncHistoryResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Letta.PipelinesListPipelineSyncHistoryResponseErrorCode?))
                {
                    return new global::Letta.JsonConverters.PipelinesListPipelineSyncHistoryResponseErrorCodeNullableJsonConverter();
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
                    0 => new PipelinesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}