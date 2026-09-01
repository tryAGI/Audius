
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: top
    /// </summary>
    public enum GetTrackCommentsSortMethod
    {
        /// <summary>
        ///
        /// </summary>
        Newest,
        /// <summary>
        ///
        /// </summary>
        Timestamp,
        /// <summary>
        ///
        /// </summary>
        Top,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTrackCommentsSortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrackCommentsSortMethod value)
        {
            return value switch
            {
                GetTrackCommentsSortMethod.Newest => "newest",
                GetTrackCommentsSortMethod.Timestamp => "timestamp",
                GetTrackCommentsSortMethod.Top => "top",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrackCommentsSortMethod? ToEnum(string value)
        {
            return value switch
            {
                "newest" => GetTrackCommentsSortMethod.Newest,
                "timestamp" => GetTrackCommentsSortMethod.Timestamp,
                "top" => GetTrackCommentsSortMethod.Top,
                _ => null,
            };
        }
    }
}