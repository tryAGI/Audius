#nullable enable

namespace Audius
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Gets the user's $USDC transaction history within the App
        /// </summary>
        /// <param name="id"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="sortMethod">
        /// Default Value: date
        /// </param>
        /// <param name="sortDirection">
        /// Default Value: desc
        /// </param>
        /// <param name="encodedDataMessage"></param>
        /// <param name="encodedDataSignature"></param>
        /// <param name="type"></param>
        /// <param name="includeSystemTransactions">
        /// Default Value: false
        /// </param>
        /// <param name="method"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.TransactionHistoryResponse> GetUsdcTransactionsAsync(
            string id,
            int? offset = default,
            int? limit = default,
            global::Audius.GetUsdcTransactionsSortMethod? sortMethod = default,
            global::Audius.GetUsdcTransactionsSortDirection? sortDirection = default,
            string? encodedDataMessage = default,
            string? encodedDataSignature = default,
            global::System.Collections.Generic.IList<global::Audius.GetUsdcTransactionsTypeItem>? type = default,
            bool? includeSystemTransactions = default,
            global::Audius.GetUsdcTransactionsMethod? method = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the user's $USDC transaction history within the App
        /// </summary>
        /// <param name="id"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="sortMethod">
        /// Default Value: date
        /// </param>
        /// <param name="sortDirection">
        /// Default Value: desc
        /// </param>
        /// <param name="encodedDataMessage"></param>
        /// <param name="encodedDataSignature"></param>
        /// <param name="type"></param>
        /// <param name="includeSystemTransactions">
        /// Default Value: false
        /// </param>
        /// <param name="method"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.TransactionHistoryResponse>> GetUsdcTransactionsAsResponseAsync(
            string id,
            int? offset = default,
            int? limit = default,
            global::Audius.GetUsdcTransactionsSortMethod? sortMethod = default,
            global::Audius.GetUsdcTransactionsSortDirection? sortDirection = default,
            string? encodedDataMessage = default,
            string? encodedDataSignature = default,
            global::System.Collections.Generic.IList<global::Audius.GetUsdcTransactionsTypeItem>? type = default,
            bool? includeSystemTransactions = default,
            global::Audius.GetUsdcTransactionsMethod? method = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}