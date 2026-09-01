
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserCoin
    {
        /// <summary>
        /// The coin mint address<br/>
        /// Example: 9LzCMqDgTKYz9Drzqnpgee3SGa89up3a247ypMj2xrqM
        /// </summary>
        /// <example>9LzCMqDgTKYz9Drzqnpgee3SGa89up3a247ypMj2xrqM</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Mint { get; set; }

        /// <summary>
        /// The coin symbol<br/>
        /// Example: $AUDIO
        /// </summary>
        /// <example>$AUDIO</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ticker")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ticker { get; set; }

        /// <summary>
        /// The number of decimals for the coin<br/>
        /// Example: 8
        /// </summary>
        /// <example>8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("decimals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Decimals { get; set; }

        /// <summary>
        /// The ID of the user associated with the coin<br/>
        /// Example: 7eP5n
        /// </summary>
        /// <example>7eP5n</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// URL to the coin's logo image<br/>
        /// Example: https://example.com/logo.png
        /// </summary>
        /// <example>https://example.com/logo.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_uri")]
        public string? LogoUri { get; set; }

        /// <summary>
        /// URL to the coin's banner image<br/>
        /// Example: https://example.com/banner.png
        /// </summary>
        /// <example>https://example.com/banner.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("banner_image_url")]
        public string? BannerImageUrl { get; set; }

        /// <summary>
        /// Whether the coin has a Discord server<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_discord")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasDiscord { get; set; }

        /// <summary>
        /// The balance of the coin in the user's account (in wei)<br/>
        /// Example: 1000000000
        /// </summary>
        /// <example>1000000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Balance { get; set; }

        /// <summary>
        /// The balance of the coin in the user's account in USD<br/>
        /// Example: 1.23
        /// </summary>
        /// <example>1.23</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BalanceUsd { get; set; }

        /// <summary>
        /// Per-token-account breakdown of the user's holdings for this coin. Populated by GET /v1/users/{id}/coins; omitted by GET /v1/wallet/{walletId}/coins.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accounts")]
        public global::System.Collections.Generic.IList<global::Audius.UserCoinAccount>? Accounts { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserCoin" /> class.
        /// </summary>
        /// <param name="mint">
        /// The coin mint address<br/>
        /// Example: 9LzCMqDgTKYz9Drzqnpgee3SGa89up3a247ypMj2xrqM
        /// </param>
        /// <param name="ticker">
        /// The coin symbol<br/>
        /// Example: $AUDIO
        /// </param>
        /// <param name="decimals">
        /// The number of decimals for the coin<br/>
        /// Example: 8
        /// </param>
        /// <param name="ownerId">
        /// The ID of the user associated with the coin<br/>
        /// Example: 7eP5n
        /// </param>
        /// <param name="hasDiscord">
        /// Whether the coin has a Discord server<br/>
        /// Example: true
        /// </param>
        /// <param name="balance">
        /// The balance of the coin in the user's account (in wei)<br/>
        /// Example: 1000000000
        /// </param>
        /// <param name="balanceUsd">
        /// The balance of the coin in the user's account in USD<br/>
        /// Example: 1.23
        /// </param>
        /// <param name="logoUri">
        /// URL to the coin's logo image<br/>
        /// Example: https://example.com/logo.png
        /// </param>
        /// <param name="bannerImageUrl">
        /// URL to the coin's banner image<br/>
        /// Example: https://example.com/banner.png
        /// </param>
        /// <param name="accounts">
        /// Per-token-account breakdown of the user's holdings for this coin. Populated by GET /v1/users/{id}/coins; omitted by GET /v1/wallet/{walletId}/coins.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserCoin(
            string mint,
            string ticker,
            int decimals,
            string ownerId,
            bool hasDiscord,
            int balance,
            double balanceUsd,
            string? logoUri,
            string? bannerImageUrl,
            global::System.Collections.Generic.IList<global::Audius.UserCoinAccount>? accounts)
        {
            this.Mint = mint ?? throw new global::System.ArgumentNullException(nameof(mint));
            this.Ticker = ticker ?? throw new global::System.ArgumentNullException(nameof(ticker));
            this.Decimals = decimals;
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.LogoUri = logoUri;
            this.BannerImageUrl = bannerImageUrl;
            this.HasDiscord = hasDiscord;
            this.Balance = balance;
            this.BalanceUsd = balanceUsd;
            this.Accounts = accounts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserCoin" /> class.
        /// </summary>
        public UserCoin()
        {
        }

    }
}