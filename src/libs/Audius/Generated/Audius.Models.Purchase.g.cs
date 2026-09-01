
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Purchase
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slot")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Slot { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Signature { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seller_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SellerUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buyer_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BuyerUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Amount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExtraAmount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Access { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("splits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Audius.PurchaseSplit> Splits { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Purchase" /> class.
        /// </summary>
        /// <param name="slot"></param>
        /// <param name="signature"></param>
        /// <param name="sellerUserId"></param>
        /// <param name="buyerUserId"></param>
        /// <param name="amount"></param>
        /// <param name="extraAmount"></param>
        /// <param name="contentType"></param>
        /// <param name="contentId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="access"></param>
        /// <param name="splits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Purchase(
            int slot,
            string signature,
            string sellerUserId,
            string buyerUserId,
            string amount,
            string extraAmount,
            string contentType,
            string contentId,
            string createdAt,
            string updatedAt,
            string access,
            global::System.Collections.Generic.IList<global::Audius.PurchaseSplit> splits)
        {
            this.Slot = slot;
            this.Signature = signature ?? throw new global::System.ArgumentNullException(nameof(signature));
            this.SellerUserId = sellerUserId ?? throw new global::System.ArgumentNullException(nameof(sellerUserId));
            this.BuyerUserId = buyerUserId ?? throw new global::System.ArgumentNullException(nameof(buyerUserId));
            this.Amount = amount ?? throw new global::System.ArgumentNullException(nameof(amount));
            this.ExtraAmount = extraAmount ?? throw new global::System.ArgumentNullException(nameof(extraAmount));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.ContentId = contentId ?? throw new global::System.ArgumentNullException(nameof(contentId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Access = access ?? throw new global::System.ArgumentNullException(nameof(access));
            this.Splits = splits ?? throw new global::System.ArgumentNullException(nameof(splits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Purchase" /> class.
        /// </summary>
        public Purchase()
        {
        }

    }
}