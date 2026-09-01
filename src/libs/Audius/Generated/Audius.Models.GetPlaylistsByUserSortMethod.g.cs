
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: recent
    /// </summary>
    public enum GetPlaylistsByUserSortMethod
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
    public static class GetPlaylistsByUserSortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPlaylistsByUserSortMethod value)
        {
            return value switch
            {
                GetPlaylistsByUserSortMethod.Popular => "popular",
                GetPlaylistsByUserSortMethod.Recent => "recent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPlaylistsByUserSortMethod? ToEnum(string value)
        {
            return value switch
            {
                "popular" => GetPlaylistsByUserSortMethod.Popular,
                "recent" => GetPlaylistsByUserSortMethod.Recent,
                _ => null,
            };
        }
    }
}