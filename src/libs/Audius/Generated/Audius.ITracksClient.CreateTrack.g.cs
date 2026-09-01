#nullable enable

namespace Audius
{
    public partial interface ITracksClient
    {
        /// <summary>
        /// Creates a new track
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.CreateTrackResponse> CreateTrackAsync(
            string userId,

            global::Audius.CreateTrackRequestBody request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new track
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.CreateTrackResponse>> CreateTrackAsResponseAsync(
            string userId,

            global::Audius.CreateTrackRequestBody request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new track
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="trackId">
        /// Optional track ID (will be generated if not provided)<br/>
        /// Example: x5pJ3Az
        /// </param>
        /// <param name="title">
        /// Track title<br/>
        /// Example: My New Track
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
        /// CID for the track audio file (required)
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.CreateTrackResponse> CreateTrackAsync(
            string userId,
            string title,
            global::Audius.Genre genre,
            string trackCid,
            string? trackId = default,
            string? description = default,
            global::Audius.Mood? mood = default,
            double? bpm = default,
            string? musicalKey = default,
            string? tags = default,
            string? license = default,
            string? isrc = default,
            string? iswc = default,
            global::System.DateTime? releaseDate = default,
            string? origFileCid = default,
            string? origFilename = default,
            string? coverArtSizes = default,
            string? previewCid = default,
            float? previewStartSeconds = default,
            float? duration = default,
            bool? isDownloadable = default,
            bool? isUnlisted = default,
            bool? isStreamGated = default,
            global::System.Collections.Generic.IList<string>? accessAuthorities = default,
            global::System.Collections.Generic.IList<string>? allowedApiKeys = default,
            global::Audius.AccessGate? streamConditions = default,
            global::Audius.AccessGate? downloadConditions = default,
            global::Audius.FieldVisibility? fieldVisibility = default,
            string? placementHosts = default,
            global::Audius.StemParent? stemOf = default,
            global::Audius.RemixParentWrite? remixOf = default,
            string? ddexApp = default,
            object? ddexReleaseIds = default,
            global::System.Collections.Generic.IList<object>? artists = default,
            global::System.Collections.Generic.IList<global::Audius.DdexResourceContributor>? resourceContributors = default,
            global::System.Collections.Generic.IList<global::Audius.DdexResourceContributor>? indirectResourceContributors = default,
            global::Audius.DdexRightsController? rightsController = default,
            global::Audius.DdexCopyright? copyrightLine = default,
            global::Audius.DdexCopyright? producerCopyrightLine = default,
            string? parentalWarningType = default,
            string? coverOriginalSongTitle = default,
            string? coverOriginalArtist = default,
            bool? isOwnedByUser = default,
            global::System.Collections.Generic.IList<string>? territoryCodes = default,
            bool? noAiUse = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}