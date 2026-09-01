
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum GetCoinMembersSortDirection
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
    public static class GetCoinMembersSortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCoinMembersSortDirection value)
        {
            return value switch
            {
                GetCoinMembersSortDirection.Asc => "asc",
                GetCoinMembersSortDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCoinMembersSortDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetCoinMembersSortDirection.Asc,
                "desc" => GetCoinMembersSortDirection.Desc,
                _ => null,
            };
        }
    }
}