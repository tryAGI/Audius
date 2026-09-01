
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTrendingTracksTime
    {
        /// <summary>
        ///
        /// </summary>
        AllTime,
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
    public static class GetTrendingTracksTimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingTracksTime value)
        {
            return value switch
            {
                GetTrendingTracksTime.AllTime => "allTime",
                GetTrendingTracksTime.Month => "month",
                GetTrendingTracksTime.Week => "week",
                GetTrendingTracksTime.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingTracksTime? ToEnum(string value)
        {
            return value switch
            {
                "allTime" => GetTrendingTracksTime.AllTime,
                "month" => GetTrendingTracksTime.Month,
                "week" => GetTrendingTracksTime.Week,
                "year" => GetTrendingTracksTime.Year,
                _ => null,
            };
        }
    }
}