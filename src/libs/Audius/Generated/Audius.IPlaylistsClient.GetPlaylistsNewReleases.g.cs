#nullable enable

namespace Audius
{
    public partial interface IPlaylistsClient
    {
        /// <summary>
        /// Returns recently released playlists or albums
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="type">
        /// Default Value: playlist
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.TrendingPlaylistsResponse> GetPlaylistsNewReleasesAsync(
            int? offset = default,
            int? limit = default,
            global::Audius.GetPlaylistsNewReleasesType? type = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns recently released playlists or albums
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="type">
        /// Default Value: playlist
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.TrendingPlaylistsResponse>> GetPlaylistsNewReleasesAsResponseAsync(
            int? offset = default,
            int? limit = default,
            global::Audius.GetPlaylistsNewReleasesType? type = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}