#nullable enable

namespace Audius
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Gets the tracks created by a user using their user ID
        /// </summary>
        /// <param name="id"></param>
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
        /// <param name="gateCondition"></param>
        /// <param name="encodedDataMessage"></param>
        /// <param name="encodedDataSignature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.Tracks> GetTracksByUserAsync(
            string id,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetTracksByUserSort? sort = default,
            string? query = default,
            global::Audius.GetTracksByUserSortMethod? sortMethod = default,
            global::Audius.GetTracksByUserSortDirection? sortDirection = default,
            global::Audius.GetTracksByUserFilterTracks? filterTracks = default,
            global::System.Collections.Generic.IList<global::Audius.GetTracksByUserGateConditionItem>? gateCondition = default,
            string? encodedDataMessage = default,
            string? encodedDataSignature = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the tracks created by a user using their user ID
        /// </summary>
        /// <param name="id"></param>
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
        /// <param name="gateCondition"></param>
        /// <param name="encodedDataMessage"></param>
        /// <param name="encodedDataSignature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.Tracks>> GetTracksByUserAsResponseAsync(
            string id,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetTracksByUserSort? sort = default,
            string? query = default,
            global::Audius.GetTracksByUserSortMethod? sortMethod = default,
            global::Audius.GetTracksByUserSortDirection? sortDirection = default,
            global::Audius.GetTracksByUserFilterTracks? filterTracks = default,
            global::System.Collections.Generic.IList<global::Audius.GetTracksByUserGateConditionItem>? gateCondition = default,
            string? encodedDataMessage = default,
            string? encodedDataSignature = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}