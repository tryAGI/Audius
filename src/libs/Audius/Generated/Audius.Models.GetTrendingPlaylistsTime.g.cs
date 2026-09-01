
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTrendingPlaylistsTime
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
    public static class GetTrendingPlaylistsTimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingPlaylistsTime value)
        {
            return value switch
            {
                GetTrendingPlaylistsTime.AllTime => "allTime",
                GetTrendingPlaylistsTime.Month => "month",
                GetTrendingPlaylistsTime.Week => "week",
                GetTrendingPlaylistsTime.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingPlaylistsTime? ToEnum(string value)
        {
            return value switch
            {
                "allTime" => GetTrendingPlaylistsTime.AllTime,
                "month" => GetTrendingPlaylistsTime.Month,
                "week" => GetTrendingPlaylistsTime.Week,
                "year" => GetTrendingPlaylistsTime.Year,
                _ => null,
            };
        }
    }
}