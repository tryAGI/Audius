#nullable enable

namespace Audius
{
    public partial interface IChallengesClient
    {
        /// <summary>
        /// Produces an attestation that a given user has completed a challenge, or errors.
        /// </summary>
        /// <param name="challengeId"></param>
        /// <param name="oracle"></param>
        /// <param name="specifier"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AttestationReponse> GetChallengeAttestationAsync(
            string challengeId,
            string oracle,
            string specifier,
            string userId,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Produces an attestation that a given user has completed a challenge, or errors.
        /// </summary>
        /// <param name="challengeId"></param>
        /// <param name="oracle"></param>
        /// <param name="specifier"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.AttestationReponse>> GetChallengeAttestationAsResponseAsync(
            string challengeId,
            string oracle,
            string specifier,
            string userId,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}