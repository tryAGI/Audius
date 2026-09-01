
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RemixesResponseData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks")]
        public global::System.Collections.Generic.IList<global::Audius.Track>? Tracks { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemixesResponseData" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="tracks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemixesResponseData(
            int count,
            global::System.Collections.Generic.IList<global::Audius.Track>? tracks)
        {
            this.Count = count;
            this.Tracks = tracks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemixesResponseData" /> class.
        /// </summary>
        public RemixesResponseData()
        {
        }

    }
}