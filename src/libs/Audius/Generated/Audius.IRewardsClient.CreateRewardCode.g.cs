#nullable enable

namespace Audius
{
    public partial interface IRewardsClient
    {
        /// <summary>
        /// Creates a new reward code with Solana signature verification
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.CreateRewardCodeResponse> CreateRewardCodeAsync(

            global::Audius.CreateRewardCodeRequest request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new reward code with Solana signature verification
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.CreateRewardCodeResponse>> CreateRewardCodeAsResponseAsync(

            global::Audius.CreateRewardCodeRequest request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new reward code with Solana signature verification
        /// </summary>
        /// <param name="signature">
        /// Base64-encoded Solana Ed25519 signature of the string "code"<br/>
        /// Example: 3fG7xQh2L8vK9pN4mR5sT6uW7vX8yZ1aB2cD3eF4gH5iJ6kL7mN8oP9qR0sT1uV2wX3yZ4aB5cD6eF7gH8iJ9k=
        /// </param>
        /// <param name="mint">
        /// The coin mint address<br/>
        /// Example: 9LzCMqDgTKYz9Drzqnpgee3SGa89up3a247ypMj2xrqM
        /// </param>
        /// <param name="amount">
        /// The reward amount (must be greater than 0)<br/>
        /// Example: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.CreateRewardCodeResponse> CreateRewardCodeAsync(
            string signature,
            string mint,
            int amount,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}