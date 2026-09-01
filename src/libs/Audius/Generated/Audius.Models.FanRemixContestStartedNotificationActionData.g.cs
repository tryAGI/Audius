
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FanRemixContestStartedNotificationActionData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FanRemixContestStartedNotificationActionData" /> class.
        /// </summary>
        /// <param name="entityUserId"></param>
        /// <param name="entityId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FanRemixContestStartedNotificationActionData(
            string entityUserId,
            string entityId)
        {
            this.EntityUserId = entityUserId ?? throw new global::System.ArgumentNullException(nameof(entityUserId));
            this.EntityId = entityId ?? throw new global::System.ArgumentNullException(nameof(entityId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FanRemixContestStartedNotificationActionData" /> class.
        /// </summary>
        public FanRemixContestStartedNotificationActionData()
        {
        }

    }
}