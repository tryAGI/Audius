
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum GetUsdcTransactionsSortDirection
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
    public static class GetUsdcTransactionsSortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsdcTransactionsSortDirection value)
        {
            return value switch
            {
                GetUsdcTransactionsSortDirection.Asc => "asc",
                GetUsdcTransactionsSortDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsdcTransactionsSortDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetUsdcTransactionsSortDirection.Asc,
                "desc" => GetUsdcTransactionsSortDirection.Desc,
                _ => null,
            };
        }
    }
}