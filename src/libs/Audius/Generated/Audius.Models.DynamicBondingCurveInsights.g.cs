
#nullable enable

namespace Audius
{
    /// <summary>
    /// Information about the dynamic bonding curve if one exists for the coin
    /// </summary>
    public sealed partial class DynamicBondingCurveInsights
    {
        /// <summary>
        /// Address of the bonding curve pool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        public string? Address { get; set; }

        /// <summary>
        /// Current price in the pool's quote token (e.g., AUDIO)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public double? Price { get; set; }

        /// <summary>
        /// Current price in USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priceUSD")]
        public double? PriceUSD { get; set; }

        /// <summary>
        /// Progress along the bonding curve (0.0 - 1.0)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("curveProgress")]
        public double? CurveProgress { get; set; }

        /// <summary>
        /// Whether the bonding curve has been migrated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isMigrated")]
        public bool? IsMigrated { get; set; }

        /// <summary>
        /// Creator quote fee for the bonding curve
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creatorQuoteFee")]
        public double? CreatorQuoteFee { get; set; }

        /// <summary>
        /// Total trading quote fee accumulated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalTradingQuoteFee")]
        public double? TotalTradingQuoteFee { get; set; }

        /// <summary>
        /// Address of the pool creator's wallet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creatorWalletAddress")]
        public string? CreatorWalletAddress { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicBondingCurveInsights" /> class.
        /// </summary>
        /// <param name="address">
        /// Address of the bonding curve pool
        /// </param>
        /// <param name="price">
        /// Current price in the pool's quote token (e.g., AUDIO)
        /// </param>
        /// <param name="priceUSD">
        /// Current price in USD
        /// </param>
        /// <param name="curveProgress">
        /// Progress along the bonding curve (0.0 - 1.0)
        /// </param>
        /// <param name="isMigrated">
        /// Whether the bonding curve has been migrated
        /// </param>
        /// <param name="creatorQuoteFee">
        /// Creator quote fee for the bonding curve
        /// </param>
        /// <param name="totalTradingQuoteFee">
        /// Total trading quote fee accumulated
        /// </param>
        /// <param name="creatorWalletAddress">
        /// Address of the pool creator's wallet
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DynamicBondingCurveInsights(
            string? address,
            double? price,
            double? priceUSD,
            double? curveProgress,
            bool? isMigrated,
            double? creatorQuoteFee,
            double? totalTradingQuoteFee,
            string? creatorWalletAddress)
        {
            this.Address = address;
            this.Price = price;
            this.PriceUSD = priceUSD;
            this.CurveProgress = curveProgress;
            this.IsMigrated = isMigrated;
            this.CreatorQuoteFee = creatorQuoteFee;
            this.TotalTradingQuoteFee = totalTradingQuoteFee;
            this.CreatorWalletAddress = creatorWalletAddress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicBondingCurveInsights" /> class.
        /// </summary>
        public DynamicBondingCurveInsights()
        {
        }

    }
}