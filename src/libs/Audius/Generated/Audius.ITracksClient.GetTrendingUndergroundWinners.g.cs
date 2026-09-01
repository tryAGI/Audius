#nullable enable

namespace Audius
{
    public partial interface ITracksClient
    {
        /// <summary>
        /// Gets weekly trending underground winners from the trending_results table. Returns track objects for the specified week. Defaults to the most recent week with data when no week is provided.
        /// </summary>
        /// <param name="week"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.TracksResponse> GetTrendingUndergroundWinnersAsync(
            global::System.DateTime? week = default,
            string? userId = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets weekly trending underground winners from the trending_results table. Returns track objects for the specified week. Defaults to the most recent week with data when no week is provided.
        /// </summary>
        /// <param name="week"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.TracksResponse>> GetTrendingUndergroundWinnersAsResponseAsync(
            global::System.DateTime? week = default,
            string? userId = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}