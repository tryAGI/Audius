
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TierChangeNotificationActionData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_tier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewTier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrentValue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_tier_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NewTierValue { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TierChangeNotificationActionData" /> class.
        /// </summary>
        /// <param name="newTier"></param>
        /// <param name="currentValue"></param>
        /// <param name="newTierValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TierChangeNotificationActionData(
            string newTier,
            string currentValue,
            int newTierValue)
        {
            this.NewTier = newTier ?? throw new global::System.ArgumentNullException(nameof(newTier));
            this.CurrentValue = currentValue ?? throw new global::System.ArgumentNullException(nameof(currentValue));
            this.NewTierValue = newTierValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TierChangeNotificationActionData" /> class.
        /// </summary>
        public TierChangeNotificationActionData()
        {
        }

    }
}