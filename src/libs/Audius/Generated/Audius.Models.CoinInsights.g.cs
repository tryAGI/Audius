
#nullable enable

namespace Audius
{
    /// <summary>
    /// Additional token information from Birdeye's defi token overview API.<br/>
    /// Includes price, volume, supply, market cap, and other on-chain and market data.
    /// </summary>
    public sealed partial class CoinInsights
    {
        /// <summary>
        /// The SPL token mint address<br/>
        /// Example: DezXAZ8z7PnrnRJjz3wXBoRgixCa6xjnB7YaB1pPB263
        /// </summary>
        /// <example>DezXAZ8z7PnrnRJjz3wXBoRgixCa6xjnB7YaB1pPB263</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        public string? Address { get; set; }

        /// <summary>
        /// Number of decimals for the token<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("decimals")]
        public int? Decimals { get; set; }

        /// <summary>
        /// The token symbol<br/>
        /// Example: BONK
        /// </summary>
        /// <example>BONK</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("symbol")]
        public string? Symbol { get; set; }

        /// <summary>
        /// The token name<br/>
        /// Example: Bonk
        /// </summary>
        /// <example>Bonk</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Market capitalization in USD<br/>
        /// Example: 2625779824.994664
        /// </summary>
        /// <example>2625779824.994664</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("marketCap")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MarketCap { get; set; }

        /// <summary>
        /// Fully diluted valuation in USD<br/>
        /// Example: 2625779824.994664
        /// </summary>
        /// <example>2625779824.994664</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fdv")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Fdv { get; set; }

        /// <summary>
        /// Token metadata and links
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extensions")]
        public global::Audius.CoinInsightsExtensions? Extensions { get; set; }

        /// <summary>
        /// Current liquidity in USD<br/>
        /// Example: 18977326.389274083
        /// </summary>
        /// <example>18977326.389274083</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("liquidity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Liquidity { get; set; }

        /// <summary>
        /// Unix timestamp of the last trade<br/>
        /// Example: 1752620592
        /// </summary>
        /// <example>1752620592</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastTradeUnixTime")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset LastTradeUnixTime { get; set; }

        /// <summary>
        /// ISO8601 time of the last trade<br/>
        /// Example: 2025-07-15T23:03:12
        /// </summary>
        /// <example>2025-07-15T23:03:12</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastTradeHumanTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastTradeHumanTime { get; set; }

        /// <summary>
        /// Current price in USD<br/>
        /// Example: 0.000029571022098881748
        /// </summary>
        /// <example>0.000029571022098881748</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Price { get; set; }

        /// <summary>
        /// Price 24 hours ago in USD<br/>
        /// Example: 0.000027195701160436288
        /// </summary>
        /// <example>0.000027195701160436288</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("history24hPrice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double History24hPrice { get; set; }

        /// <summary>
        /// 24h price change in percent<br/>
        /// Example: 8.73417796596848
        /// </summary>
        /// <example>8.73417796596848</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("priceChange24hPercent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PriceChange24hPercent { get; set; }

        /// <summary>
        /// Unique wallets traded in last 24h<br/>
        /// Example: 20242
        /// </summary>
        /// <example>20242</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uniqueWallet24h")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UniqueWallet24h { get; set; }

        /// <summary>
        /// Unique wallets traded in previous 24h<br/>
        /// Example: 21155
        /// </summary>
        /// <example>21155</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uniqueWalletHistory24h")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UniqueWalletHistory24h { get; set; }

        /// <summary>
        /// 24h change in unique wallets (percent)<br/>
        /// Example: -4.315764594658473
        /// </summary>
        /// <example>-4.315764594658473</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uniqueWallet24hChangePercent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UniqueWallet24hChangePercent { get; set; }

        /// <summary>
        /// Total supply of the token<br/>
        /// Example: 88795707372386.03
        /// </summary>
        /// <example>88795707372386.03</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSupply")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalSupply { get; set; }

        /// <summary>
        /// Circulating supply of the token<br/>
        /// Example: 88795707372386.03
        /// </summary>
        /// <example>88795707372386.03</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("circulatingSupply")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CirculatingSupply { get; set; }

        /// <summary>
        /// Number of holders<br/>
        /// Example: 957291
        /// </summary>
        /// <example>957291</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("holder")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Holder { get; set; }

        /// <summary>
        /// Number of trades in last 24h<br/>
        /// Example: 449987
        /// </summary>
        /// <example>449987</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trade24h")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Trade24h { get; set; }

        /// <summary>
        /// Number of trades in previous 24h<br/>
        /// Example: 390400
        /// </summary>
        /// <example>390400</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tradeHistory24h")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TradeHistory24h { get; set; }

        /// <summary>
        /// 24h change in trade count (percent)<br/>
        /// Example: 15.263063524590164
        /// </summary>
        /// <example>15.263063524590164</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trade24hChangePercent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Trade24hChangePercent { get; set; }

        /// <summary>
        /// Number of sell trades in last 24h<br/>
        /// Example: 223845
        /// </summary>
        /// <example>223845</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sell24h")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Sell24h { get; set; }

        /// <summary>
        /// Number of sell trades in previous 24h<br/>
        /// Example: 191979
        /// </summary>
        /// <example>191979</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sellHistory24h")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SellHistory24h { get; set; }

        /// <summary>
        /// 24h change in sell trades (percent)<br/>
        /// Example: 16.598690481771445
        /// </summary>
        /// <example>16.598690481771445</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sell24hChangePercent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Sell24hChangePercent { get; set; }

        /// <summary>
        /// Number of buy trades in last 24h<br/>
        /// Example: 226142
        /// </summary>
        /// <example>226142</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("buy24h")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Buy24h { get; set; }

        /// <summary>
        /// Number of buy trades in previous 24h<br/>
        /// Example: 198421
        /// </summary>
        /// <example>198421</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("buyHistory24h")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BuyHistory24h { get; set; }

        /// <summary>
        /// 24h change in buy trades (percent)<br/>
        /// Example: 13.970799461750522
        /// </summary>
        /// <example>13.970799461750522</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("buy24hChangePercent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Buy24hChangePercent { get; set; }

        /// <summary>
        /// 24h trading volume (token units)<br/>
        /// Example: 2456470915352.043
        /// </summary>
        /// <example>2456470915352.043</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("v24h")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double V24h { get; set; }

        /// <summary>
        /// 24h trading volume in USD<br/>
        /// Example: 69961943.60091284
        /// </summary>
        /// <example>69961943.60091284</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("v24hUSD")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double V24hUSD { get; set; }

        /// <summary>
        /// Previous 24h trading volume (token units)<br/>
        /// Example: 1849367819551.6223
        /// </summary>
        /// <example>1849367819551.6223</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vHistory24h")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double VHistory24h { get; set; }

        /// <summary>
        /// Previous 24h trading volume in USD<br/>
        /// Example: 49529721.91224754
        /// </summary>
        /// <example>49529721.91224754</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vHistory24hUSD")]
        public double? VHistory24hUSD { get; set; }

        /// <summary>
        /// 24h change in volume (percent)<br/>
        /// Example: 32.82760137718911
        /// </summary>
        /// <example>32.82760137718911</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("v24hChangePercent")]
        public double? V24hChangePercent { get; set; }

        /// <summary>
        /// 24h buy volume (token units)<br/>
        /// Example: 1267704208631.2197
        /// </summary>
        /// <example>1267704208631.2197</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vBuy24h")]
        public double? VBuy24h { get; set; }

        /// <summary>
        /// 24h buy volume in USD<br/>
        /// Example: 35985775.23314727
        /// </summary>
        /// <example>35985775.23314727</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vBuy24hUSD")]
        public double? VBuy24hUSD { get; set; }

        /// <summary>
        /// Previous 24h buy volume (token units)<br/>
        /// Example: 926415751610.5529
        /// </summary>
        /// <example>926415751610.5529</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vBuyHistory24h")]
        public double? VBuyHistory24h { get; set; }

        /// <summary>
        /// Previous 24h buy volume in USD<br/>
        /// Example: 24916558.31987226
        /// </summary>
        /// <example>24916558.31987226</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vBuyHistory24hUSD")]
        public double? VBuyHistory24hUSD { get; set; }

        /// <summary>
        /// 24h change in buy volume (percent)<br/>
        /// Example: 36.83966474310746
        /// </summary>
        /// <example>36.83966474310746</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vBuy24hChangePercent")]
        public double? VBuy24hChangePercent { get; set; }

        /// <summary>
        /// 24h sell volume (token units)<br/>
        /// Example: 1188766706720.8232
        /// </summary>
        /// <example>1188766706720.8232</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vSell24h")]
        public double? VSell24h { get; set; }

        /// <summary>
        /// 24h sell volume in USD<br/>
        /// Example: 33976168.367765576
        /// </summary>
        /// <example>33976168.367765576</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vSell24hUSD")]
        public double? VSell24hUSD { get; set; }

        /// <summary>
        /// Previous 24h sell volume (token units)<br/>
        /// Example: 922952067941.0695
        /// </summary>
        /// <example>922952067941.0695</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vSellHistory24h")]
        public double? VSellHistory24h { get; set; }

        /// <summary>
        /// Previous 24h sell volume in USD<br/>
        /// Example: 24613163.592375275
        /// </summary>
        /// <example>24613163.592375275</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vSellHistory24hUSD")]
        public double? VSellHistory24hUSD { get; set; }

        /// <summary>
        /// 24h change in sell volume (percent)<br/>
        /// Example: 28.800481413161105
        /// </summary>
        /// <example>28.800481413161105</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vSell24hChangePercent")]
        public double? VSell24hChangePercent { get; set; }

        /// <summary>
        /// Number of markets the token is traded on<br/>
        /// Example: 317
        /// </summary>
        /// <example>317</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberMarkets")]
        public int? NumberMarkets { get; set; }

        /// <summary>
        /// Total volume of coin traded (all time)<br/>
        /// Example: 158766463.26959822
        /// </summary>
        /// <example>158766463.26959822</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalVolume")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalVolume { get; set; }

        /// <summary>
        /// Total volume of coin traded in USD (all time)<br/>
        /// Example: 20188521260.405678
        /// </summary>
        /// <example>20188521260.405678</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalVolumeUSD")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalVolumeUSD { get; set; }

        /// <summary>
        /// Total volume bought (all time)<br/>
        /// Example: 78227859.16098201
        /// </summary>
        /// <example>78227859.16098201</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumeBuy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double VolumeBuy { get; set; }

        /// <summary>
        /// Total volume bought in USD (all time)<br/>
        /// Example: 20188521260.405678
        /// </summary>
        /// <example>20188521260.405678</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumeBuyUSD")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double VolumeBuyUSD { get; set; }

        /// <summary>
        /// Total volume sold (all time)<br/>
        /// Example: 80538604.1086162
        /// </summary>
        /// <example>80538604.1086162</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumeSell")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double VolumeSell { get; set; }

        /// <summary>
        /// Total volume sold in USD (all time)<br/>
        /// Example: 20188521260.405678
        /// </summary>
        /// <example>20188521260.405678</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumeSellUSD")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double VolumeSellUSD { get; set; }

        /// <summary>
        /// Total number of trades (all time)<br/>
        /// Example: 258522892
        /// </summary>
        /// <example>258522892</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalTrade")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTrade { get; set; }

        /// <summary>
        /// Total number of buys (all time)<br/>
        /// Example: 87829497
        /// </summary>
        /// <example>87829497</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("buy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Buy { get; set; }

        /// <summary>
        /// Total number of sells (all time)<br/>
        /// Example: 170693395
        /// </summary>
        /// <example>170693395</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sell")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Sell { get; set; }

        /// <summary>
        /// Information about the dynamic bonding curve if one exists for the Coin
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamicBondingCurve")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.CoinInsightsDynamicBondingCurve DynamicBondingCurve { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CoinInsights" /> class.
        /// </summary>
        /// <param name="marketCap">
        /// Market capitalization in USD<br/>
        /// Example: 2625779824.994664
        /// </param>
        /// <param name="fdv">
        /// Fully diluted valuation in USD<br/>
        /// Example: 2625779824.994664
        /// </param>
        /// <param name="liquidity">
        /// Current liquidity in USD<br/>
        /// Example: 18977326.389274083
        /// </param>
        /// <param name="lastTradeUnixTime">
        /// Unix timestamp of the last trade<br/>
        /// Example: 1752620592
        /// </param>
        /// <param name="lastTradeHumanTime">
        /// ISO8601 time of the last trade<br/>
        /// Example: 2025-07-15T23:03:12
        /// </param>
        /// <param name="price">
        /// Current price in USD<br/>
        /// Example: 0.000029571022098881748
        /// </param>
        /// <param name="history24hPrice">
        /// Price 24 hours ago in USD<br/>
        /// Example: 0.000027195701160436288
        /// </param>
        /// <param name="priceChange24hPercent">
        /// 24h price change in percent<br/>
        /// Example: 8.73417796596848
        /// </param>
        /// <param name="uniqueWallet24h">
        /// Unique wallets traded in last 24h<br/>
        /// Example: 20242
        /// </param>
        /// <param name="uniqueWalletHistory24h">
        /// Unique wallets traded in previous 24h<br/>
        /// Example: 21155
        /// </param>
        /// <param name="uniqueWallet24hChangePercent">
        /// 24h change in unique wallets (percent)<br/>
        /// Example: -4.315764594658473
        /// </param>
        /// <param name="totalSupply">
        /// Total supply of the token<br/>
        /// Example: 88795707372386.03
        /// </param>
        /// <param name="circulatingSupply">
        /// Circulating supply of the token<br/>
        /// Example: 88795707372386.03
        /// </param>
        /// <param name="holder">
        /// Number of holders<br/>
        /// Example: 957291
        /// </param>
        /// <param name="trade24h">
        /// Number of trades in last 24h<br/>
        /// Example: 449987
        /// </param>
        /// <param name="tradeHistory24h">
        /// Number of trades in previous 24h<br/>
        /// Example: 390400
        /// </param>
        /// <param name="trade24hChangePercent">
        /// 24h change in trade count (percent)<br/>
        /// Example: 15.263063524590164
        /// </param>
        /// <param name="sell24h">
        /// Number of sell trades in last 24h<br/>
        /// Example: 223845
        /// </param>
        /// <param name="sellHistory24h">
        /// Number of sell trades in previous 24h<br/>
        /// Example: 191979
        /// </param>
        /// <param name="sell24hChangePercent">
        /// 24h change in sell trades (percent)<br/>
        /// Example: 16.598690481771445
        /// </param>
        /// <param name="buy24h">
        /// Number of buy trades in last 24h<br/>
        /// Example: 226142
        /// </param>
        /// <param name="buyHistory24h">
        /// Number of buy trades in previous 24h<br/>
        /// Example: 198421
        /// </param>
        /// <param name="buy24hChangePercent">
        /// 24h change in buy trades (percent)<br/>
        /// Example: 13.970799461750522
        /// </param>
        /// <param name="v24h">
        /// 24h trading volume (token units)<br/>
        /// Example: 2456470915352.043
        /// </param>
        /// <param name="v24hUSD">
        /// 24h trading volume in USD<br/>
        /// Example: 69961943.60091284
        /// </param>
        /// <param name="vHistory24h">
        /// Previous 24h trading volume (token units)<br/>
        /// Example: 1849367819551.6223
        /// </param>
        /// <param name="totalVolume">
        /// Total volume of coin traded (all time)<br/>
        /// Example: 158766463.26959822
        /// </param>
        /// <param name="totalVolumeUSD">
        /// Total volume of coin traded in USD (all time)<br/>
        /// Example: 20188521260.405678
        /// </param>
        /// <param name="volumeBuy">
        /// Total volume bought (all time)<br/>
        /// Example: 78227859.16098201
        /// </param>
        /// <param name="volumeBuyUSD">
        /// Total volume bought in USD (all time)<br/>
        /// Example: 20188521260.405678
        /// </param>
        /// <param name="volumeSell">
        /// Total volume sold (all time)<br/>
        /// Example: 80538604.1086162
        /// </param>
        /// <param name="volumeSellUSD">
        /// Total volume sold in USD (all time)<br/>
        /// Example: 20188521260.405678
        /// </param>
        /// <param name="totalTrade">
        /// Total number of trades (all time)<br/>
        /// Example: 258522892
        /// </param>
        /// <param name="buy">
        /// Total number of buys (all time)<br/>
        /// Example: 87829497
        /// </param>
        /// <param name="sell">
        /// Total number of sells (all time)<br/>
        /// Example: 170693395
        /// </param>
        /// <param name="dynamicBondingCurve">
        /// Information about the dynamic bonding curve if one exists for the Coin
        /// </param>
        /// <param name="address">
        /// The SPL token mint address<br/>
        /// Example: DezXAZ8z7PnrnRJjz3wXBoRgixCa6xjnB7YaB1pPB263
        /// </param>
        /// <param name="decimals">
        /// Number of decimals for the token<br/>
        /// Example: 5
        /// </param>
        /// <param name="symbol">
        /// The token symbol<br/>
        /// Example: BONK
        /// </param>
        /// <param name="name">
        /// The token name<br/>
        /// Example: Bonk
        /// </param>
        /// <param name="extensions">
        /// Token metadata and links
        /// </param>
        /// <param name="vHistory24hUSD">
        /// Previous 24h trading volume in USD<br/>
        /// Example: 49529721.91224754
        /// </param>
        /// <param name="v24hChangePercent">
        /// 24h change in volume (percent)<br/>
        /// Example: 32.82760137718911
        /// </param>
        /// <param name="vBuy24h">
        /// 24h buy volume (token units)<br/>
        /// Example: 1267704208631.2197
        /// </param>
        /// <param name="vBuy24hUSD">
        /// 24h buy volume in USD<br/>
        /// Example: 35985775.23314727
        /// </param>
        /// <param name="vBuyHistory24h">
        /// Previous 24h buy volume (token units)<br/>
        /// Example: 926415751610.5529
        /// </param>
        /// <param name="vBuyHistory24hUSD">
        /// Previous 24h buy volume in USD<br/>
        /// Example: 24916558.31987226
        /// </param>
        /// <param name="vBuy24hChangePercent">
        /// 24h change in buy volume (percent)<br/>
        /// Example: 36.83966474310746
        /// </param>
        /// <param name="vSell24h">
        /// 24h sell volume (token units)<br/>
        /// Example: 1188766706720.8232
        /// </param>
        /// <param name="vSell24hUSD">
        /// 24h sell volume in USD<br/>
        /// Example: 33976168.367765576
        /// </param>
        /// <param name="vSellHistory24h">
        /// Previous 24h sell volume (token units)<br/>
        /// Example: 922952067941.0695
        /// </param>
        /// <param name="vSellHistory24hUSD">
        /// Previous 24h sell volume in USD<br/>
        /// Example: 24613163.592375275
        /// </param>
        /// <param name="vSell24hChangePercent">
        /// 24h change in sell volume (percent)<br/>
        /// Example: 28.800481413161105
        /// </param>
        /// <param name="numberMarkets">
        /// Number of markets the token is traded on<br/>
        /// Example: 317
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CoinInsights(
            double marketCap,
            double fdv,
            double liquidity,
            global::System.DateTimeOffset lastTradeUnixTime,
            string lastTradeHumanTime,
            double price,
            double history24hPrice,
            double priceChange24hPercent,
            int uniqueWallet24h,
            int uniqueWalletHistory24h,
            double uniqueWallet24hChangePercent,
            double totalSupply,
            double circulatingSupply,
            int holder,
            int trade24h,
            int tradeHistory24h,
            double trade24hChangePercent,
            int sell24h,
            int sellHistory24h,
            double sell24hChangePercent,
            int buy24h,
            int buyHistory24h,
            double buy24hChangePercent,
            double v24h,
            double v24hUSD,
            double vHistory24h,
            double totalVolume,
            double totalVolumeUSD,
            double volumeBuy,
            double volumeBuyUSD,
            double volumeSell,
            double volumeSellUSD,
            int totalTrade,
            int buy,
            int sell,
            global::Audius.CoinInsightsDynamicBondingCurve dynamicBondingCurve,
            string? address,
            int? decimals,
            string? symbol,
            string? name,
            global::Audius.CoinInsightsExtensions? extensions,
            double? vHistory24hUSD,
            double? v24hChangePercent,
            double? vBuy24h,
            double? vBuy24hUSD,
            double? vBuyHistory24h,
            double? vBuyHistory24hUSD,
            double? vBuy24hChangePercent,
            double? vSell24h,
            double? vSell24hUSD,
            double? vSellHistory24h,
            double? vSellHistory24hUSD,
            double? vSell24hChangePercent,
            int? numberMarkets)
        {
            this.Address = address;
            this.Decimals = decimals;
            this.Symbol = symbol;
            this.Name = name;
            this.MarketCap = marketCap;
            this.Fdv = fdv;
            this.Extensions = extensions;
            this.Liquidity = liquidity;
            this.LastTradeUnixTime = lastTradeUnixTime;
            this.LastTradeHumanTime = lastTradeHumanTime ?? throw new global::System.ArgumentNullException(nameof(lastTradeHumanTime));
            this.Price = price;
            this.History24hPrice = history24hPrice;
            this.PriceChange24hPercent = priceChange24hPercent;
            this.UniqueWallet24h = uniqueWallet24h;
            this.UniqueWalletHistory24h = uniqueWalletHistory24h;
            this.UniqueWallet24hChangePercent = uniqueWallet24hChangePercent;
            this.TotalSupply = totalSupply;
            this.CirculatingSupply = circulatingSupply;
            this.Holder = holder;
            this.Trade24h = trade24h;
            this.TradeHistory24h = tradeHistory24h;
            this.Trade24hChangePercent = trade24hChangePercent;
            this.Sell24h = sell24h;
            this.SellHistory24h = sellHistory24h;
            this.Sell24hChangePercent = sell24hChangePercent;
            this.Buy24h = buy24h;
            this.BuyHistory24h = buyHistory24h;
            this.Buy24hChangePercent = buy24hChangePercent;
            this.V24h = v24h;
            this.V24hUSD = v24hUSD;
            this.VHistory24h = vHistory24h;
            this.VHistory24hUSD = vHistory24hUSD;
            this.V24hChangePercent = v24hChangePercent;
            this.VBuy24h = vBuy24h;
            this.VBuy24hUSD = vBuy24hUSD;
            this.VBuyHistory24h = vBuyHistory24h;
            this.VBuyHistory24hUSD = vBuyHistory24hUSD;
            this.VBuy24hChangePercent = vBuy24hChangePercent;
            this.VSell24h = vSell24h;
            this.VSell24hUSD = vSell24hUSD;
            this.VSellHistory24h = vSellHistory24h;
            this.VSellHistory24hUSD = vSellHistory24hUSD;
            this.VSell24hChangePercent = vSell24hChangePercent;
            this.NumberMarkets = numberMarkets;
            this.TotalVolume = totalVolume;
            this.TotalVolumeUSD = totalVolumeUSD;
            this.VolumeBuy = volumeBuy;
            this.VolumeBuyUSD = volumeBuyUSD;
            this.VolumeSell = volumeSell;
            this.VolumeSellUSD = volumeSellUSD;
            this.TotalTrade = totalTrade;
            this.Buy = buy;
            this.Sell = sell;
            this.DynamicBondingCurve = dynamicBondingCurve ?? throw new global::System.ArgumentNullException(nameof(dynamicBondingCurve));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoinInsights" /> class.
        /// </summary>
        public CoinInsights()
        {
        }

    }
}