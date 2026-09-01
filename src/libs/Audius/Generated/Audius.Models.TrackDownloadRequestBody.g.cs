
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrackDownloadRequestBody
    {
        /// <summary>
        /// City where the download occurred
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// Region where the download occurred
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Country where the download occurred
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackDownloadRequestBody" /> class.
        /// </summary>
        /// <param name="city">
        /// City where the download occurred
        /// </param>
        /// <param name="region">
        /// Region where the download occurred
        /// </param>
        /// <param name="country">
        /// Country where the download occurred
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackDownloadRequestBody(
            string? city,
            string? region,
            string? country)
        {
            this.City = city;
            this.Region = region;
            this.Country = country;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackDownloadRequestBody" /> class.
        /// </summary>
        public TrackDownloadRequestBody()
        {
        }

    }
}