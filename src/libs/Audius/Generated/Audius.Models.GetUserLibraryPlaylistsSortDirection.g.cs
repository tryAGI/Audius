
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetUserLibraryPlaylistsSortDirection
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
    public static class GetUserLibraryPlaylistsSortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUserLibraryPlaylistsSortDirection value)
        {
            return value switch
            {
                GetUserLibraryPlaylistsSortDirection.Asc => "asc",
                GetUserLibraryPlaylistsSortDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUserLibraryPlaylistsSortDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetUserLibraryPlaylistsSortDirection.Asc,
                "desc" => GetUserLibraryPlaylistsSortDirection.Desc,
                _ => null,
            };
        }
    }
}