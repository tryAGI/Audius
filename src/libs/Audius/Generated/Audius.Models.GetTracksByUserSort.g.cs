
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: date
    /// </summary>
    public enum GetTracksByUserSort
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
    public static class GetTracksByUserSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTracksByUserSort value)
        {
            return value switch
            {
                GetTracksByUserSort.Date => "date",
                GetTracksByUserSort.Plays => "plays",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTracksByUserSort? ToEnum(string value)
        {
            return value switch
            {
                "date" => GetTracksByUserSort.Date,
                "plays" => GetTracksByUserSort.Plays,
                _ => null,
            };
        }
    }
}