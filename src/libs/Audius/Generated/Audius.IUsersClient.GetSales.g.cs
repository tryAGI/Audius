#nullable enable

namespace Audius
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Gets the sales the user has made
        /// </summary>
        /// <param name="id"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="sortMethod"></param>
        /// <param name="sortDirection"></param>
        /// <param name="contentIds"></param>
        /// <param name="encodedDataMessage"></param>
        /// <param name="encodedDataSignature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.PurchasesResponse> GetSalesAsync(
            string id,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetSalesSortMethod? sortMethod = default,
            global::Audius.GetSalesSortDirection? sortDirection = default,
            global::System.Collections.Generic.IList<string>? contentIds = default,
            string? encodedDataMessage = default,
            string? encodedDataSignature = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the sales the user has made
        /// </summary>
        /// <param name="id"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="sortMethod"></param>
        /// <param name="sortDirection"></param>
        /// <param name="contentIds"></param>
        /// <param name="encodedDataMessage"></param>
        /// <param name="encodedDataSignature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.PurchasesResponse>> GetSalesAsResponseAsync(
            string id,
            int? offset = default,
            int? limit = default,
            string? userId = default,
            global::Audius.GetSalesSortMethod? sortMethod = default,
            global::Audius.GetSalesSortDirection? sortDirection = default,
            global::System.Collections.Generic.IList<string>? contentIds = default,
            string? encodedDataMessage = default,
            string? encodedDataSignature = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}