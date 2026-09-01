#nullable enable

namespace Audius
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Gets the encrypted key for email access between the receiving user and granting user.
        /// </summary>
        /// <param name="receivingUserId"></param>
        /// <param name="grantorUserId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.EmailAccessResponse> GetUserEmailKeyAsync(
            string receivingUserId,
            string grantorUserId,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the encrypted key for email access between the receiving user and granting user.
        /// </summary>
        /// <param name="receivingUserId"></param>
        /// <param name="grantorUserId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.EmailAccessResponse>> GetUserEmailKeyAsResponseAsync(
            string receivingUserId,
            string grantorUserId,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}