
#nullable enable

namespace Audius
{
    /// <summary>
    /// Information about the dynamic bonding curve if one exists for the Coin
    /// </summary>
    public sealed partial class CoinInsightsDynamicBondingCurve
    {
        /// <summary>
        /// Address of the bonding curve pool<br/>
        /// Example: 2AAsAwNPTNBk5N466xyPiwqdgbc5WLbDTdnn9gVuDKaN
        /// </summary>
        /// <example>2AAsAwNPTNBk5N466xyPiwqdgbc5WLbDTdnn9gVuDKaN</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Address { get; set; }

        /// <summary>
        /// Current price in the pool's quote token (e.g., AUDIO)<br/>
        /// Example: 0.0028402095736478586
        /// </summary>
        /// <example>0.0028402095736478586</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Price { get; set; }

        /// <summary>
        /// Current price in USD<br/>
        /// Example: 0.000029571022098881748
        /// </summary>
        /// <example>0.000029571022098881748</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("priceUSD")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PriceUSD { get; set; }

        /// <summary>
        /// Progress along the bonding curve (0.0 - 1.0)<br/>
        /// Example: 0.75
        /// </summary>
        /// <example>0.75</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("curveProgress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CurveProgress { get; set; }

        /// <summary>
        /// Whether the bonding curve has been migrated<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("isMigrated")]
        public bool? IsMigrated { get; set; }

        /// <summary>
        /// Creator quote fee for the bonding curve<br/>
        /// Example: 0.05
        /// </summary>
        /// <example>0.05</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("creatorQuoteFee")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatorQuoteFee { get; set; }

        /// <summary>
        /// Total trading quote fee accumulated<br/>
        /// Example: 0.001
        /// </summary>
        /// <example>0.001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalTradingQuoteFee")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalTradingQuoteFee { get; set; }

        /// <summary>
        /// Address of the pool creator's wallet<br/>
        /// Example: 2AAsAwNPTNBk5N466xyPiwqdgbc5WLbDTdnn9gVuDKaN
        /// </summary>
        /// <example>2AAsAwNPTNBk5N466xyPiwqdgbc5WLbDTdnn9gVuDKaN</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("creatorWalletAddress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatorWalletAddress { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CoinInsightsDynamicBondingCurve" /> class.
        /// </summary>
        /// <param name="address">
        /// Address of the bonding curve pool<br/>
        /// Example: 2AAsAwNPTNBk5N466xyPiwqdgbc5WLbDTdnn9gVuDKaN
        /// </param>
        /// <param name="price">
        /// Current price in the pool's quote token (e.g., AUDIO)<br/>
        /// Example: 0.0028402095736478586
        /// </param>
        /// <param name="priceUSD">
        /// Current price in USD<br/>
        /// Example: 0.000029571022098881748
        /// </param>
        /// <param name="curveProgress">
        /// Progress along the bonding curve (0.0 - 1.0)<br/>
        /// Example: 0.75
        /// </param>
        /// <param name="creatorQuoteFee">
        /// Creator quote fee for the bonding curve<br/>
        /// Example: 0.05
        /// </param>
        /// <param name="totalTradingQuoteFee">
        /// Total trading quote fee accumulated<br/>
        /// Example: 0.001
        /// </param>
        /// <param name="creatorWalletAddress">
        /// Address of the pool creator's wallet<br/>
        /// Example: 2AAsAwNPTNBk5N466xyPiwqdgbc5WLbDTdnn9gVuDKaN
        /// </param>
        /// <param name="isMigrated">
        /// Whether the bonding curve has been migrated<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CoinInsightsDynamicBondingCurve(
            string address,
            double price,
            double priceUSD,
            double curveProgress,
            double creatorQuoteFee,
            double totalTradingQuoteFee,
            string creatorWalletAddress,
            bool? isMigrated)
        {
            this.Address = address ?? throw new global::System.ArgumentNullException(nameof(address));
            this.Price = price;
            this.PriceUSD = priceUSD;
            this.CurveProgress = curveProgress;
            this.IsMigrated = isMigrated;
            this.CreatorQuoteFee = creatorQuoteFee;
            this.TotalTradingQuoteFee = totalTradingQuoteFee;
            this.CreatorWalletAddress = creatorWalletAddress ?? throw new global::System.ArgumentNullException(nameof(creatorWalletAddress));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoinInsightsDynamicBondingCurve" /> class.
        /// </summary>
        public CoinInsightsDynamicBondingCurve()
        {
        }

    }
}