
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum SearchKind
    {
        /// <summary>
        /// all, users, tracks, playlists, or albums
        /// </summary>
        Albums,
        /// <summary>
        /// all, users, tracks, playlists, or albums
        /// </summary>
        All,
        /// <summary>
        /// all, users, tracks, playlists, or albums
        /// </summary>
        Playlists,
        /// <summary>
        /// all, users, tracks, playlists, or albums
        /// </summary>
        Tracks,
        /// <summary>
        /// all, users, tracks, playlists, or albums
        /// </summary>
        Users,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchKind value)
        {
            return value switch
            {
                SearchKind.Albums => "albums",
                SearchKind.All => "all",
                SearchKind.Playlists => "playlists",
                SearchKind.Tracks => "tracks",
                SearchKind.Users => "users",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchKind? ToEnum(string value)
        {
            return value switch
            {
                "albums" => SearchKind.Albums,
                "all" => SearchKind.All,
                "playlists" => SearchKind.Playlists,
                "tracks" => SearchKind.Tracks,
                "users" => SearchKind.Users,
                _ => null,
            };
        }
    }
}