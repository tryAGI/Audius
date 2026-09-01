
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTrendingPlaylistsWithVersionTime
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
    public static class GetTrendingPlaylistsWithVersionTimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingPlaylistsWithVersionTime value)
        {
            return value switch
            {
                GetTrendingPlaylistsWithVersionTime.AllTime => "allTime",
                GetTrendingPlaylistsWithVersionTime.Month => "month",
                GetTrendingPlaylistsWithVersionTime.Week => "week",
                GetTrendingPlaylistsWithVersionTime.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingPlaylistsWithVersionTime? ToEnum(string value)
        {
            return value switch
            {
                "allTime" => GetTrendingPlaylistsWithVersionTime.AllTime,
                "month" => GetTrendingPlaylistsWithVersionTime.Month,
                "week" => GetTrendingPlaylistsWithVersionTime.Week,
                "year" => GetTrendingPlaylistsWithVersionTime.Year,
                _ => null,
            };
        }
    }
}