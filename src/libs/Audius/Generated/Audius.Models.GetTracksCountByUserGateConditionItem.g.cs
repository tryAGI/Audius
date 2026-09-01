
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTracksCountByUserGateConditionItem
    {
        /// <summary>
        ///
        /// </summary>
        Follow,
        /// <summary>
        ///
        /// </summary>
        Nft,
        /// <summary>
        ///
        /// </summary>
        Tip,
        /// <summary>
        ///
        /// </summary>
        Token,
        /// <summary>
        ///
        /// </summary>
        Ungated,
        /// <summary>
        ///
        /// </summary>
        UsdcPurchase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTracksCountByUserGateConditionItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTracksCountByUserGateConditionItem value)
        {
            return value switch
            {
                GetTracksCountByUserGateConditionItem.Follow => "follow",
                GetTracksCountByUserGateConditionItem.Nft => "nft",
                GetTracksCountByUserGateConditionItem.Tip => "tip",
                GetTracksCountByUserGateConditionItem.Token => "token",
                GetTracksCountByUserGateConditionItem.Ungated => "ungated",
                GetTracksCountByUserGateConditionItem.UsdcPurchase => "usdc_purchase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTracksCountByUserGateConditionItem? ToEnum(string value)
        {
            return value switch
            {
                "follow" => GetTracksCountByUserGateConditionItem.Follow,
                "nft" => GetTracksCountByUserGateConditionItem.Nft,
                "tip" => GetTracksCountByUserGateConditionItem.Tip,
                "token" => GetTracksCountByUserGateConditionItem.Token,
                "ungated" => GetTracksCountByUserGateConditionItem.Ungated,
                "usdc_purchase" => GetTracksCountByUserGateConditionItem.UsdcPurchase,
                _ => null,
            };
        }
    }
}