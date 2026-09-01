#nullable enable

namespace Audius
{
    public partial interface IPlaylistsClient
    {
        /// <summary>
        /// Gets a list of playlists by ID, UPC, or permalink
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="id"></param>
        /// <param name="permalink"></param>
        /// <param name="upc"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.PlaylistResponse> GetBulkPlaylistsAsync(
            string? userId = default,
            global::System.Collections.Generic.IList<string>? id = default,
            global::System.Collections.Generic.IList<string>? permalink = default,
            global::System.Collections.Generic.IList<string>? upc = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets a list of playlists by ID, UPC, or permalink
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="id"></param>
        /// <param name="permalink"></param>
        /// <param name="upc"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.PlaylistResponse>> GetBulkPlaylistsAsResponseAsync(
            string? userId = default,
            global::System.Collections.Generic.IList<string>? id = default,
            global::System.Collections.Generic.IList<string>? permalink = default,
            global::System.Collections.Generic.IList<string>? upc = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}