#nullable enable

namespace Audius
{
    public partial interface ITracksClient
    {
        /// <summary>
        /// Gets random tracks found on the "Feeling Lucky" smart playlist
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="withUsers">
        /// Default Value: false
        /// </param>
        /// <param name="minFollowers"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.TracksResponse> GetFeelingLuckyTracksAsync(
            string? userId = default,
            int? limit = default,
            bool? withUsers = default,
            int? minFollowers = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets random tracks found on the "Feeling Lucky" smart playlist
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="withUsers">
        /// Default Value: false
        /// </param>
        /// <param name="minFollowers"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.TracksResponse>> GetFeelingLuckyTracksAsResponseAsync(
            string? userId = default,
            int? limit = default,
            bool? withUsers = default,
            int? minFollowers = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}