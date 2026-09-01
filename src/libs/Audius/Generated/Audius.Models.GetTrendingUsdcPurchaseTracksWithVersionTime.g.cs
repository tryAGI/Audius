
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTrendingUsdcPurchaseTracksWithVersionTime
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
    public static class GetTrendingUsdcPurchaseTracksWithVersionTimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingUsdcPurchaseTracksWithVersionTime value)
        {
            return value switch
            {
                GetTrendingUsdcPurchaseTracksWithVersionTime.AllTime => "allTime",
                GetTrendingUsdcPurchaseTracksWithVersionTime.Month => "month",
                GetTrendingUsdcPurchaseTracksWithVersionTime.Week => "week",
                GetTrendingUsdcPurchaseTracksWithVersionTime.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingUsdcPurchaseTracksWithVersionTime? ToEnum(string value)
        {
            return value switch
            {
                "allTime" => GetTrendingUsdcPurchaseTracksWithVersionTime.AllTime,
                "month" => GetTrendingUsdcPurchaseTracksWithVersionTime.Month,
                "week" => GetTrendingUsdcPurchaseTracksWithVersionTime.Week,
                "year" => GetTrendingUsdcPurchaseTracksWithVersionTime.Year,
                _ => null,
            };
        }
    }
}