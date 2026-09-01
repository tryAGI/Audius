
#nullable enable

namespace Audius
{
    /// <summary>
    /// Error message indicating why the code cannot be redeemed<br/>
    /// Example: used
    /// </summary>
    public enum RewardCodeErrorResponseError
    {
        /// <summary>
        ///
        /// </summary>
        Invalid,
        /// <summary>
        ///
        /// </summary>
        Used,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RewardCodeErrorResponseErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RewardCodeErrorResponseError value)
        {
            return value switch
            {
                RewardCodeErrorResponseError.Invalid => "invalid",
                RewardCodeErrorResponseError.Used => "used",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RewardCodeErrorResponseError? ToEnum(string value)
        {
            return value switch
            {
                "invalid" => RewardCodeErrorResponseError.Invalid,
                "used" => RewardCodeErrorResponseError.Used,
                _ => null,
            };
        }
    }
}