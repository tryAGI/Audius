#nullable enable

namespace Audius
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Fetch a user's full library tracks<br/>
        /// Gets a user's saved/reposted/purchased/all tracks
        /// </summary>
        /// <param name="id"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="query"></param>
        /// <param name="sortMethod"></param>
        /// <param name="sortDirection"></param>
        /// <param name="type">
        /// Default Value: favorite
        /// </param>
        /// <param name="encodedDataMessage"></param>
        /// <param name="encodedDataSignature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.TrackLibraryResponse> GetUserLibraryTracksAsync(
            string id,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            string? query = default,
            global::Audius.GetUserLibraryTracksSortMethod? sortMethod = default,
            global::Audius.GetUserLibraryTracksSortDirection? sortDirection = default,
            global::Audius.GetUserLibraryTracksType? type = default,
            string? encodedDataMessage = default,
            string? encodedDataSignature = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fetch a user's full library tracks<br/>
        /// Gets a user's saved/reposted/purchased/all tracks
        /// </summary>
        /// <param name="id"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="query"></param>
        /// <param name="sortMethod"></param>
        /// <param name="sortDirection"></param>
        /// <param name="type">
        /// Default Value: favorite
        /// </param>
        /// <param name="encodedDataMessage"></param>
        /// <param name="encodedDataSignature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.TrackLibraryResponse>> GetUserLibraryTracksAsResponseAsync(
            string id,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            string? query = default,
            global::Audius.GetUserLibraryTracksSortMethod? sortMethod = default,
            global::Audius.GetUserLibraryTracksSortDirection? sortDirection = default,
            global::Audius.GetUserLibraryTracksType? type = default,
            string? encodedDataMessage = default,
            string? encodedDataSignature = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}