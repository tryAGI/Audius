
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrackAddedToPlaylistNotificationActionData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrackId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlaylistId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlaylistOwnerId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackAddedToPlaylistNotificationActionData" /> class.
        /// </summary>
        /// <param name="trackId"></param>
        /// <param name="playlistId"></param>
        /// <param name="playlistOwnerId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackAddedToPlaylistNotificationActionData(
            string trackId,
            string playlistId,
            string playlistOwnerId)
        {
            this.TrackId = trackId ?? throw new global::System.ArgumentNullException(nameof(trackId));
            this.PlaylistId = playlistId ?? throw new global::System.ArgumentNullException(nameof(playlistId));
            this.PlaylistOwnerId = playlistOwnerId ?? throw new global::System.ArgumentNullException(nameof(playlistOwnerId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackAddedToPlaylistNotificationActionData" /> class.
        /// </summary>
        public TrackAddedToPlaylistNotificationActionData()
        {
        }

    }
}