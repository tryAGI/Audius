
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClaimRewardsResponseDataItem
    {
        /// <summary>
        /// The challenge ID<br/>
        /// Example: u
        /// </summary>
        /// <example>u</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("challengeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChallengeId { get; set; }

        /// <summary>
        /// The challenge specifier<br/>
        /// Example: 7eP5n
        /// </summary>
        /// <example>7eP5n</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("specifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Specifier { get; set; }

        /// <summary>
        /// The reward amount<br/>
        /// Example: 1000000000
        /// </summary>
        /// <example>1000000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public string? Amount { get; set; }

        /// <summary>
        /// Transaction signatures<br/>
        /// Example: [5j7s1QjmRKFuDbCWMRVRNibSV2VAAEcNKP6HWU7GwPdXkBZvhz8n4vQl7bBq8tN4Rz9x1Kj3mP5wQ8rT2Y6zA]
        /// </summary>
        /// <example>[5j7s1QjmRKFuDbCWMRVRNibSV2VAAEcNKP6HWU7GwPdXkBZvhz8n4vQl7bBq8tN4Rz9x1Kj3mP5wQ8rT2Y6zA]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("signatures")]
        public global::System.Collections.Generic.IList<string>? Signatures { get; set; }

        /// <summary>
        /// Error message if claim failed<br/>
        /// Example: Insufficient balance
        /// </summary>
        /// <example>Insufficient balance</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimRewardsResponseDataItem" /> class.
        /// </summary>
        /// <param name="challengeId">
        /// The challenge ID<br/>
        /// Example: u
        /// </param>
        /// <param name="specifier">
        /// The challenge specifier<br/>
        /// Example: 7eP5n
        /// </param>
        /// <param name="amount">
        /// The reward amount<br/>
        /// Example: 1000000000
        /// </param>
        /// <param name="signatures">
        /// Transaction signatures<br/>
        /// Example: [5j7s1QjmRKFuDbCWMRVRNibSV2VAAEcNKP6HWU7GwPdXkBZvhz8n4vQl7bBq8tN4Rz9x1Kj3mP5wQ8rT2Y6zA]
        /// </param>
        /// <param name="error">
        /// Error message if claim failed<br/>
        /// Example: Insufficient balance
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClaimRewardsResponseDataItem(
            string challengeId,
            string specifier,
            string? amount,
            global::System.Collections.Generic.IList<string>? signatures,
            string? error)
        {
            this.ChallengeId = challengeId ?? throw new global::System.ArgumentNullException(nameof(challengeId));
            this.Specifier = specifier ?? throw new global::System.ArgumentNullException(nameof(specifier));
            this.Amount = amount;
            this.Signatures = signatures;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimRewardsResponseDataItem" /> class.
        /// </summary>
        public ClaimRewardsResponseDataItem()
        {
        }

    }
}