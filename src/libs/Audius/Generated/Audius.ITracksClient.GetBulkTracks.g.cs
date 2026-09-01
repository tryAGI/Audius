#nullable enable

namespace Audius
{
    public partial interface ITracksClient
    {
        /// <summary>
        /// Gets a list of tracks using their IDs or permalinks
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="permalink"></param>
        /// <param name="id"></param>
        /// <param name="isrc"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.TracksResponse> GetBulkTracksAsync(
            string? userId = default,
            global::System.Collections.Generic.IList<string>? permalink = default,
            global::System.Collections.Generic.IList<string>? id = default,
            global::System.Collections.Generic.IList<string>? isrc = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets a list of tracks using their IDs or permalinks
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="permalink"></param>
        /// <param name="id"></param>
        /// <param name="isrc"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.TracksResponse>> GetBulkTracksAsResponseAsync(
            string? userId = default,
            global::System.Collections.Generic.IList<string>? permalink = default,
            global::System.Collections.Generic.IList<string>? id = default,
            global::System.Collections.Generic.IList<string>? isrc = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}