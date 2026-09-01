
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: date
    /// </summary>
    public enum GetAudioTransactionsSortMethod
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
    public static class GetAudioTransactionsSortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAudioTransactionsSortMethod value)
        {
            return value switch
            {
                GetAudioTransactionsSortMethod.Date => "date",
                GetAudioTransactionsSortMethod.TransactionType => "transaction_type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAudioTransactionsSortMethod? ToEnum(string value)
        {
            return value switch
            {
                "date" => GetAudioTransactionsSortMethod.Date,
                "transaction_type" => GetAudioTransactionsSortMethod.TransactionType,
                _ => null,
            };
        }
    }
}