
#nullable enable

namespace Audius
{
    /// <summary>
    /// Example: playlist
    /// </summary>
    public enum CollectionActivityWithoutTracksVariant2ItemType
    {
        /// <summary>
        ///
        /// </summary>
        Playlist,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CollectionActivityWithoutTracksVariant2ItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CollectionActivityWithoutTracksVariant2ItemType value)
        {
            return value switch
            {
                CollectionActivityWithoutTracksVariant2ItemType.Playlist => "playlist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CollectionActivityWithoutTracksVariant2ItemType? ToEnum(string value)
        {
            return value switch
            {
                "playlist" => CollectionActivityWithoutTracksVariant2ItemType.Playlist,
                _ => null,
            };
        }
    }
}