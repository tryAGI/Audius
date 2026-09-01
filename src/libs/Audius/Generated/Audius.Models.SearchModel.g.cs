
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Audius.User> Users { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followed_users")]
        public global::System.Collections.Generic.IList<global::Audius.User>? FollowedUsers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Audius.SearchTrack> Tracks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saved_tracks")]
        public global::System.Collections.Generic.IList<global::Audius.SearchTrack>? SavedTracks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlists")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Audius.SearchPlaylist> Playlists { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saved_playlists")]
        public global::System.Collections.Generic.IList<global::Audius.SearchPlaylist>? SavedPlaylists { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("albums")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Audius.SearchPlaylist> Albums { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saved_albums")]
        public global::System.Collections.Generic.IList<global::Audius.SearchPlaylist>? SavedAlbums { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchModel" /> class.
        /// </summary>
        /// <param name="users"></param>
        /// <param name="tracks"></param>
        /// <param name="playlists"></param>
        /// <param name="albums"></param>
        /// <param name="followedUsers"></param>
        /// <param name="savedTracks"></param>
        /// <param name="savedPlaylists"></param>
        /// <param name="savedAlbums"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchModel(
            global::System.Collections.Generic.IList<global::Audius.User> users,
            global::System.Collections.Generic.IList<global::Audius.SearchTrack> tracks,
            global::System.Collections.Generic.IList<global::Audius.SearchPlaylist> playlists,
            global::System.Collections.Generic.IList<global::Audius.SearchPlaylist> albums,
            global::System.Collections.Generic.IList<global::Audius.User>? followedUsers,
            global::System.Collections.Generic.IList<global::Audius.SearchTrack>? savedTracks,
            global::System.Collections.Generic.IList<global::Audius.SearchPlaylist>? savedPlaylists,
            global::System.Collections.Generic.IList<global::Audius.SearchPlaylist>? savedAlbums)
        {
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
            this.FollowedUsers = followedUsers;
            this.Tracks = tracks ?? throw new global::System.ArgumentNullException(nameof(tracks));
            this.SavedTracks = savedTracks;
            this.Playlists = playlists ?? throw new global::System.ArgumentNullException(nameof(playlists));
            this.SavedPlaylists = savedPlaylists;
            this.Albums = albums ?? throw new global::System.ArgumentNullException(nameof(albums));
            this.SavedAlbums = savedAlbums;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchModel" /> class.
        /// </summary>
        public SearchModel()
        {
        }

    }
}