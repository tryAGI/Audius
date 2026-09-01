
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: date
    /// </summary>
    public enum GetAudioTransactionHistorySortMethod
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
    public static class GetAudioTransactionHistorySortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAudioTransactionHistorySortMethod value)
        {
            return value switch
            {
                GetAudioTransactionHistorySortMethod.Date => "date",
                GetAudioTransactionHistorySortMethod.TransactionType => "transaction_type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAudioTransactionHistorySortMethod? ToEnum(string value)
        {
            return value switch
            {
                "date" => GetAudioTransactionHistorySortMethod.Date,
                "transaction_type" => GetAudioTransactionHistorySortMethod.TransactionType,
                _ => null,
            };
        }
    }
}