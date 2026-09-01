
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetUsdcTransactionsMethod
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
    public static class GetUsdcTransactionsMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsdcTransactionsMethod value)
        {
            return value switch
            {
                GetUsdcTransactionsMethod.Receive => "receive",
                GetUsdcTransactionsMethod.Send => "send",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsdcTransactionsMethod? ToEnum(string value)
        {
            return value switch
            {
                "receive" => GetUsdcTransactionsMethod.Receive,
                "send" => GetUsdcTransactionsMethod.Send,
                _ => null,
            };
        }
    }
}