
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class User
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("album_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AlbumCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artist_pick_track_id")]
        public string? ArtistPickTrackId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artist_coin_badge")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Audius.UserArtistCoinBadge ArtistCoinBadge { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coin_flair_mint")]
        public string? CoinFlairMint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bio")]
        public string? Bio { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_photo")]
        public global::Audius.CoverPhoto? CoverPhoto { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followee_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FolloweeCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("follower_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FollowerCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Handle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_verified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsVerified { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twitter_handle")]
        public string? TwitterHandle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instagram_handle")]
        public string? InstagramHandle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tiktok_handle")]
        public string? TiktokHandle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified_with_twitter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool VerifiedWithTwitter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified_with_instagram")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool VerifiedWithInstagram { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified_with_tiktok")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool VerifiedWithTiktok { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        public string? Website { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("donation")]
        public string? Donation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PlaylistCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_picture")]
        public global::Audius.ProfilePicture? ProfilePicture { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repost_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RepostCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TrackCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_deactivated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDeactivated { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAvailable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("erc_wallet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErcWallet { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spl_wallet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SplWallet { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spl_usdc_wallet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SplUsdcWallet { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spl_usdc_payout_wallet")]
        public string? SplUsdcPayoutWallet { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supporter_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SupporterCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supporting_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SupportingCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_audio_balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalAudioBalance { get; set; }

        /// <summary>
        /// The user's Ethereum wallet address for their account
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wallet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Wallet { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Balance { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("associated_wallets_balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssociatedWalletsBalance { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TotalBalance { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("waudio_balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WaudioBalance { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("associated_sol_wallets_balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssociatedSolWalletsBalance { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocknumber")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Blocknumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_storage_v2")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsStorageV2 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_node_endpoint")]
        public string? CreatorNodeEndpoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_user_followee_follow_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CurrentUserFolloweeFollowCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("does_current_user_follow")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DoesCurrentUserFollow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("does_current_user_subscribe")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DoesCurrentUserSubscribe { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("does_follow_current_user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DoesFollowCurrentUser { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handle_lc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HandleLc { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_photo_sizes")]
        public string? CoverPhotoSizes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_photo_cids")]
        public global::Audius.CoverPhoto? CoverPhotoCids { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_photo_legacy")]
        public string? CoverPhotoLegacy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_picture_sizes")]
        public string? ProfilePictureSizes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_picture_cids")]
        public global::Audius.ProfilePicture? ProfilePictureCids { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_picture_legacy")]
        public string? ProfilePictureLegacy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_collectibles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasCollectibles { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_library")]
        public global::Audius.PlaylistLibrary? PlaylistLibrary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_ai_attribution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowAiAttribution { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_type")]
        public string? ProfileType { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="albumCount"></param>
        /// <param name="artistCoinBadge"></param>
        /// <param name="followeeCount"></param>
        /// <param name="followerCount"></param>
        /// <param name="handle"></param>
        /// <param name="id"></param>
        /// <param name="isVerified"></param>
        /// <param name="verifiedWithTwitter"></param>
        /// <param name="verifiedWithInstagram"></param>
        /// <param name="verifiedWithTiktok"></param>
        /// <param name="name"></param>
        /// <param name="playlistCount"></param>
        /// <param name="repostCount"></param>
        /// <param name="trackCount"></param>
        /// <param name="isDeactivated"></param>
        /// <param name="isAvailable"></param>
        /// <param name="ercWallet"></param>
        /// <param name="splWallet"></param>
        /// <param name="splUsdcWallet"></param>
        /// <param name="supporterCount"></param>
        /// <param name="supportingCount"></param>
        /// <param name="totalAudioBalance"></param>
        /// <param name="wallet">
        /// The user's Ethereum wallet address for their account
        /// </param>
        /// <param name="balance"></param>
        /// <param name="associatedWalletsBalance"></param>
        /// <param name="totalBalance"></param>
        /// <param name="waudioBalance"></param>
        /// <param name="associatedSolWalletsBalance"></param>
        /// <param name="blocknumber"></param>
        /// <param name="createdAt"></param>
        /// <param name="isStorageV2"></param>
        /// <param name="currentUserFolloweeFollowCount"></param>
        /// <param name="doesCurrentUserFollow"></param>
        /// <param name="doesCurrentUserSubscribe"></param>
        /// <param name="doesFollowCurrentUser"></param>
        /// <param name="handleLc"></param>
        /// <param name="updatedAt"></param>
        /// <param name="hasCollectibles"></param>
        /// <param name="allowAiAttribution"></param>
        /// <param name="artistPickTrackId"></param>
        /// <param name="coinFlairMint"></param>
        /// <param name="bio"></param>
        /// <param name="coverPhoto"></param>
        /// <param name="twitterHandle"></param>
        /// <param name="instagramHandle"></param>
        /// <param name="tiktokHandle"></param>
        /// <param name="website"></param>
        /// <param name="donation"></param>
        /// <param name="location"></param>
        /// <param name="profilePicture"></param>
        /// <param name="splUsdcPayoutWallet"></param>
        /// <param name="creatorNodeEndpoint"></param>
        /// <param name="coverPhotoSizes"></param>
        /// <param name="coverPhotoCids"></param>
        /// <param name="coverPhotoLegacy"></param>
        /// <param name="profilePictureSizes"></param>
        /// <param name="profilePictureCids"></param>
        /// <param name="profilePictureLegacy"></param>
        /// <param name="playlistLibrary"></param>
        /// <param name="profileType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public User(
            int albumCount,
            global::Audius.UserArtistCoinBadge artistCoinBadge,
            int followeeCount,
            int followerCount,
            string handle,
            string id,
            bool isVerified,
            bool verifiedWithTwitter,
            bool verifiedWithInstagram,
            bool verifiedWithTiktok,
            string name,
            int playlistCount,
            int repostCount,
            int trackCount,
            bool isDeactivated,
            bool isAvailable,
            string ercWallet,
            string splWallet,
            string splUsdcWallet,
            int supporterCount,
            int supportingCount,
            int totalAudioBalance,
            string wallet,
            string balance,
            string associatedWalletsBalance,
            string totalBalance,
            string waudioBalance,
            string associatedSolWalletsBalance,
            int blocknumber,
            string createdAt,
            bool isStorageV2,
            int currentUserFolloweeFollowCount,
            bool doesCurrentUserFollow,
            bool doesCurrentUserSubscribe,
            bool doesFollowCurrentUser,
            string handleLc,
            string updatedAt,
            bool hasCollectibles,
            bool allowAiAttribution,
            string? artistPickTrackId,
            string? coinFlairMint,
            string? bio,
            global::Audius.CoverPhoto? coverPhoto,
            string? twitterHandle,
            string? instagramHandle,
            string? tiktokHandle,
            string? website,
            string? donation,
            string? location,
            global::Audius.ProfilePicture? profilePicture,
            string? splUsdcPayoutWallet,
            string? creatorNodeEndpoint,
            string? coverPhotoSizes,
            global::Audius.CoverPhoto? coverPhotoCids,
            string? coverPhotoLegacy,
            string? profilePictureSizes,
            global::Audius.ProfilePicture? profilePictureCids,
            string? profilePictureLegacy,
            global::Audius.PlaylistLibrary? playlistLibrary,
            string? profileType)
        {
            this.AlbumCount = albumCount;
            this.ArtistPickTrackId = artistPickTrackId;
            this.ArtistCoinBadge = artistCoinBadge ?? throw new global::System.ArgumentNullException(nameof(artistCoinBadge));
            this.CoinFlairMint = coinFlairMint;
            this.Bio = bio;
            this.CoverPhoto = coverPhoto;
            this.FolloweeCount = followeeCount;
            this.FollowerCount = followerCount;
            this.Handle = handle ?? throw new global::System.ArgumentNullException(nameof(handle));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.IsVerified = isVerified;
            this.TwitterHandle = twitterHandle;
            this.InstagramHandle = instagramHandle;
            this.TiktokHandle = tiktokHandle;
            this.VerifiedWithTwitter = verifiedWithTwitter;
            this.VerifiedWithInstagram = verifiedWithInstagram;
            this.VerifiedWithTiktok = verifiedWithTiktok;
            this.Website = website;
            this.Donation = donation;
            this.Location = location;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PlaylistCount = playlistCount;
            this.ProfilePicture = profilePicture;
            this.RepostCount = repostCount;
            this.TrackCount = trackCount;
            this.IsDeactivated = isDeactivated;
            this.IsAvailable = isAvailable;
            this.ErcWallet = ercWallet ?? throw new global::System.ArgumentNullException(nameof(ercWallet));
            this.SplWallet = splWallet ?? throw new global::System.ArgumentNullException(nameof(splWallet));
            this.SplUsdcWallet = splUsdcWallet ?? throw new global::System.ArgumentNullException(nameof(splUsdcWallet));
            this.SplUsdcPayoutWallet = splUsdcPayoutWallet;
            this.SupporterCount = supporterCount;
            this.SupportingCount = supportingCount;
            this.TotalAudioBalance = totalAudioBalance;
            this.Wallet = wallet ?? throw new global::System.ArgumentNullException(nameof(wallet));
            this.Balance = balance ?? throw new global::System.ArgumentNullException(nameof(balance));
            this.AssociatedWalletsBalance = associatedWalletsBalance ?? throw new global::System.ArgumentNullException(nameof(associatedWalletsBalance));
            this.TotalBalance = totalBalance ?? throw new global::System.ArgumentNullException(nameof(totalBalance));
            this.WaudioBalance = waudioBalance ?? throw new global::System.ArgumentNullException(nameof(waudioBalance));
            this.AssociatedSolWalletsBalance = associatedSolWalletsBalance ?? throw new global::System.ArgumentNullException(nameof(associatedSolWalletsBalance));
            this.Blocknumber = blocknumber;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.IsStorageV2 = isStorageV2;
            this.CreatorNodeEndpoint = creatorNodeEndpoint;
            this.CurrentUserFolloweeFollowCount = currentUserFolloweeFollowCount;
            this.DoesCurrentUserFollow = doesCurrentUserFollow;
            this.DoesCurrentUserSubscribe = doesCurrentUserSubscribe;
            this.DoesFollowCurrentUser = doesFollowCurrentUser;
            this.HandleLc = handleLc ?? throw new global::System.ArgumentNullException(nameof(handleLc));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.CoverPhotoSizes = coverPhotoSizes;
            this.CoverPhotoCids = coverPhotoCids;
            this.CoverPhotoLegacy = coverPhotoLegacy;
            this.ProfilePictureSizes = profilePictureSizes;
            this.ProfilePictureCids = profilePictureCids;
            this.ProfilePictureLegacy = profilePictureLegacy;
            this.HasCollectibles = hasCollectibles;
            this.PlaylistLibrary = playlistLibrary;
            this.AllowAiAttribution = allowAiAttribution;
            this.ProfileType = profileType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        public User()
        {
        }

    }
}