#nullable enable

namespace Audius
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Gets the count of the user's $USDC transaction history within the App
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="includeSystemTransactions">
        /// Default Value: false
        /// </param>
        /// <param name="method"></param>
        /// <param name="encodedDataMessage"></param>
        /// <param name="encodedDataSignature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.TransactionHistoryCountResponse> GetUsdcTransactionCountAsync(
            string id,
            global::System.Collections.Generic.IList<global::Audius.GetUsdcTransactionCountTypeItem>? type = default,
            bool? includeSystemTransactions = default,
            global::Audius.GetUsdcTransactionCountMethod? method = default,
            string? encodedDataMessage = default,
            string? encodedDataSignature = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the count of the user's $USDC transaction history within the App
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="includeSystemTransactions">
        /// Default Value: false
        /// </param>
        /// <param name="method"></param>
        /// <param name="encodedDataMessage"></param>
        /// <param name="encodedDataSignature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.TransactionHistoryCountResponse>> GetUsdcTransactionCountAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::Audius.GetUsdcTransactionCountTypeItem>? type = default,
            bool? includeSystemTransactions = default,
            global::Audius.GetUsdcTransactionCountMethod? method = default,
            string? encodedDataMessage = default,
            string? encodedDataSignature = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}