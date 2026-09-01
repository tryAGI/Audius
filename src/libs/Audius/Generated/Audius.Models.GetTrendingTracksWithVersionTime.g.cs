
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTrendingTracksWithVersionTime
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
    public static class GetTrendingTracksWithVersionTimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingTracksWithVersionTime value)
        {
            return value switch
            {
                GetTrendingTracksWithVersionTime.AllTime => "allTime",
                GetTrendingTracksWithVersionTime.Month => "month",
                GetTrendingTracksWithVersionTime.Week => "week",
                GetTrendingTracksWithVersionTime.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingTracksWithVersionTime? ToEnum(string value)
        {
            return value switch
            {
                "allTime" => GetTrendingTracksWithVersionTime.AllTime,
                "month" => GetTrendingTracksWithVersionTime.Month,
                "week" => GetTrendingTracksWithVersionTime.Week,
                "year" => GetTrendingTracksWithVersionTime.Year,
                _ => null,
            };
        }
    }
}