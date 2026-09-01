
#nullable enable

namespace Audius
{
    /// <summary>
    /// Example: track
    /// </summary>
    public enum RepostNotificationActionDataType
    {
        /// <summary>
        ///
        /// </summary>
        Album,
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
    public static class RepostNotificationActionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepostNotificationActionDataType value)
        {
            return value switch
            {
                RepostNotificationActionDataType.Album => "album",
                RepostNotificationActionDataType.Playlist => "playlist",
                RepostNotificationActionDataType.Track => "track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepostNotificationActionDataType? ToEnum(string value)
        {
            return value switch
            {
                "album" => RepostNotificationActionDataType.Album,
                "playlist" => RepostNotificationActionDataType.Playlist,
                "track" => RepostNotificationActionDataType.Track,
                _ => null,
            };
        }
    }
}