
#nullable enable

namespace Audius
{
    /// <summary>
    /// Folder containing nested playlists and folders
    /// </summary>
    public sealed partial class PlaylistLibraryFolder
    {
        /// <summary>
        /// Unique folder identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.PlaylistLibraryFolderTypeJsonConverter))]
        public global::Audius.PlaylistLibraryFolderType Type { get; set; }

        /// <summary>
        /// Folder name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Nested folders and playlist identifiers
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
        /// Initializes a new instance of the <see cref="PlaylistLibraryFolder" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique folder identifier
        /// </param>
        /// <param name="name">
        /// Folder name
        /// </param>
        /// <param name="contents">
        /// Nested folders and playlist identifiers
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaylistLibraryFolder(
            string id,
            string name,
            global::System.Collections.Generic.IList<global::Audius.OneOf<global::Audius.PlaylistLibraryFolder, global::Audius.PlaylistLibraryPlaylistIdentifier, global::Audius.PlaylistLibraryExplorePlaylistIdentifier>> contents,
            global::Audius.PlaylistLibraryFolderType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Contents = contents ?? throw new global::System.ArgumentNullException(nameof(contents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistLibraryFolder" /> class.
        /// </summary>
        public PlaylistLibraryFolder()
        {
        }

    }
}