
#nullable enable

namespace Audius
{
    /// <summary>
    /// Example: track
    /// </summary>
    public enum BestSellingItemContentType
    {
        /// <summary>
        ///
        /// </summary>
        Album,
        /// <summary>
        ///
        /// </summary>
        Track,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BestSellingItemContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BestSellingItemContentType value)
        {
            return value switch
            {
                BestSellingItemContentType.Album => "album",
                BestSellingItemContentType.Track => "track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BestSellingItemContentType? ToEnum(string value)
        {
            return value switch
            {
                "album" => BestSellingItemContentType.Album,
                "track" => BestSellingItemContentType.Track,
                _ => null,
            };
        }
    }
}