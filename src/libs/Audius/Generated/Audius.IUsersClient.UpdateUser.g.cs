#nullable enable

namespace Audius
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Updates an existing user profile
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.WriteResponse> UpdateUserAsync(
            string id,
            string userId,

            global::Audius.UpdateUserRequestBody request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates an existing user profile
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Audius.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Audius.AutoSDKHttpResponse<global::Audius.WriteResponse>> UpdateUserAsResponseAsync(
            string id,
            string userId,

            global::Audius.UpdateUserRequestBody request,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates an existing user profile
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="handle">
        /// User handle. Can only be set if the user does not already have a handle.
        /// </param>
        /// <param name="name">
        /// Display name
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
        /// <param name="isDeactivated">
        /// Whether the user is deactivated
        /// </param>
        /// <param name="artistPickTrackId">
        /// Track hash ID to feature as artist pick<br/>
        /// Example: x5pJ3Az
        /// </param>
        /// <param name="allowAiAttribution">
        /// Whether to allow AI attribution
        /// </param>
        /// <param name="splUsdcPayoutWallet">
        /// Solana USDC payout wallet address
        /// </param>
        /// <param name="coinFlairMint">
        /// Coin flair mint address
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
        global::System.Threading.Tasks.Task<global::Audius.WriteResponse> UpdateUserAsync(
            string id,
            string userId,
            string? handle = default,
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
            global::Audius.UpdateUserRequestBodyProfileType? profileType = default,
            bool? isDeactivated = default,
            string? artistPickTrackId = default,
            bool? allowAiAttribution = default,
            string? splUsdcPayoutWallet = default,
            string? coinFlairMint = default,
            global::Audius.UserPlaylistLibrary? playlistLibrary = default,
            global::Audius.UpdateUserRequestBodyEvents? events = default,
            global::Audius.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}