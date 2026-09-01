
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSalesSortDirection
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
    public static class GetSalesSortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSalesSortDirection value)
        {
            return value switch
            {
                GetSalesSortDirection.Asc => "asc",
                GetSalesSortDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSalesSortDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetSalesSortDirection.Asc,
                "desc" => GetSalesSortDirection.Desc,
                _ => null,
            };
        }
    }
}