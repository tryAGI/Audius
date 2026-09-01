
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchTagsSortMethod
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
    public static class SearchTagsSortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchTagsSortMethod value)
        {
            return value switch
            {
                SearchTagsSortMethod.Popular => "popular",
                SearchTagsSortMethod.Recent => "recent",
                SearchTagsSortMethod.Relevant => "relevant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchTagsSortMethod? ToEnum(string value)
        {
            return value switch
            {
                "popular" => SearchTagsSortMethod.Popular,
                "recent" => SearchTagsSortMethod.Recent,
                "relevant" => SearchTagsSortMethod.Relevant,
                _ => null,
            };
        }
    }
}