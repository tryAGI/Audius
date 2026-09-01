
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetUserFavoriteTracksSortDirection
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
    public static class GetUserFavoriteTracksSortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUserFavoriteTracksSortDirection value)
        {
            return value switch
            {
                GetUserFavoriteTracksSortDirection.Asc => "asc",
                GetUserFavoriteTracksSortDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUserFavoriteTracksSortDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetUserFavoriteTracksSortDirection.Asc,
                "desc" => GetUserFavoriteTracksSortDirection.Desc,
                _ => null,
            };
        }
    }
}