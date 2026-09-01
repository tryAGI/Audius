
#nullable enable

namespace Audius
{
    /// <summary>
    /// Request body for updating user profile. All fields are optional.
    /// </summary>
    public sealed partial class UpdateUserRequestBody
    {
        /// <summary>
        /// User handle. Can only be set if the user does not already have a handle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handle")]
        public string? Handle { get; set; }

        /// <summary>
        /// Display name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// User bio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bio")]
        public string? Bio { get; set; }

        /// <summary>
        /// User location
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// Website URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        public string? Website { get; set; }

        /// <summary>
        /// Donation link
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("donation")]
        public string? Donation { get; set; }

        /// <summary>
        /// Twitter handle (without @)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twitter_handle")]
        public string? TwitterHandle { get; set; }

        /// <summary>
        /// Instagram handle (without @)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instagram_handle")]
        public string? InstagramHandle { get; set; }

        /// <summary>
        /// TikTok handle (without @)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tiktok_handle")]
        public string? TiktokHandle { get; set; }

        /// <summary>
        /// Profile picture CID or URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_picture")]
        public string? ProfilePicture { get; set; }

        /// <summary>
        /// Profile picture sizes metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_picture_sizes")]
        public string? ProfilePictureSizes { get; set; }

        /// <summary>
        /// Cover photo CID or URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_photo")]
        public string? CoverPhoto { get; set; }

        /// <summary>
        /// Cover photo sizes metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_photo_sizes")]
        public string? CoverPhotoSizes { get; set; }

        /// <summary>
        /// Type of profile (e.g., 'label' for record labels)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Audius.JsonConverters.UpdateUserRequestBodyProfileTypeJsonConverter))]
        public global::Audius.UpdateUserRequestBodyProfileType? ProfileType { get; set; }

        /// <summary>
        /// Whether the user is deactivated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_deactivated")]
        public bool? IsDeactivated { get; set; }

        /// <summary>
        /// Track hash ID to feature as artist pick<br/>
        /// Example: x5pJ3Az
        /// </summary>
        /// <example>x5pJ3Az</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("artist_pick_track_id")]
        public string? ArtistPickTrackId { get; set; }

        /// <summary>
        /// Whether to allow AI attribution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_ai_attribution")]
        public bool? AllowAiAttribution { get; set; }

        /// <summary>
        /// Solana USDC payout wallet address
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spl_usdc_payout_wallet")]
        public string? SplUsdcPayoutWallet { get; set; }

        /// <summary>
        /// Coin flair mint address
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coin_flair_mint")]
        public string? CoinFlairMint { get; set; }

        /// <summary>
        /// User's playlist library with support for folders and playlists
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playlist_library")]
        public global::Audius.UserPlaylistLibrary? PlaylistLibrary { get; set; }

        /// <summary>
        /// User events for tracking referrals and mobile users
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::Audius.UpdateUserRequestBodyEvents? Events { get; set; }

        /// <summary>
        /// Raw JSON properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, global::System.Text.Json.JsonElement>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserRequestBody" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateUserRequestBody(
            string? handle,
            string? name,
            string? bio,
            string? location,
            string? website,
            string? donation,
            string? twitterHandle,
            string? instagramHandle,
            string? tiktokHandle,
            string? profilePicture,
            string? profilePictureSizes,
            string? coverPhoto,
            string? coverPhotoSizes,
            global::Audius.UpdateUserRequestBodyProfileType? profileType,
            bool? isDeactivated,
            string? artistPickTrackId,
            bool? allowAiAttribution,
            string? splUsdcPayoutWallet,
            string? coinFlairMint,
            global::Audius.UserPlaylistLibrary? playlistLibrary,
            global::Audius.UpdateUserRequestBodyEvents? events)
        {
            this.Handle = handle;
            this.Name = name;
            this.Bio = bio;
            this.Location = location;
            this.Website = website;
            this.Donation = donation;
            this.TwitterHandle = twitterHandle;
            this.InstagramHandle = instagramHandle;
            this.TiktokHandle = tiktokHandle;
            this.ProfilePicture = profilePicture;
            this.ProfilePictureSizes = profilePictureSizes;
            this.CoverPhoto = coverPhoto;
            this.CoverPhotoSizes = coverPhotoSizes;
            this.ProfileType = profileType;
            this.IsDeactivated = isDeactivated;
            this.ArtistPickTrackId = artistPickTrackId;
            this.AllowAiAttribution = allowAiAttribution;
            this.SplUsdcPayoutWallet = splUsdcPayoutWallet;
            this.CoinFlairMint = coinFlairMint;
            this.PlaylistLibrary = playlistLibrary;
            this.Events = events;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserRequestBody" /> class.
        /// </summary>
        public UpdateUserRequestBody()
        {
        }

    }
}