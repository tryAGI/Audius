
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum SearchTagsKind
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
    public static class SearchTagsKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchTagsKind value)
        {
            return value switch
            {
                SearchTagsKind.Albums => "albums",
                SearchTagsKind.All => "all",
                SearchTagsKind.Playlists => "playlists",
                SearchTagsKind.Tracks => "tracks",
                SearchTagsKind.Users => "users",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchTagsKind? ToEnum(string value)
        {
            return value switch
            {
                "albums" => SearchTagsKind.Albums,
                "all" => SearchTagsKind.All,
                "playlists" => SearchTagsKind.Playlists,
                "tracks" => SearchTagsKind.Tracks,
                "users" => SearchTagsKind.Users,
                _ => null,
            };
        }
    }
}