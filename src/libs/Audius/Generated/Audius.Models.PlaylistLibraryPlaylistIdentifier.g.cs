
#nullable enable

namespace Audius
{
    /// <summary>
    /// Reference to a playlist
    /// </summary>
    public sealed partial class PlaylistLibraryPlaylistIdentifier
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.PlaylistLibraryPlaylistIdentifierTypeJsonConverter))]
        public global::Audius.PlaylistLibraryPlaylistIdentifierType Type { get; set; }

        /// <summary>
        /// Playlist ID<br/>
        /// Example: 1234
        /// </summary>
        /// <example>1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PlaylistId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistLibraryPlaylistIdentifier" /> class.
        /// </summary>
        /// <param name="playlistId">
        /// Playlist ID<br/>
        /// Example: 1234
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaylistLibraryPlaylistIdentifier(
            int playlistId,
            global::Audius.PlaylistLibraryPlaylistIdentifierType type)
        {
            this.Type = type;
            this.PlaylistId = playlistId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistLibraryPlaylistIdentifier" /> class.
        /// </summary>
        public PlaylistLibraryPlaylistIdentifier()
        {
        }

    }
}