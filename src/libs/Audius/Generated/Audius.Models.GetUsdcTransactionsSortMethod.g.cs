
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: date
    /// </summary>
    public enum GetUsdcTransactionsSortMethod
    {
        /// <summary>
        ///
        /// </summary>
        Date,
        /// <summary>
        ///
        /// </summary>
        TransactionType,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUsdcTransactionsSortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsdcTransactionsSortMethod value)
        {
            return value switch
            {
                GetUsdcTransactionsSortMethod.Date => "date",
                GetUsdcTransactionsSortMethod.TransactionType => "transaction_type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsdcTransactionsSortMethod? ToEnum(string value)
        {
            return value switch
            {
                "date" => GetUsdcTransactionsSortMethod.Date,
                "transaction_type" => GetUsdcTransactionsSortMethod.TransactionType,
                _ => null,
            };
        }
    }
}