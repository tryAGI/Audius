
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetUserTrackHistorySortDirection
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
    public static class GetUserTrackHistorySortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUserTrackHistorySortDirection value)
        {
            return value switch
            {
                GetUserTrackHistorySortDirection.Asc => "asc",
                GetUserTrackHistorySortDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUserTrackHistorySortDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetUserTrackHistorySortDirection.Asc,
                "desc" => GetUserTrackHistorySortDirection.Desc,
                _ => null,
            };
        }
    }
}