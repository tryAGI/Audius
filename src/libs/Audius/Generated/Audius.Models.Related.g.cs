
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Related
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<global::Audius.User>? Users { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks")]
        public global::System.Collections.Generic.IList<global::Audius.Track>? Tracks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlists")]
        public global::System.Collections.Generic.IList<global::Audius.Playlist>? Playlists { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Related" /> class.
        /// </summary>
        /// <param name="users"></param>
        /// <param name="tracks"></param>
        /// <param name="playlists"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Related(
            global::System.Collections.Generic.IList<global::Audius.User>? users,
            global::System.Collections.Generic.IList<global::Audius.Track>? tracks,
            global::System.Collections.Generic.IList<global::Audius.Playlist>? playlists)
        {
            this.Users = users;
            this.Tracks = tracks;
            this.Playlists = playlists;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Related" /> class.
        /// </summary>
        public Related()
        {
        }

    }
}