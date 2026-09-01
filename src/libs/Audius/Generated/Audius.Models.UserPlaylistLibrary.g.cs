
#nullable enable

namespace Audius
{
    /// <summary>
    /// User's playlist library with support for folders and playlists
    /// </summary>
    public sealed partial class UserPlaylistLibrary
    {
        /// <summary>
        /// Array of folders and playlist identifiers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Audius.OneOf<global::Audius.PlaylistLibraryFolder, global::Audius.PlaylistLibraryPlaylistIdentifier, global::Audius.PlaylistLibraryExplorePlaylistIdentifier>> Contents { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserPlaylistLibrary" /> class.
        /// </summary>
        /// <param name="contents">
        /// Array of folders and playlist identifiers
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserPlaylistLibrary(
            global::System.Collections.Generic.IList<global::Audius.OneOf<global::Audius.PlaylistLibraryFolder, global::Audius.PlaylistLibraryPlaylistIdentifier, global::Audius.PlaylistLibraryExplorePlaylistIdentifier>> contents)
        {
            this.Contents = contents ?? throw new global::System.ArgumentNullException(nameof(contents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserPlaylistLibrary" /> class.
        /// </summary>
        public UserPlaylistLibrary()
        {
        }

    }
}