#nullable enable

namespace Audius
{
    public partial interface ICoinsClient
    {
        /// <summary>
        /// Claims a coin reward for a given mint
        /// </summary>
        /// <param name="mint">
        /// Example: 9LzCMqDgTKYz9Drzqnpgee3SGa89up3a247ypMj2xrqM
        /// </param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.ClaimRewardsResponse> ClaimCoinRewardAsync(
            string mint,
            string userId,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Claims a coin reward for a given mint
        /// </summary>
        /// <param name="mint">
        /// Example: 9LzCMqDgTKYz9Drzqnpgee3SGa89up3a247ypMj2xrqM
        /// </param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.ClaimRewardsResponse>> ClaimCoinRewardAsResponseAsync(
            string mint,
            string userId,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}