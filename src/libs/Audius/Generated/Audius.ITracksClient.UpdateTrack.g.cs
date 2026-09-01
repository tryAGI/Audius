#nullable enable

namespace Audius
{
    public partial interface ITracksClient
    {
        /// <summary>
        /// Updates an existing track
        /// </summary>
        /// <param name="trackId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.WriteResponse> UpdateTrackAsync(
            string trackId,
            string userId,

            global::Audius.UpdateTrackRequestBody request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates an existing track
        /// </summary>
        /// <param name="trackId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.WriteResponse>> UpdateTrackAsResponseAsync(
            string trackId,
            string userId,

            global::Audius.UpdateTrackRequestBody request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates an existing track
        /// </summary>
        /// <param name="trackId"></param>
        /// <param name="userId"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.WriteResponse> UpdateTrackAsync(
            string trackId,
            string userId,
            string? title = default,
            global::Audius.Genre? genre = default,
            string? description = default,
            global::Audius.Mood? mood = default,
            double? bpm = default,
            string? musicalKey = default,
            string? tags = default,
            string? license = default,
            string? isrc = default,
            string? iswc = default,
            global::System.DateTime? releaseDate = default,
            string? trackCid = default,
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
            string? parentalWarningType = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}