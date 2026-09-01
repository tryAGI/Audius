#nullable enable

namespace Audius
{
    public partial interface IWalletClient
    {
        /// <summary>
        /// Gets a list of the coins held by a wallet address and their balances
        /// </summary>
        /// <param name="walletId">
        /// Example: Dez1g5f3h4j5k6l7m8n9o0p1q2r3s4t5u6v7w8x9y0z
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.UserCoinsResponse> GetWalletCoinsAsync(
            string walletId,
            int? offset = default,
            int? limit = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets a list of the coins held by a wallet address and their balances
        /// </summary>
        /// <param name="walletId">
        /// Example: Dez1g5f3h4j5k6l7m8n9o0p1q2r3s4t5u6v7w8x9y0z
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.UserCoinsResponse>> GetWalletCoinsAsResponseAsync(
            string walletId,
            int? offset = default,
            int? limit = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}