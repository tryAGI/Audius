
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetEntityEventsEntityType
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
    public static class GetEntityEventsEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEntityEventsEntityType value)
        {
            return value switch
            {
                GetEntityEventsEntityType.Collection => "collection",
                GetEntityEventsEntityType.Track => "track",
                GetEntityEventsEntityType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEntityEventsEntityType? ToEnum(string value)
        {
            return value switch
            {
                "collection" => GetEntityEventsEntityType.Collection,
                "track" => GetEntityEventsEntityType.Track,
                "user" => GetEntityEventsEntityType.User,
                _ => null,
            };
        }
    }
}