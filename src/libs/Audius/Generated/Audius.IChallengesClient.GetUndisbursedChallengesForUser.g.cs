#nullable enable

namespace Audius
{
    public partial interface IChallengesClient
    {
        /// <summary>
        /// Get all undisbursed challenges for a user
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="completedBlocknumber"></param>
        /// <param name="challengeId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.UndisbursedChallenges> GetUndisbursedChallengesForUserAsync(
            string userId,
            int? offset = default,
            int? limit = default,
            int? completedBlocknumber = default,
            string? challengeId = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get all undisbursed challenges for a user
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="completedBlocknumber"></param>
        /// <param name="challengeId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.UndisbursedChallenges>> GetUndisbursedChallengesForUserAsResponseAsync(
            string userId,
            int? offset = default,
            int? limit = default,
            int? completedBlocknumber = default,
            string? challengeId = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}