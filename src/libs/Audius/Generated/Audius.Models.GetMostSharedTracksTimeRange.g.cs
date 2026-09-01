
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: week
    /// </summary>
    public enum GetMostSharedTracksTimeRange
    {
        /// <summary>
        ///
        /// </summary>
        AllTime,
        /// <summary>
        ///
        /// </summary>
        Month,
        /// <summary>
        ///
        /// </summary>
        Week,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMostSharedTracksTimeRangeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMostSharedTracksTimeRange value)
        {
            return value switch
            {
                GetMostSharedTracksTimeRange.AllTime => "allTime",
                GetMostSharedTracksTimeRange.Month => "month",
                GetMostSharedTracksTimeRange.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMostSharedTracksTimeRange? ToEnum(string value)
        {
            return value switch
            {
                "allTime" => GetMostSharedTracksTimeRange.AllTime,
                "month" => GetMostSharedTracksTimeRange.Month,
                "week" => GetMostSharedTracksTimeRange.Week,
                _ => null,
            };
        }
    }
}