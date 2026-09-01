
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PlaylistUpdate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlaylistId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_seen_at")]
        public int? LastSeenAt { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistUpdate" /> class.
        /// </summary>
        /// <param name="playlistId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="lastSeenAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaylistUpdate(
            string playlistId,
            int updatedAt,
            int? lastSeenAt)
        {
            this.PlaylistId = playlistId ?? throw new global::System.ArgumentNullException(nameof(playlistId));
            this.UpdatedAt = updatedAt;
            this.LastSeenAt = lastSeenAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistUpdate" /> class.
        /// </summary>
        public PlaylistUpdate()
        {
        }

    }
}