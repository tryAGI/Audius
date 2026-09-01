
#nullable enable

namespace Audius
{
    /// <summary>
    /// Request body for updating track information. All fields are optional.
    /// </summary>
    public sealed partial class UpdateTrackRequestBody
    {
        /// <summary>
        /// Track title
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Music genre
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genre")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.GenreJsonConverter))]
        public global::Audius.Genre? Genre { get; set; }

        /// <summary>
        /// Track description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mood")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.MoodJsonConverter))]
        public global::Audius.Mood? Mood { get; set; }

        /// <summary>
        /// Beats per minute (tempo)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bpm")]
        public double? Bpm { get; set; }

        /// <summary>
        /// Musical key of the track
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("musical_key")]
        public string? MusicalKey { get; set; }

        /// <summary>
        /// Comma-separated tags
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public string? Tags { get; set; }

        /// <summary>
        /// License type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        public string? License { get; set; }

        /// <summary>
        /// International Standard Recording Code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isrc")]
        public string? Isrc { get; set; }

        /// <summary>
        /// International Standard Musical Work Code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iswc")]
        public string? Iswc { get; set; }

        /// <summary>
        /// Release date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_date")]
        public global::System.DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// CID for the track audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_cid")]
        public string? TrackCid { get; set; }

        /// <summary>
        /// CID for the original track file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orig_file_cid")]
        public string? OrigFileCid { get; set; }

        /// <summary>
        /// Original filename of the track
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orig_filename")]
        public string? OrigFilename { get; set; }

        /// <summary>
        /// CID for the track cover art
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_art_sizes")]
        public string? CoverArtSizes { get; set; }

        /// <summary>
        /// CID for the track preview
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_cid")]
        public string? PreviewCid { get; set; }

        /// <summary>
        /// Preview start time in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_start_seconds")]
        public float? PreviewStartSeconds { get; set; }

        /// <summary>
        /// Track duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public float? Duration { get; set; }

        /// <summary>
        /// Whether the track is downloadable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_downloadable")]
        public bool? IsDownloadable { get; set; }

        /// <summary>
        /// Whether the track is unlisted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_unlisted")]
        public bool? IsUnlisted { get; set; }

        /// <summary>
        /// Whether streaming is restricted behind an access gate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_stream_gated")]
        public bool? IsStreamGated { get; set; }

        /// <summary>
        /// Wallet addresses that can sign to authorize stream access (programmable distribution). When empty or omitted, the track is public and validator/creator nodes can serve it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_authorities")]
        public global::System.Collections.Generic.IList<string>? AccessAuthorities { get; set; }

        /// <summary>
        /// API keys allowed to stream this track
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_api_keys")]
        public global::System.Collections.Generic.IList<string>? AllowedApiKeys { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_conditions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.AccessGateJsonConverter))]
        public global::Audius.AccessGate? StreamConditions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_conditions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.AccessGateJsonConverter))]
        public global::Audius.AccessGate? DownloadConditions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_visibility")]
        public global::Audius.FieldVisibility? FieldVisibility { get; set; }

        /// <summary>
        /// Placement hosts for the track
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placement_hosts")]
        public string? PlacementHosts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stem_of")]
        public global::Audius.StemParent? StemOf { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remix_of")]
        public global::Audius.RemixParentWrite? RemixOf { get; set; }

        /// <summary>
        /// DDEX application identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ddex_app")]
        public string? DdexApp { get; set; }

        /// <summary>
        /// Parental warning type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parental_warning_type")]
        public string? ParentalWarningType { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTrackRequestBody" /> class.
        /// </summary>
        /// <param name="title">
        /// Track title
        /// </param>
        /// <param name="genre">
        /// Music genre
        /// </param>
        /// <param name="description">
        /// Track description
        /// </param>
        /// <param name="mood"></param>
        /// <param name="bpm">
        /// Beats per minute (tempo)
        /// </param>
        /// <param name="musicalKey">
        /// Musical key of the track
        /// </param>
        /// <param name="tags">
        /// Comma-separated tags
        /// </param>
        /// <param name="license">
        /// License type
        /// </param>
        /// <param name="isrc">
        /// International Standard Recording Code
        /// </param>
        /// <param name="iswc">
        /// International Standard Musical Work Code
        /// </param>
        /// <param name="releaseDate">
        /// Release date
        /// </param>
        /// <param name="trackCid">
        /// CID for the track audio file
        /// </param>
        /// <param name="origFileCid">
        /// CID for the original track file
        /// </param>
        /// <param name="origFilename">
        /// Original filename of the track
        /// </param>
        /// <param name="coverArtSizes">
        /// CID for the track cover art
        /// </param>
        /// <param name="previewCid">
        /// CID for the track preview
        /// </param>
        /// <param name="previewStartSeconds">
        /// Preview start time in seconds
        /// </param>
        /// <param name="duration">
        /// Track duration in seconds
        /// </param>
        /// <param name="isDownloadable">
        /// Whether the track is downloadable
        /// </param>
        /// <param name="isUnlisted">
        /// Whether the track is unlisted
        /// </param>
        /// <param name="isStreamGated">
        /// Whether streaming is restricted behind an access gate
        /// </param>
        /// <param name="accessAuthorities">
        /// Wallet addresses that can sign to authorize stream access (programmable distribution). When empty or omitted, the track is public and validator/creator nodes can serve it.
        /// </param>
        /// <param name="allowedApiKeys">
        /// API keys allowed to stream this track
        /// </param>
        /// <param name="streamConditions"></param>
        /// <param name="downloadConditions"></param>
        /// <param name="fieldVisibility"></param>
        /// <param name="placementHosts">
        /// Placement hosts for the track
        /// </param>
        /// <param name="stemOf"></param>
        /// <param name="remixOf"></param>
        /// <param name="ddexApp">
        /// DDEX application identifier
        /// </param>
        /// <param name="parentalWarningType">
        /// Parental warning type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTrackRequestBody(
            string? title,
            global::Audius.Genre? genre,
            string? description,
            global::Audius.Mood? mood,
            double? bpm,
            string? musicalKey,
            string? tags,
            string? license,
            string? isrc,
            string? iswc,
            global::System.DateTime? releaseDate,
            string? trackCid,
            string? origFileCid,
            string? origFilename,
            string? coverArtSizes,
            string? previewCid,
            float? previewStartSeconds,
            float? duration,
            bool? isDownloadable,
            bool? isUnlisted,
            bool? isStreamGated,
            global::System.Collections.Generic.IList<string>? accessAuthorities,
            global::System.Collections.Generic.IList<string>? allowedApiKeys,
            global::Audius.AccessGate? streamConditions,
            global::Audius.AccessGate? downloadConditions,
            global::Audius.FieldVisibility? fieldVisibility,
            string? placementHosts,
            global::Audius.StemParent? stemOf,
            global::Audius.RemixParentWrite? remixOf,
            string? ddexApp,
            string? parentalWarningType)
        {
            this.Title = title;
            this.Genre = genre;
            this.Description = description;
            this.Mood = mood;
            this.Bpm = bpm;
            this.MusicalKey = musicalKey;
            this.Tags = tags;
            this.License = license;
            this.Isrc = isrc;
            this.Iswc = iswc;
            this.ReleaseDate = releaseDate;
            this.TrackCid = trackCid;
            this.OrigFileCid = origFileCid;
            this.OrigFilename = origFilename;
            this.CoverArtSizes = coverArtSizes;
            this.PreviewCid = previewCid;
            this.PreviewStartSeconds = previewStartSeconds;
            this.Duration = duration;
            this.IsDownloadable = isDownloadable;
            this.IsUnlisted = isUnlisted;
            this.IsStreamGated = isStreamGated;
            this.AccessAuthorities = accessAuthorities;
            this.AllowedApiKeys = allowedApiKeys;
            this.StreamConditions = streamConditions;
            this.DownloadConditions = downloadConditions;
            this.FieldVisibility = fieldVisibility;
            this.PlacementHosts = placementHosts;
            this.StemOf = stemOf;
            this.RemixOf = remixOf;
            this.DdexApp = ddexApp;
            this.ParentalWarningType = parentalWarningType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTrackRequestBody" /> class.
        /// </summary>
        public UpdateTrackRequestBody()
        {
        }

    }
}