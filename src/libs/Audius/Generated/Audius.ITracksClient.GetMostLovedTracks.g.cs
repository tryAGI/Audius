#nullable enable

namespace Audius
{
    public partial interface ITracksClient
    {
        /// <summary>
        /// Gets the tracks found on the "Most Loved" smart playlist
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="withUsers"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.TracksResponse> GetMostLovedTracksAsync(
            string? userId = default,
            int? limit = default,
            bool? withUsers = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the tracks found on the "Most Loved" smart playlist
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="limit">
        /// Default Value: 25
        /// </param>
        /// <param name="withUsers"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.TracksResponse>> GetMostLovedTracksAsResponseAsync(
            string? userId = default,
            int? limit = default,
            bool? withUsers = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}