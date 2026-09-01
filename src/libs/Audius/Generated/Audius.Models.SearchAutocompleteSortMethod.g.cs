
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchAutocompleteSortMethod
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
    public static class SearchAutocompleteSortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchAutocompleteSortMethod value)
        {
            return value switch
            {
                SearchAutocompleteSortMethod.Popular => "popular",
                SearchAutocompleteSortMethod.Recent => "recent",
                SearchAutocompleteSortMethod.Relevant => "relevant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchAutocompleteSortMethod? ToEnum(string value)
        {
            return value switch
            {
                "popular" => SearchAutocompleteSortMethod.Popular,
                "recent" => SearchAutocompleteSortMethod.Recent,
                "relevant" => SearchAutocompleteSortMethod.Relevant,
                _ => null,
            };
        }
    }
}