
#nullable enable

namespace Audius
{
    /// <summary>
    /// Example: track
    /// </summary>
    public enum TrackActivityVariant2ItemType
    {
        /// <summary>
        ///
        /// </summary>
        Track,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrackActivityVariant2ItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrackActivityVariant2ItemType value)
        {
            return value switch
            {
                TrackActivityVariant2ItemType.Track => "track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrackActivityVariant2ItemType? ToEnum(string value)
        {
            return value switch
            {
                "track" => TrackActivityVariant2ItemType.Track,
                _ => null,
            };
        }
    }
}