
#nullable enable

namespace Audius
{
    /// <summary>
    /// Example: track
    /// </summary>
    public enum SaveOfRepostNotificationActionDataType
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
    public static class SaveOfRepostNotificationActionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SaveOfRepostNotificationActionDataType value)
        {
            return value switch
            {
                SaveOfRepostNotificationActionDataType.Album => "album",
                SaveOfRepostNotificationActionDataType.Playlist => "playlist",
                SaveOfRepostNotificationActionDataType.Track => "track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SaveOfRepostNotificationActionDataType? ToEnum(string value)
        {
            return value switch
            {
                "album" => SaveOfRepostNotificationActionDataType.Album,
                "playlist" => SaveOfRepostNotificationActionDataType.Playlist,
                "track" => SaveOfRepostNotificationActionDataType.Track,
                _ => null,
            };
        }
    }
}