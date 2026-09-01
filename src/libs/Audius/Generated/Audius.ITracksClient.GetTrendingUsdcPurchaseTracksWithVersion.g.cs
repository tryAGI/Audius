#nullable enable

namespace Audius
{
    public partial interface ITracksClient
    {
        /// <summary>
        /// Gets the top trending (most popular) USDC purchase tracks on Audius using a given trending strategy version
        /// </summary>
        /// <param name="version"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="genre"></param>
        /// <param name="time"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.TracksResponse> GetTrendingUsdcPurchaseTracksWithVersionAsync(
            string version,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            string? genre = default,
            global::Audius.GetTrendingUsdcPurchaseTracksWithVersionTime? time = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the top trending (most popular) USDC purchase tracks on Audius using a given trending strategy version
        /// </summary>
        /// <param name="version"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="genre"></param>
        /// <param name="time"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.TracksResponse>> GetTrendingUsdcPurchaseTracksWithVersionAsResponseAsync(
            string version,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            string? genre = default,
            global::Audius.GetTrendingUsdcPurchaseTracksWithVersionTime? time = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}