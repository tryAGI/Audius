
#nullable enable

namespace Audius
{
    /// <summary>
    /// Example: ERC721
    /// </summary>
    public enum NftCollectionStandard
    {
        /// <summary>
        ///
        /// </summary>
        Erc1155,
        /// <summary>
        ///
        /// </summary>
        Erc721,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NftCollectionStandardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NftCollectionStandard value)
        {
            return value switch
            {
                NftCollectionStandard.Erc1155 => "ERC1155",
                NftCollectionStandard.Erc721 => "ERC721",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NftCollectionStandard? ToEnum(string value)
        {
            return value switch
            {
                "ERC1155" => NftCollectionStandard.Erc1155,
                "ERC721" => NftCollectionStandard.Erc721,
                _ => null,
            };
        }
    }
}