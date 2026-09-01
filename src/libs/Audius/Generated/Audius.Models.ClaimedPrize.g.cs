
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClaimedPrize
    {
        /// <summary>
        /// The unique identifier of the claimed prize record<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The wallet address that claimed the prize<br/>
        /// Example: HLnpSz9h2S4hiLQ43rnSD9XkcUThA7B8hQMKmDaiTLcC
        /// </summary>
        /// <example>HLnpSz9h2S4hiLQ43rnSD9XkcUThA7B8hQMKmDaiTLcC</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("wallet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Wallet { get; set; }

        /// <summary>
        /// The transaction signature used to claim the prize<br/>
        /// Example: 5j7s1QjmRKFuDbCWMRVRNibSV2VAAEcNKP6HWU7GwPdXkBZvhz8n4vQl7bBq8tN4Rz9x1Kj3mP5wQ8rT2Y6zA
        /// </summary>
        /// <example>5j7s1QjmRKFuDbCWMRVRNibSV2VAAEcNKP6HWU7GwPdXkBZvhz8n4vQl7bBq8tN4Rz9x1Kj3mP5wQ8rT2Y6zA</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Signature { get; set; }

        /// <summary>
        /// The coin mint address used for the claim<br/>
        /// Example: ZDaUDL4XFdEct7UgeztrFQAptsvh4ZdhyZDZ1RpxYAK
        /// </summary>
        /// <example>ZDaUDL4XFdEct7UgeztrFQAptsvh4ZdhyZDZ1RpxYAK</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Mint { get; set; }

        /// <summary>
        /// The amount paid to claim the prize (in smallest unit, e.g., lamports)<br/>
        /// Example: 2000000000
        /// </summary>
        /// <example>2000000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Amount { get; set; }

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
        /// The type of prize (e.g., "coin_airdrop", "download")<br/>
        /// Example: coin_airdrop
        /// </summary>
        /// <example>coin_airdrop</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prize_type")]
        public string? PrizeType { get; set; }

        /// <summary>
        /// When the prize was claimed<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimedPrize" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the claimed prize record<br/>
        /// Example: 1
        /// </param>
        /// <param name="wallet">
        /// The wallet address that claimed the prize<br/>
        /// Example: HLnpSz9h2S4hiLQ43rnSD9XkcUThA7B8hQMKmDaiTLcC
        /// </param>
        /// <param name="signature">
        /// The transaction signature used to claim the prize<br/>
        /// Example: 5j7s1QjmRKFuDbCWMRVRNibSV2VAAEcNKP6HWU7GwPdXkBZvhz8n4vQl7bBq8tN4Rz9x1Kj3mP5wQ8rT2Y6zA
        /// </param>
        /// <param name="mint">
        /// The coin mint address used for the claim<br/>
        /// Example: ZDaUDL4XFdEct7UgeztrFQAptsvh4ZdhyZDZ1RpxYAK
        /// </param>
        /// <param name="amount">
        /// The amount paid to claim the prize (in smallest unit, e.g., lamports)<br/>
        /// Example: 2000000000
        /// </param>
        /// <param name="prizeId">
        /// The unique identifier of the prize won<br/>
        /// Example: prize_1_yak_airdrop
        /// </param>
        /// <param name="prizeName">
        /// The name of the prize won<br/>
        /// Example: 1 YAK Airdrop
        /// </param>
        /// <param name="createdAt">
        /// When the prize was claimed<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </param>
        /// <param name="prizeType">
        /// The type of prize (e.g., "coin_airdrop", "download")<br/>
        /// Example: coin_airdrop
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClaimedPrize(
            int id,
            string wallet,
            string signature,
            string mint,
            int amount,
            string prizeId,
            string prizeName,
            global::System.DateTime createdAt,
            string? prizeType)
        {
            this.Id = id;
            this.Wallet = wallet ?? throw new global::System.ArgumentNullException(nameof(wallet));
            this.Signature = signature ?? throw new global::System.ArgumentNullException(nameof(signature));
            this.Mint = mint ?? throw new global::System.ArgumentNullException(nameof(mint));
            this.Amount = amount;
            this.PrizeId = prizeId ?? throw new global::System.ArgumentNullException(nameof(prizeId));
            this.PrizeName = prizeName ?? throw new global::System.ArgumentNullException(nameof(prizeName));
            this.PrizeType = prizeType;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimedPrize" /> class.
        /// </summary>
        public ClaimedPrize()
        {
        }

    }
}