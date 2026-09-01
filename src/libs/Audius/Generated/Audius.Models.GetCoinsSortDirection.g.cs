
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum GetCoinsSortDirection
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
    public static class GetCoinsSortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCoinsSortDirection value)
        {
            return value switch
            {
                GetCoinsSortDirection.Asc => "asc",
                GetCoinsSortDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCoinsSortDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetCoinsSortDirection.Asc,
                "desc" => GetCoinsSortDirection.Desc,
                _ => null,
            };
        }
    }
}