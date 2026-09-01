
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FieldVisibility
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mood")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Mood { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Tags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genre")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Genre { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("share")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Share { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("play_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PlayCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remixes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Remixes { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldVisibility" /> class.
        /// </summary>
        /// <param name="mood"></param>
        /// <param name="tags"></param>
        /// <param name="genre"></param>
        /// <param name="share"></param>
        /// <param name="playCount"></param>
        /// <param name="remixes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FieldVisibility(
            bool mood,
            bool tags,
            bool genre,
            bool share,
            bool playCount,
            bool remixes)
        {
            this.Mood = mood;
            this.Tags = tags;
            this.Genre = genre;
            this.Share = share;
            this.PlayCount = playCount;
            this.Remixes = remixes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldVisibility" /> class.
        /// </summary>
        public FieldVisibility()
        {
        }

    }
}