
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum GetTracksByUserHandleFilterTracks
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
    public static class GetTracksByUserHandleFilterTracksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTracksByUserHandleFilterTracks value)
        {
            return value switch
            {
                GetTracksByUserHandleFilterTracks.All => "all",
                GetTracksByUserHandleFilterTracks.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTracksByUserHandleFilterTracks? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetTracksByUserHandleFilterTracks.All,
                "public" => GetTracksByUserHandleFilterTracks.Public,
                _ => null,
            };
        }
    }
}