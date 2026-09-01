
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: recent
    /// </summary>
    public enum GetAlbumsByUserSortMethod
    {
        /// <summary>
        ///
        /// </summary>
        Popular,
        /// <summary>
        ///
        /// </summary>
        Recent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAlbumsByUserSortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAlbumsByUserSortMethod value)
        {
            return value switch
            {
                GetAlbumsByUserSortMethod.Popular => "popular",
                GetAlbumsByUserSortMethod.Recent => "recent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAlbumsByUserSortMethod? ToEnum(string value)
        {
            return value switch
            {
                "popular" => GetAlbumsByUserSortMethod.Popular,
                "recent" => GetAlbumsByUserSortMethod.Recent,
                _ => null,
            };
        }
    }
}