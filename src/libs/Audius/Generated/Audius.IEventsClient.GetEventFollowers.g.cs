#nullable enable

namespace Audius
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// Get event followers<br/>
        /// Returns the list of users subscribed to a given remix-contest event, ordered by each follower's own follower count so the most-followed fans surface first. Used by the contest page's Followers card (avatar stack + leaderboard).
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.FollowersResponse> GetEventFollowersAsync(
            string eventId,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get event followers<br/>
        /// Returns the list of users subscribed to a given remix-contest event, ordered by each follower's own follower count so the most-followed fans surface first. Used by the contest page's Followers card (avatar stack + leaderboard).
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.FollowersResponse>> GetEventFollowersAsResponseAsync(
            string eventId,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}