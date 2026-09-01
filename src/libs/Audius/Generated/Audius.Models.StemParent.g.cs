
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StemParent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Category { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_track_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ParentTrackId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StemParent" /> class.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="parentTrackId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StemParent(
            string category,
            int parentTrackId)
        {
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.ParentTrackId = parentTrackId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StemParent" /> class.
        /// </summary>
        public StemParent()
        {
        }

    }
}