
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum GetAiAttributedTracksByUserHandleFilterTracks
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
    public static class GetAiAttributedTracksByUserHandleFilterTracksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAiAttributedTracksByUserHandleFilterTracks value)
        {
            return value switch
            {
                GetAiAttributedTracksByUserHandleFilterTracks.All => "all",
                GetAiAttributedTracksByUserHandleFilterTracks.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAiAttributedTracksByUserHandleFilterTracks? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetAiAttributedTracksByUserHandleFilterTracks.All,
                "public" => GetAiAttributedTracksByUserHandleFilterTracks.Public,
                _ => null,
            };
        }
    }
}