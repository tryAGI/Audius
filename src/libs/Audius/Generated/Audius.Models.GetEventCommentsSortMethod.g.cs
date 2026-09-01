
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: newest
    /// </summary>
    public enum GetEventCommentsSortMethod
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
    public static class GetEventCommentsSortMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEventCommentsSortMethod value)
        {
            return value switch
            {
                GetEventCommentsSortMethod.Newest => "newest",
                GetEventCommentsSortMethod.Timestamp => "timestamp",
                GetEventCommentsSortMethod.Top => "top",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEventCommentsSortMethod? ToEnum(string value)
        {
            return value switch
            {
                "newest" => GetEventCommentsSortMethod.Newest,
                "timestamp" => GetEventCommentsSortMethod.Timestamp,
                "top" => GetEventCommentsSortMethod.Top,
                _ => null,
            };
        }
    }
}