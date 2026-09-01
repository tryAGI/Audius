#nullable enable

namespace Audius
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Search for users that match the given query
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="query"></param>
        /// <param name="genre"></param>
        /// <param name="sortMethod"></param>
        /// <param name="isVerified"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.UserSearch> SearchUsersAsync(
            int? offset = default,
            int? limit = default,
            string? query = default,
            global::System.Collections.Generic.IList<string>? genre = default,
            global::Audius.SearchUsersSortMethod? sortMethod = default,
            string? isVerified = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search for users that match the given query
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="query"></param>
        /// <param name="genre"></param>
        /// <param name="sortMethod"></param>
        /// <param name="isVerified"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.UserSearch>> SearchUsersAsResponseAsync(
            int? offset = default,
            int? limit = default,
            string? query = default,
            global::System.Collections.Generic.IList<string>? genre = default,
            global::Audius.SearchUsersSortMethod? sortMethod = default,
            string? isVerified = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}