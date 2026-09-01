#nullable enable

namespace Audius
{
    public partial interface ITipsClient
    {
        /// <summary>
        /// Gets the most recent tips on the network
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="receiverMinFollowers">
        /// Default Value: 0
        /// </param>
        /// <param name="receiverIsVerified">
        /// Default Value: false
        /// </param>
        /// <param name="currentUserFollows"></param>
        /// <param name="uniqueBy"></param>
        /// <param name="minSlot">
        /// Default Value: 0
        /// </param>
        /// <param name="maxSlot">
        /// Default Value: 0
        /// </param>
        /// <param name="txSignatures"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.GetTipsResponse> GetTipsAsync(
            int? offset = default,
            int? limit = default,
            string? userId = default,
            int? receiverMinFollowers = default,
            bool? receiverIsVerified = default,
            global::Audius.GetTipsCurrentUserFollows? currentUserFollows = default,
            global::Audius.GetTipsUniqueBy? uniqueBy = default,
            int? minSlot = default,
            int? maxSlot = default,
            global::System.Collections.Generic.IList<string>? txSignatures = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the most recent tips on the network
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="receiverMinFollowers">
        /// Default Value: 0
        /// </param>
        /// <param name="receiverIsVerified">
        /// Default Value: false
        /// </param>
        /// <param name="currentUserFollows"></param>
        /// <param name="uniqueBy"></param>
        /// <param name="minSlot">
        /// Default Value: 0
        /// </param>
        /// <param name="maxSlot">
        /// Default Value: 0
        /// </param>
        /// <param name="txSignatures"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.GetTipsResponse>> GetTipsAsResponseAsync(
            int? offset = default,
            int? limit = default,
            string? userId = default,
            int? receiverMinFollowers = default,
            bool? receiverIsVerified = default,
            global::Audius.GetTipsCurrentUserFollows? currentUserFollows = default,
            global::Audius.GetTipsUniqueBy? uniqueBy = default,
            int? minSlot = default,
            int? maxSlot = default,
            global::System.Collections.Generic.IList<string>? txSignatures = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}