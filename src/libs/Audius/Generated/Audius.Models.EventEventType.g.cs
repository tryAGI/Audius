
#nullable enable

namespace Audius
{
    /// <summary>
    /// Example: remix_contest
    /// </summary>
    public enum EventEventType
    {
        /// <summary>
        ///
        /// </summary>
        LiveEvent,
        /// <summary>
        ///
        /// </summary>
        NewRelease,
        /// <summary>
        ///
        /// </summary>
        RemixContest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EventEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventEventType value)
        {
            return value switch
            {
                EventEventType.LiveEvent => "live_event",
                EventEventType.NewRelease => "new_release",
                EventEventType.RemixContest => "remix_contest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventEventType? ToEnum(string value)
        {
            return value switch
            {
                "live_event" => EventEventType.LiveEvent,
                "new_release" => EventEventType.NewRelease,
                "remix_contest" => EventEventType.RemixContest,
                _ => null,
            };
        }
    }
}