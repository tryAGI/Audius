#nullable enable

namespace Audius
{
    public partial interface IDeveloperAppsClient
    {
        /// <summary>
        /// Register api_key and api_secret in api_keys table for developer apps created via entity manager transactions. Use when the client sends raw ManageEntity tx instead of POST /developer-apps. Inserts with rps=10, rpm=500000. Requires the app to exist in developer_apps and belong to the authenticated user.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="address"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.RegisterApiKeyResponse> RegisterDeveloperAppApiKeyAsync(
            string userId,
            string address,

            global::Audius.RegisterApiKeyRequestBody request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register api_key and api_secret in api_keys table for developer apps created via entity manager transactions. Use when the client sends raw ManageEntity tx instead of POST /developer-apps. Inserts with rps=10, rpm=500000. Requires the app to exist in developer_apps and belong to the authenticated user.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="address"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.RegisterApiKeyResponse>> RegisterDeveloperAppApiKeyAsResponseAsync(
            string userId,
            string address,

            global::Audius.RegisterApiKeyRequestBody request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register api_key and api_secret in api_keys table for developer apps created via entity manager transactions. Use when the client sends raw ManageEntity tx instead of POST /developer-apps. Inserts with rps=10, rpm=500000. Requires the app to exist in developer_apps and belong to the authenticated user.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="address"></param>
        /// <param name="apiSecret">
        /// The API secret (private key hex) for the developer app
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.RegisterApiKeyResponse> RegisterDeveloperAppApiKeyAsync(
            string userId,
            string address,
            string apiSecret,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}