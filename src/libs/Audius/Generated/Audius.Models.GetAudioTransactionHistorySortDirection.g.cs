
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum GetAudioTransactionHistorySortDirection
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAudioTransactionHistorySortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAudioTransactionHistorySortDirection value)
        {
            return value switch
            {
                GetAudioTransactionHistorySortDirection.Asc => "asc",
                GetAudioTransactionHistorySortDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAudioTransactionHistorySortDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetAudioTransactionHistorySortDirection.Asc,
                "desc" => GetAudioTransactionHistorySortDirection.Desc,
                _ => null,
            };
        }
    }
}