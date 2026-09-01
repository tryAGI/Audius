#nullable enable

namespace Audius
{
    public partial interface IPlaylistsClient
    {
        /// <summary>
        /// Returns trending playlists for a time period based on the given trending version
        /// </summary>
        /// <param name="version"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="time"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.TrendingPlaylistsResponse> GetTrendingPlaylistsWithVersionAsync(
            string version,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetTrendingPlaylistsWithVersionTime? time = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns trending playlists for a time period based on the given trending version
        /// </summary>
        /// <param name="version"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="time"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.TrendingPlaylistsResponse>> GetTrendingPlaylistsWithVersionAsResponseAsync(
            string version,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetTrendingPlaylistsWithVersionTime? time = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}