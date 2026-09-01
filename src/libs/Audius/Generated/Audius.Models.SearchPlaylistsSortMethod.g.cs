
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchPlaylistsSortMethod
    {
        /// <summary>
        ///
        /// </summary>
        Popular,
        /// <summary>
        ///
        /// </summary>
        Recent,
        /// <summary>
        ///
        /// </summary>
        Relevant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchPlaylistsSortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchPlaylistsSortMethod value)
        {
            return value switch
            {
                SearchPlaylistsSortMethod.Popular => "popular",
                SearchPlaylistsSortMethod.Recent => "recent",
                SearchPlaylistsSortMethod.Relevant => "relevant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchPlaylistsSortMethod? ToEnum(string value)
        {
            return value switch
            {
                "popular" => SearchPlaylistsSortMethod.Popular,
                "recent" => SearchPlaylistsSortMethod.Recent,
                "relevant" => SearchPlaylistsSortMethod.Relevant,
                _ => null,
            };
        }
    }
}