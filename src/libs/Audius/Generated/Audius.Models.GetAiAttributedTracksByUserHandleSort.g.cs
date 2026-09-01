
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: date
    /// </summary>
    public enum GetAiAttributedTracksByUserHandleSort
    {
        /// <summary>
        ///
        /// </summary>
        Date,
        /// <summary>
        ///
        /// </summary>
        Plays,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAiAttributedTracksByUserHandleSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAiAttributedTracksByUserHandleSort value)
        {
            return value switch
            {
                GetAiAttributedTracksByUserHandleSort.Date => "date",
                GetAiAttributedTracksByUserHandleSort.Plays => "plays",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAiAttributedTracksByUserHandleSort? ToEnum(string value)
        {
            return value switch
            {
                "date" => GetAiAttributedTracksByUserHandleSort.Date,
                "plays" => GetAiAttributedTracksByUserHandleSort.Plays,
                _ => null,
            };
        }
    }
}