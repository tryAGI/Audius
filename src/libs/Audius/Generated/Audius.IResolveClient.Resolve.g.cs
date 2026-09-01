#nullable enable

namespace Audius
{
    public partial interface IResolveClient
    {
        /// <summary>
        /// Resolves and redirects a provided Audius app URL to the API resource URL it represents<br/>
        /// This endpoint allows you to lookup and access API resources when you only know the<br/>
        /// audius.co URL.<br/>
        /// Tracks, Playlists, and Users are supported.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task ResolveAsync(
            string url,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resolves and redirects a provided Audius app URL to the API resource URL it represents<br/>
        /// This endpoint allows you to lookup and access API resources when you only know the<br/>
        /// audius.co URL.<br/>
        /// Tracks, Playlists, and Users are supported.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse> ResolveAsResponseAsync(
            string url,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}