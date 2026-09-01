
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum PlaylistLibraryFolderType
    {
        /// <summary>
        ///
        /// </summary>
        Folder,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlaylistLibraryFolderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaylistLibraryFolderType value)
        {
            return value switch
            {
                PlaylistLibraryFolderType.Folder => "folder",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaylistLibraryFolderType? ToEnum(string value)
        {
            return value switch
            {
                "folder" => PlaylistLibraryFolderType.Folder,
                _ => null,
            };
        }
    }
}