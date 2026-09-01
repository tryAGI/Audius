#nullable enable

namespace Audius
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Gets a user's favorite tracks
        /// </summary>
        /// <param name="id"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="query"></param>
        /// <param name="sortMethod"></param>
        /// <param name="sortDirection"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.TrackLibraryResponse> GetUserFavoriteTracksAsync(
            string id,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            string? query = default,
            global::Audius.GetUserFavoriteTracksSortMethod? sortMethod = default,
            global::Audius.GetUserFavoriteTracksSortDirection? sortDirection = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets a user's favorite tracks
        /// </summary>
        /// <param name="id"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="query"></param>
        /// <param name="sortMethod"></param>
        /// <param name="sortDirection"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.TrackLibraryResponse>> GetUserFavoriteTracksAsResponseAsync(
            string id,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            string? query = default,
            global::Audius.GetUserFavoriteTracksSortMethod? sortMethod = default,
            global::Audius.GetUserFavoriteTracksSortDirection? sortDirection = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}