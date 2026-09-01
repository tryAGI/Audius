#nullable enable

namespace Audius
{
    public partial interface ITracksClient
    {
        /// <summary>
        /// Get the streamable MP3 file of a track<br/>
        /// Stream an mp3 track<br/>
        /// This endpoint accepts the Range header for streaming.<br/>
        /// https://developer.mozilla.org/en-US/docs/Web/HTTP/Range_requests
        /// </summary>
        /// <param name="trackId"></param>
        /// <param name="userId"></param>
        /// <param name="preview">
        /// Default Value: false
        /// </param>
        /// <param name="userSignature"></param>
        /// <param name="userData"></param>
        /// <param name="nftAccessSignature"></param>
        /// <param name="skipPlayCount">
        /// Default Value: false
        /// </param>
        /// <param name="apiKey"></param>
        /// <param name="skipCheck"></param>
        /// <param name="noRedirect"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.StreamUrlResponse> StreamTrackAsync(
            string trackId,
            string? userId = default,
            bool? preview = default,
            string? userSignature = default,
            string? userData = default,
            string? nftAccessSignature = default,
            bool? skipPlayCount = default,
            string? apiKey = default,
            bool? skipCheck = default,
            bool? noRedirect = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the streamable MP3 file of a track<br/>
        /// Stream an mp3 track<br/>
        /// This endpoint accepts the Range header for streaming.<br/>
        /// https://developer.mozilla.org/en-US/docs/Web/HTTP/Range_requests
        /// </summary>
        /// <param name="trackId"></param>
        /// <param name="userId"></param>
        /// <param name="preview">
        /// Default Value: false
        /// </param>
        /// <param name="userSignature"></param>
        /// <param name="userData"></param>
        /// <param name="nftAccessSignature"></param>
        /// <param name="skipPlayCount">
        /// Default Value: false
        /// </param>
        /// <param name="apiKey"></param>
        /// <param name="skipCheck"></param>
        /// <param name="noRedirect"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.StreamUrlResponse>> StreamTrackAsResponseAsync(
            string trackId,
            string? userId = default,
            bool? preview = default,
            string? userSignature = default,
            string? userData = default,
            string? nftAccessSignature = default,
            bool? skipPlayCount = default,
            string? apiKey = default,
            bool? skipCheck = default,
            bool? noRedirect = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}