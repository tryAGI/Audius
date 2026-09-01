
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetBulkEventsEventType
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
    public static class GetBulkEventsEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBulkEventsEventType value)
        {
            return value switch
            {
                GetBulkEventsEventType.LiveEvent => "live_event",
                GetBulkEventsEventType.NewRelease => "new_release",
                GetBulkEventsEventType.RemixContest => "remix_contest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBulkEventsEventType? ToEnum(string value)
        {
            return value switch
            {
                "live_event" => GetBulkEventsEventType.LiveEvent,
                "new_release" => GetBulkEventsEventType.NewRelease,
                "remix_contest" => GetBulkEventsEventType.RemixContest,
                _ => null,
            };
        }
    }
}