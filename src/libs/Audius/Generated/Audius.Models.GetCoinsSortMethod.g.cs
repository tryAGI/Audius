
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: market_cap
    /// </summary>
    public enum GetCoinsSortMethod
    {
        /// <summary>
        ///
        /// </summary>
        CreatedAt,
        /// <summary>
        ///
        /// </summary>
        Holder,
        /// <summary>
        ///
        /// </summary>
        MarketCap,
        /// <summary>
        ///
        /// </summary>
        Price,
        /// <summary>
        ///
        /// </summary>
        Volume,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCoinsSortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCoinsSortMethod value)
        {
            return value switch
            {
                GetCoinsSortMethod.CreatedAt => "created_at",
                GetCoinsSortMethod.Holder => "holder",
                GetCoinsSortMethod.MarketCap => "market_cap",
                GetCoinsSortMethod.Price => "price",
                GetCoinsSortMethod.Volume => "volume",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCoinsSortMethod? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => GetCoinsSortMethod.CreatedAt,
                "holder" => GetCoinsSortMethod.Holder,
                "market_cap" => GetCoinsSortMethod.MarketCap,
                "price" => GetCoinsSortMethod.Price,
                "volume" => GetCoinsSortMethod.Volume,
                _ => null,
            };
        }
    }
}