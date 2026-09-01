
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrackDownloadCountResponseData
    {
        /// <summary>
        /// Track ID (hash)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Full track + all stems (parent) or stem-only (stem)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DownloadCount { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackDownloadCountResponseData" /> class.
        /// </summary>
        /// <param name="id">
        /// Track ID (hash)
        /// </param>
        /// <param name="downloadCount">
        /// Full track + all stems (parent) or stem-only (stem)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackDownloadCountResponseData(
            string id,
            int downloadCount)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DownloadCount = downloadCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackDownloadCountResponseData" /> class.
        /// </summary>
        public TrackDownloadCountResponseData()
        {
        }

    }
}