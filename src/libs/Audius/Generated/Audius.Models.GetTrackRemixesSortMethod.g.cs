
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: recent
    /// </summary>
    public enum GetTrackRemixesSortMethod
    {
        /// <summary>
        ///
        /// </summary>
        Likes,
        /// <summary>
        ///
        /// </summary>
        Plays,
        /// <summary>
        ///
        /// </summary>
        Recent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTrackRemixesSortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrackRemixesSortMethod value)
        {
            return value switch
            {
                GetTrackRemixesSortMethod.Likes => "likes",
                GetTrackRemixesSortMethod.Plays => "plays",
                GetTrackRemixesSortMethod.Recent => "recent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrackRemixesSortMethod? ToEnum(string value)
        {
            return value switch
            {
                "likes" => GetTrackRemixesSortMethod.Likes,
                "plays" => GetTrackRemixesSortMethod.Plays,
                "recent" => GetTrackRemixesSortMethod.Recent,
                _ => null,
            };
        }
    }
}