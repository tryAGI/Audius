#nullable enable

namespace Audius
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Gets User IDs from any Ethereum wallet address or Solana account address associated with their Audius account.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.UserIdsAddressesResponse> GetUserIDsByAddressesAsync(
            global::System.Collections.Generic.IList<string> address,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets User IDs from any Ethereum wallet address or Solana account address associated with their Audius account.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.UserIdsAddressesResponse>> GetUserIDsByAddressesAsResponseAsync(
            global::System.Collections.Generic.IList<string> address,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}