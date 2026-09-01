#nullable enable

namespace Audius
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Gets the count of unique users who have remixed tracks by the given user, or a specific track by that user if provided
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="trackId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.RemixersCountResponse> GetRemixersCountAsync(
            string id,
            string? userId = default,
            string? trackId = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the count of unique users who have remixed tracks by the given user, or a specific track by that user if provided
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="trackId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.RemixersCountResponse>> GetRemixersCountAsResponseAsync(
            string id,
            string? userId = default,
            string? trackId = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}