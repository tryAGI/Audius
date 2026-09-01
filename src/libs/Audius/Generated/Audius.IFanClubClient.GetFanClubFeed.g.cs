#nullable enable

namespace Audius
{
    public partial interface IFanClubClient
    {
        /// <summary>
        /// Get the fan club feed for a given artist, including text posts and comments
        /// </summary>
        /// <param name="mint"></param>
        /// <param name="userId"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.TrackCommentsResponse> GetFanClubFeedAsync(
            string mint,
            string? userId = default,
            int? offset = default,
            int? limit = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the fan club feed for a given artist, including text posts and comments
        /// </summary>
        /// <param name="mint"></param>
        /// <param name="userId"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.TrackCommentsResponse>> GetFanClubFeedAsResponseAsync(
            string mint,
            string? userId = default,
            int? offset = default,
            int? limit = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}