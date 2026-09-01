#nullable enable

namespace Audius
{
    public partial interface IPlaylistsClient
    {
        /// <summary>
        /// Favorite a playlist
        /// </summary>
        /// <param name="playlistId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.WriteResponse> FavoritePlaylistAsync(
            string playlistId,
            string userId,

            global::Audius.FavoriteRequestBody request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Favorite a playlist
        /// </summary>
        /// <param name="playlistId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.WriteResponse>> FavoritePlaylistAsResponseAsync(
            string playlistId,
            string userId,

            global::Audius.FavoriteRequestBody request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Favorite a playlist
        /// </summary>
        /// <param name="playlistId"></param>
        /// <param name="userId"></param>
        /// <param name="isSaveOfRepost">
        /// Set to true when favoriting a reposted item (used for notifications)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.WriteResponse> FavoritePlaylistAsync(
            string playlistId,
            string userId,
            bool? isSaveOfRepost = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}