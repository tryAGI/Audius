
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: playlist
    /// </summary>
    public enum GetTrendingPlaylistsType
    {
        /// <summary>
        ///
        /// </summary>
        Album,
        /// <summary>
        ///
        /// </summary>
        Playlist,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTrendingPlaylistsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingPlaylistsType value)
        {
            return value switch
            {
                GetTrendingPlaylistsType.Album => "album",
                GetTrendingPlaylistsType.Playlist => "playlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingPlaylistsType? ToEnum(string value)
        {
            return value switch
            {
                "album" => GetTrendingPlaylistsType.Album,
                "playlist" => GetTrendingPlaylistsType.Playlist,
                _ => null,
            };
        }
    }
}