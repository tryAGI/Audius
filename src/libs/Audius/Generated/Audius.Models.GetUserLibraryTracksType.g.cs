
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: favorite
    /// </summary>
    public enum GetUserLibraryTracksType
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
    public static class GetUserLibraryTracksTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUserLibraryTracksType value)
        {
            return value switch
            {
                GetUserLibraryTracksType.All => "all",
                GetUserLibraryTracksType.Favorite => "favorite",
                GetUserLibraryTracksType.Purchase => "purchase",
                GetUserLibraryTracksType.Repost => "repost",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUserLibraryTracksType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetUserLibraryTracksType.All,
                "favorite" => GetUserLibraryTracksType.Favorite,
                "purchase" => GetUserLibraryTracksType.Purchase,
                "repost" => GetUserLibraryTracksType.Repost,
                _ => null,
            };
        }
    }
}