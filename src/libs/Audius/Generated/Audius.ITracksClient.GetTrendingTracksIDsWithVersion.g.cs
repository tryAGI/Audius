#nullable enable

namespace Audius
{
    public partial interface ITracksClient
    {
        /// <summary>
        /// Gets the track IDs of the top trending tracks on Audius based on the given trending strategy version
        /// </summary>
        /// <param name="version"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="genre"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.TrendingIdsResponse> GetTrendingTracksIDsWithVersionAsync(
            string version,
            int? offset = default,
            int? limit = default,
            string? genre = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the track IDs of the top trending tracks on Audius based on the given trending strategy version
        /// </summary>
        /// <param name="version"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="genre"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.TrendingIdsResponse>> GetTrendingTracksIDsWithVersionAsResponseAsync(
            string version,
            int? offset = default,
            int? limit = default,
            string? genre = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}