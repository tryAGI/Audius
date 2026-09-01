#nullable enable

namespace Audius
{
    public partial interface IExploreClient
    {
        /// <summary>
        /// Get best selling tracks and playlists with related entities<br/>
        /// Get best selling tracks and/or albums with related entities
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="type">
        /// Default Value: all
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.BestSellingResponse> GetBestSellingAsync(
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetBestSellingType? type = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get best selling tracks and playlists with related entities<br/>
        /// Get best selling tracks and/or albums with related entities
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="type">
        /// Default Value: all
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.BestSellingResponse>> GetBestSellingAsResponseAsync(
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetBestSellingType? type = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}