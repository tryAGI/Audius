
#nullable enable

namespace Audius
{
    /// <summary>
    /// Example: Track
    /// </summary>
    public enum CommentThreadNotificationActionDataType
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
    public static class CommentThreadNotificationActionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CommentThreadNotificationActionDataType value)
        {
            return value switch
            {
                CommentThreadNotificationActionDataType.Album => "Album",
                CommentThreadNotificationActionDataType.Playlist => "Playlist",
                CommentThreadNotificationActionDataType.Track => "Track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CommentThreadNotificationActionDataType? ToEnum(string value)
        {
            return value switch
            {
                "Album" => CommentThreadNotificationActionDataType.Album,
                "Playlist" => CommentThreadNotificationActionDataType.Playlist,
                "Track" => CommentThreadNotificationActionDataType.Track,
                _ => null,
            };
        }
    }
}