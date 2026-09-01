
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateCoinResponseData
    {
        /// <summary>
        /// The mint address of the coin<br/>
        /// Example: bearR26zyyB3fNQm5wWv1ZfN8MPQDUMwaAuoG79b1Yj
        /// </summary>
        /// <example>bearR26zyyB3fNQm5wWv1ZfN8MPQDUMwaAuoG79b1Yj</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Mint { get; set; }

        /// <summary>
        /// The coin symbol/ticker<br/>
        /// Example: BEAR
        /// </summary>
        /// <example>BEAR</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ticker")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ticker { get; set; }

        /// <summary>
        /// The user ID who created the coin<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UserId { get; set; }

        /// <summary>
        /// The number of decimals for the coin<br/>
        /// Example: 9
        /// </summary>
        /// <example>9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("decimals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Decimals { get; set; }

        /// <summary>
        /// The coin name<br/>
        /// Example: BEAR
        /// </summary>
        /// <example>BEAR</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The URI for the coin's logo image<br/>
        /// Example: https://example.com/logo.png
        /// </summary>
        /// <example>https://example.com/logo.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_uri")]
        public string? LogoUri { get; set; }

        /// <summary>
        /// The URI for the coin's banner image<br/>
        /// Example: https://example.com/banner.png
        /// </summary>
        /// <example>https://example.com/banner.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("banner_image_url")]
        public string? BannerImageUrl { get; set; }

        /// <summary>
        /// The description of the coin<br/>
        /// Example: A majestic bear token for wildlife conservation
        /// </summary>
        /// <example>A majestic bear token for wildlife conservation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Generic link URL for the coin<br/>
        /// Example: https://x.com/bear_token
        /// </summary>
        /// <example>https://x.com/bear_token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("link_1")]
        public string? Link1 { get; set; }

        /// <summary>
        /// Generic link URL for the coin<br/>
        /// Example: https://instagram.com/bear_token
        /// </summary>
        /// <example>https://instagram.com/bear_token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("link_2")]
        public string? Link2 { get; set; }

        /// <summary>
        /// Generic link URL for the coin<br/>
        /// Example: https://tiktok.com/@bear_token
        /// </summary>
        /// <example>https://tiktok.com/@bear_token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("link_3")]
        public string? Link3 { get; set; }

        /// <summary>
        /// Generic link URL for the coin<br/>
        /// Example: https://bear-token.com
        /// </summary>
        /// <example>https://bear-token.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("link_4")]
        public string? Link4 { get; set; }

        /// <summary>
        /// The date and time when the coin was created<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCoinResponseData" /> class.
        /// </summary>
        /// <param name="mint">
        /// The mint address of the coin<br/>
        /// Example: bearR26zyyB3fNQm5wWv1ZfN8MPQDUMwaAuoG79b1Yj
        /// </param>
        /// <param name="ticker">
        /// The coin symbol/ticker<br/>
        /// Example: BEAR
        /// </param>
        /// <param name="userId">
        /// The user ID who created the coin<br/>
        /// Example: 1
        /// </param>
        /// <param name="decimals">
        /// The number of decimals for the coin<br/>
        /// Example: 9
        /// </param>
        /// <param name="name">
        /// The coin name<br/>
        /// Example: BEAR
        /// </param>
        /// <param name="createdAt">
        /// The date and time when the coin was created<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </param>
        /// <param name="logoUri">
        /// The URI for the coin's logo image<br/>
        /// Example: https://example.com/logo.png
        /// </param>
        /// <param name="bannerImageUrl">
        /// The URI for the coin's banner image<br/>
        /// Example: https://example.com/banner.png
        /// </param>
        /// <param name="description">
        /// The description of the coin<br/>
        /// Example: A majestic bear token for wildlife conservation
        /// </param>
        /// <param name="link1">
        /// Generic link URL for the coin<br/>
        /// Example: https://x.com/bear_token
        /// </param>
        /// <param name="link2">
        /// Generic link URL for the coin<br/>
        /// Example: https://instagram.com/bear_token
        /// </param>
        /// <param name="link3">
        /// Generic link URL for the coin<br/>
        /// Example: https://tiktok.com/@bear_token
        /// </param>
        /// <param name="link4">
        /// Generic link URL for the coin<br/>
        /// Example: https://bear-token.com
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCoinResponseData(
            string mint,
            string ticker,
            int userId,
            int decimals,
            string name,
            global::System.DateTime createdAt,
            string? logoUri,
            string? bannerImageUrl,
            string? description,
            string? link1,
            string? link2,
            string? link3,
            string? link4)
        {
            this.Mint = mint ?? throw new global::System.ArgumentNullException(nameof(mint));
            this.Ticker = ticker ?? throw new global::System.ArgumentNullException(nameof(ticker));
            this.UserId = userId;
            this.Decimals = decimals;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.LogoUri = logoUri;
            this.BannerImageUrl = bannerImageUrl;
            this.Description = description;
            this.Link1 = link1;
            this.Link2 = link2;
            this.Link3 = link3;
            this.Link4 = link4;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCoinResponseData" /> class.
        /// </summary>
        public CreateCoinResponseData()
        {
        }

    }
}