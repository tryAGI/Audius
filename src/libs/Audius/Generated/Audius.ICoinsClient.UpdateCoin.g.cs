#nullable enable

namespace Audius
{
    public partial interface ICoinsClient
    {
        /// <summary>
        /// Updates information about a specific coin by its mint address
        /// </summary>
        /// <param name="mint">
        /// Example: bearR26zyyB3fNQm5wWv1ZfN8MPQDUMwaAuoG79b1Yj
        /// </param>
        /// <param name="userId">
        /// Example: 7eP5n
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.UpdateCoinResponse> UpdateCoinAsync(
            string mint,
            string userId,

            global::Audius.UpdateCoinRequest request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates information about a specific coin by its mint address
        /// </summary>
        /// <param name="mint">
        /// Example: bearR26zyyB3fNQm5wWv1ZfN8MPQDUMwaAuoG79b1Yj
        /// </param>
        /// <param name="userId">
        /// Example: 7eP5n
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.UpdateCoinResponse>> UpdateCoinAsResponseAsync(
            string mint,
            string userId,

            global::Audius.UpdateCoinRequest request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates information about a specific coin by its mint address
        /// </summary>
        /// <param name="mint">
        /// Example: bearR26zyyB3fNQm5wWv1ZfN8MPQDUMwaAuoG79b1Yj
        /// </param>
        /// <param name="userId">
        /// Example: 7eP5n
        /// </param>
        /// <param name="description">
        /// The description of the coin (max 2500 characters)<br/>
        /// Example: Updated description for the bear token
        /// </param>
        /// <param name="bannerImageUrl">
        /// URL for the coin's banner image<br/>
        /// Example: https://example.com/banner.png
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
        global::System.Threading.Tasks.Task<global::Audius.UpdateCoinResponse> UpdateCoinAsync(
            string mint,
            string userId,
            string? description = default,
            string? bannerImageUrl = default,
            string? link1 = default,
            string? link2 = default,
            string? link3 = default,
            string? link4 = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}