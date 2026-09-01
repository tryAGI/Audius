#nullable enable

namespace Audius
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// Get a list of events by ID
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="id"></param>
        /// <param name="eventType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.EventsResponse> GetBulkEventsAsync(
            string? userId = default,
            global::System.Collections.Generic.IList<string>? id = default,
            global::Audius.GetBulkEventsEventType? eventType = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a list of events by ID
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="id"></param>
        /// <param name="eventType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.EventsResponse>> GetBulkEventsAsResponseAsync(
            string? userId = default,
            global::System.Collections.Generic.IList<string>? id = default,
            global::Audius.GetBulkEventsEventType? eventType = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}