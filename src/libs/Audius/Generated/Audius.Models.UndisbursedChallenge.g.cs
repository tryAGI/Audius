
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UndisbursedChallenge
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("challenge_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChallengeId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("specifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Specifier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Amount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_blocknumber")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletedBlocknumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Handle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wallet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Wallet { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CompletedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cooldown_days")]
        public int? CooldownDays { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UndisbursedChallenge" /> class.
        /// </summary>
        /// <param name="challengeId"></param>
        /// <param name="userId"></param>
        /// <param name="specifier"></param>
        /// <param name="amount"></param>
        /// <param name="completedBlocknumber"></param>
        /// <param name="handle"></param>
        /// <param name="wallet"></param>
        /// <param name="createdAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="cooldownDays"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UndisbursedChallenge(
            string challengeId,
            string userId,
            string specifier,
            string amount,
            int completedBlocknumber,
            string handle,
            string wallet,
            string createdAt,
            string completedAt,
            int? cooldownDays)
        {
            this.ChallengeId = challengeId ?? throw new global::System.ArgumentNullException(nameof(challengeId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Specifier = specifier ?? throw new global::System.ArgumentNullException(nameof(specifier));
            this.Amount = amount ?? throw new global::System.ArgumentNullException(nameof(amount));
            this.CompletedBlocknumber = completedBlocknumber;
            this.Handle = handle ?? throw new global::System.ArgumentNullException(nameof(handle));
            this.Wallet = wallet ?? throw new global::System.ArgumentNullException(nameof(wallet));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.CompletedAt = completedAt ?? throw new global::System.ArgumentNullException(nameof(completedAt));
            this.CooldownDays = cooldownDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UndisbursedChallenge" /> class.
        /// </summary>
        public UndisbursedChallenge()
        {
        }

    }
}