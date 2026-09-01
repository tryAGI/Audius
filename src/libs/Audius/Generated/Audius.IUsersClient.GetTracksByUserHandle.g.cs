#nullable enable

namespace Audius
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Gets the tracks created by a user using the user's handle
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
        global::System.Threading.Tasks.Task<global::Audius.Tracks> GetTracksByUserHandleAsync(
            string handle,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetTracksByUserHandleSort? sort = default,
            string? query = default,
            global::Audius.GetTracksByUserHandleSortMethod? sortMethod = default,
            global::Audius.GetTracksByUserHandleSortDirection? sortDirection = default,
            global::Audius.GetTracksByUserHandleFilterTracks? filterTracks = default,
            string? encodedDataMessage = default,
            string? encodedDataSignature = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the tracks created by a user using the user's handle
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
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.Tracks>> GetTracksByUserHandleAsResponseAsync(
            string handle,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetTracksByUserHandleSort? sort = default,
            string? query = default,
            global::Audius.GetTracksByUserHandleSortMethod? sortMethod = default,
            global::Audius.GetTracksByUserHandleSortDirection? sortDirection = default,
            global::Audius.GetTracksByUserHandleFilterTracks? filterTracks = default,
            string? encodedDataMessage = default,
            string? encodedDataSignature = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}