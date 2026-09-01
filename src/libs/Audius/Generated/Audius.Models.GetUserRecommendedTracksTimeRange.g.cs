
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: week
    /// </summary>
    public enum GetUserRecommendedTracksTimeRange
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUserRecommendedTracksTimeRangeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUserRecommendedTracksTimeRange value)
        {
            return value switch
            {
                GetUserRecommendedTracksTimeRange.AllTime => "allTime",
                GetUserRecommendedTracksTimeRange.Month => "month",
                GetUserRecommendedTracksTimeRange.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUserRecommendedTracksTimeRange? ToEnum(string value)
        {
            return value switch
            {
                "allTime" => GetUserRecommendedTracksTimeRange.AllTime,
                "month" => GetUserRecommendedTracksTimeRange.Month,
                "week" => GetUserRecommendedTracksTimeRange.Week,
                _ => null,
            };
        }
    }
}