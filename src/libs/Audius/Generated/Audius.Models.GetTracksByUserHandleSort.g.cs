
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: date
    /// </summary>
    public enum GetTracksByUserHandleSort
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
    public static class GetTracksByUserHandleSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTracksByUserHandleSort value)
        {
            return value switch
            {
                GetTracksByUserHandleSort.Date => "date",
                GetTracksByUserHandleSort.Plays => "plays",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTracksByUserHandleSort? ToEnum(string value)
        {
            return value switch
            {
                "date" => GetTracksByUserHandleSort.Date,
                "plays" => GetTracksByUserHandleSort.Plays,
                _ => null,
            };
        }
    }
}