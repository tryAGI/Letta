
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public enum SGLangModelSettingsResponseFormatVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonObject,
        /// <summary>
        /// 
        /// </summary>
        JsonSchema,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SGLangModelSettingsResponseFormatVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SGLangModelSettingsResponseFormatVariant1DiscriminatorType value)
        {
            return value switch
            {
                SGLangModelSettingsResponseFormatVariant1DiscriminatorType.JsonObject => "json_object",
                SGLangModelSettingsResponseFormatVariant1DiscriminatorType.JsonSchema => "json_schema",
                SGLangModelSettingsResponseFormatVariant1DiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SGLangModelSettingsResponseFormatVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => SGLangModelSettingsResponseFormatVariant1DiscriminatorType.JsonObject,
                "json_schema" => SGLangModelSettingsResponseFormatVariant1DiscriminatorType.JsonSchema,
                "text" => SGLangModelSettingsResponseFormatVariant1DiscriminatorType.Text,
                _ => null,
            };
        }
    }
}