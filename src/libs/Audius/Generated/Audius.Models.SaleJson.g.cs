
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SaleJson
    {
        /// <summary>
        /// Title of the content (track/album/playlist)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// URL link to the content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// Name of the buyer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchased_by")]
        public string? PurchasedBy { get; set; }

        /// <summary>
        /// User ID of the buyer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buyer_user_id")]
        public int? BuyerUserId { get; set; }

        /// <summary>
        /// ISO format date string of when the sale occurred
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// Base sale price in USDC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sale_price")]
        public double? SalePrice { get; set; }

        /// <summary>
        /// Network fee deducted from sale in USDC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network_fee")]
        public double? NetworkFee { get; set; }

        /// <summary>
        /// Extra amount paid by buyer in USDC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pay_extra")]
        public double? PayExtra { get; set; }

        /// <summary>
        /// Total amount received by seller in USDC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public double? Total { get; set; }

        /// <summary>
        /// Country code where purchase was made
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Encrypted email of buyer if available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_email")]
        public string? EncryptedEmail { get; set; }

        /// <summary>
        /// Encrypted key for decrypting the buyer's email
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_key")]
        public string? EncryptedKey { get; set; }

        /// <summary>
        /// Whether this is an initial encryption from the backfill
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_initial")]
        public bool? IsInitial { get; set; }

        /// <summary>
        /// Base64 encoded public key of the buyer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pubkey_base64")]
        public string? PubkeyBase64 { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SaleJson" /> class.
        /// </summary>
        /// <param name="title">
        /// Title of the content (track/album/playlist)
        /// </param>
        /// <param name="link">
        /// URL link to the content
        /// </param>
        /// <param name="purchasedBy">
        /// Name of the buyer
        /// </param>
        /// <param name="buyerUserId">
        /// User ID of the buyer
        /// </param>
        /// <param name="date">
        /// ISO format date string of when the sale occurred
        /// </param>
        /// <param name="salePrice">
        /// Base sale price in USDC
        /// </param>
        /// <param name="networkFee">
        /// Network fee deducted from sale in USDC
        /// </param>
        /// <param name="payExtra">
        /// Extra amount paid by buyer in USDC
        /// </param>
        /// <param name="total">
        /// Total amount received by seller in USDC
        /// </param>
        /// <param name="country">
        /// Country code where purchase was made
        /// </param>
        /// <param name="encryptedEmail">
        /// Encrypted email of buyer if available
        /// </param>
        /// <param name="encryptedKey">
        /// Encrypted key for decrypting the buyer's email
        /// </param>
        /// <param name="isInitial">
        /// Whether this is an initial encryption from the backfill
        /// </param>
        /// <param name="pubkeyBase64">
        /// Base64 encoded public key of the buyer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SaleJson(
            string? title,
            string? link,
            string? purchasedBy,
            int? buyerUserId,
            string? date,
            double? salePrice,
            double? networkFee,
            double? payExtra,
            double? total,
            string? country,
            string? encryptedEmail,
            string? encryptedKey,
            bool? isInitial,
            string? pubkeyBase64)
        {
            this.Title = title;
            this.Link = link;
            this.PurchasedBy = purchasedBy;
            this.BuyerUserId = buyerUserId;
            this.Date = date;
            this.SalePrice = salePrice;
            this.NetworkFee = networkFee;
            this.PayExtra = payExtra;
            this.Total = total;
            this.Country = country;
            this.EncryptedEmail = encryptedEmail;
            this.EncryptedKey = encryptedKey;
            this.IsInitial = isInitial;
            this.PubkeyBase64 = pubkeyBase64;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaleJson" /> class.
        /// </summary>
        public SaleJson()
        {
        }

    }
}