#nullable enable

namespace Audius
{
    public partial interface IDeveloperAppsClient
    {
        /// <summary>
        /// Create a new developer app. Indexer validates grants.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.CreateDeveloperAppResponse> CreateDeveloperAppAsync(
            string userId,

            global::Audius.CreateDeveloperAppRequestBody request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new developer app. Indexer validates grants.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.CreateDeveloperAppResponse>> CreateDeveloperAppAsResponseAsync(
            string userId,

            global::Audius.CreateDeveloperAppRequestBody request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new developer app. Indexer validates grants.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="name">
        /// Developer app name<br/>
        /// Example: My API Key
        /// </param>
        /// <param name="description">
        /// App description
        /// </param>
        /// <param name="imageUrl">
        /// App logo/image URL
        /// </param>
        /// <param name="redirectUris">
        /// Pre-registered OAuth redirect/callback URIs
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.CreateDeveloperAppResponse> CreateDeveloperAppAsync(
            string userId,
            string name,
            string? description = default,
            string? imageUrl = default,
            global::System.Collections.Generic.IList<string>? redirectUris = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}