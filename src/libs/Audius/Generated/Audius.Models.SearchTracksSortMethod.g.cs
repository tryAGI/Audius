
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchTracksSortMethod
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
    public static class SearchTracksSortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchTracksSortMethod value)
        {
            return value switch
            {
                SearchTracksSortMethod.Popular => "popular",
                SearchTracksSortMethod.Recent => "recent",
                SearchTracksSortMethod.Relevant => "relevant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchTracksSortMethod? ToEnum(string value)
        {
            return value switch
            {
                "popular" => SearchTracksSortMethod.Popular,
                "recent" => SearchTracksSortMethod.Recent,
                "relevant" => SearchTracksSortMethod.Relevant,
                _ => null,
            };
        }
    }
}