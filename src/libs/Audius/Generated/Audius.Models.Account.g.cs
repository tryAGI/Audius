
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Account
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.User User { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlists")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Audius.AccountCollection> Playlists { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_library")]
        public global::Audius.PlaylistLibrary? PlaylistLibrary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_save_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TrackSaveCount { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="playlists"></param>
        /// <param name="trackSaveCount"></param>
        /// <param name="playlistLibrary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Account(
            global::Audius.User user,
            global::System.Collections.Generic.IList<global::Audius.AccountCollection> playlists,
            int trackSaveCount,
            global::Audius.PlaylistLibrary? playlistLibrary)
        {
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Playlists = playlists ?? throw new global::System.ArgumentNullException(nameof(playlists));
            this.PlaylistLibrary = playlistLibrary;
            this.TrackSaveCount = trackSaveCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        public Account()
        {
        }

    }
}