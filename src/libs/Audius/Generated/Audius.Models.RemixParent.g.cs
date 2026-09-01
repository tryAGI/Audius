
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RemixParent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks")]
        public global::System.Collections.Generic.IList<global::Audius.Remix>? Tracks { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemixParent" /> class.
        /// </summary>
        /// <param name="tracks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemixParent(
            global::System.Collections.Generic.IList<global::Audius.Remix>? tracks)
        {
            this.Tracks = tracks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemixParent" /> class.
        /// </summary>
        public RemixParent()
        {
        }

    }
}