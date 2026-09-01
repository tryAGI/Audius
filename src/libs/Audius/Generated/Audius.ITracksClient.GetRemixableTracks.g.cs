#nullable enable

namespace Audius
{
    public partial interface ITracksClient
    {
        /// <summary>
        /// Gets a list of tracks that have stems available for remixing
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="withUsers"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.RemixablesResponse> GetRemixableTracksAsync(
            int? limit = default,
            string? userId = default,
            bool? withUsers = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets a list of tracks that have stems available for remixing
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="withUsers"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.RemixablesResponse>> GetRemixableTracksAsResponseAsync(
            int? limit = default,
            string? userId = default,
            bool? withUsers = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}