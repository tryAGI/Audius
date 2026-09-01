
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrackAccessInfo
    {
        /// <summary>
        /// Describes what access the given user has
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        public global::Audius.Access? Access { get; set; }

        /// <summary>
        /// The user ID of the owner of this track
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The blocknumber this track was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocknumber")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Blocknumber { get; set; }

        /// <summary>
        /// Whether or not the owner has restricted streaming behind an access gate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_stream_gated")]
        public bool? IsStreamGated { get; set; }

        /// <summary>
        /// How to unlock stream access to the track
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_conditions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.ExtendedAccessGateJsonConverter))]
        public global::Audius.ExtendedAccessGate? StreamConditions { get; set; }

        /// <summary>
        /// Whether or not the owner has restricted downloading behind an access gate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_download_gated")]
        public bool? IsDownloadGated { get; set; }

        /// <summary>
        /// How to unlock the track download
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_conditions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.ExtendedAccessGateJsonConverter))]
        public global::Audius.ExtendedAccessGate? DownloadConditions { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackAccessInfo" /> class.
        /// </summary>
        /// <param name="userId">
        /// The user ID of the owner of this track
        /// </param>
        /// <param name="blocknumber">
        /// The blocknumber this track was last updated
        /// </param>
        /// <param name="access">
        /// Describes what access the given user has
        /// </param>
        /// <param name="isStreamGated">
        /// Whether or not the owner has restricted streaming behind an access gate
        /// </param>
        /// <param name="streamConditions">
        /// How to unlock stream access to the track
        /// </param>
        /// <param name="isDownloadGated">
        /// Whether or not the owner has restricted downloading behind an access gate
        /// </param>
        /// <param name="downloadConditions">
        /// How to unlock the track download
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrackAccessInfo(
            string userId,
            int blocknumber,
            global::Audius.Access? access,
            bool? isStreamGated,
            global::Audius.ExtendedAccessGate? streamConditions,
            bool? isDownloadGated,
            global::Audius.ExtendedAccessGate? downloadConditions)
        {
            this.Access = access;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Blocknumber = blocknumber;
            this.IsStreamGated = isStreamGated;
            this.StreamConditions = streamConditions;
            this.IsDownloadGated = isDownloadGated;
            this.DownloadConditions = downloadConditions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackAccessInfo" /> class.
        /// </summary>
        public TrackAccessInfo()
        {
        }

    }
}