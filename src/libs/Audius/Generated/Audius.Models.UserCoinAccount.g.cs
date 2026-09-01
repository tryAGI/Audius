
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserCoinAccount
    {
        /// <summary>
        /// The token account address<br/>
        /// Example: CTyFguG69kwYrzk24P3UuBvY1rR5atu9kf2S6XEwAU8X
        /// </summary>
        /// <example>CTyFguG69kwYrzk24P3UuBvY1rR5atu9kf2S6XEwAU8X</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("account")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Account { get; set; }

        /// <summary>
        /// The owner wallet of the token account<br/>
        /// Example: HzZ3EKACbH6XEHs59Rt1adVzUKv5cTDE9o9YWFaMhwpF
        /// </summary>
        /// <example>HzZ3EKACbH6XEHs59Rt1adVzUKv5cTDE9o9YWFaMhwpF</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Owner { get; set; }

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
        /// Whether the account is in the user's in-app wallet<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_in_app_wallet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsInAppWallet { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserCoinAccount" /> class.
        /// </summary>
        /// <param name="account">
        /// The token account address<br/>
        /// Example: CTyFguG69kwYrzk24P3UuBvY1rR5atu9kf2S6XEwAU8X
        /// </param>
        /// <param name="owner">
        /// The owner wallet of the token account<br/>
        /// Example: HzZ3EKACbH6XEHs59Rt1adVzUKv5cTDE9o9YWFaMhwpF
        /// </param>
        /// <param name="balance">
        /// The balance of the coin in the user's account (in wei)<br/>
        /// Example: 1000000000
        /// </param>
        /// <param name="balanceUsd">
        /// The balance of the coin in the user's account in USD<br/>
        /// Example: 1.23
        /// </param>
        /// <param name="isInAppWallet">
        /// Whether the account is in the user's in-app wallet<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserCoinAccount(
            string account,
            string owner,
            int balance,
            double balanceUsd,
            bool isInAppWallet)
        {
            this.Account = account ?? throw new global::System.ArgumentNullException(nameof(account));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Balance = balance;
            this.BalanceUsd = balanceUsd;
            this.IsInAppWallet = isInAppWallet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserCoinAccount" /> class.
        /// </summary>
        public UserCoinAccount()
        {
        }

    }
}