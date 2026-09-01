
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: playlist
    /// </summary>
    public enum GetPlaylistsNewReleasesType
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
    public static class GetPlaylistsNewReleasesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPlaylistsNewReleasesType value)
        {
            return value switch
            {
                GetPlaylistsNewReleasesType.Album => "album",
                GetPlaylistsNewReleasesType.Playlist => "playlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPlaylistsNewReleasesType? ToEnum(string value)
        {
            return value switch
            {
                "album" => GetPlaylistsNewReleasesType.Album,
                "playlist" => GetPlaylistsNewReleasesType.Playlist,
                _ => null,
            };
        }
    }
}