#nullable enable

namespace Audius
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Gets the recommended tracks for the user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="timeRange">
        /// Default Value: week
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.Tracks> GetUserRecommendedTracksAsync(
            string id,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetUserRecommendedTracksTimeRange? timeRange = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the recommended tracks for the user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="timeRange">
        /// Default Value: week
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.Tracks>> GetUserRecommendedTracksAsResponseAsync(
            string id,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetUserRecommendedTracksTimeRange? timeRange = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}