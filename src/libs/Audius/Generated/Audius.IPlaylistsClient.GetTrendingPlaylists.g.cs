#nullable enable

namespace Audius
{
    public partial interface IPlaylistsClient
    {
        /// <summary>
        /// Returns trending playlists for a time period
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="time"></param>
        /// <param name="type">
        /// Default Value: playlist
        /// </param>
        /// <param name="omitTracks">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.TrendingPlaylistsResponse> GetTrendingPlaylistsAsync(
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetTrendingPlaylistsTime? time = default,
            global::Audius.GetTrendingPlaylistsType? type = default,
            bool? omitTracks = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns trending playlists for a time period
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="time"></param>
        /// <param name="type">
        /// Default Value: playlist
        /// </param>
        /// <param name="omitTracks">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.TrendingPlaylistsResponse>> GetTrendingPlaylistsAsResponseAsync(
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetTrendingPlaylistsTime? time = default,
            global::Audius.GetTrendingPlaylistsType? type = default,
            bool? omitTracks = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}