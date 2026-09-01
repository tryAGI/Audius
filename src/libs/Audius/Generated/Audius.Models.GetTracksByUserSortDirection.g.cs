
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTracksByUserSortDirection
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
    public static class GetTracksByUserSortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTracksByUserSortDirection value)
        {
            return value switch
            {
                GetTracksByUserSortDirection.Asc => "asc",
                GetTracksByUserSortDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTracksByUserSortDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetTracksByUserSortDirection.Asc,
                "desc" => GetTracksByUserSortDirection.Desc,
                _ => null,
            };
        }
    }
}