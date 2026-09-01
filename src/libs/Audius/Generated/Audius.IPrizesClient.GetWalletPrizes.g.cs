#nullable enable

namespace Audius
{
    public partial interface IPrizesClient
    {
        /// <summary>
        /// Gets all claimed prizes for a wallet. Public endpoint - no authentication required. Excludes sensitive action_data for security.
        /// </summary>
        /// <param name="wallet">
        /// Example: HLnpSz9h2S4hiLQ43rnSD9XkcUThA7B8hQMKmDaiTLcC
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.ClaimedPrizesResponse> GetWalletPrizesAsync(
            string wallet,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets all claimed prizes for a wallet. Public endpoint - no authentication required. Excludes sensitive action_data for security.
        /// </summary>
        /// <param name="wallet">
        /// Example: HLnpSz9h2S4hiLQ43rnSD9XkcUThA7B8hQMKmDaiTLcC
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.ClaimedPrizesResponse>> GetWalletPrizesAsResponseAsync(
            string wallet,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}