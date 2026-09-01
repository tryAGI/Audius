
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PrizeClaimResponse
    {
        /// <summary>
        /// The unique identifier of the prize won<br/>
        /// Example: prize_1_yak_airdrop
        /// </summary>
        /// <example>prize_1_yak_airdrop</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prize_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrizeId { get; set; }

        /// <summary>
        /// The name of the prize won<br/>
        /// Example: 1 YAK Airdrop
        /// </summary>
        /// <example>1 YAK Airdrop</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prize_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrizeName { get; set; }

        /// <summary>
        /// The wallet address that claimed the prize<br/>
        /// Example: HLnpSz9h2S4hiLQ43rnSD9XkcUThA7B8hQMKmDaiTLcC
        /// </summary>
        /// <example>HLnpSz9h2S4hiLQ43rnSD9XkcUThA7B8hQMKmDaiTLcC</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("wallet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Wallet { get; set; }

        /// <summary>
        /// The type of prize (e.g., "coin_airdrop", "download")<br/>
        /// Example: coin_airdrop
        /// </summary>
        /// <example>coin_airdrop</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prize_type")]
        public string? PrizeType { get; set; }

        /// <summary>
        /// Prize-specific action data (e.g., redeem code/URL for coin airdrops, download URL for downloads)<br/>
        /// Example: {"code":"aB3d5F","url":"/coins/YAK/redeem/aB3d5F"}
        /// </summary>
        /// <example>{"code":"aB3d5F","url":"/coins/YAK/redeem/aB3d5F"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("action_data")]
        public object? ActionData { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrizeClaimResponse" /> class.
        /// </summary>
        /// <param name="prizeId">
        /// The unique identifier of the prize won<br/>
        /// Example: prize_1_yak_airdrop
        /// </param>
        /// <param name="prizeName">
        /// The name of the prize won<br/>
        /// Example: 1 YAK Airdrop
        /// </param>
        /// <param name="wallet">
        /// The wallet address that claimed the prize<br/>
        /// Example: HLnpSz9h2S4hiLQ43rnSD9XkcUThA7B8hQMKmDaiTLcC
        /// </param>
        /// <param name="prizeType">
        /// The type of prize (e.g., "coin_airdrop", "download")<br/>
        /// Example: coin_airdrop
        /// </param>
        /// <param name="actionData">
        /// Prize-specific action data (e.g., redeem code/URL for coin airdrops, download URL for downloads)<br/>
        /// Example: {"code":"aB3d5F","url":"/coins/YAK/redeem/aB3d5F"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrizeClaimResponse(
            string prizeId,
            string prizeName,
            string wallet,
            string? prizeType,
            object? actionData)
        {
            this.PrizeId = prizeId ?? throw new global::System.ArgumentNullException(nameof(prizeId));
            this.PrizeName = prizeName ?? throw new global::System.ArgumentNullException(nameof(prizeName));
            this.Wallet = wallet ?? throw new global::System.ArgumentNullException(nameof(wallet));
            this.PrizeType = prizeType;
            this.ActionData = actionData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrizeClaimResponse" /> class.
        /// </summary>
        public PrizeClaimResponse()
        {
        }

    }
}