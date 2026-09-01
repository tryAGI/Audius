
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetRecommendedTracksTime
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
    public static class GetRecommendedTracksTimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRecommendedTracksTime value)
        {
            return value switch
            {
                GetRecommendedTracksTime.AllTime => "allTime",
                GetRecommendedTracksTime.Month => "month",
                GetRecommendedTracksTime.Week => "week",
                GetRecommendedTracksTime.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRecommendedTracksTime? ToEnum(string value)
        {
            return value switch
            {
                "allTime" => GetRecommendedTracksTime.AllTime,
                "month" => GetRecommendedTracksTime.Month,
                "week" => GetRecommendedTracksTime.Week,
                "year" => GetRecommendedTracksTime.Year,
                _ => null,
            };
        }
    }
}