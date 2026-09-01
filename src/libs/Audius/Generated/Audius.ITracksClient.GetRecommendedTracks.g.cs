#nullable enable

namespace Audius
{
    public partial interface ITracksClient
    {
        /// <summary>
        /// Get recommended tracks
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="genre"></param>
        /// <param name="time"></param>
        /// <param name="exclusionList"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.TracksResponse> GetRecommendedTracksAsync(
            int? limit = default,
            string? genre = default,
            global::Audius.GetRecommendedTracksTime? time = default,
            global::System.Collections.Generic.IList<int>? exclusionList = default,
            string? userId = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get recommended tracks
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="genre"></param>
        /// <param name="time"></param>
        /// <param name="exclusionList"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.TracksResponse>> GetRecommendedTracksAsResponseAsync(
            int? limit = default,
            string? genre = default,
            global::Audius.GetRecommendedTracksTime? time = default,
            global::System.Collections.Generic.IList<int>? exclusionList = default,
            string? userId = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}