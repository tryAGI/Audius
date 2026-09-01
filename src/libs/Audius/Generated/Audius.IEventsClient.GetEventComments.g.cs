#nullable enable

namespace Audius
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// Get event comments<br/>
        /// Paginated stream of top-level comments (with nested replies) for a remix-contest event. Host-authored top-level comments represent "post updates"; everything else is a community comment.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="sortMethod">
        /// Default Value: newest
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.TrackCommentsResponse> GetEventCommentsAsync(
            string eventId,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetEventCommentsSortMethod? sortMethod = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get event comments<br/>
        /// Paginated stream of top-level comments (with nested replies) for a remix-contest event. Host-authored top-level comments represent "post updates"; everything else is a community comment.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="sortMethod">
        /// Default Value: newest
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.TrackCommentsResponse>> GetEventCommentsAsResponseAsync(
            string eventId,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetEventCommentsSortMethod? sortMethod = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}