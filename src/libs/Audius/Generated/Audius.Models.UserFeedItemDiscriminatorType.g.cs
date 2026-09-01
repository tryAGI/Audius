
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum UserFeedItemDiscriminatorType
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
    public static class UserFeedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserFeedItemDiscriminatorType value)
        {
            return value switch
            {
                UserFeedItemDiscriminatorType.Playlist => "playlist",
                UserFeedItemDiscriminatorType.Track => "track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserFeedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "playlist" => UserFeedItemDiscriminatorType.Playlist,
                "track" => UserFeedItemDiscriminatorType.Track,
                _ => null,
            };
        }
    }
}