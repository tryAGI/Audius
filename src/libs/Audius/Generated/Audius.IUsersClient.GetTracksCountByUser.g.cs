#nullable enable

namespace Audius
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Gets the count of tracks created by a user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="filterTracks">
        /// Default Value: all
        /// </param>
        /// <param name="gateCondition"></param>
        /// <param name="encodedDataMessage"></param>
        /// <param name="encodedDataSignature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.TracksCountResponse> GetTracksCountByUserAsync(
            string id,
            string? userId = default,
            global::Audius.GetTracksCountByUserFilterTracks? filterTracks = default,
            global::System.Collections.Generic.IList<global::Audius.GetTracksCountByUserGateConditionItem>? gateCondition = default,
            string? encodedDataMessage = default,
            string? encodedDataSignature = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the count of tracks created by a user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="filterTracks">
        /// Default Value: all
        /// </param>
        /// <param name="gateCondition"></param>
        /// <param name="encodedDataMessage"></param>
        /// <param name="encodedDataSignature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.TracksCountResponse>> GetTracksCountByUserAsResponseAsync(
            string id,
            string? userId = default,
            global::Audius.GetTracksCountByUserFilterTracks? filterTracks = default,
            global::System.Collections.Generic.IList<global::Audius.GetTracksCountByUserGateConditionItem>? gateCondition = default,
            string? encodedDataMessage = default,
            string? encodedDataSignature = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}