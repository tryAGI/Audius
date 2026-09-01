#nullable enable

namespace Audius
{
    public partial interface ICoinsClient
    {
        /// <summary>
        /// Gets a list of Audius users with a non-zero balance of a specific coin
        /// </summary>
        /// <param name="mint">
        /// Example: 9LzCMqDgTKYz9Drzqnpgee3SGa89up3a247ypMj2xrqM
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="sortDirection">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.CoinMembersResponse> GetCoinMembersAsync(
            string mint,
            int? offset = default,
            int? limit = default,
            global::Audius.GetCoinMembersSortDirection? sortDirection = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets a list of Audius users with a non-zero balance of a specific coin
        /// </summary>
        /// <param name="mint">
        /// Example: 9LzCMqDgTKYz9Drzqnpgee3SGa89up3a247ypMj2xrqM
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="sortDirection">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.CoinMembersResponse>> GetCoinMembersAsResponseAsync(
            string mint,
            int? offset = default,
            int? limit = default,
            global::Audius.GetCoinMembersSortDirection? sortDirection = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}