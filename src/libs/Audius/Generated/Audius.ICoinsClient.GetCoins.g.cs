#nullable enable

namespace Audius
{
    public partial interface ICoinsClient
    {
        /// <summary>
        /// Gets a list of coins with optional filtering
        /// </summary>
        /// <param name="ticker"></param>
        /// <param name="mint"></param>
        /// <param name="ownerId"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="query"></param>
        /// <param name="sortMethod">
        /// Default Value: market_cap
        /// </param>
        /// <param name="sortDirection">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.CoinsResponse> GetCoinsAsync(
            global::System.Collections.Generic.IList<string>? ticker = default,
            global::System.Collections.Generic.IList<string>? mint = default,
            global::System.Collections.Generic.IList<string>? ownerId = default,
            int? limit = default,
            int? offset = default,
            string? query = default,
            global::Audius.GetCoinsSortMethod? sortMethod = default,
            global::Audius.GetCoinsSortDirection? sortDirection = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets a list of coins with optional filtering
        /// </summary>
        /// <param name="ticker"></param>
        /// <param name="mint"></param>
        /// <param name="ownerId"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="query"></param>
        /// <param name="sortMethod">
        /// Default Value: market_cap
        /// </param>
        /// <param name="sortDirection">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.CoinsResponse>> GetCoinsAsResponseAsync(
            global::System.Collections.Generic.IList<string>? ticker = default,
            global::System.Collections.Generic.IList<string>? mint = default,
            global::System.Collections.Generic.IList<string>? ownerId = default,
            int? limit = default,
            int? offset = default,
            string? query = default,
            global::Audius.GetCoinsSortMethod? sortMethod = default,
            global::Audius.GetCoinsSortDirection? sortDirection = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}