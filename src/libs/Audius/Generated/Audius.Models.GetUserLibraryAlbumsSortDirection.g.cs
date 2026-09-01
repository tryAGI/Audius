
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetUserLibraryAlbumsSortDirection
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
    public static class GetUserLibraryAlbumsSortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUserLibraryAlbumsSortDirection value)
        {
            return value switch
            {
                GetUserLibraryAlbumsSortDirection.Asc => "asc",
                GetUserLibraryAlbumsSortDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUserLibraryAlbumsSortDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetUserLibraryAlbumsSortDirection.Asc,
                "desc" => GetUserLibraryAlbumsSortDirection.Desc,
                _ => null,
            };
        }
    }
}