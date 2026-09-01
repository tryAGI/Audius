
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: favorite
    /// </summary>
    public enum GetUserLibraryPlaylistsType
    {
        /// <summary>
        /// favorited, reposted, purchased, or all. Defaults to favorite
        /// </summary>
        All,
        /// <summary>
        /// favorited, reposted, purchased, or all. Defaults to favorite
        /// </summary>
        Favorite,
        /// <summary>
        /// favorited, reposted, purchased, or all. Defaults to favorite
        /// </summary>
        Purchase,
        /// <summary>
        /// favorited, reposted, purchased, or all. Defaults to favorite
        /// </summary>
        Repost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUserLibraryPlaylistsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUserLibraryPlaylistsType value)
        {
            return value switch
            {
                GetUserLibraryPlaylistsType.All => "all",
                GetUserLibraryPlaylistsType.Favorite => "favorite",
                GetUserLibraryPlaylistsType.Purchase => "purchase",
                GetUserLibraryPlaylistsType.Repost => "repost",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUserLibraryPlaylistsType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetUserLibraryPlaylistsType.All,
                "favorite" => GetUserLibraryPlaylistsType.Favorite,
                "purchase" => GetUserLibraryPlaylistsType.Purchase,
                "repost" => GetUserLibraryPlaylistsType.Repost,
                _ => null,
            };
        }
    }
}