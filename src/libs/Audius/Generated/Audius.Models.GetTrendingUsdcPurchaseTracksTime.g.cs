
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTrendingUsdcPurchaseTracksTime
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
    public static class GetTrendingUsdcPurchaseTracksTimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingUsdcPurchaseTracksTime value)
        {
            return value switch
            {
                GetTrendingUsdcPurchaseTracksTime.AllTime => "allTime",
                GetTrendingUsdcPurchaseTracksTime.Month => "month",
                GetTrendingUsdcPurchaseTracksTime.Week => "week",
                GetTrendingUsdcPurchaseTracksTime.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingUsdcPurchaseTracksTime? ToEnum(string value)
        {
            return value switch
            {
                "allTime" => GetTrendingUsdcPurchaseTracksTime.AllTime,
                "month" => GetTrendingUsdcPurchaseTracksTime.Month,
                "week" => GetTrendingUsdcPurchaseTracksTime.Week,
                "year" => GetTrendingUsdcPurchaseTracksTime.Year,
                _ => null,
            };
        }
    }
}