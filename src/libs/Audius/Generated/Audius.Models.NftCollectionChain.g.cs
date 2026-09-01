
#nullable enable

namespace Audius
{
    /// <summary>
    /// Example: eth
    /// </summary>
    public enum NftCollectionChain
    {
        /// <summary>
        ///
        /// </summary>
        Eth,
        /// <summary>
        ///
        /// </summary>
        Sol,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NftCollectionChainExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NftCollectionChain value)
        {
            return value switch
            {
                NftCollectionChain.Eth => "eth",
                NftCollectionChain.Sol => "sol",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NftCollectionChain? ToEnum(string value)
        {
            return value switch
            {
                "eth" => NftCollectionChain.Eth,
                "sol" => NftCollectionChain.Sol,
                _ => null,
            };
        }
    }
}