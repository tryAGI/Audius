
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Access
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Stream { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Download { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Access" /> class.
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="download"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Access(
            bool stream,
            bool download)
        {
            this.Stream = stream;
            this.Download = download;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Access" /> class.
        /// </summary>
        public Access()
        {
        }

    }
}