
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PlaylistAddedTimestamp
    {
        /// <summary>
        /// Optional. Metadata timestamp for when the track was added to the playlist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_timestamp")]
        public int? MetadataTimestamp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Timestamp { get; set; }

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
        /// Initializes a new instance of the <see cref="PlaylistAddedTimestamp" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="trackId"></param>
        /// <param name="metadataTimestamp">
        /// Optional. Metadata timestamp for when the track was added to the playlist.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaylistAddedTimestamp(
            int timestamp,
            string trackId,
            int? metadataTimestamp)
        {
            this.MetadataTimestamp = metadataTimestamp;
            this.Timestamp = timestamp;
            this.TrackId = trackId ?? throw new global::System.ArgumentNullException(nameof(trackId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistAddedTimestamp" /> class.
        /// </summary>
        public PlaylistAddedTimestamp()
        {
        }

    }
}