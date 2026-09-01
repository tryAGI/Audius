
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Remix
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_track_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ParentTrackId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.User User { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_remix_author_reposted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasRemixAuthorReposted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_remix_author_saved")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasRemixAuthorSaved { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Remix" /> class.
        /// </summary>
        /// <param name="parentTrackId"></param>
        /// <param name="user"></param>
        /// <param name="hasRemixAuthorReposted"></param>
        /// <param name="hasRemixAuthorSaved"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Remix(
            string parentTrackId,
            global::Audius.User user,
            bool hasRemixAuthorReposted,
            bool hasRemixAuthorSaved)
        {
            this.ParentTrackId = parentTrackId ?? throw new global::System.ArgumentNullException(nameof(parentTrackId));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.HasRemixAuthorReposted = hasRemixAuthorReposted;
            this.HasRemixAuthorSaved = hasRemixAuthorSaved;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Remix" /> class.
        /// </summary>
        public Remix()
        {
        }

    }
}