#nullable enable

namespace Audius
{
    public partial interface IReactionsClient
    {
        /// <summary>
        /// Gets reactions by reacted_to_id and type
        /// </summary>
        /// <param name="type"></param>
        /// <param name="reactedToIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.Reactions> BulkGetReactionsAsync(
            global::System.Collections.Generic.IList<string> reactedToIds,
            string? type = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets reactions by reacted_to_id and type
        /// </summary>
        /// <param name="type"></param>
        /// <param name="reactedToIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.Reactions>> BulkGetReactionsAsResponseAsync(
            global::System.Collections.Generic.IList<string> reactedToIds,
            string? type = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}