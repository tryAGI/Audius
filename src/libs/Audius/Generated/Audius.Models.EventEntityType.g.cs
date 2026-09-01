
#nullable enable

namespace Audius
{
    /// <summary>
    /// Example: track
    /// </summary>
    public enum EventEntityType
    {
        /// <summary>
        ///
        /// </summary>
        Collection,
        /// <summary>
        ///
        /// </summary>
        Track,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EventEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventEntityType value)
        {
            return value switch
            {
                EventEntityType.Collection => "collection",
                EventEntityType.Track => "track",
                EventEntityType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventEntityType? ToEnum(string value)
        {
            return value switch
            {
                "collection" => EventEntityType.Collection,
                "track" => EventEntityType.Track,
                "user" => EventEntityType.User,
                _ => null,
            };
        }
    }
}