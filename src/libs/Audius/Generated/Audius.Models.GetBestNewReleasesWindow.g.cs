
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetBestNewReleasesWindow
    {
        /// <summary>
        ///
        /// </summary>
        Month,
        /// <summary>
        ///
        /// </summary>
        Week,
        /// <summary>
        ///
        /// </summary>
        Year,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetBestNewReleasesWindowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBestNewReleasesWindow value)
        {
            return value switch
            {
                GetBestNewReleasesWindow.Month => "month",
                GetBestNewReleasesWindow.Week => "week",
                GetBestNewReleasesWindow.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBestNewReleasesWindow? ToEnum(string value)
        {
            return value switch
            {
                "month" => GetBestNewReleasesWindow.Month,
                "week" => GetBestNewReleasesWindow.Week,
                "year" => GetBestNewReleasesWindow.Year,
                _ => null,
            };
        }
    }
}