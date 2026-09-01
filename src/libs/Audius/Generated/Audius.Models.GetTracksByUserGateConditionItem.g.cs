
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTracksByUserGateConditionItem
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
    public static class GetTracksByUserGateConditionItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTracksByUserGateConditionItem value)
        {
            return value switch
            {
                GetTracksByUserGateConditionItem.Follow => "follow",
                GetTracksByUserGateConditionItem.Nft => "nft",
                GetTracksByUserGateConditionItem.Tip => "tip",
                GetTracksByUserGateConditionItem.Token => "token",
                GetTracksByUserGateConditionItem.Ungated => "ungated",
                GetTracksByUserGateConditionItem.UsdcPurchase => "usdc_purchase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTracksByUserGateConditionItem? ToEnum(string value)
        {
            return value switch
            {
                "follow" => GetTracksByUserGateConditionItem.Follow,
                "nft" => GetTracksByUserGateConditionItem.Nft,
                "tip" => GetTracksByUserGateConditionItem.Tip,
                "token" => GetTracksByUserGateConditionItem.Token,
                "ungated" => GetTracksByUserGateConditionItem.Ungated,
                "usdc_purchase" => GetTracksByUserGateConditionItem.UsdcPurchase,
                _ => null,
            };
        }
    }
}