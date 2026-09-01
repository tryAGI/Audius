
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetUserLibraryAlbumsSortMethod
    {
        /// <summary>
        ///
        /// </summary>
        AddedDate,
        /// <summary>
        ///
        /// </summary>
        Reposts,
        /// <summary>
        ///
        /// </summary>
        Saves,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUserLibraryAlbumsSortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUserLibraryAlbumsSortMethod value)
        {
            return value switch
            {
                GetUserLibraryAlbumsSortMethod.AddedDate => "added_date",
                GetUserLibraryAlbumsSortMethod.Reposts => "reposts",
                GetUserLibraryAlbumsSortMethod.Saves => "saves",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUserLibraryAlbumsSortMethod? ToEnum(string value)
        {
            return value switch
            {
                "added_date" => GetUserLibraryAlbumsSortMethod.AddedDate,
                "reposts" => GetUserLibraryAlbumsSortMethod.Reposts,
                "saves" => GetUserLibraryAlbumsSortMethod.Saves,
                _ => null,
            };
        }
    }
}