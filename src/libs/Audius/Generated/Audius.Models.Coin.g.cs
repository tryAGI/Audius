
#nullable enable

namespace Audius
{
    /// <summary>
    /// A coin object
    /// </summary>
    public sealed partial class Coin
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
        /// X (Twitter) handle for the coin<br/>
        /// Example: bear_token
        /// </summary>
        /// <example>bear_token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("x_handle")]
        public string? XHandle { get; set; }

        /// <summary>
        /// Instagram handle for the coin<br/>
        /// Example: bear_token
        /// </summary>
        /// <example>bear_token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("instagram_handle")]
        public string? InstagramHandle { get; set; }

        /// <summary>
        /// TikTok handle for the coin<br/>
        /// Example: bear_token
        /// </summary>
        /// <example>bear_token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tiktok_handle")]
        public string? TiktokHandle { get; set; }

        /// <summary>
        /// Website URL for the coin<br/>
        /// Example: https://bear-token.com
        /// </summary>
        /// <example>https://bear-token.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        public string? Website { get; set; }

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
        /// Whether the coin has a Discord server<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_discord")]
        public bool? HasDiscord { get; set; }

        /// <summary>
        /// The date and time when the coin was created<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the coin was last updated<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The user ID of the coin owner<br/>
        /// Example: 7eP5n
        /// </summary>
        /// <example>7eP5n</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        public string? OwnerId { get; set; }

        /// <summary>
        /// The escrow recipient address for custom-created coins without DBCs<br/>
        /// Example: DezXAZ8z7PnrnRJjz3wXBoRgixCa6xjnB7YaB1pPB263
        /// </summary>
        /// <example>DezXAZ8z7PnrnRJjz3wXBoRgixCa6xjnB7YaB1pPB263</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("escrow_recipient")]
        public string? EscrowRecipient { get; set; }

        /// <summary>
        /// Information about the dynamic bonding curve if one exists for the coin
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamicBondingCurve")]
        public global::Audius.DynamicBondingCurveInsights? DynamicBondingCurve { get; set; }

        /// <summary>
        /// Artist locker balance and claimable info for the coin
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artist_locker")]
        public global::Audius.ArtistLocker? ArtistLocker { get; set; }

        /// <summary>
        /// Artist coin fee info (unclaimed/total)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artist_fees")]
        public global::Audius.ArtistCoinFees? ArtistFees { get; set; }

        /// <summary>
        /// Reward pool for the coin
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reward_pool")]
        public global::Audius.RewardPool? RewardPool { get; set; }

        /// <summary>
        /// Current price in USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public double? Price { get; set; }

        /// <summary>
        /// Market capitalization in USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marketCap")]
        public double? MarketCap { get; set; }

        /// <summary>
        /// Total volume traded in USD (all time)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalVolumeUSD")]
        public double? TotalVolumeUSD { get; set; }

        /// <summary>
        /// Number of holders
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("holder")]
        public int? Holder { get; set; }

        /// <summary>
        /// Total supply of the token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSupply")]
        public double? TotalSupply { get; set; }

        /// <summary>
        /// Current liquidity in USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("liquidity")]
        public double? Liquidity { get; set; }

        /// <summary>
        /// Circulating supply of the token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("circulatingSupply")]
        public double? CirculatingSupply { get; set; }

        /// <summary>
        /// 24h price change in percent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priceChange24hPercent")]
        public double? PriceChange24hPercent { get; set; }

        /// <summary>
        /// Display price (client-computed, e.g. for display formatting)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayPrice")]
        public double? DisplayPrice { get; set; }

        /// <summary>
        /// Display market cap (client-computed)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayMarketCap")]
        public double? DisplayMarketCap { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Coin" /> class.
        /// </summary>
        /// <param name="mint">
        /// The mint address of the coin<br/>
        /// Example: bearR26zyyB3fNQm5wWv1ZfN8MPQDUMwaAuoG79b1Yj
        /// </param>
        /// <param name="ticker">
        /// The coin symbol/ticker<br/>
        /// Example: BEAR
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
        /// <param name="xHandle">
        /// X (Twitter) handle for the coin<br/>
        /// Example: bear_token
        /// </param>
        /// <param name="instagramHandle">
        /// Instagram handle for the coin<br/>
        /// Example: bear_token
        /// </param>
        /// <param name="tiktokHandle">
        /// TikTok handle for the coin<br/>
        /// Example: bear_token
        /// </param>
        /// <param name="website">
        /// Website URL for the coin<br/>
        /// Example: https://bear-token.com
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
        /// <param name="hasDiscord">
        /// Whether the coin has a Discord server<br/>
        /// Example: false
        /// </param>
        /// <param name="updatedAt">
        /// The date and time when the coin was last updated<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </param>
        /// <param name="ownerId">
        /// The user ID of the coin owner<br/>
        /// Example: 7eP5n
        /// </param>
        /// <param name="escrowRecipient">
        /// The escrow recipient address for custom-created coins without DBCs<br/>
        /// Example: DezXAZ8z7PnrnRJjz3wXBoRgixCa6xjnB7YaB1pPB263
        /// </param>
        /// <param name="dynamicBondingCurve">
        /// Information about the dynamic bonding curve if one exists for the coin
        /// </param>
        /// <param name="artistLocker">
        /// Artist locker balance and claimable info for the coin
        /// </param>
        /// <param name="artistFees">
        /// Artist coin fee info (unclaimed/total)
        /// </param>
        /// <param name="rewardPool">
        /// Reward pool for the coin
        /// </param>
        /// <param name="price">
        /// Current price in USD
        /// </param>
        /// <param name="marketCap">
        /// Market capitalization in USD
        /// </param>
        /// <param name="totalVolumeUSD">
        /// Total volume traded in USD (all time)
        /// </param>
        /// <param name="holder">
        /// Number of holders
        /// </param>
        /// <param name="totalSupply">
        /// Total supply of the token
        /// </param>
        /// <param name="liquidity">
        /// Current liquidity in USD
        /// </param>
        /// <param name="circulatingSupply">
        /// Circulating supply of the token
        /// </param>
        /// <param name="priceChange24hPercent">
        /// 24h price change in percent
        /// </param>
        /// <param name="displayPrice">
        /// Display price (client-computed, e.g. for display formatting)
        /// </param>
        /// <param name="displayMarketCap">
        /// Display market cap (client-computed)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Coin(
            string mint,
            string ticker,
            int decimals,
            string name,
            global::System.DateTime createdAt,
            string? logoUri,
            string? bannerImageUrl,
            string? description,
            string? xHandle,
            string? instagramHandle,
            string? tiktokHandle,
            string? website,
            string? link1,
            string? link2,
            string? link3,
            string? link4,
            bool? hasDiscord,
            global::System.DateTime? updatedAt,
            string? ownerId,
            string? escrowRecipient,
            global::Audius.DynamicBondingCurveInsights? dynamicBondingCurve,
            global::Audius.ArtistLocker? artistLocker,
            global::Audius.ArtistCoinFees? artistFees,
            global::Audius.RewardPool? rewardPool,
            double? price,
            double? marketCap,
            double? totalVolumeUSD,
            int? holder,
            double? totalSupply,
            double? liquidity,
            double? circulatingSupply,
            double? priceChange24hPercent,
            double? displayPrice,
            double? displayMarketCap)
        {
            this.Mint = mint ?? throw new global::System.ArgumentNullException(nameof(mint));
            this.Ticker = ticker ?? throw new global::System.ArgumentNullException(nameof(ticker));
            this.Decimals = decimals;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.LogoUri = logoUri;
            this.BannerImageUrl = bannerImageUrl;
            this.Description = description;
            this.XHandle = xHandle;
            this.InstagramHandle = instagramHandle;
            this.TiktokHandle = tiktokHandle;
            this.Website = website;
            this.Link1 = link1;
            this.Link2 = link2;
            this.Link3 = link3;
            this.Link4 = link4;
            this.HasDiscord = hasDiscord;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.OwnerId = ownerId;
            this.EscrowRecipient = escrowRecipient;
            this.DynamicBondingCurve = dynamicBondingCurve;
            this.ArtistLocker = artistLocker;
            this.ArtistFees = artistFees;
            this.RewardPool = rewardPool;
            this.Price = price;
            this.MarketCap = marketCap;
            this.TotalVolumeUSD = totalVolumeUSD;
            this.Holder = holder;
            this.TotalSupply = totalSupply;
            this.Liquidity = liquidity;
            this.CirculatingSupply = circulatingSupply;
            this.PriceChange24hPercent = priceChange24hPercent;
            this.DisplayPrice = displayPrice;
            this.DisplayMarketCap = displayMarketCap;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coin" /> class.
        /// </summary>
        public Coin()
        {
        }

    }
}