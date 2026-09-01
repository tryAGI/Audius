
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum GetTracksCountByUserFilterTracks
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTracksCountByUserFilterTracksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTracksCountByUserFilterTracks value)
        {
            return value switch
            {
                GetTracksCountByUserFilterTracks.All => "all",
                GetTracksCountByUserFilterTracks.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTracksCountByUserFilterTracks? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetTracksCountByUserFilterTracks.All,
                "public" => GetTracksCountByUserFilterTracks.Public,
                _ => null,
            };
        }
    }
}