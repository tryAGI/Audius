
#nullable enable

namespace Audius
{
    /// <summary>
    /// Example: track
    /// </summary>
    public enum ActivityItemType
    {
        /// <summary>
        ///
        /// </summary>
        Playlist,
        /// <summary>
        ///
        /// </summary>
        Track,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActivityItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActivityItemType value)
        {
            return value switch
            {
                ActivityItemType.Playlist => "playlist",
                ActivityItemType.Track => "track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActivityItemType? ToEnum(string value)
        {
            return value switch
            {
                "playlist" => ActivityItemType.Playlist,
                "track" => ActivityItemType.Track,
                _ => null,
            };
        }
    }
}