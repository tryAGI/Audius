
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrackElementWrite
    {
        /// <summary>
        /// Example: x5pJ3Az
        /// </summary>
        /// <example>x5pJ3Az</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_track_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ParentTrackId { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackElementWrite" /> class.
        /// </summary>
        /// <param name="parentTrackId">
        /// Example: x5pJ3Az
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackElementWrite(
            string parentTrackId)
        {
            this.ParentTrackId = parentTrackId ?? throw new global::System.ArgumentNullException(nameof(parentTrackId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackElementWrite" /> class.
        /// </summary>
        public TrackElementWrite()
        {
        }

    }
}