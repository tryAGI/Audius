
#nullable enable

namespace Audius
{
    /// <summary>
    /// Example: week
    /// </summary>
    public enum TrendingPlaylistNotificationActionDataTimeRange
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
    public static class TrendingPlaylistNotificationActionDataTimeRangeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrendingPlaylistNotificationActionDataTimeRange value)
        {
            return value switch
            {
                TrendingPlaylistNotificationActionDataTimeRange.Month => "month",
                TrendingPlaylistNotificationActionDataTimeRange.Week => "week",
                TrendingPlaylistNotificationActionDataTimeRange.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrendingPlaylistNotificationActionDataTimeRange? ToEnum(string value)
        {
            return value switch
            {
                "month" => TrendingPlaylistNotificationActionDataTimeRange.Month,
                "week" => TrendingPlaylistNotificationActionDataTimeRange.Week,
                "year" => TrendingPlaylistNotificationActionDataTimeRange.Year,
                _ => null,
            };
        }
    }
}