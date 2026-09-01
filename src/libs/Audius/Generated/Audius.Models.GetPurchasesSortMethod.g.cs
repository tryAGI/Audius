
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetPurchasesSortMethod
    {
        /// <summary>
        ///
        /// </summary>
        ArtistName,
        /// <summary>
        ///
        /// </summary>
        BuyerName,
        /// <summary>
        ///
        /// </summary>
        ContentTitle,
        /// <summary>
        ///
        /// </summary>
        Date,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPurchasesSortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPurchasesSortMethod value)
        {
            return value switch
            {
                GetPurchasesSortMethod.ArtistName => "artist_name",
                GetPurchasesSortMethod.BuyerName => "buyer_name",
                GetPurchasesSortMethod.ContentTitle => "content_title",
                GetPurchasesSortMethod.Date => "date",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPurchasesSortMethod? ToEnum(string value)
        {
            return value switch
            {
                "artist_name" => GetPurchasesSortMethod.ArtistName,
                "buyer_name" => GetPurchasesSortMethod.BuyerName,
                "content_title" => GetPurchasesSortMethod.ContentTitle,
                "date" => GetPurchasesSortMethod.Date,
                _ => null,
            };
        }
    }
}