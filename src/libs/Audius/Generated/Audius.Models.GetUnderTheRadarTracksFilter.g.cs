
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum GetUnderTheRadarTracksFilter
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Original,
        /// <summary>
        ///
        /// </summary>
        Repost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUnderTheRadarTracksFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUnderTheRadarTracksFilter value)
        {
            return value switch
            {
                GetUnderTheRadarTracksFilter.All => "all",
                GetUnderTheRadarTracksFilter.Original => "original",
                GetUnderTheRadarTracksFilter.Repost => "repost",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUnderTheRadarTracksFilter? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetUnderTheRadarTracksFilter.All,
                "original" => GetUnderTheRadarTracksFilter.Original,
                "repost" => GetUnderTheRadarTracksFilter.Repost,
                _ => null,
            };
        }
    }
}