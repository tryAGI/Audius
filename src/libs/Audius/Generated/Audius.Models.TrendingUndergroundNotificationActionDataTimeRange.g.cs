
#nullable enable

namespace Audius
{
    /// <summary>
    /// Example: week
    /// </summary>
    public enum TrendingUndergroundNotificationActionDataTimeRange
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
    public static class TrendingUndergroundNotificationActionDataTimeRangeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrendingUndergroundNotificationActionDataTimeRange value)
        {
            return value switch
            {
                TrendingUndergroundNotificationActionDataTimeRange.Month => "month",
                TrendingUndergroundNotificationActionDataTimeRange.Week => "week",
                TrendingUndergroundNotificationActionDataTimeRange.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrendingUndergroundNotificationActionDataTimeRange? ToEnum(string value)
        {
            return value switch
            {
                "month" => TrendingUndergroundNotificationActionDataTimeRange.Month,
                "week" => TrendingUndergroundNotificationActionDataTimeRange.Week,
                "year" => TrendingUndergroundNotificationActionDataTimeRange.Year,
                _ => null,
            };
        }
    }
}