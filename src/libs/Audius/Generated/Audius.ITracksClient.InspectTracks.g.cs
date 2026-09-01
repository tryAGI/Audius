#nullable enable

namespace Audius
{
    public partial interface ITracksClient
    {
        /// <summary>
        /// Inspects the details of the files for multiple tracks<br/>
        /// Inspect multiple tracks
        /// </summary>
        /// <param name="id"></param>
        /// <param name="original">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.TrackInspectList> InspectTracksAsync(
            global::System.Collections.Generic.IList<string> id,
            bool? original = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Inspects the details of the files for multiple tracks<br/>
        /// Inspect multiple tracks
        /// </summary>
        /// <param name="id"></param>
        /// <param name="original">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.TrackInspectList>> InspectTracksAsResponseAsync(
            global::System.Collections.Generic.IList<string> id,
            bool? original = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}