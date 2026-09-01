#nullable enable

namespace Audius
{
    public partial interface ITracksClient
    {
        /// <summary>
        /// Get recommended tracks using the given trending strategy version
        /// </summary>
        /// <param name="version"></param>
        /// <param name="limit"></param>
        /// <param name="genre"></param>
        /// <param name="time"></param>
        /// <param name="exclusionList"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.TracksResponse> GetRecommendedTracksWithVersionAsync(
            string version,
            int? limit = default,
            string? genre = default,
            global::Audius.GetRecommendedTracksWithVersionTime? time = default,
            global::System.Collections.Generic.IList<int>? exclusionList = default,
            string? userId = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get recommended tracks using the given trending strategy version
        /// </summary>
        /// <param name="version"></param>
        /// <param name="limit"></param>
        /// <param name="genre"></param>
        /// <param name="time"></param>
        /// <param name="exclusionList"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.TracksResponse>> GetRecommendedTracksWithVersionAsResponseAsync(
            string version,
            int? limit = default,
            string? genre = default,
            global::Audius.GetRecommendedTracksWithVersionTime? time = default,
            global::System.Collections.Generic.IList<int>? exclusionList = default,
            string? userId = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}