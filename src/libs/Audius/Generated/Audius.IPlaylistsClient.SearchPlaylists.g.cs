#nullable enable

namespace Audius
{
    public partial interface IPlaylistsClient
    {
        /// <summary>
        /// Search for a playlist
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="query"></param>
        /// <param name="genre"></param>
        /// <param name="sortMethod"></param>
        /// <param name="mood"></param>
        /// <param name="includePurchaseable"></param>
        /// <param name="hasDownloads"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.PlaylistSearchResult> SearchPlaylistsAsync(
            int? offset = default,
            int? limit = default,
            string? query = default,
            global::System.Collections.Generic.IList<string>? genre = default,
            global::Audius.SearchPlaylistsSortMethod? sortMethod = default,
            global::System.Collections.Generic.IList<string>? mood = default,
            string? includePurchaseable = default,
            string? hasDownloads = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search for a playlist
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="query"></param>
        /// <param name="genre"></param>
        /// <param name="sortMethod"></param>
        /// <param name="mood"></param>
        /// <param name="includePurchaseable"></param>
        /// <param name="hasDownloads"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.PlaylistSearchResult>> SearchPlaylistsAsResponseAsync(
            int? offset = default,
            int? limit = default,
            string? query = default,
            global::System.Collections.Generic.IList<string>? genre = default,
            global::Audius.SearchPlaylistsSortMethod? sortMethod = default,
            global::System.Collections.Generic.IList<string>? mood = default,
            string? includePurchaseable = default,
            string? hasDownloads = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}