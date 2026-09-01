#nullable enable

namespace Audius
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get authenticated user<br/>
        /// Returns the full profile of the currently authenticated user based on the Bearer access token obtained via OAuth.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.UserResponseSingle> GetMeAsync(
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get authenticated user<br/>
        /// Returns the full profile of the currently authenticated user based on the Bearer access token obtained via OAuth.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.UserResponseSingle>> GetMeAsResponseAsync(
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}