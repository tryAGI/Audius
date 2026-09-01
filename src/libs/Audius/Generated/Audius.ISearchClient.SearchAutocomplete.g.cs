#nullable enable

namespace Audius
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Get Users/Tracks/Playlists/Albums that best match the search query<br/>
        /// Same as search but optimized for quicker response at the cost of some entity information.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="query"></param>
        /// <param name="kind">
        /// Default Value: all
        /// </param>
        /// <param name="includePurchaseable"></param>
        /// <param name="genre"></param>
        /// <param name="mood"></param>
        /// <param name="isVerified"></param>
        /// <param name="hasDownloads"></param>
        /// <param name="isPurchaseable"></param>
        /// <param name="key"></param>
        /// <param name="bpmMin"></param>
        /// <param name="bpmMax"></param>
        /// <param name="sortMethod"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.SearchAutocompleteResponse> SearchAutocompleteAsync(
            int? offset = default,
            int? limit = default,
            string? userId = default,
            string? query = default,
            global::Audius.SearchAutocompleteKind? kind = default,
            bool? includePurchaseable = default,
            global::System.Collections.Generic.IList<string>? genre = default,
            global::System.Collections.Generic.IList<string>? mood = default,
            bool? isVerified = default,
            bool? hasDownloads = default,
            bool? isPurchaseable = default,
            global::System.Collections.Generic.IList<string>? key = default,
            double? bpmMin = default,
            double? bpmMax = default,
            global::Audius.SearchAutocompleteSortMethod? sortMethod = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Users/Tracks/Playlists/Albums that best match the search query<br/>
        /// Same as search but optimized for quicker response at the cost of some entity information.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="query"></param>
        /// <param name="kind">
        /// Default Value: all
        /// </param>
        /// <param name="includePurchaseable"></param>
        /// <param name="genre"></param>
        /// <param name="mood"></param>
        /// <param name="isVerified"></param>
        /// <param name="hasDownloads"></param>
        /// <param name="isPurchaseable"></param>
        /// <param name="key"></param>
        /// <param name="bpmMin"></param>
        /// <param name="bpmMax"></param>
        /// <param name="sortMethod"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.SearchAutocompleteResponse>> SearchAutocompleteAsResponseAsync(
            int? offset = default,
            int? limit = default,
            string? userId = default,
            string? query = default,
            global::Audius.SearchAutocompleteKind? kind = default,
            bool? includePurchaseable = default,
            global::System.Collections.Generic.IList<string>? genre = default,
            global::System.Collections.Generic.IList<string>? mood = default,
            bool? isVerified = default,
            bool? hasDownloads = default,
            bool? isPurchaseable = default,
            global::System.Collections.Generic.IList<string>? key = default,
            double? bpmMin = default,
            double? bpmMax = default,
            global::Audius.SearchAutocompleteSortMethod? sortMethod = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}