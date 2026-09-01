#nullable enable

namespace Audius
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get all users who have authorized a particular grantee (developer app) identified by their wallet address. Supports pagination.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="isApproved"></param>
        /// <param name="isRevoked">
        /// Default Value: false
        /// </param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.FollowersResponse> GetGranteeUsersAsync(
            string address,
            int? offset = default,
            int? limit = default,
            bool? isApproved = default,
            bool? isRevoked = default,
            string? userId = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get all users who have authorized a particular grantee (developer app) identified by their wallet address. Supports pagination.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="isApproved"></param>
        /// <param name="isRevoked">
        /// Default Value: false
        /// </param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.FollowersResponse>> GetGranteeUsersAsResponseAsync(
            string address,
            int? offset = default,
            int? limit = default,
            bool? isApproved = default,
            bool? isRevoked = default,
            string? userId = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}