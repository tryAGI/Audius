
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserTracksDownloadCountResponse
    {
        /// <summary>
        /// Total download count for all tracks (and stems) owned by the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Data { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserTracksDownloadCountResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Total download count for all tracks (and stems) owned by the user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserTracksDownloadCountResponse(
            long data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserTracksDownloadCountResponse" /> class.
        /// </summary>
        public UserTracksDownloadCountResponse()
        {
        }

    }
}