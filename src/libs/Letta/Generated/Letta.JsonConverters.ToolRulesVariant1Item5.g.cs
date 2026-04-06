#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class ToolRulesVariant1Item5JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.ToolRulesVariant1Item5>
    {
        /// <inheritdoc />
        public override global::Letta.ToolRulesVariant1Item5 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Letta.ChildToolRule? constrainChildTools = default;
            if (discriminator?.Type == global::Letta.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.ConstrainChildTools)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ChildToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ChildToolRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ChildToolRule)}");
                constrainChildTools = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.InitToolRule? runFirst = default;
            if (discriminator?.Type == global::Letta.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.RunFirst)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.InitToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.InitToolRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.InitToolRule)}");
                runFirst = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.TerminalToolRule? exitLoop = default;
            if (discriminator?.Type == global::Letta.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.ExitLoop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.TerminalToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.TerminalToolRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.TerminalToolRule)}");
                exitLoop = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ConditionalToolRule? conditional = default;
            if (discriminator?.Type == global::Letta.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.Conditional)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ConditionalToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ConditionalToolRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ConditionalToolRule)}");
                conditional = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ContinueToolRule? continueLoop = default;
            if (discriminator?.Type == global::Letta.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.ContinueLoop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ContinueToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ContinueToolRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ContinueToolRule)}");
                continueLoop = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.RequiredBeforeExitToolRule? requiredBeforeExit = default;
            if (discriminator?.Type == global::Letta.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.RequiredBeforeExit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.RequiredBeforeExitToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.RequiredBeforeExitToolRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.RequiredBeforeExitToolRule)}");
                requiredBeforeExit = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.MaxCountPerStepToolRule? maxCountPerStep = default;
            if (discriminator?.Type == global::Letta.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.MaxCountPerStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MaxCountPerStepToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MaxCountPerStepToolRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.MaxCountPerStepToolRule)}");
                maxCountPerStep = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.ParentToolRule? parentLastTool = default;
            if (discriminator?.Type == global::Letta.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.ParentLastTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ParentToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ParentToolRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.ParentToolRule)}");
                parentLastTool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Letta.RequiresApprovalToolRule? requiresApproval = default;
            if (discriminator?.Type == global::Letta.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType.RequiresApproval)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.RequiresApprovalToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.RequiresApprovalToolRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Letta.RequiresApprovalToolRule)}");
                requiresApproval = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Letta.ToolRulesVariant1Item5(
                discriminator?.Type,
                constrainChildTools,

                runFirst,

                exitLoop,

                conditional,

                continueLoop,

                requiredBeforeExit,

                maxCountPerStep,

                parentLastTool,

                requiresApproval
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Letta.ToolRulesVariant1Item5 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsConstrainChildTools)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ChildToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ChildToolRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.ChildToolRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConstrainChildTools!, typeInfo);
            }
            else if (value.IsRunFirst)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.InitToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.InitToolRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.InitToolRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunFirst!, typeInfo);
            }
            else if (value.IsExitLoop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.TerminalToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.TerminalToolRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.TerminalToolRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExitLoop!, typeInfo);
            }
            else if (value.IsConditional)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ConditionalToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ConditionalToolRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.ConditionalToolRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Conditional!, typeInfo);
            }
            else if (value.IsContinueLoop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ContinueToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ContinueToolRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.ContinueToolRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContinueLoop!, typeInfo);
            }
            else if (value.IsRequiredBeforeExit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.RequiredBeforeExitToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.RequiredBeforeExitToolRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.RequiredBeforeExitToolRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiredBeforeExit!, typeInfo);
            }
            else if (value.IsMaxCountPerStep)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.MaxCountPerStepToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.MaxCountPerStepToolRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.MaxCountPerStepToolRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxCountPerStep!, typeInfo);
            }
            else if (value.IsParentLastTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.ParentToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.ParentToolRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.ParentToolRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ParentLastTool!, typeInfo);
            }
            else if (value.IsRequiresApproval)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Letta.RequiresApprovalToolRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Letta.RequiresApprovalToolRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Letta.RequiresApprovalToolRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiresApproval!, typeInfo);
            }
        }
    }
}