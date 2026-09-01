#nullable enable

namespace Audius
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Gets the feed for the user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="filter">
        /// Default Value: all
        /// </param>
        /// <param name="tracksOnly"></param>
        /// <param name="withUsers"></param>
        /// <param name="followeeUserId"></param>
        /// <param name="encodedDataMessage"></param>
        /// <param name="encodedDataSignature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.UserFeedResponse> GetUserFeedAsync(
            string id,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetUserFeedFilter? filter = default,
            bool? tracksOnly = default,
            bool? withUsers = default,
            global::System.Collections.Generic.IList<int>? followeeUserId = default,
            string? encodedDataMessage = default,
            string? encodedDataSignature = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the feed for the user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="filter">
        /// Default Value: all
        /// </param>
        /// <param name="tracksOnly"></param>
        /// <param name="withUsers"></param>
        /// <param name="followeeUserId"></param>
        /// <param name="encodedDataMessage"></param>
        /// <param name="encodedDataSignature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.UserFeedResponse>> GetUserFeedAsResponseAsync(
            string id,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetUserFeedFilter? filter = default,
            bool? tracksOnly = default,
            bool? withUsers = default,
            global::System.Collections.Generic.IList<int>? followeeUserId = default,
            string? encodedDataMessage = default,
            string? encodedDataSignature = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}