#nullable enable

namespace Audius
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Fetch a user's full library playlists<br/>
        /// Gets a user's saved/reposted/purchased/all playlists
        /// </summary>
        /// <param name="id"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="query"></param>
        /// <param name="sortDirection"></param>
        /// <param name="type">
        /// Default Value: favorite
        /// </param>
        /// <param name="sortMethod"></param>
        /// <param name="encodedDataMessage"></param>
        /// <param name="encodedDataSignature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.CollectionLibraryResponse> GetUserLibraryPlaylistsAsync(
            string id,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            string? query = default,
            global::Audius.GetUserLibraryPlaylistsSortDirection? sortDirection = default,
            global::Audius.GetUserLibraryPlaylistsType? type = default,
            global::Audius.GetUserLibraryPlaylistsSortMethod? sortMethod = default,
            string? encodedDataMessage = default,
            string? encodedDataSignature = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fetch a user's full library playlists<br/>
        /// Gets a user's saved/reposted/purchased/all playlists
        /// </summary>
        /// <param name="id"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="query"></param>
        /// <param name="sortDirection"></param>
        /// <param name="type">
        /// Default Value: favorite
        /// </param>
        /// <param name="sortMethod"></param>
        /// <param name="encodedDataMessage"></param>
        /// <param name="encodedDataSignature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.CollectionLibraryResponse>> GetUserLibraryPlaylistsAsResponseAsync(
            string id,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            string? query = default,
            global::Audius.GetUserLibraryPlaylistsSortDirection? sortDirection = default,
            global::Audius.GetUserLibraryPlaylistsType? type = default,
            global::Audius.GetUserLibraryPlaylistsSortMethod? sortMethod = default,
            string? encodedDataMessage = default,
            string? encodedDataSignature = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}