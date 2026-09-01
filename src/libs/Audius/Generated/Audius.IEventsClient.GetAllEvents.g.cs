#nullable enable

namespace Audius
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// Get all events<br/>
        /// Get all events
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="sortMethod">
        /// Default Value: newest
        /// </param>
        /// <param name="eventType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.EventsResponse> GetAllEventsAsync(
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetAllEventsSortMethod? sortMethod = default,
            global::Audius.GetAllEventsEventType? eventType = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get all events<br/>
        /// Get all events
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="sortMethod">
        /// Default Value: newest
        /// </param>
        /// <param name="eventType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.EventsResponse>> GetAllEventsAsResponseAsync(
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetAllEventsSortMethod? sortMethod = default,
            global::Audius.GetAllEventsEventType? eventType = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}