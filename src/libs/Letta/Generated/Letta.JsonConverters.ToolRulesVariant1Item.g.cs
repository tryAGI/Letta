#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Letta.JsonConverters
{
    /// <inheritdoc />
    public class ToolRulesVariant1ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Letta.ToolRulesVariant1Item>
    {
        /// <inheritdoc />
        public override global::Letta.ToolRulesVariant1Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.AgentStateToolRulesVariant1ItemDiscriminator>(ref readerCopy, options);

            global::Letta.ChildToolRule? constrainChildTools = default;
            if (discriminator?.Type == global::Letta.AgentStateToolRulesVariant1ItemDiscriminatorType.ConstrainChildTools)
            {
                constrainChildTools = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ChildToolRule>(ref reader, options);
            }
            global::Letta.InitToolRule? runFirst = default;
            if (discriminator?.Type == global::Letta.AgentStateToolRulesVariant1ItemDiscriminatorType.RunFirst)
            {
                runFirst = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.InitToolRule>(ref reader, options);
            }
            global::Letta.TerminalToolRule? exitLoop = default;
            if (discriminator?.Type == global::Letta.AgentStateToolRulesVariant1ItemDiscriminatorType.ExitLoop)
            {
                exitLoop = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.TerminalToolRule>(ref reader, options);
            }
            global::Letta.ConditionalToolRule? conditional = default;
            if (discriminator?.Type == global::Letta.AgentStateToolRulesVariant1ItemDiscriminatorType.Conditional)
            {
                conditional = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ConditionalToolRule>(ref reader, options);
            }
            global::Letta.ContinueToolRule? continueLoop = default;
            if (discriminator?.Type == global::Letta.AgentStateToolRulesVariant1ItemDiscriminatorType.ContinueLoop)
            {
                continueLoop = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ContinueToolRule>(ref reader, options);
            }
            global::Letta.RequiredBeforeExitToolRule? requiredBeforeExit = default;
            if (discriminator?.Type == global::Letta.AgentStateToolRulesVariant1ItemDiscriminatorType.RequiredBeforeExit)
            {
                requiredBeforeExit = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.RequiredBeforeExitToolRule>(ref reader, options);
            }
            global::Letta.MaxCountPerStepToolRule? maxCountPerStep = default;
            if (discriminator?.Type == global::Letta.AgentStateToolRulesVariant1ItemDiscriminatorType.MaxCountPerStep)
            {
                maxCountPerStep = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.MaxCountPerStepToolRule>(ref reader, options);
            }
            global::Letta.ParentToolRule? parentLastTool = default;
            if (discriminator?.Type == global::Letta.AgentStateToolRulesVariant1ItemDiscriminatorType.ParentLastTool)
            {
                parentLastTool = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.ParentToolRule>(ref reader, options);
            }
            global::Letta.RequiresApprovalToolRule? requiresApproval = default;
            if (discriminator?.Type == global::Letta.AgentStateToolRulesVariant1ItemDiscriminatorType.RequiresApproval)
            {
                requiresApproval = global::System.Text.Json.JsonSerializer.Deserialize<global::Letta.RequiresApprovalToolRule>(ref reader, options);
            }

            var __value = new global::Letta.ToolRulesVariant1Item(
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
            global::Letta.ToolRulesVariant1Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsConstrainChildTools)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConstrainChildTools, typeof(global::Letta.ChildToolRule), options);
            }
            else if (value.IsRunFirst)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunFirst, typeof(global::Letta.InitToolRule), options);
            }
            else if (value.IsExitLoop)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExitLoop, typeof(global::Letta.TerminalToolRule), options);
            }
            else if (value.IsConditional)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Conditional, typeof(global::Letta.ConditionalToolRule), options);
            }
            else if (value.IsContinueLoop)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContinueLoop, typeof(global::Letta.ContinueToolRule), options);
            }
            else if (value.IsRequiredBeforeExit)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiredBeforeExit, typeof(global::Letta.RequiredBeforeExitToolRule), options);
            }
            else if (value.IsMaxCountPerStep)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxCountPerStep, typeof(global::Letta.MaxCountPerStepToolRule), options);
            }
            else if (value.IsParentLastTool)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ParentLastTool, typeof(global::Letta.ParentToolRule), options);
            }
            else if (value.IsRequiresApproval)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequiresApproval, typeof(global::Letta.RequiresApprovalToolRule), options);
            }
        }
    }
}