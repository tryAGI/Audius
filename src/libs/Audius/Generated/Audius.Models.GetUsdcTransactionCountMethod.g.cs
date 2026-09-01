
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetUsdcTransactionCountMethod
    {
        /// <summary>
        ///
        /// </summary>
        Receive,
        /// <summary>
        ///
        /// </summary>
        Send,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUsdcTransactionCountMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsdcTransactionCountMethod value)
        {
            return value switch
            {
                GetUsdcTransactionCountMethod.Receive => "receive",
                GetUsdcTransactionCountMethod.Send => "send",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsdcTransactionCountMethod? ToEnum(string value)
        {
            return value switch
            {
                "receive" => GetUsdcTransactionCountMethod.Receive,
                "send" => GetUsdcTransactionCountMethod.Send,
                _ => null,
            };
        }
    }
}