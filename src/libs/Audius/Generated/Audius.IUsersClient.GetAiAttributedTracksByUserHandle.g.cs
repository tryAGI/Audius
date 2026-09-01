#nullable enable

namespace Audius
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Gets the AI generated tracks attributed to a user using the user's handle
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="sort">
        /// Default Value: date
        /// </param>
        /// <param name="query"></param>
        /// <param name="sortMethod"></param>
        /// <param name="sortDirection"></param>
        /// <param name="filterTracks">
        /// Default Value: all
        /// </param>
        /// <param name="encodedDataMessage"></param>
        /// <param name="encodedDataSignature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.Tracks> GetAiAttributedTracksByUserHandleAsync(
            string handle,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetAiAttributedTracksByUserHandleSort? sort = default,
            string? query = default,
            global::Audius.GetAiAttributedTracksByUserHandleSortMethod? sortMethod = default,
            global::Audius.GetAiAttributedTracksByUserHandleSortDirection? sortDirection = default,
            global::Audius.GetAiAttributedTracksByUserHandleFilterTracks? filterTracks = default,
            string? encodedDataMessage = default,
            string? encodedDataSignature = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the AI generated tracks attributed to a user using the user's handle
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="sort">
        /// Default Value: date
        /// </param>
        /// <param name="query"></param>
        /// <param name="sortMethod"></param>
        /// <param name="sortDirection"></param>
        /// <param name="filterTracks">
        /// Default Value: all
        /// </param>
        /// <param name="encodedDataMessage"></param>
        /// <param name="encodedDataSignature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.Tracks>> GetAiAttributedTracksByUserHandleAsResponseAsync(
            string handle,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetAiAttributedTracksByUserHandleSort? sort = default,
            string? query = default,
            global::Audius.GetAiAttributedTracksByUserHandleSortMethod? sortMethod = default,
            global::Audius.GetAiAttributedTracksByUserHandleSortDirection? sortDirection = default,
            global::Audius.GetAiAttributedTracksByUserHandleFilterTracks? filterTracks = default,
            string? encodedDataMessage = default,
            string? encodedDataSignature = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}