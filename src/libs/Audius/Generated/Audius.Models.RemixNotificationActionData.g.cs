
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RemixNotificationActionData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_track_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ParentTrackId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrackId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemixNotificationActionData" /> class.
        /// </summary>
        /// <param name="parentTrackId"></param>
        /// <param name="trackId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemixNotificationActionData(
            string parentTrackId,
            string trackId)
        {
            this.ParentTrackId = parentTrackId ?? throw new global::System.ArgumentNullException(nameof(parentTrackId));
            this.TrackId = trackId ?? throw new global::System.ArgumentNullException(nameof(trackId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemixNotificationActionData" /> class.
        /// </summary>
        public RemixNotificationActionData()
        {
        }

    }
}