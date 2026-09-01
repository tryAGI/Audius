
#nullable enable

namespace Audius
{
    /// <summary>
    /// Example: track
    /// </summary>
    public enum RepostOfRepostNotificationActionDataType
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
    public static class RepostOfRepostNotificationActionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepostOfRepostNotificationActionDataType value)
        {
            return value switch
            {
                RepostOfRepostNotificationActionDataType.Album => "album",
                RepostOfRepostNotificationActionDataType.Playlist => "playlist",
                RepostOfRepostNotificationActionDataType.Track => "track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepostOfRepostNotificationActionDataType? ToEnum(string value)
        {
            return value switch
            {
                "album" => RepostOfRepostNotificationActionDataType.Album,
                "playlist" => RepostOfRepostNotificationActionDataType.Playlist,
                "track" => RepostOfRepostNotificationActionDataType.Track,
                _ => null,
            };
        }
    }
}