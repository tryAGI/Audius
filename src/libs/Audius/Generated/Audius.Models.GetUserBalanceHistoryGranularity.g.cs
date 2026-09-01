
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: hourly
    /// </summary>
    public enum GetUserBalanceHistoryGranularity
    {
        /// <summary>
        ///
        /// </summary>
        Daily,
        /// <summary>
        ///
        /// </summary>
        Hourly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUserBalanceHistoryGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUserBalanceHistoryGranularity value)
        {
            return value switch
            {
                GetUserBalanceHistoryGranularity.Daily => "daily",
                GetUserBalanceHistoryGranularity.Hourly => "hourly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUserBalanceHistoryGranularity? ToEnum(string value)
        {
            return value switch
            {
                "daily" => GetUserBalanceHistoryGranularity.Daily,
                "hourly" => GetUserBalanceHistoryGranularity.Hourly,
                _ => null,
            };
        }
    }
}