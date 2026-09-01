
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CoinInsightsResponse
    {
        /// <summary>
        /// Additional token information from Birdeye's defi token overview API.<br/>
        /// Includes price, volume, supply, market cap, and other on-chain and market data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Audius.CoinInsights? Data { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CoinInsightsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Additional token information from Birdeye's defi token overview API.<br/>
        /// Includes price, volume, supply, market cap, and other on-chain and market data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CoinInsightsResponse(
            global::Audius.CoinInsights? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoinInsightsResponse" /> class.
        /// </summary>
        public CoinInsightsResponse()
        {
        }

    }
}