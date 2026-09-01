#nullable enable

namespace Audius
{
    public partial interface ICoinsClient
    {
        /// <summary>
        /// Gets top coin&lt;&gt;AUDIO trading addresses by volume
        /// </summary>
        /// <param name="from">
        /// Default Value: (most recent midnight UTC)<br/>
        /// Example: 2006-01-02T15:04:05Z
        /// </param>
        /// <param name="to">
        /// Default Value: (most recent midnight UTC + 24hrs)<br/>
        /// Example: 2006-01-02T15:04:05Z
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.CoinsVolumeLeadersResponse> GetVolumeLeadersAsync(
            string? from = default,
            string? to = default,
            int? offset = default,
            int? limit = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets top coin&lt;&gt;AUDIO trading addresses by volume
        /// </summary>
        /// <param name="from">
        /// Default Value: (most recent midnight UTC)<br/>
        /// Example: 2006-01-02T15:04:05Z
        /// </param>
        /// <param name="to">
        /// Default Value: (most recent midnight UTC + 24hrs)<br/>
        /// Example: 2006-01-02T15:04:05Z
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.CoinsVolumeLeadersResponse>> GetVolumeLeadersAsResponseAsync(
            string? from = default,
            string? to = default,
            int? offset = default,
            int? limit = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}