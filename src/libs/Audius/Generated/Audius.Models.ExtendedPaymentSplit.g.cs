
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExtendedPaymentSplit
    {
        /// <summary>
        /// Example: 1234
        /// </summary>
        /// <example>1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Percentage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eth_wallet")]
        public string? EthWallet { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payout_wallet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PayoutWallet { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Amount { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedPaymentSplit" /> class.
        /// </summary>
        /// <param name="percentage"></param>
        /// <param name="payoutWallet"></param>
        /// <param name="amount"></param>
        /// <param name="userId">
        /// Example: 1234
        /// </param>
        /// <param name="ethWallet"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtendedPaymentSplit(
            double percentage,
            string payoutWallet,
            int amount,
            int? userId,
            string? ethWallet)
        {
            this.UserId = userId;
            this.Percentage = percentage;
            this.EthWallet = ethWallet;
            this.PayoutWallet = payoutWallet ?? throw new global::System.ArgumentNullException(nameof(payoutWallet));
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedPaymentSplit" /> class.
        /// </summary>
        public ExtendedPaymentSplit()
        {
        }

    }
}