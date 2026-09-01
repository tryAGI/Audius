
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TransactionDetails
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TransactionDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TransactionType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Method { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Signature { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_bank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserBank { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("change")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Change { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Balance { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metadata { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionDetails" /> class.
        /// </summary>
        /// <param name="transactionDate"></param>
        /// <param name="transactionType"></param>
        /// <param name="method"></param>
        /// <param name="signature"></param>
        /// <param name="userBank"></param>
        /// <param name="change"></param>
        /// <param name="balance"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransactionDetails(
            string transactionDate,
            string transactionType,
            string method,
            string signature,
            string userBank,
            string change,
            string balance,
            object metadata)
        {
            this.TransactionDate = transactionDate ?? throw new global::System.ArgumentNullException(nameof(transactionDate));
            this.TransactionType = transactionType ?? throw new global::System.ArgumentNullException(nameof(transactionType));
            this.Method = method ?? throw new global::System.ArgumentNullException(nameof(method));
            this.Signature = signature ?? throw new global::System.ArgumentNullException(nameof(signature));
            this.UserBank = userBank ?? throw new global::System.ArgumentNullException(nameof(userBank));
            this.Change = change ?? throw new global::System.ArgumentNullException(nameof(change));
            this.Balance = balance ?? throw new global::System.ArgumentNullException(nameof(balance));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionDetails" /> class.
        /// </summary>
        public TransactionDetails()
        {
        }

    }
}