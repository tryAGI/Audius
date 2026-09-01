
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsdcPurchaseBuyerNotificationActionData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buyer_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BuyerUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seller_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SellerUserId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("content_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsdcPurchaseBuyerNotificationActionData" /> class.
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="buyerUserId"></param>
        /// <param name="sellerUserId"></param>
        /// <param name="amount"></param>
        /// <param name="extraAmount"></param>
        /// <param name="contentId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsdcPurchaseBuyerNotificationActionData(
            string contentType,
            string buyerUserId,
            string sellerUserId,
            string amount,
            string extraAmount,
            string contentId)
        {
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.BuyerUserId = buyerUserId ?? throw new global::System.ArgumentNullException(nameof(buyerUserId));
            this.SellerUserId = sellerUserId ?? throw new global::System.ArgumentNullException(nameof(sellerUserId));
            this.Amount = amount ?? throw new global::System.ArgumentNullException(nameof(amount));
            this.ExtraAmount = extraAmount ?? throw new global::System.ArgumentNullException(nameof(extraAmount));
            this.ContentId = contentId ?? throw new global::System.ArgumentNullException(nameof(contentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsdcPurchaseBuyerNotificationActionData" /> class.
        /// </summary>
        public UsdcPurchaseBuyerNotificationActionData()
        {
        }

    }
}