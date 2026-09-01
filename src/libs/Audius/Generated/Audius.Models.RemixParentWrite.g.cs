
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RemixParentWrite
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Audius.TrackElementWrite> Tracks { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemixParentWrite" /> class.
        /// </summary>
        /// <param name="tracks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemixParentWrite(
            global::System.Collections.Generic.IList<global::Audius.TrackElementWrite> tracks)
        {
            this.Tracks = tracks ?? throw new global::System.ArgumentNullException(nameof(tracks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemixParentWrite" /> class.
        /// </summary>
        public RemixParentWrite()
        {
        }

    }
}