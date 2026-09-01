
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ArtistRemixContestSubmissionsNotificationActionData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("milestone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Milestone { get; set; }

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
        /// Initializes a new instance of the <see cref="ArtistRemixContestSubmissionsNotificationActionData" /> class.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="milestone"></param>
        /// <param name="entityId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArtistRemixContestSubmissionsNotificationActionData(
            string eventId,
            int milestone,
            string entityId)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Milestone = milestone;
            this.EntityId = entityId ?? throw new global::System.ArgumentNullException(nameof(entityId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtistRemixContestSubmissionsNotificationActionData" /> class.
        /// </summary>
        public ArtistRemixContestSubmissionsNotificationActionData()
        {
        }

    }
}