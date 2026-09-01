#nullable enable

namespace Audius
{
    public partial interface IDashboardWalletUsersClient
    {
        /// <summary>
        /// Gets Audius user profiles connected to given dashboard wallet addresses
        /// </summary>
        /// <param name="wallets"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.DashboardWalletUsersResponse> BulkGetDashboardWalletUsersAsync(
            global::System.Collections.Generic.IList<string> wallets,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets Audius user profiles connected to given dashboard wallet addresses
        /// </summary>
        /// <param name="wallets"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.DashboardWalletUsersResponse>> BulkGetDashboardWalletUsersAsResponseAsync(
            global::System.Collections.Generic.IList<string> wallets,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}