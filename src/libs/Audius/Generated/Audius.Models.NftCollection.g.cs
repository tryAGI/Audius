
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NftCollection
    {
        /// <summary>
        /// Example: eth
        /// </summary>
        /// <example>eth</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chain")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.NftCollectionChainJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.NftCollectionChain Chain { get; set; }

        /// <summary>
        /// Example: ERC721
        /// </summary>
        /// <example>ERC721</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("standard")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.NftCollectionStandardJsonConverter))]
        public global::Audius.NftCollectionStandard? Standard { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Address { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalLink")]
        public string? ExternalLink { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NftCollection" /> class.
        /// </summary>
        /// <param name="chain">
        /// Example: eth
        /// </param>
        /// <param name="address"></param>
        /// <param name="name"></param>
        /// <param name="standard">
        /// Example: ERC721
        /// </param>
        /// <param name="imageUrl"></param>
        /// <param name="externalLink"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NftCollection(
            global::Audius.NftCollectionChain chain,
            string address,
            string name,
            global::Audius.NftCollectionStandard? standard,
            string? imageUrl,
            string? externalLink)
        {
            this.Chain = chain;
            this.Standard = standard;
            this.Address = address ?? throw new global::System.ArgumentNullException(nameof(address));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ImageUrl = imageUrl;
            this.ExternalLink = externalLink;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NftCollection" /> class.
        /// </summary>
        public NftCollection()
        {
        }

    }
}