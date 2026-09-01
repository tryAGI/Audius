
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AlbumBacklink
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PlaylistId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlaylistName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permalink")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Permalink { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlbumBacklink" /> class.
        /// </summary>
        /// <param name="playlistId"></param>
        /// <param name="playlistName"></param>
        /// <param name="permalink"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlbumBacklink(
            int playlistId,
            string playlistName,
            string permalink)
        {
            this.PlaylistId = playlistId;
            this.PlaylistName = playlistName ?? throw new global::System.ArgumentNullException(nameof(playlistName));
            this.Permalink = permalink ?? throw new global::System.ArgumentNullException(nameof(permalink));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlbumBacklink" /> class.
        /// </summary>
        public AlbumBacklink()
        {
        }

    }
}