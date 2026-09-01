
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSalesSortMethod
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
    public static class GetSalesSortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSalesSortMethod value)
        {
            return value switch
            {
                GetSalesSortMethod.ArtistName => "artist_name",
                GetSalesSortMethod.BuyerName => "buyer_name",
                GetSalesSortMethod.ContentTitle => "content_title",
                GetSalesSortMethod.Date => "date",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSalesSortMethod? ToEnum(string value)
        {
            return value switch
            {
                "artist_name" => GetSalesSortMethod.ArtistName,
                "buyer_name" => GetSalesSortMethod.BuyerName,
                "content_title" => GetSalesSortMethod.ContentTitle,
                "date" => GetSalesSortMethod.Date,
                _ => null,
            };
        }
    }
}