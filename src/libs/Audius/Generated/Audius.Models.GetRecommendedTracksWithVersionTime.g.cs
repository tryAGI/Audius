
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetRecommendedTracksWithVersionTime
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
    public static class GetRecommendedTracksWithVersionTimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRecommendedTracksWithVersionTime value)
        {
            return value switch
            {
                GetRecommendedTracksWithVersionTime.AllTime => "allTime",
                GetRecommendedTracksWithVersionTime.Month => "month",
                GetRecommendedTracksWithVersionTime.Week => "week",
                GetRecommendedTracksWithVersionTime.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRecommendedTracksWithVersionTime? ToEnum(string value)
        {
            return value switch
            {
                "allTime" => GetRecommendedTracksWithVersionTime.AllTime,
                "month" => GetRecommendedTracksWithVersionTime.Month,
                "week" => GetRecommendedTracksWithVersionTime.Week,
                "year" => GetRecommendedTracksWithVersionTime.Year,
                _ => null,
            };
        }
    }
}