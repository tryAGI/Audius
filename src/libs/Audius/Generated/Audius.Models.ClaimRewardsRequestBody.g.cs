
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClaimRewardsRequestBody
    {
        /// <summary>
        /// The challenge ID to filter rewards (optional)<br/>
        /// Example: u
        /// </summary>
        /// <example>u</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("challengeId")]
        public string? ChallengeId { get; set; }

        /// <summary>
        /// The specifier to filter rewards (optional)<br/>
        /// Example: 7eP5n
        /// </summary>
        /// <example>7eP5n</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("specifier")]
        public string? Specifier { get; set; }

        /// <summary>
        /// The user ID to claim rewards for<br/>
        /// Example: 7eP5n
        /// </summary>
        /// <example>7eP5n</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimRewardsRequestBody" /> class.
        /// </summary>
        /// <param name="userId">
        /// The user ID to claim rewards for<br/>
        /// Example: 7eP5n
        /// </param>
        /// <param name="challengeId">
        /// The challenge ID to filter rewards (optional)<br/>
        /// Example: u
        /// </param>
        /// <param name="specifier">
        /// The specifier to filter rewards (optional)<br/>
        /// Example: 7eP5n
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClaimRewardsRequestBody(
            string userId,
            string? challengeId,
            string? specifier)
        {
            this.ChallengeId = challengeId;
            this.Specifier = specifier;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimRewardsRequestBody" /> class.
        /// </summary>
        public ClaimRewardsRequestBody()
        {
        }

    }
}