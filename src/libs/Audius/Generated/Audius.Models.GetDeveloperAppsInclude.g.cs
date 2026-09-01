
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetDeveloperAppsInclude
    {
        /// <summary>
        ///
        /// </summary>
        Metrics,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDeveloperAppsIncludeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDeveloperAppsInclude value)
        {
            return value switch
            {
                GetDeveloperAppsInclude.Metrics => "metrics",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDeveloperAppsInclude? ToEnum(string value)
        {
            return value switch
            {
                "metrics" => GetDeveloperAppsInclude.Metrics,
                _ => null,
            };
        }
    }
}