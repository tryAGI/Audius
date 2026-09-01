
#nullable enable

namespace Audius
{
    /// <summary>
    /// Example: Track
    /// </summary>
    public enum CommentNotificationActionDataType
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
    public static class CommentNotificationActionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CommentNotificationActionDataType value)
        {
            return value switch
            {
                CommentNotificationActionDataType.Album => "Album",
                CommentNotificationActionDataType.Playlist => "Playlist",
                CommentNotificationActionDataType.Track => "Track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CommentNotificationActionDataType? ToEnum(string value)
        {
            return value switch
            {
                "Album" => CommentNotificationActionDataType.Album,
                "Playlist" => CommentNotificationActionDataType.Playlist,
                "Track" => CommentNotificationActionDataType.Track,
                _ => null,
            };
        }
    }
}