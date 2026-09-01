#nullable enable

namespace Audius
{
    public partial interface IDeveloperAppsClient
    {
        /// <summary>
        /// Deactivate a bearer token (API access key) for a developer app. Indexer validates grants.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="address"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.DeactivateAccessKeyResponse> DeactivateDeveloperAppAccessKeyAsync(
            string userId,
            string address,

            global::Audius.DeactivateAccessKeyRequestBody request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deactivate a bearer token (API access key) for a developer app. Indexer validates grants.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="address"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.DeactivateAccessKeyResponse>> DeactivateDeveloperAppAccessKeyAsResponseAsync(
            string userId,
            string address,

            global::Audius.DeactivateAccessKeyRequestBody request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deactivate a bearer token (API access key) for a developer app. Indexer validates grants.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="address"></param>
        /// <param name="apiAccessKey">
        /// The bearer token (API access key) to deactivate
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.DeactivateAccessKeyResponse> DeactivateDeveloperAppAccessKeyAsync(
            string userId,
            string address,
            string apiAccessKey,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}