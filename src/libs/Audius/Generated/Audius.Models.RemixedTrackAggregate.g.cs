
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RemixedTrackAggregate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrackId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remix_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RemixCount { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemixedTrackAggregate" /> class.
        /// </summary>
        /// <param name="trackId"></param>
        /// <param name="title"></param>
        /// <param name="remixCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemixedTrackAggregate(
            string trackId,
            string title,
            int remixCount)
        {
            this.TrackId = trackId ?? throw new global::System.ArgumentNullException(nameof(trackId));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.RemixCount = remixCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemixedTrackAggregate" /> class.
        /// </summary>
        public RemixedTrackAggregate()
        {
        }

    }
}