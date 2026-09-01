
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NftGate
    {
        /// <summary>
        /// Must hold an NFT of the given collection to unlock
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nft_collection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.NftCollection NftCollection { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NftGate" /> class.
        /// </summary>
        /// <param name="nftCollection">
        /// Must hold an NFT of the given collection to unlock
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NftGate(
            global::Audius.NftCollection nftCollection)
        {
            this.NftCollection = nftCollection ?? throw new global::System.ArgumentNullException(nameof(nftCollection));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NftGate" /> class.
        /// </summary>
        public NftGate()
        {
        }

    }
}