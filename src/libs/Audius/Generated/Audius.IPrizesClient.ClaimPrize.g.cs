#nullable enable

namespace Audius
{
    public partial interface IPrizesClient
    {
        /// <summary>
        /// Claims a prize by verifying a Solana transaction. User must send exactly 2 YAK to the prize receiver address. Returns the prize won and any redeem codes/URLs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.PrizeClaimResponse> ClaimPrizeAsync(

            global::Audius.PrizeClaimRequestBody request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Claims a prize by verifying a Solana transaction. User must send exactly 2 YAK to the prize receiver address. Returns the prize won and any redeem codes/URLs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.PrizeClaimResponse>> ClaimPrizeAsResponseAsync(

            global::Audius.PrizeClaimRequestBody request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Claims a prize by verifying a Solana transaction. User must send exactly 2 YAK to the prize receiver address. Returns the prize won and any redeem codes/URLs.
        /// </summary>
        /// <param name="signature">
        /// The Solana transaction signature for the 2 YAK payment<br/>
        /// Example: 5j7s1QjmRKFuDbCWMRVRNibSV2VAAEcNKP6HWU7GwPdXkBZvhz8n4vQl7bBq8tN4Rz9x1Kj3mP5wQ8rT2Y6zA
        /// </param>
        /// <param name="wallet">
        /// The wallet address that sent the transaction<br/>
        /// Example: HLnpSz9h2S4hiLQ43rnSD9XkcUThA7B8hQMKmDaiTLcC
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.PrizeClaimResponse> ClaimPrizeAsync(
            string signature,
            string wallet,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}