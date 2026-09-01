#nullable enable

namespace Audius
{
    public partial interface ICoinsClient
    {
        /// <summary>
        /// Creates a new artist coin
        /// </summary>
        /// <param name="userId">
        /// Example: 7eP5n
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.CreateCoinResponse> CreateCoinAsync(
            string userId,

            global::Audius.CreateCoinRequest request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new artist coin
        /// </summary>
        /// <param name="userId">
        /// Example: 7eP5n
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.CreateCoinResponse>> CreateCoinAsResponseAsync(
            string userId,

            global::Audius.CreateCoinRequest request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new artist coin
        /// </summary>
        /// <param name="userId">
        /// Example: 7eP5n
        /// </param>
        /// <param name="mint">
        /// The mint address of the coin<br/>
        /// Example: bearR26zyyB3fNQm5wWv1ZfN8MPQDUMwaAuoG79b1Yj
        /// </param>
        /// <param name="ticker">
        /// The coin symbol/ticker<br/>
        /// Example: BEAR
        /// </param>
        /// <param name="decimals">
        /// The number of decimals for the coin (0-18)<br/>
        /// Example: 9
        /// </param>
        /// <param name="name">
        /// The coin name<br/>
        /// Example: BEAR
        /// </param>
        /// <param name="logoUri">
        /// The URI for the coin's logo image<br/>
        /// Example: https://example.com/logo.png
        /// </param>
        /// <param name="bannerImageUrl">
        /// The URI for the coin's banner image<br/>
        /// Example: https://example.com/banner.png
        /// </param>
        /// <param name="description">
        /// The description of the coin<br/>
        /// Example: A majestic bear token for wildlife conservation
        /// </param>
        /// <param name="link1">
        /// Generic link URL for the coin<br/>
        /// Example: https://x.com/bear_token
        /// </param>
        /// <param name="link2">
        /// Generic link URL for the coin<br/>
        /// Example: https://instagram.com/bear_token
        /// </param>
        /// <param name="link3">
        /// Generic link URL for the coin<br/>
        /// Example: https://tiktok.com/@bear_token
        /// </param>
        /// <param name="link4">
        /// Generic link URL for the coin<br/>
        /// Example: https://bear-token.com
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.CreateCoinResponse> CreateCoinAsync(
            string userId,
            string mint,
            string ticker,
            int decimals,
            string name,
            string? logoUri = default,
            string? bannerImageUrl = default,
            string? description = default,
            string? link1 = default,
            string? link2 = default,
            string? link3 = default,
            string? link4 = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}