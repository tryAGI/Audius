
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ArtistRemixContestEndedNotificationActionData
    {
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
        /// Initializes a new instance of the <see cref="ArtistRemixContestEndedNotificationActionData" /> class.
        /// </summary>
        /// <param name="entityId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArtistRemixContestEndedNotificationActionData(
            string entityId)
        {
            this.EntityId = entityId ?? throw new global::System.ArgumentNullException(nameof(entityId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtistRemixContestEndedNotificationActionData" /> class.
        /// </summary>
        public ArtistRemixContestEndedNotificationActionData()
        {
        }

    }
}