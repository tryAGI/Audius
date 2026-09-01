
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetAllEventsEventType
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
    public static class GetAllEventsEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllEventsEventType value)
        {
            return value switch
            {
                GetAllEventsEventType.LiveEvent => "live_event",
                GetAllEventsEventType.NewRelease => "new_release",
                GetAllEventsEventType.RemixContest => "remix_contest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllEventsEventType? ToEnum(string value)
        {
            return value switch
            {
                "live_event" => GetAllEventsEventType.LiveEvent,
                "new_release" => GetAllEventsEventType.NewRelease,
                "remix_contest" => GetAllEventsEventType.RemixContest,
                _ => null,
            };
        }
    }
}