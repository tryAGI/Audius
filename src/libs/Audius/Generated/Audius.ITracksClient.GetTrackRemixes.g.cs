#nullable enable

namespace Audius
{
    public partial interface ITracksClient
    {
        /// <summary>
        /// Get all tracks that remix the given track
        /// </summary>
        /// <param name="trackId"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="sortMethod">
        /// Default Value: recent
        /// </param>
        /// <param name="onlyCosigns"></param>
        /// <param name="onlyContestEntries"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.RemixesResponse> GetTrackRemixesAsync(
            string trackId,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetTrackRemixesSortMethod? sortMethod = default,
            bool? onlyCosigns = default,
            bool? onlyContestEntries = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get all tracks that remix the given track
        /// </summary>
        /// <param name="trackId"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="sortMethod">
        /// Default Value: recent
        /// </param>
        /// <param name="onlyCosigns"></param>
        /// <param name="onlyContestEntries"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.RemixesResponse>> GetTrackRemixesAsResponseAsync(
            string trackId,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetTrackRemixesSortMethod? sortMethod = default,
            bool? onlyCosigns = default,
            bool? onlyContestEntries = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}