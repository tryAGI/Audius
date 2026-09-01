
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchTrack
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artwork")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.TrackArtwork Artwork { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genre")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Genre { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_cid")]
        public string? TrackCid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_cid")]
        public string? PreviewCid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orig_file_cid")]
        public string? OrigFileCid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orig_filename")]
        public string? OrigFilename { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_original_available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOriginalAvailable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mood")]
        public string? Mood { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_date")]
        public global::System.DateTime? ReleaseDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remix_of")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.RemixParent RemixOf { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repost_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RepostCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("favorite_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FavoriteCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CommentCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public string? Tags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.User User { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Duration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_downloadable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDownloadable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("play_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PlayCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permalink")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Permalink { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_streamable")]
        public bool? IsStreamable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ddex_app")]
        public string? DdexApp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlists_containing_track")]
        public global::System.Collections.Generic.IList<int>? PlaylistsContainingTrack { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pinned_comment_id")]
        public int? PinnedCommentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("album_backlink")]
        public global::Audius.AlbumBacklink? AlbumBacklink { get; set; }

        /// <summary>
        /// Describes what access the given user has
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.Access Access { get; set; }

        /// <summary>
        /// The blocknumber this track was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocknumber")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Blocknumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_date")]
        public string? CreateDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_art_sizes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CoverArtSizes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_art_cids")]
        public global::Audius.CoverArt? CoverArtCids { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_splits")]
        public string? CreditsSplits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isrc")]
        public string? Isrc { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        public string? License { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iswc")]
        public string? Iswc { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_visibility")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.FieldVisibility FieldVisibility { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followee_reposts")]
        public global::System.Collections.Generic.IList<global::Audius.Repost>? FolloweeReposts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_current_user_reposted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasCurrentUserReposted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_scheduled_release")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsScheduledRelease { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_unlisted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsUnlisted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_current_user_saved")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasCurrentUserSaved { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followee_favorites")]
        public global::System.Collections.Generic.IList<global::Audius.Favorite>? FolloweeFavorites { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route_id")]
        public string? RouteId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stem_of")]
        public global::Audius.StemParent? StemOf { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Audius.TrackSegment> TrackSegments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_delete")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDelete { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_art")]
        public string? CoverArt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAvailable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_attribution_user_id")]
        public int? AiAttributionUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_api_keys")]
        public global::System.Collections.Generic.IList<string>? AllowedApiKeys { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_upload_id")]
        public string? AudioUploadId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_start_seconds")]
        public double? PreviewStartSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bpm")]
        public double? Bpm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_custom_bpm")]
        public bool? IsCustomBpm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("musical_key")]
        public string? MusicalKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_custom_musical_key")]
        public bool? IsCustomMusicalKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_analysis_error_count")]
        public int? AudioAnalysisErrorCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments_disabled")]
        public bool? CommentsDisabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ddex_release_ids")]
        public object? DdexReleaseIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artists")]
        public global::System.Collections.Generic.IList<object>? Artists { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_contributors")]
        public global::System.Collections.Generic.IList<global::Audius.DdexResourceContributor>? ResourceContributors { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indirect_resource_contributors")]
        public global::System.Collections.Generic.IList<global::Audius.DdexResourceContributor>? IndirectResourceContributors { get; set; }

        /// <summary>
        /// DDEX rights controller
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rights_controller")]
        public global::Audius.DdexRightsController? RightsController { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copyright_line")]
        public global::Audius.DdexCopyright? CopyrightLine { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("producer_copyright_line")]
        public global::Audius.DdexCopyright? ProducerCopyrightLine { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parental_warning_type")]
        public string? ParentalWarningType { get; set; }

        /// <summary>
        /// Whether or not the owner has restricted streaming behind an access gate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_stream_gated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsStreamGated { get; set; }

        /// <summary>
        /// How to unlock stream access to the track
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_conditions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.AccessGateJsonConverter))]
        public global::Audius.AccessGate? StreamConditions { get; set; }

        /// <summary>
        /// Whether or not the owner has restricted downloading behind an access gate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_download_gated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDownloadGated { get; set; }

        /// <summary>
        /// How to unlock the track download
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_conditions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.AccessGateJsonConverter))]
        public global::Audius.AccessGate? DownloadConditions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_original_song_title")]
        public string? CoverOriginalSongTitle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_original_artist")]
        public string? CoverOriginalArtist { get; set; }

        /// <summary>
        /// Indicates whether the track is owned by the user for MRI sake
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_owned_by_user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOwnedByUser { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.UrlWithMirrors Stream { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.UrlWithMirrors Download { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.UrlWithMirrors Preview { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchTrack" /> class.
        /// </summary>
        /// <param name="artwork"></param>
        /// <param name="genre"></param>
        /// <param name="id"></param>
        /// <param name="isOriginalAvailable"></param>
        /// <param name="remixOf"></param>
        /// <param name="repostCount"></param>
        /// <param name="favoriteCount"></param>
        /// <param name="commentCount"></param>
        /// <param name="title"></param>
        /// <param name="user"></param>
        /// <param name="duration"></param>
        /// <param name="isDownloadable"></param>
        /// <param name="playCount"></param>
        /// <param name="permalink"></param>
        /// <param name="access">
        /// Describes what access the given user has
        /// </param>
        /// <param name="blocknumber">
        /// The blocknumber this track was last updated
        /// </param>
        /// <param name="coverArtSizes"></param>
        /// <param name="createdAt"></param>
        /// <param name="fieldVisibility"></param>
        /// <param name="hasCurrentUserReposted"></param>
        /// <param name="isScheduledRelease"></param>
        /// <param name="isUnlisted"></param>
        /// <param name="hasCurrentUserSaved"></param>
        /// <param name="trackSegments"></param>
        /// <param name="updatedAt"></param>
        /// <param name="userId"></param>
        /// <param name="isDelete"></param>
        /// <param name="isAvailable"></param>
        /// <param name="isStreamGated">
        /// Whether or not the owner has restricted streaming behind an access gate
        /// </param>
        /// <param name="isDownloadGated">
        /// Whether or not the owner has restricted downloading behind an access gate
        /// </param>
        /// <param name="isOwnedByUser">
        /// Indicates whether the track is owned by the user for MRI sake
        /// </param>
        /// <param name="stream"></param>
        /// <param name="download"></param>
        /// <param name="preview"></param>
        /// <param name="description"></param>
        /// <param name="trackCid"></param>
        /// <param name="previewCid"></param>
        /// <param name="origFileCid"></param>
        /// <param name="origFilename"></param>
        /// <param name="mood"></param>
        /// <param name="releaseDate"></param>
        /// <param name="tags"></param>
        /// <param name="isStreamable"></param>
        /// <param name="ddexApp"></param>
        /// <param name="playlistsContainingTrack"></param>
        /// <param name="pinnedCommentId"></param>
        /// <param name="albumBacklink"></param>
        /// <param name="createDate"></param>
        /// <param name="coverArtCids"></param>
        /// <param name="creditsSplits"></param>
        /// <param name="isrc"></param>
        /// <param name="license"></param>
        /// <param name="iswc"></param>
        /// <param name="followeeReposts"></param>
        /// <param name="followeeFavorites"></param>
        /// <param name="routeId"></param>
        /// <param name="stemOf"></param>
        /// <param name="coverArt"></param>
        /// <param name="aiAttributionUserId"></param>
        /// <param name="allowedApiKeys"></param>
        /// <param name="audioUploadId"></param>
        /// <param name="previewStartSeconds"></param>
        /// <param name="bpm"></param>
        /// <param name="isCustomBpm"></param>
        /// <param name="musicalKey"></param>
        /// <param name="isCustomMusicalKey"></param>
        /// <param name="audioAnalysisErrorCount"></param>
        /// <param name="commentsDisabled"></param>
        /// <param name="ddexReleaseIds"></param>
        /// <param name="artists"></param>
        /// <param name="resourceContributors"></param>
        /// <param name="indirectResourceContributors"></param>
        /// <param name="rightsController">
        /// DDEX rights controller
        /// </param>
        /// <param name="copyrightLine"></param>
        /// <param name="producerCopyrightLine"></param>
        /// <param name="parentalWarningType"></param>
        /// <param name="streamConditions">
        /// How to unlock stream access to the track
        /// </param>
        /// <param name="downloadConditions">
        /// How to unlock the track download
        /// </param>
        /// <param name="coverOriginalSongTitle"></param>
        /// <param name="coverOriginalArtist"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchTrack(
            global::Audius.TrackArtwork artwork,
            string genre,
            string id,
            bool isOriginalAvailable,
            global::Audius.RemixParent remixOf,
            int repostCount,
            int favoriteCount,
            int commentCount,
            string title,
            global::Audius.User user,
            int duration,
            bool isDownloadable,
            int playCount,
            string permalink,
            global::Audius.Access access,
            int blocknumber,
            string coverArtSizes,
            string createdAt,
            global::Audius.FieldVisibility fieldVisibility,
            bool hasCurrentUserReposted,
            bool isScheduledRelease,
            bool isUnlisted,
            bool hasCurrentUserSaved,
            global::System.Collections.Generic.IList<global::Audius.TrackSegment> trackSegments,
            string updatedAt,
            string userId,
            bool isDelete,
            bool isAvailable,
            bool isStreamGated,
            bool isDownloadGated,
            bool isOwnedByUser,
            global::Audius.UrlWithMirrors stream,
            global::Audius.UrlWithMirrors download,
            global::Audius.UrlWithMirrors preview,
            string? description,
            string? trackCid,
            string? previewCid,
            string? origFileCid,
            string? origFilename,
            string? mood,
            global::System.DateTime? releaseDate,
            string? tags,
            bool? isStreamable,
            string? ddexApp,
            global::System.Collections.Generic.IList<int>? playlistsContainingTrack,
            int? pinnedCommentId,
            global::Audius.AlbumBacklink? albumBacklink,
            string? createDate,
            global::Audius.CoverArt? coverArtCids,
            string? creditsSplits,
            string? isrc,
            string? license,
            string? iswc,
            global::System.Collections.Generic.IList<global::Audius.Repost>? followeeReposts,
            global::System.Collections.Generic.IList<global::Audius.Favorite>? followeeFavorites,
            string? routeId,
            global::Audius.StemParent? stemOf,
            string? coverArt,
            int? aiAttributionUserId,
            global::System.Collections.Generic.IList<string>? allowedApiKeys,
            string? audioUploadId,
            double? previewStartSeconds,
            double? bpm,
            bool? isCustomBpm,
            string? musicalKey,
            bool? isCustomMusicalKey,
            int? audioAnalysisErrorCount,
            bool? commentsDisabled,
            object? ddexReleaseIds,
            global::System.Collections.Generic.IList<object>? artists,
            global::System.Collections.Generic.IList<global::Audius.DdexResourceContributor>? resourceContributors,
            global::System.Collections.Generic.IList<global::Audius.DdexResourceContributor>? indirectResourceContributors,
            global::Audius.DdexRightsController? rightsController,
            global::Audius.DdexCopyright? copyrightLine,
            global::Audius.DdexCopyright? producerCopyrightLine,
            string? parentalWarningType,
            global::Audius.AccessGate? streamConditions,
            global::Audius.AccessGate? downloadConditions,
            string? coverOriginalSongTitle,
            string? coverOriginalArtist)
        {
            this.Artwork = artwork ?? throw new global::System.ArgumentNullException(nameof(artwork));
            this.Description = description;
            this.Genre = genre ?? throw new global::System.ArgumentNullException(nameof(genre));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TrackCid = trackCid;
            this.PreviewCid = previewCid;
            this.OrigFileCid = origFileCid;
            this.OrigFilename = origFilename;
            this.IsOriginalAvailable = isOriginalAvailable;
            this.Mood = mood;
            this.ReleaseDate = releaseDate;
            this.RemixOf = remixOf ?? throw new global::System.ArgumentNullException(nameof(remixOf));
            this.RepostCount = repostCount;
            this.FavoriteCount = favoriteCount;
            this.CommentCount = commentCount;
            this.Tags = tags;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Duration = duration;
            this.IsDownloadable = isDownloadable;
            this.PlayCount = playCount;
            this.Permalink = permalink ?? throw new global::System.ArgumentNullException(nameof(permalink));
            this.IsStreamable = isStreamable;
            this.DdexApp = ddexApp;
            this.PlaylistsContainingTrack = playlistsContainingTrack;
            this.PinnedCommentId = pinnedCommentId;
            this.AlbumBacklink = albumBacklink;
            this.Access = access ?? throw new global::System.ArgumentNullException(nameof(access));
            this.Blocknumber = blocknumber;
            this.CreateDate = createDate;
            this.CoverArtSizes = coverArtSizes ?? throw new global::System.ArgumentNullException(nameof(coverArtSizes));
            this.CoverArtCids = coverArtCids;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.CreditsSplits = creditsSplits;
            this.Isrc = isrc;
            this.License = license;
            this.Iswc = iswc;
            this.FieldVisibility = fieldVisibility ?? throw new global::System.ArgumentNullException(nameof(fieldVisibility));
            this.FolloweeReposts = followeeReposts;
            this.HasCurrentUserReposted = hasCurrentUserReposted;
            this.IsScheduledRelease = isScheduledRelease;
            this.IsUnlisted = isUnlisted;
            this.HasCurrentUserSaved = hasCurrentUserSaved;
            this.FolloweeFavorites = followeeFavorites;
            this.RouteId = routeId;
            this.StemOf = stemOf;
            this.TrackSegments = trackSegments ?? throw new global::System.ArgumentNullException(nameof(trackSegments));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.IsDelete = isDelete;
            this.CoverArt = coverArt;
            this.IsAvailable = isAvailable;
            this.AiAttributionUserId = aiAttributionUserId;
            this.AllowedApiKeys = allowedApiKeys;
            this.AudioUploadId = audioUploadId;
            this.PreviewStartSeconds = previewStartSeconds;
            this.Bpm = bpm;
            this.IsCustomBpm = isCustomBpm;
            this.MusicalKey = musicalKey;
            this.IsCustomMusicalKey = isCustomMusicalKey;
            this.AudioAnalysisErrorCount = audioAnalysisErrorCount;
            this.CommentsDisabled = commentsDisabled;
            this.DdexReleaseIds = ddexReleaseIds;
            this.Artists = artists;
            this.ResourceContributors = resourceContributors;
            this.IndirectResourceContributors = indirectResourceContributors;
            this.RightsController = rightsController;
            this.CopyrightLine = copyrightLine;
            this.ProducerCopyrightLine = producerCopyrightLine;
            this.ParentalWarningType = parentalWarningType;
            this.IsStreamGated = isStreamGated;
            this.StreamConditions = streamConditions;
            this.IsDownloadGated = isDownloadGated;
            this.DownloadConditions = downloadConditions;
            this.CoverOriginalSongTitle = coverOriginalSongTitle;
            this.CoverOriginalArtist = coverOriginalArtist;
            this.IsOwnedByUser = isOwnedByUser;
            this.Stream = stream ?? throw new global::System.ArgumentNullException(nameof(stream));
            this.Download = download ?? throw new global::System.ArgumentNullException(nameof(download));
            this.Preview = preview ?? throw new global::System.ArgumentNullException(nameof(preview));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchTrack" /> class.
        /// </summary>
        public SearchTrack()
        {
        }

    }
}