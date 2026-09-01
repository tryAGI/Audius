#nullable enable

namespace Audius
{
    public partial interface IDeveloperAppsClient
    {
        /// <summary>
        /// Get developer apps for the user.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.DeveloperAppsResponse> GetDeveloperAppsAsync(
            string id,
            global::Audius.GetDeveloperAppsInclude? include = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get developer apps for the user.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.DeveloperAppsResponse>> GetDeveloperAppsAsResponseAsync(
            string id,
            global::Audius.GetDeveloperAppsInclude? include = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}