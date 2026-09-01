
#nullable enable

namespace Audius
{
    /// <summary>
    /// Example: Track
    /// </summary>
    public enum CommentMentionNotificationActionDataType
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
    public static class CommentMentionNotificationActionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CommentMentionNotificationActionDataType value)
        {
            return value switch
            {
                CommentMentionNotificationActionDataType.Album => "Album",
                CommentMentionNotificationActionDataType.Playlist => "Playlist",
                CommentMentionNotificationActionDataType.Track => "Track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CommentMentionNotificationActionDataType? ToEnum(string value)
        {
            return value switch
            {
                "Album" => CommentMentionNotificationActionDataType.Album,
                "Playlist" => CommentMentionNotificationActionDataType.Playlist,
                "Track" => CommentMentionNotificationActionDataType.Track,
                _ => null,
            };
        }
    }
}