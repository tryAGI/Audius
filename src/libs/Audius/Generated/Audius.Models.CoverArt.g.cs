
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CoverArt
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("150x150")]
        public string? x150x150 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("480x480")]
        public string? x480x480 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("1000x1000")]
        public string? x1000x1000 { get; set; }

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
        /// Initializes a new instance of the <see cref="CoverArt" /> class.
        /// </summary>
        /// <param name="x150x150"></param>
        /// <param name="x480x480"></param>
        /// <param name="x1000x1000"></param>
        /// <param name="mirrors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CoverArt(
            string? x150x150,
            string? x480x480,
            string? x1000x1000,
            global::System.Collections.Generic.IList<string>? mirrors)
        {
            this.x150x150 = x150x150;
            this.x480x480 = x480x480;
            this.x1000x1000 = x1000x1000;
            this.Mirrors = mirrors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoverArt" /> class.
        /// </summary>
        public CoverArt()
        {
        }

    }
}