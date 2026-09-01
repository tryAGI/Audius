#nullable enable

namespace Audius
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get the Top Users for a Given Genre
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="genre"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.TopGenreUsersResponse> GetTopUsersInGenreAsync(
            int? offset = default,
            int? limit = default,
            global::System.Collections.Generic.IList<string>? genre = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the Top Users for a Given Genre
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="genre"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.TopGenreUsersResponse>> GetTopUsersInGenreAsResponseAsync(
            int? offset = default,
            int? limit = default,
            global::System.Collections.Generic.IList<string>? genre = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}