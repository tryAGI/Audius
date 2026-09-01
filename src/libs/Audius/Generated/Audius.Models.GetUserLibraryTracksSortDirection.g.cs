
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetUserLibraryTracksSortDirection
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
    public static class GetUserLibraryTracksSortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUserLibraryTracksSortDirection value)
        {
            return value switch
            {
                GetUserLibraryTracksSortDirection.Asc => "asc",
                GetUserLibraryTracksSortDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUserLibraryTracksSortDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetUserLibraryTracksSortDirection.Asc,
                "desc" => GetUserLibraryTracksSortDirection.Desc,
                _ => null,
            };
        }
    }
}