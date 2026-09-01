#nullable enable

namespace Audius
{
    public partial interface ITracksClient
    {
        /// <summary>
        /// Search for a track or tracks
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="query"></param>
        /// <param name="genre"></param>
        /// <param name="sortMethod"></param>
        /// <param name="mood"></param>
        /// <param name="onlyDownloadable">
        /// Default Value: false
        /// </param>
        /// <param name="includePurchaseable"></param>
        /// <param name="isPurchaseable"></param>
        /// <param name="hasDownloads"></param>
        /// <param name="key"></param>
        /// <param name="bpmMin"></param>
        /// <param name="bpmMax"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.TrackSearch> SearchTracksAsync(
            int? offset = default,
            int? limit = default,
            string? query = default,
            global::System.Collections.Generic.IList<string>? genre = default,
            global::Audius.SearchTracksSortMethod? sortMethod = default,
            global::System.Collections.Generic.IList<string>? mood = default,
            string? onlyDownloadable = default,
            string? includePurchaseable = default,
            string? isPurchaseable = default,
            string? hasDownloads = default,
            global::System.Collections.Generic.IList<string>? key = default,
            string? bpmMin = default,
            string? bpmMax = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search for a track or tracks
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="query"></param>
        /// <param name="genre"></param>
        /// <param name="sortMethod"></param>
        /// <param name="mood"></param>
        /// <param name="onlyDownloadable">
        /// Default Value: false
        /// </param>
        /// <param name="includePurchaseable"></param>
        /// <param name="isPurchaseable"></param>
        /// <param name="hasDownloads"></param>
        /// <param name="key"></param>
        /// <param name="bpmMin"></param>
        /// <param name="bpmMax"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.TrackSearch>> SearchTracksAsResponseAsync(
            int? offset = default,
            int? limit = default,
            string? query = default,
            global::System.Collections.Generic.IList<string>? genre = default,
            global::Audius.SearchTracksSortMethod? sortMethod = default,
            global::System.Collections.Generic.IList<string>? mood = default,
            string? onlyDownloadable = default,
            string? includePurchaseable = default,
            string? isPurchaseable = default,
            string? hasDownloads = default,
            global::System.Collections.Generic.IList<string>? key = default,
            string? bpmMin = default,
            string? bpmMax = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}