
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchSortMethod
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
    public static class SearchSortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchSortMethod value)
        {
            return value switch
            {
                SearchSortMethod.Popular => "popular",
                SearchSortMethod.Recent => "recent",
                SearchSortMethod.Relevant => "relevant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchSortMethod? ToEnum(string value)
        {
            return value switch
            {
                "popular" => SearchSortMethod.Popular,
                "recent" => SearchSortMethod.Recent,
                "relevant" => SearchSortMethod.Relevant,
                _ => null,
            };
        }
    }
}