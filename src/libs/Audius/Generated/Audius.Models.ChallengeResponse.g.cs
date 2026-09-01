
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChallengeResponse
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
        public string? Specifier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_complete")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsComplete { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsActive { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_disbursed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDisbursed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_step_count")]
        public int? CurrentStepCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_steps")]
        public int? MaxSteps { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("challenge_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChallengeType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Amount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disbursed_amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DisbursedAmount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cooldown_days")]
        public int? CooldownDays { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metadata { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChallengeResponse" /> class.
        /// </summary>
        /// <param name="challengeId"></param>
        /// <param name="userId"></param>
        /// <param name="isComplete"></param>
        /// <param name="isActive"></param>
        /// <param name="isDisbursed"></param>
        /// <param name="challengeType"></param>
        /// <param name="amount"></param>
        /// <param name="disbursedAmount"></param>
        /// <param name="metadata"></param>
        /// <param name="specifier"></param>
        /// <param name="currentStepCount"></param>
        /// <param name="maxSteps"></param>
        /// <param name="cooldownDays"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChallengeResponse(
            string challengeId,
            string userId,
            bool isComplete,
            bool isActive,
            bool isDisbursed,
            string challengeType,
            string amount,
            int disbursedAmount,
            object metadata,
            string? specifier,
            int? currentStepCount,
            int? maxSteps,
            int? cooldownDays)
        {
            this.ChallengeId = challengeId ?? throw new global::System.ArgumentNullException(nameof(challengeId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Specifier = specifier;
            this.IsComplete = isComplete;
            this.IsActive = isActive;
            this.IsDisbursed = isDisbursed;
            this.CurrentStepCount = currentStepCount;
            this.MaxSteps = maxSteps;
            this.ChallengeType = challengeType ?? throw new global::System.ArgumentNullException(nameof(challengeType));
            this.Amount = amount ?? throw new global::System.ArgumentNullException(nameof(amount));
            this.DisbursedAmount = disbursedAmount;
            this.CooldownDays = cooldownDays;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChallengeResponse" /> class.
        /// </summary>
        public ChallengeResponse()
        {
        }

    }
}