#nullable enable

namespace Audius
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Gets information about a specific coin owned by the user and their wallets
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mint">
        /// Example: Dez1g5f3h4j5k6l7m8n9o0p1q2r3s4t5u6v7w8x9y0z
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.UserCoinResponse> GetUserCoinAsync(
            string id,
            string mint,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets information about a specific coin owned by the user and their wallets
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mint">
        /// Example: Dez1g5f3h4j5k6l7m8n9o0p1q2r3s4t5u6v7w8x9y0z
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.UserCoinResponse>> GetUserCoinAsResponseAsync(
            string id,
            string mint,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}