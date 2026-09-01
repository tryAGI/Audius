
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreatePlaylistNotificationActionData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_album")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAlbum { get; set; }

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="CreatePlaylistNotificationActionData" /> class.
        /// </summary>
        /// <param name="isAlbum"></param>
        /// <param name="playlistId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePlaylistNotificationActionData(
            bool isAlbum,
            string playlistId)
        {
            this.IsAlbum = isAlbum;
            this.PlaylistId = playlistId ?? throw new global::System.ArgumentNullException(nameof(playlistId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePlaylistNotificationActionData" /> class.
        /// </summary>
        public CreatePlaylistNotificationActionData()
        {
        }

    }
}