
#nullable enable

namespace Audius
{
    /// <summary>
    /// Example: track
    /// </summary>
    public enum SaveNotificationActionDataType
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
    public static class SaveNotificationActionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SaveNotificationActionDataType value)
        {
            return value switch
            {
                SaveNotificationActionDataType.Album => "album",
                SaveNotificationActionDataType.Playlist => "playlist",
                SaveNotificationActionDataType.Track => "track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SaveNotificationActionDataType? ToEnum(string value)
        {
            return value switch
            {
                "album" => SaveNotificationActionDataType.Album,
                "playlist" => SaveNotificationActionDataType.Playlist,
                "track" => SaveNotificationActionDataType.Track,
                _ => null,
            };
        }
    }
}