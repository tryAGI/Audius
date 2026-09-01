
#nullable enable

namespace Audius
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum GetRemixContestsStatus
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Ended,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRemixContestsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRemixContestsStatus value)
        {
            return value switch
            {
                GetRemixContestsStatus.Active => "active",
                GetRemixContestsStatus.All => "all",
                GetRemixContestsStatus.Ended => "ended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRemixContestsStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => GetRemixContestsStatus.Active,
                "all" => GetRemixContestsStatus.All,
                "ended" => GetRemixContestsStatus.Ended,
                _ => null,
            };
        }
    }
}