
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum GetAudioTransactionsSortDirection
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
    public static class GetAudioTransactionsSortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAudioTransactionsSortDirection value)
        {
            return value switch
            {
                GetAudioTransactionsSortDirection.Asc => "asc",
                GetAudioTransactionsSortDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAudioTransactionsSortDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetAudioTransactionsSortDirection.Asc,
                "desc" => GetAudioTransactionsSortDirection.Desc,
                _ => null,
            };
        }
    }
}