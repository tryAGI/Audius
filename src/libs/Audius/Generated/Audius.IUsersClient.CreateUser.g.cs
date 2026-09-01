#nullable enable

namespace Audius
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Creates a new user
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.CreateUserResponse> CreateUserAsync(

            global::Audius.CreateUserRequestBody request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new user
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.CreateUserResponse>> CreateUserAsResponseAsync(

            global::Audius.CreateUserRequestBody request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new user
        /// </summary>
        /// <param name="userId">
        /// Optional user hash ID (will be generated if not provided)<br/>
        /// Example: p9Km2Lx
        /// </param>
        /// <param name="handle">
        /// User handle (unique username)<br/>
        /// Example: newartist
        /// </param>
        /// <param name="wallet">
        /// Wallet address (required)<br/>
        /// Example: 0x1234...
        /// </param>
        /// <param name="name">
        /// Display name<br/>
        /// Example: New Artist
        /// </param>
        /// <param name="bio">
        /// User bio
        /// </param>
        /// <param name="location">
        /// User location
        /// </param>
        /// <param name="website">
        /// Website URL
        /// </param>
        /// <param name="donation">
        /// Donation link
        /// </param>
        /// <param name="twitterHandle">
        /// Twitter handle (without @)
        /// </param>
        /// <param name="instagramHandle">
        /// Instagram handle (without @)
        /// </param>
        /// <param name="tiktokHandle">
        /// TikTok handle (without @)
        /// </param>
        /// <param name="profilePicture">
        /// Profile picture CID or URL
        /// </param>
        /// <param name="profilePictureSizes">
        /// Profile picture sizes metadata
        /// </param>
        /// <param name="coverPhoto">
        /// Cover photo CID or URL
        /// </param>
        /// <param name="coverPhotoSizes">
        /// Cover photo sizes metadata
        /// </param>
        /// <param name="profileType">
        /// Type of profile (e.g., 'label' for record labels)
        /// </param>
        /// <param name="allowAiAttribution">
        /// Whether to allow AI attribution
        /// </param>
        /// <param name="splUsdcPayoutWallet">
        /// Solana USDC payout wallet address
        /// </param>
        /// <param name="playlistLibrary">
        /// User's playlist library with support for folders and playlists
        /// </param>
        /// <param name="events">
        /// User events for tracking referrals and mobile users
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.CreateUserResponse> CreateUserAsync(
            string handle,
            string wallet,
            string? userId = default,
            string? name = default,
            string? bio = default,
            string? location = default,
            string? website = default,
            string? donation = default,
            string? twitterHandle = default,
            string? instagramHandle = default,
            string? tiktokHandle = default,
            string? profilePicture = default,
            string? profilePictureSizes = default,
            string? coverPhoto = default,
            string? coverPhotoSizes = default,
            global::Audius.CreateUserRequestBodyProfileType? profileType = default,
            bool? allowAiAttribution = default,
            string? splUsdcPayoutWallet = default,
            global::Audius.UserPlaylistLibrary? playlistLibrary = default,
            global::Audius.CreateUserRequestBodyEvents? events = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}