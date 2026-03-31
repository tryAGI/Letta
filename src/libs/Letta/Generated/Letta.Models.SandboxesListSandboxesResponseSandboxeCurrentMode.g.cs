
#nullable enable

namespace Letta
{
    /// <summary>
    /// 
    /// </summary>
    public enum SandboxesListSandboxesResponseSandboxeCurrentMode
    {
        /// <summary>
        /// 
        /// </summary>
        AcceptEdits,
        /// <summary>
        /// 
        /// </summary>
        BypassPermissions,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Plan,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxesListSandboxesResponseSandboxeCurrentModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxesListSandboxesResponseSandboxeCurrentMode value)
        {
            return value switch
            {
                SandboxesListSandboxesResponseSandboxeCurrentMode.AcceptEdits => "acceptEdits",
                SandboxesListSandboxesResponseSandboxeCurrentMode.BypassPermissions => "bypassPermissions",
                SandboxesListSandboxesResponseSandboxeCurrentMode.Default => "default",
                SandboxesListSandboxesResponseSandboxeCurrentMode.Plan => "plan",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxesListSandboxesResponseSandboxeCurrentMode? ToEnum(string value)
        {
            return value switch
            {
                "acceptEdits" => SandboxesListSandboxesResponseSandboxeCurrentMode.AcceptEdits,
                "bypassPermissions" => SandboxesListSandboxesResponseSandboxeCurrentMode.BypassPermissions,
                "default" => SandboxesListSandboxesResponseSandboxeCurrentMode.Default,
                "plan" => SandboxesListSandboxesResponseSandboxeCurrentMode.Plan,
                _ => null,
            };
        }
    }
}