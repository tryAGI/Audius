#nullable enable

namespace Audius
{
    public partial interface IDeveloperAppsClient
    {
        /// <summary>
        /// Deletes a developer app. Indexer validates grants.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="address"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.WriteResponse> DeleteDeveloperAppAsync(
            string userId,
            string address,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes a developer app. Indexer validates grants.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="address"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.WriteResponse>> DeleteDeveloperAppAsResponseAsync(
            string userId,
            string address,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}