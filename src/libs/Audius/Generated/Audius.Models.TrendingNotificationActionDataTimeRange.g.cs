
#nullable enable

namespace Audius
{
    /// <summary>
    /// Example: week
    /// </summary>
    public enum TrendingNotificationActionDataTimeRange
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
    public static class TrendingNotificationActionDataTimeRangeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrendingNotificationActionDataTimeRange value)
        {
            return value switch
            {
                TrendingNotificationActionDataTimeRange.Month => "month",
                TrendingNotificationActionDataTimeRange.Week => "week",
                TrendingNotificationActionDataTimeRange.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrendingNotificationActionDataTimeRange? ToEnum(string value)
        {
            return value switch
            {
                "month" => TrendingNotificationActionDataTimeRange.Month,
                "week" => TrendingNotificationActionDataTimeRange.Week,
                "year" => TrendingNotificationActionDataTimeRange.Year,
                _ => null,
            };
        }
    }
}