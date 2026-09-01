#nullable enable

namespace Audius
{
    public partial interface IEventsClient
    {
        /// <summary>
        /// Get all remix contests<br/>
        /// Get remix contest events ordered with currently-active contests first (by soonest-ending), followed by ended contests (most-recently-ended first). Active contests are those whose end_date is null or in the future.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="status">
        /// Default Value: all
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.RemixContestsResponse> GetRemixContestsAsync(
            int? offset = default,
            int? limit = default,
            global::Audius.GetRemixContestsStatus? status = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get all remix contests<br/>
        /// Get remix contest events ordered with currently-active contests first (by soonest-ending), followed by ended contests (most-recently-ended first). Active contests are those whose end_date is null or in the future.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="status">
        /// Default Value: all
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.RemixContestsResponse>> GetRemixContestsAsResponseAsync(
            int? offset = default,
            int? limit = default,
            global::Audius.GetRemixContestsStatus? status = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}