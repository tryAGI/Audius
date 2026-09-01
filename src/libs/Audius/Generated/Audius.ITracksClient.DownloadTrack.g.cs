#nullable enable

namespace Audius
{
    public partial interface ITracksClient
    {
        /// <summary>
        /// Download the original or MP3 file of a track<br/>
        /// Download an original or mp3 track
        /// </summary>
        /// <param name="trackId"></param>
        /// <param name="userId"></param>
        /// <param name="userSignature"></param>
        /// <param name="userData"></param>
        /// <param name="nftAccessSignature"></param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task DownloadTrackAsync(
            string trackId,
            string? userId = default,
            string? userSignature = default,
            string? userData = default,
            string? nftAccessSignature = default,
            string? filename = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download the original or MP3 file of a track<br/>
        /// Download an original or mp3 track
        /// </summary>
        /// <param name="trackId"></param>
        /// <param name="userId"></param>
        /// <param name="userSignature"></param>
        /// <param name="userData"></param>
        /// <param name="nftAccessSignature"></param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse> DownloadTrackAsResponseAsync(
            string trackId,
            string? userId = default,
            string? userSignature = default,
            string? userData = default,
            string? nftAccessSignature = default,
            string? filename = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}