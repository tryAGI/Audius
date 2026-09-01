
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchUsersSortMethod
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
    public static class SearchUsersSortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchUsersSortMethod value)
        {
            return value switch
            {
                SearchUsersSortMethod.Popular => "popular",
                SearchUsersSortMethod.Recent => "recent",
                SearchUsersSortMethod.Relevant => "relevant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchUsersSortMethod? ToEnum(string value)
        {
            return value switch
            {
                "popular" => SearchUsersSortMethod.Popular,
                "recent" => SearchUsersSortMethod.Recent,
                "relevant" => SearchUsersSortMethod.Relevant,
                _ => null,
            };
        }
    }
}