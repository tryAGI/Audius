
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrackSegment
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multihash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Multihash { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackSegment" /> class.
        /// </summary>
        /// <param name="duration"></param>
        /// <param name="multihash"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackSegment(
            double duration,
            string multihash)
        {
            this.Duration = duration;
            this.Multihash = multihash ?? throw new global::System.ArgumentNullException(nameof(multihash));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackSegment" /> class.
        /// </summary>
        public TrackSegment()
        {
        }

    }
}