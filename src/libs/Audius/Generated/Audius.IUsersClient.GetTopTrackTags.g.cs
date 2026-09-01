#nullable enable

namespace Audius
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Fetch most used tags in a user's tracks<br/>
        /// Gets the most used track tags by a user.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.TagsResponse> GetTopTrackTagsAsync(
            string id,
            int? limit = default,
            string? userId = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fetch most used tags in a user's tracks<br/>
        /// Gets the most used track tags by a user.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.TagsResponse>> GetTopTrackTagsAsResponseAsync(
            string id,
            int? limit = default,
            string? userId = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}