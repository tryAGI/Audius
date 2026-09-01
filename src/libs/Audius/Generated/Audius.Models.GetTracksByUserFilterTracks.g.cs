
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum GetTracksByUserFilterTracks
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
    public static class GetTracksByUserFilterTracksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTracksByUserFilterTracks value)
        {
            return value switch
            {
                GetTracksByUserFilterTracks.All => "all",
                GetTracksByUserFilterTracks.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTracksByUserFilterTracks? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetTracksByUserFilterTracks.All,
                "public" => GetTracksByUserFilterTracks.Public,
                _ => null,
            };
        }
    }
}