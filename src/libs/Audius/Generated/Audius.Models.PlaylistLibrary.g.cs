
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PlaylistLibrary
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        public global::System.Collections.Generic.IList<object>? Contents { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistLibrary" /> class.
        /// </summary>
        /// <param name="contents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaylistLibrary(
            global::System.Collections.Generic.IList<object>? contents)
        {
            this.Contents = contents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaylistLibrary" /> class.
        /// </summary>
        public PlaylistLibrary()
        {
        }

    }
}