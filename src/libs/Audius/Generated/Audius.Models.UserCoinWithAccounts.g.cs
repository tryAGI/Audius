
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserCoinWithAccounts
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
        /// URL to the coin's logo image<br/>
        /// Example: https://example.com/logo.png
        /// </summary>
        /// <example>https://example.com/logo.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_uri")]
        public string? LogoUri { get; set; }

        /// <summary>
        /// The total balance of the coin in the user's account (in wei)<br/>
        /// Example: 1000000000
        /// </summary>
        /// <example>1000000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Balance { get; set; }

        /// <summary>
        /// The total balance of the coin in the user's account in USD<br/>
        /// Example: 1.23
        /// </summary>
        /// <example>1.23</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BalanceUsd { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accounts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Audius.UserCoinAccount> Accounts { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserCoinWithAccounts" /> class.
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
        /// <param name="balance">
        /// The total balance of the coin in the user's account (in wei)<br/>
        /// Example: 1000000000
        /// </param>
        /// <param name="balanceUsd">
        /// The total balance of the coin in the user's account in USD<br/>
        /// Example: 1.23
        /// </param>
        /// <param name="accounts"></param>
        /// <param name="logoUri">
        /// URL to the coin's logo image<br/>
        /// Example: https://example.com/logo.png
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserCoinWithAccounts(
            string mint,
            string ticker,
            int decimals,
            int balance,
            double balanceUsd,
            global::System.Collections.Generic.IList<global::Audius.UserCoinAccount> accounts,
            string? logoUri)
        {
            this.Mint = mint ?? throw new global::System.ArgumentNullException(nameof(mint));
            this.Ticker = ticker ?? throw new global::System.ArgumentNullException(nameof(ticker));
            this.Decimals = decimals;
            this.LogoUri = logoUri;
            this.Balance = balance;
            this.BalanceUsd = balanceUsd;
            this.Accounts = accounts ?? throw new global::System.ArgumentNullException(nameof(accounts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserCoinWithAccounts" /> class.
        /// </summary>
        public UserCoinWithAccounts()
        {
        }

    }
}