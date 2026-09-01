
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTrackRequestBody
    {
        /// <summary>
        /// Optional track ID (will be generated if not provided)<br/>
        /// Example: x5pJ3Az
        /// </summary>
        /// <example>x5pJ3Az</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_id")]
        public string? TrackId { get; set; }

        /// <summary>
        /// Track title<br/>
        /// Example: My New Track
        /// </summary>
        /// <example>My New Track</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Music genre
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genre")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.GenreJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.Genre Genre { get; set; }

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
        /// CID for the track audio file (required)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_cid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrackCid { get; set; }

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
        /// DDEX release identifiers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ddex_release_ids")]
        public object? DdexReleaseIds { get; set; }

        /// <summary>
        /// DDEX resource contributors / artists
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artists")]
        public global::System.Collections.Generic.IList<object>? Artists { get; set; }

        /// <summary>
        /// DDEX resource contributors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_contributors")]
        public global::System.Collections.Generic.IList<global::Audius.DdexResourceContributor>? ResourceContributors { get; set; }

        /// <summary>
        /// DDEX indirect resource contributors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indirect_resource_contributors")]
        public global::System.Collections.Generic.IList<global::Audius.DdexResourceContributor>? IndirectResourceContributors { get; set; }

        /// <summary>
        /// DDEX rights controller
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rights_controller")]
        public global::Audius.DdexRightsController? RightsController { get; set; }

        /// <summary>
        /// DDEX copyright line
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copyright_line")]
        public global::Audius.DdexCopyright? CopyrightLine { get; set; }

        /// <summary>
        /// DDEX producer copyright line
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("producer_copyright_line")]
        public global::Audius.DdexCopyright? ProducerCopyrightLine { get; set; }

        /// <summary>
        /// Parental warning type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parental_warning_type")]
        public string? ParentalWarningType { get; set; }

        /// <summary>
        /// Original song title for cover tracks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_original_song_title")]
        public string? CoverOriginalSongTitle { get; set; }

        /// <summary>
        /// Original artist for cover tracks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_original_artist")]
        public string? CoverOriginalArtist { get; set; }

        /// <summary>
        /// Whether the track is owned by the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_owned_by_user")]
        public bool? IsOwnedByUser { get; set; }

        /// <summary>
        /// Territory codes for distribution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territory_codes")]
        public global::System.Collections.Generic.IList<string>? TerritoryCodes { get; set; }

        /// <summary>
        /// Whether AI use is prohibited
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("no_ai_use")]
        public bool? NoAiUse { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrackRequestBody" /> class.
        /// </summary>
        /// <param name="title">
        /// Track title<br/>
        /// Example: My New Track
        /// </param>
        /// <param name="genre">
        /// Music genre
        /// </param>
        /// <param name="trackCid">
        /// CID for the track audio file (required)
        /// </param>
        /// <param name="trackId">
        /// Optional track ID (will be generated if not provided)<br/>
        /// Example: x5pJ3Az
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
        /// <param name="ddexReleaseIds">
        /// DDEX release identifiers
        /// </param>
        /// <param name="artists">
        /// DDEX resource contributors / artists
        /// </param>
        /// <param name="resourceContributors">
        /// DDEX resource contributors
        /// </param>
        /// <param name="indirectResourceContributors">
        /// DDEX indirect resource contributors
        /// </param>
        /// <param name="rightsController">
        /// DDEX rights controller
        /// </param>
        /// <param name="copyrightLine">
        /// DDEX copyright line
        /// </param>
        /// <param name="producerCopyrightLine">
        /// DDEX producer copyright line
        /// </param>
        /// <param name="parentalWarningType">
        /// Parental warning type
        /// </param>
        /// <param name="coverOriginalSongTitle">
        /// Original song title for cover tracks
        /// </param>
        /// <param name="coverOriginalArtist">
        /// Original artist for cover tracks
        /// </param>
        /// <param name="isOwnedByUser">
        /// Whether the track is owned by the user
        /// </param>
        /// <param name="territoryCodes">
        /// Territory codes for distribution
        /// </param>
        /// <param name="noAiUse">
        /// Whether AI use is prohibited
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTrackRequestBody(
            string title,
            global::Audius.Genre genre,
            string trackCid,
            string? trackId,
            string? description,
            global::Audius.Mood? mood,
            double? bpm,
            string? musicalKey,
            string? tags,
            string? license,
            string? isrc,
            string? iswc,
            global::System.DateTime? releaseDate,
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
            object? ddexReleaseIds,
            global::System.Collections.Generic.IList<object>? artists,
            global::System.Collections.Generic.IList<global::Audius.DdexResourceContributor>? resourceContributors,
            global::System.Collections.Generic.IList<global::Audius.DdexResourceContributor>? indirectResourceContributors,
            global::Audius.DdexRightsController? rightsController,
            global::Audius.DdexCopyright? copyrightLine,
            global::Audius.DdexCopyright? producerCopyrightLine,
            string? parentalWarningType,
            string? coverOriginalSongTitle,
            string? coverOriginalArtist,
            bool? isOwnedByUser,
            global::System.Collections.Generic.IList<string>? territoryCodes,
            bool? noAiUse)
        {
            this.TrackId = trackId;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
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
            this.TrackCid = trackCid ?? throw new global::System.ArgumentNullException(nameof(trackCid));
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
            this.DdexReleaseIds = ddexReleaseIds;
            this.Artists = artists;
            this.ResourceContributors = resourceContributors;
            this.IndirectResourceContributors = indirectResourceContributors;
            this.RightsController = rightsController;
            this.CopyrightLine = copyrightLine;
            this.ProducerCopyrightLine = producerCopyrightLine;
            this.ParentalWarningType = parentalWarningType;
            this.CoverOriginalSongTitle = coverOriginalSongTitle;
            this.CoverOriginalArtist = coverOriginalArtist;
            this.IsOwnedByUser = isOwnedByUser;
            this.TerritoryCodes = territoryCodes;
            this.NoAiUse = noAiUse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrackRequestBody" /> class.
        /// </summary>
        public CreateTrackRequestBody()
        {
        }

    }
}