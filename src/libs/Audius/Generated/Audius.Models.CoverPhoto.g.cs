
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CoverPhoto
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("640x")]
        public string? x640x { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("2000x")]
        public string? x2000x { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mirrors")]
        public global::System.Collections.Generic.IList<string>? Mirrors { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CoverPhoto" /> class.
        /// </summary>
        /// <param name="x640x"></param>
        /// <param name="x2000x"></param>
        /// <param name="mirrors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CoverPhoto(
            string? x640x,
            string? x2000x,
            global::System.Collections.Generic.IList<string>? mirrors)
        {
            this.x640x = x640x;
            this.x2000x = x2000x;
            this.Mirrors = mirrors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoverPhoto" /> class.
        /// </summary>
        public CoverPhoto()
        {
        }

    }
}