
#nullable enable

namespace Audius
{
    /// <summary>
    /// Type of entity that can be commented on
    /// </summary>
    public enum CommentEntityType
    {
        /// <summary>
        ///
        /// </summary>
        Event,
        /// <summary>
        ///
        /// </summary>
        FanClub,
        /// <summary>
        ///
        /// </summary>
        Track,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CommentEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CommentEntityType value)
        {
            return value switch
            {
                CommentEntityType.Event => "Event",
                CommentEntityType.FanClub => "FanClub",
                CommentEntityType.Track => "Track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CommentEntityType? ToEnum(string value)
        {
            return value switch
            {
                "Event" => CommentEntityType.Event,
                "FanClub" => CommentEntityType.FanClub,
                "Track" => CommentEntityType.Track,
                _ => null,
            };
        }
    }
}