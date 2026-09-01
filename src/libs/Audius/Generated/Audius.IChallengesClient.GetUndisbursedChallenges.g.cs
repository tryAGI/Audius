#nullable enable

namespace Audius
{
    public partial interface IChallengesClient
    {
        /// <summary>
        /// Get all undisbursed challenges
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="completedBlocknumber"></param>
        /// <param name="challengeId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.UndisbursedChallenges> GetUndisbursedChallengesAsync(
            int? offset = default,
            int? limit = default,
            string? userId = default,
            int? completedBlocknumber = default,
            string? challengeId = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get all undisbursed challenges
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="userId"></param>
        /// <param name="completedBlocknumber"></param>
        /// <param name="challengeId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.UndisbursedChallenges>> GetUndisbursedChallengesAsResponseAsync(
            int? offset = default,
            int? limit = default,
            string? userId = default,
            int? completedBlocknumber = default,
            string? challengeId = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}