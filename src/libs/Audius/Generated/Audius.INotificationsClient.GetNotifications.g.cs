#nullable enable

namespace Audius
{
    public partial interface INotificationsClient
    {
        /// <summary>
        /// Get notifications for user ID
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="timestamp"></param>
        /// <param name="groupId"></param>
        /// <param name="limit"></param>
        /// <param name="types"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.NotificationsResponse> GetNotificationsAsync(
            string userId,
            int? timestamp = default,
            string? groupId = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::Audius.GetNotificationsType>? types = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get notifications for user ID
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="timestamp"></param>
        /// <param name="groupId"></param>
        /// <param name="limit"></param>
        /// <param name="types"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.NotificationsResponse>> GetNotificationsAsResponseAsync(
            string userId,
            int? timestamp = default,
            string? groupId = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::Audius.GetNotificationsType>? types = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}