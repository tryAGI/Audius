
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum GetBestSellingType
    {
        /// <summary>
        ///
        /// </summary>
        Album,
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Track,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetBestSellingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBestSellingType value)
        {
            return value switch
            {
                GetBestSellingType.Album => "album",
                GetBestSellingType.All => "all",
                GetBestSellingType.Track => "track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBestSellingType? ToEnum(string value)
        {
            return value switch
            {
                "album" => GetBestSellingType.Album,
                "all" => GetBestSellingType.All,
                "track" => GetBestSellingType.Track,
                _ => null,
            };
        }
    }
}