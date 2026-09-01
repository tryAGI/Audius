
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClaimableRewardNotificationActionData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Amount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("specifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Specifier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("challenge_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChallengeId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimableRewardNotificationActionData" /> class.
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="specifier"></param>
        /// <param name="challengeId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClaimableRewardNotificationActionData(
            string amount,
            string specifier,
            string challengeId)
        {
            this.Amount = amount ?? throw new global::System.ArgumentNullException(nameof(amount));
            this.Specifier = specifier ?? throw new global::System.ArgumentNullException(nameof(specifier));
            this.ChallengeId = challengeId ?? throw new global::System.ArgumentNullException(nameof(challengeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimableRewardNotificationActionData" /> class.
        /// </summary>
        public ClaimableRewardNotificationActionData()
        {
        }

    }
}