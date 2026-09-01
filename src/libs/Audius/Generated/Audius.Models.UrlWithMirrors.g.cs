
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UrlWithMirrors
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mirrors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Mirrors { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlWithMirrors" /> class.
        /// </summary>
        /// <param name="mirrors"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UrlWithMirrors(
            global::System.Collections.Generic.IList<string> mirrors,
            string? url)
        {
            this.Url = url;
            this.Mirrors = mirrors ?? throw new global::System.ArgumentNullException(nameof(mirrors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UrlWithMirrors" /> class.
        /// </summary>
        public UrlWithMirrors()
        {
        }

    }
}