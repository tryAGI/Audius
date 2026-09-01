
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PrizePublic
    {
        /// <summary>
        /// The unique identifier of the prize<br/>
        /// Example: prize_1_yak_airdrop
        /// </summary>
        /// <example>prize_1_yak_airdrop</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prize_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PrizeId { get; set; }

        /// <summary>
        /// The name of the prize<br/>
        /// Example: 1 YAK Airdrop
        /// </summary>
        /// <example>1 YAK Airdrop</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the prize<br/>
        /// Example: Win 1 YAK coin airdrop
        /// </summary>
        /// <example>Win 1 YAK coin airdrop</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Weight for random selection (higher = more likely)<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Weight { get; set; }

        /// <summary>
        /// Sanitized metadata (excludes sensitive URLs)<br/>
        /// Example: {"type":"coin_airdrop","amount":1000000000}
        /// </summary>
        /// <example>{"type":"coin_airdrop","amount":1000000000}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrizePublic" /> class.
        /// </summary>
        /// <param name="prizeId">
        /// The unique identifier of the prize<br/>
        /// Example: prize_1_yak_airdrop
        /// </param>
        /// <param name="name">
        /// The name of the prize<br/>
        /// Example: 1 YAK Airdrop
        /// </param>
        /// <param name="weight">
        /// Weight for random selection (higher = more likely)<br/>
        /// Example: 1
        /// </param>
        /// <param name="description">
        /// Description of the prize<br/>
        /// Example: Win 1 YAK coin airdrop
        /// </param>
        /// <param name="metadata">
        /// Sanitized metadata (excludes sensitive URLs)<br/>
        /// Example: {"type":"coin_airdrop","amount":1000000000}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrizePublic(
            string prizeId,
            string name,
            int weight,
            string? description,
            object? metadata)
        {
            this.PrizeId = prizeId ?? throw new global::System.ArgumentNullException(nameof(prizeId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Weight = weight;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrizePublic" /> class.
        /// </summary>
        public PrizePublic()
        {
        }

    }
}