#nullable enable

namespace Audius
{
    public partial interface IRewardsClient
    {
        /// <summary>
        /// Claims all the filtered undisbursed rewards for a user
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.ClaimRewardsResponse> ClaimRewardsAsync(

            global::Audius.ClaimRewardsRequestBody request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Claims all the filtered undisbursed rewards for a user
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.ClaimRewardsResponse>> ClaimRewardsAsResponseAsync(

            global::Audius.ClaimRewardsRequestBody request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Claims all the filtered undisbursed rewards for a user
        /// </summary>
        /// <param name="challengeId">
        /// The challenge ID to filter rewards (optional)<br/>
        /// Example: u
        /// </param>
        /// <param name="specifier">
        /// The specifier to filter rewards (optional)<br/>
        /// Example: 7eP5n
        /// </param>
        /// <param name="userId">
        /// The user ID to claim rewards for<br/>
        /// Example: 7eP5n
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.ClaimRewardsResponse> ClaimRewardsAsync(
            string userId,
            string? challengeId = default,
            string? specifier = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}