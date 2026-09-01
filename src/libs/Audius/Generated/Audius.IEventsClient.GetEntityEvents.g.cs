#nullable enable

namespace Audius
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// Get events for a specific entity<br/>
        /// Get events for a specific entity
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="entityId"></param>
        /// <param name="entityType"></param>
        /// <param name="filterDeleted">
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.EventsResponse> GetEntityEventsAsync(
            global::System.Collections.Generic.IList<string> entityId,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetEntityEventsEntityType? entityType = default,
            bool? filterDeleted = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get events for a specific entity<br/>
        /// Get events for a specific entity
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="entityId"></param>
        /// <param name="entityType"></param>
        /// <param name="filterDeleted">
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.EventsResponse>> GetEntityEventsAsResponseAsync(
            global::System.Collections.Generic.IList<string> entityId,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetEntityEventsEntityType? entityType = default,
            bool? filterDeleted = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}