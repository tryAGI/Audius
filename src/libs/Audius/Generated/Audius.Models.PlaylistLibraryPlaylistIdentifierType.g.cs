
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum PlaylistLibraryPlaylistIdentifierType
    {
        /// <summary>
        ///
        /// </summary>
        Playlist,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlaylistLibraryPlaylistIdentifierTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaylistLibraryPlaylistIdentifierType value)
        {
            return value switch
            {
                PlaylistLibraryPlaylistIdentifierType.Playlist => "playlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaylistLibraryPlaylistIdentifierType? ToEnum(string value)
        {
            return value switch
            {
                "playlist" => PlaylistLibraryPlaylistIdentifierType.Playlist,
                _ => null,
            };
        }
    }
}