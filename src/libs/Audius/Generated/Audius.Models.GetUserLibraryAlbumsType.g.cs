
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: favorite
    /// </summary>
    public enum GetUserLibraryAlbumsType
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
    public static class GetUserLibraryAlbumsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUserLibraryAlbumsType value)
        {
            return value switch
            {
                GetUserLibraryAlbumsType.All => "all",
                GetUserLibraryAlbumsType.Favorite => "favorite",
                GetUserLibraryAlbumsType.Purchase => "purchase",
                GetUserLibraryAlbumsType.Repost => "repost",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUserLibraryAlbumsType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetUserLibraryAlbumsType.All,
                "favorite" => GetUserLibraryAlbumsType.Favorite,
                "purchase" => GetUserLibraryAlbumsType.Purchase,
                "repost" => GetUserLibraryAlbumsType.Repost,
                _ => null,
            };
        }
    }
}