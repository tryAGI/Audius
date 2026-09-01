
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum PlaylistLibraryExplorePlaylistIdentifierType
    {
        /// <summary>
        ///
        /// </summary>
        ExplorePlaylist,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlaylistLibraryExplorePlaylistIdentifierTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaylistLibraryExplorePlaylistIdentifierType value)
        {
            return value switch
            {
                PlaylistLibraryExplorePlaylistIdentifierType.ExplorePlaylist => "explore_playlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaylistLibraryExplorePlaylistIdentifierType? ToEnum(string value)
        {
            return value switch
            {
                "explore_playlist" => PlaylistLibraryExplorePlaylistIdentifierType.ExplorePlaylist,
                _ => null,
            };
        }
    }
}