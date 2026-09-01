
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserArtistCoinBadge
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mint")]
        public string? Mint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_uri")]
        public string? LogoUri { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("banner_image_url")]
        public string? BannerImageUrl { get; set; }

        /// <summary>
        /// The coin symbol/ticker
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ticker")]
        public string? Ticker { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserArtistCoinBadge" /> class.
        /// </summary>
        /// <param name="mint"></param>
        /// <param name="logoUri"></param>
        /// <param name="bannerImageUrl"></param>
        /// <param name="ticker">
        /// The coin symbol/ticker
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserArtistCoinBadge(
            string? mint,
            string? logoUri,
            string? bannerImageUrl,
            string? ticker)
        {
            this.Mint = mint;
            this.LogoUri = logoUri;
            this.BannerImageUrl = bannerImageUrl;
            this.Ticker = ticker;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserArtistCoinBadge" /> class.
        /// </summary>
        public UserArtistCoinBadge()
        {
        }

    }
}