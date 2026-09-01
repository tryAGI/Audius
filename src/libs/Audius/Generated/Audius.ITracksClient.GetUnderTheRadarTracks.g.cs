#nullable enable

namespace Audius
{
    public partial interface ITracksClient
    {
        /// <summary>
        /// Gets the tracks found on the "Under the Radar" smart playlist
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="filter">
        /// Default Value: all
        /// </param>
        /// <param name="tracksOnly"></param>
        /// <param name="withUsers"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.TracksResponse> GetUnderTheRadarTracksAsync(
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetUnderTheRadarTracksFilter? filter = default,
            bool? tracksOnly = default,
            bool? withUsers = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the tracks found on the "Under the Radar" smart playlist
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="filter">
        /// Default Value: all
        /// </param>
        /// <param name="tracksOnly"></param>
        /// <param name="withUsers"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.TracksResponse>> GetUnderTheRadarTracksAsResponseAsync(
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetUnderTheRadarTracksFilter? filter = default,
            bool? tracksOnly = default,
            bool? withUsers = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}