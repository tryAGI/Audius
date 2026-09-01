
#nullable enable

namespace Audius
{
    /// <summary>
    /// Example: Track
    /// </summary>
    public enum CommentReactionNotificationActionDataType
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
    public static class CommentReactionNotificationActionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CommentReactionNotificationActionDataType value)
        {
            return value switch
            {
                CommentReactionNotificationActionDataType.Album => "Album",
                CommentReactionNotificationActionDataType.Playlist => "Playlist",
                CommentReactionNotificationActionDataType.Track => "Track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CommentReactionNotificationActionDataType? ToEnum(string value)
        {
            return value switch
            {
                "Album" => CommentReactionNotificationActionDataType.Album,
                "Playlist" => CommentReactionNotificationActionDataType.Playlist,
                "Track" => CommentReactionNotificationActionDataType.Track,
                _ => null,
            };
        }
    }
}