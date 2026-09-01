
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum SearchAutocompleteKind
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
    public static class SearchAutocompleteKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchAutocompleteKind value)
        {
            return value switch
            {
                SearchAutocompleteKind.Albums => "albums",
                SearchAutocompleteKind.All => "all",
                SearchAutocompleteKind.Playlists => "playlists",
                SearchAutocompleteKind.Tracks => "tracks",
                SearchAutocompleteKind.Users => "users",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchAutocompleteKind? ToEnum(string value)
        {
            return value switch
            {
                "albums" => SearchAutocompleteKind.Albums,
                "all" => SearchAutocompleteKind.All,
                "playlists" => SearchAutocompleteKind.Playlists,
                "tracks" => SearchAutocompleteKind.Tracks,
                "users" => SearchAutocompleteKind.Users,
                _ => null,
            };
        }
    }
}