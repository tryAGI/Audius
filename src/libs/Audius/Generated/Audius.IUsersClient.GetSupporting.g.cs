#nullable enable

namespace Audius
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Gets the support from the given user to the supported user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="supportedUserId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.GetSupporting> GetSupportingAsync(
            string id,
            string supportedUserId,
            string? userId = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the support from the given user to the supported user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="supportedUserId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.GetSupporting>> GetSupportingAsResponseAsync(
            string id,
            string supportedUserId,
            string? userId = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}