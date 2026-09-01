
#nullable enable

namespace Audius
{
    /// <summary>
    /// Reference to an explore playlist
    /// </summary>
    public sealed partial class PlaylistLibraryExplorePlaylistIdentifier
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.PlaylistLibraryExplorePlaylistIdentifierTypeJsonConverter))]
        public global::Audius.PlaylistLibraryExplorePlaylistIdentifierType Type { get; set; }

        /// <summary>
        /// Explore playlist identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlaylistId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistLibraryExplorePlaylistIdentifier" /> class.
        /// </summary>
        /// <param name="playlistId">
        /// Explore playlist identifier
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaylistLibraryExplorePlaylistIdentifier(
            string playlistId,
            global::Audius.PlaylistLibraryExplorePlaylistIdentifierType type)
        {
            this.Type = type;
            this.PlaylistId = playlistId ?? throw new global::System.ArgumentNullException(nameof(playlistId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistLibraryExplorePlaylistIdentifier" /> class.
        /// </summary>
        public PlaylistLibraryExplorePlaylistIdentifier()
        {
        }

    }
}