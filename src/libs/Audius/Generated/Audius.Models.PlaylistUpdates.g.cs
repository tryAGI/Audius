
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PlaylistUpdates
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_updates")]
        public global::System.Collections.Generic.IList<global::Audius.PlaylistUpdate>? PlaylistUpdates1 { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistUpdates" /> class.
        /// </summary>
        /// <param name="playlistUpdates1"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaylistUpdates(
            global::System.Collections.Generic.IList<global::Audius.PlaylistUpdate>? playlistUpdates1)
        {
            this.PlaylistUpdates1 = playlistUpdates1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistUpdates" /> class.
        /// </summary>
        public PlaylistUpdates()
        {
        }

    }
}