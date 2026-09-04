
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateAccessKeyResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackLibraryResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.VersionMetadata), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TrackActivity>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackActivity), TypeInfoPropertyName = "TrackActivity2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PurchasesResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Purchase>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Purchase), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreatePlaylistRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Genre), TypeInfoPropertyName = "Genre2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Mood), TypeInfoPropertyName = "Mood2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.PlaylistAddedTimestamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistAddedTimestamp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AccessGate), TypeInfoPropertyName = "AccessGate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.DdexResourceContributor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DdexResourceContributor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DdexCopyright))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserTracksRemixedResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.RemixedTrackAggregate>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixedTrackAggregate), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CidDataResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DataAndType), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DdexRightsController))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ClaimedPrizesResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ClaimedPrize>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ClaimedPrize), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UndisbursedChallenges), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.UndisbursedChallenge>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UndisbursedChallenge), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PinCommentRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentEntityType), TypeInfoPropertyName = "CommentEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ClaimRewardsRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.BulkSubscribersResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.UserSubscribers>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserSubscribers), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackCommentCountResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Coin), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PurchasersResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.User>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.User), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PrizeClaimRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateRewardCodeRequest), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistTracksResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Track>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Track), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PrizeClaimResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingPlaylistsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Playlist>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Playlist), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateTrackRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FieldVisibility))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.StemParent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixParentWrite), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CollectiblesResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Collectibles), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateCommentRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DashboardWalletUsersResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.DashboardWalletUser>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DashboardWalletUser), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TipGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FollowGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PurchaseGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TokenGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UpdateTrackRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AuthorizedApps), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.AuthorizedApp>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AuthorizedApp), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Reposts), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Activity>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Activity), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DeveloperAppsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.DeveloperApp>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DeveloperApp), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistArtwork), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Access), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Repost>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Repost), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Favorite>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Favorite), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackCommentsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Comment>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Comment), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Related), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchModel), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DynamicBondingCurveInsights), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ArtistLocker), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ArtistCoinFees), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RewardPool), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackDownloadCountResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackDownloadCountResponseData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackDownloadCountsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TrackDownloadCountsResponseDataItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackDownloadCountsResponseDataItem), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserTracksDownloadCountResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateUserResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TracksCountResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.EventsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Event>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Event), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixContestsRelated), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, long>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixContestsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.EventFollowState), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.EventFollowStateResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FollowingResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistSearchResult), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TagsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackActivityVariant2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackActivityVariant2ItemType), TypeInfoPropertyName = "TrackActivityVariant2ItemType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TopUsersResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingIdsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingTimesIds), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PurchasesCountResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.EmailAccessResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.EmailAccess), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AddManagerRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AttestationReponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Attestation), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserCoinResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserCoinWithAccounts), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateCommentResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RepostRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinsVolumeLeadersResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.CoinsVolumeLeadersResponseDataItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinsVolumeLeadersResponseDataItem), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.WriteResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CidData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchAutocompleteResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackInspect), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.BlobInfo), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserIdsAddressesResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.UserIdAddress>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserIdAddress), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AccessInfoResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackAccessInfo), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserAccountResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Account), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.BalanceHistoryResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.BalanceHistoryDataPoint>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.BalanceHistoryDataPoint), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.StemsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Stem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Stem), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.HistoryResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UsdcGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.PurchaseSplit>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PurchaseSplit), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.PlaylistWithoutTracks>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistWithoutTracks), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PrizesResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.PrizePublic>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PrizePublic), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateCoinResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateCoinResponseData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UnclaimedIdResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TracksResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ManagedUsersResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ManagedUser>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ManagedUser), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Reactions), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Reaction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Reaction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserSearch), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixersResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PurchasersCountResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateDeveloperAppResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinMembersResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.CoinMember>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinMember), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.SearchTrack>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchTrack), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.SearchPlaylist>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchPlaylist), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackInspectList), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.BlobInfo>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FavoriteRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackDownloadRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TrackElementWrite>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackElementWrite), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserArtistCoinBadge), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoverPhoto), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ProfilePicture), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistLibrary), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistUpdatesResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistUpdates), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UpdateUserRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UpdateUserRequestBodyProfileType), TypeInfoPropertyName = "UpdateUserRequestBodyProfileType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserPlaylistLibrary), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UpdateUserRequestBodyEvents), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UpdateCommentRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinInsightsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinInsights), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CollectionLibraryResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.CollectionActivityWithoutTracks>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CollectionActivityWithoutTracks), TypeInfoPropertyName = "CollectionActivityWithoutTracks2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackFavoritesResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetSupporter), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Supporter), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UpdateCoinRequest), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateRewardCodeResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SalesAggregateResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.SalesAggregate>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SalesAggregate), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RelatedArtistResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.UserCoinAccount>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserCoinAccount), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ManagersResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.UserManager>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserManager), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.EventEventType), TypeInfoPropertyName = "EventEventType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.EventEntityType), TypeInfoPropertyName = "EventEntityType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateUserRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateUserRequestBodyProfileType), TypeInfoPropertyName = "CreateUserRequestBodyProfileType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateUserRequestBodyEvents), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RegisterApiKeyRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RegisterApiKeyResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DeactivateAccessKeyRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetSupporting), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Supporting), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SalesJsonResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SalesJsonContent), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ReactCommentRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentRepliesResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ReplyComment>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ReplyComment), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TransactionHistoryCountResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreatePlaylistResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackCommentNotificationResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentNotificationSetting), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.VerifyToken), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DecodedUserToken), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixersCountResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ClaimRewardsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ClaimRewardsResponseDataItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ClaimRewardsResponseDataItem), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UpdateDeveloperAppRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTipsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Tip>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Tip), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserCoinsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.UserCoin>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserCoin), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateCoinRequest), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FavoritesResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixablesResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RewardCodeErrorResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RewardCodeErrorResponseError), TypeInfoPropertyName = "RewardCodeErrorResponseError2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateGrantRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DeactivateAccessKeyResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserCommentsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinMembersCountResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Grant), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AlbumsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ApproveGrantRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserFeedResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.UserFeedItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserFeedItem), TypeInfoPropertyName = "UserFeedItem2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixingResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackRepostsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TopGenreUsersResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.MutualFollowersResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RedeemAmountResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateDeveloperAppRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Coin>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UpdateCoinResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateTrackResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetSupporters), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Supporter>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RewardCodeResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UpdatePlaylistRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Tracks), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DeveloperAppResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixesResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixesResponseData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackArtwork), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixParent), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AlbumBacklink), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoverArt), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TrackSegment>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackSegment), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UrlWithMirrors), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.StreamUrlResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FollowersResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetSupportedUsers), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Supporting>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.NotificationsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Notifications), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ConnectedWalletsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ConnectedWallets), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.BestSellingResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.BestSellingItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.BestSellingItem), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackSearch), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserTrackListenCountsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Audius.MonthlyAggregatePlay>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SubscribersResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TransactionHistoryResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TransactionDetails>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TransactionDetails), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetChallenges), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ChallengeResponse>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ChallengeResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TopListener), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TopListener>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CollectionActivityWithoutTracksVariant2), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CollectionActivityWithoutTracksVariant2ItemType), TypeInfoPropertyName = "CollectionActivityWithoutTracksVariant2ItemType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.CommentMention>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentMention), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedAccessGate), TypeInfoPropertyName = "ExtendedAccessGate2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ActivityItemType), TypeInfoPropertyName = "ActivityItemType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedTokenGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.NftGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.NftCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TrackId>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackId), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.AccountCollection>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AccountCollection), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.BestSellingItemContentType), TypeInfoPropertyName = "BestSellingItemContentType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackFeedItem), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistFeedItem), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserFeedItemDiscriminator), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserFeedItemDiscriminatorType), TypeInfoPropertyName = "UserFeedItemDiscriminatorType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.PlaylistUpdate>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistUpdate), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Remix>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Remix), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedPurchaseGate), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinInsightsExtensions), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinInsightsDynamicBondingCurve), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.PaymentSplit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PaymentSplit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.MonthlyAggregatePlay), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.NftCollectionChain), TypeInfoPropertyName = "NftCollectionChain2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.NftCollectionStandard), TypeInfoPropertyName = "NftCollectionStandard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedUsdcGate), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ExtendedPaymentSplit>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedPaymentSplit), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.OneOf<global::Audius.PlaylistLibraryFolder, global::Audius.PlaylistLibraryPlaylistIdentifier, global::Audius.PlaylistLibraryExplorePlaylistIdentifier>>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.OneOf<global::Audius.PlaylistLibraryFolder, global::Audius.PlaylistLibraryPlaylistIdentifier, global::Audius.PlaylistLibraryExplorePlaylistIdentifier>), TypeInfoPropertyName = "OneOfPlaylistLibraryFolderPlaylistLibraryPlaylistIdentifierPlaylistLibraryExplorePlaylistIdentifier2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistLibraryFolder), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistLibraryPlaylistIdentifier), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistLibraryExplorePlaylistIdentifier), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Notification>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Notification), TypeInfoPropertyName = "Notification2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.SaleJson>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SaleJson), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.SupporterReference>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SupporterReference), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AccountCollectionUser), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FollowNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SaveNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RepostNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RepostOfRepostNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SaveOfRepostNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TastemakerNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CosignNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SendTipNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ReceiveTipNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SupporterDethronedNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SupporterRankUpNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ChallengeRewardNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ClaimableRewardNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ReactionNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.MilestoneNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TierChangeNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackAddedToPlaylistNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackAddedToPurchasedAlbumNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UsdcPurchaseSellerNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UsdcPurchaseBuyerNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RequestManagerNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ApproveManagerRequestNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingPlaylistNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingUndergroundNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AnnouncementNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentThreadNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentMentionNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentReactionNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ListenStreakReminderNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestStartedNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestEndedNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestEndingSoonNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ArtistRemixContestEndedNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ArtistRemixContestEndingSoonNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ArtistRemixContestSubmissionsNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestWinnersSelectedNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixContestUpdateNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestSubmissionNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanClubTextPostNotification), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.NotificationDiscriminator), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.NotificationDiscriminatorType), TypeInfoPropertyName = "NotificationDiscriminatorType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.SaveNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SaveNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistLibraryPlaylistIdentifierType), TypeInfoPropertyName = "PlaylistLibraryPlaylistIdentifierType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.FanRemixContestEndedNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestEndedNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.FanRemixContestWinnersSelectedNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestWinnersSelectedNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.RemixContestUpdateNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixContestUpdateNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.FanRemixContestSubmissionNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestSubmissionNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TierChangeNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TierChangeNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.CosignNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CosignNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.CommentReactionNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentReactionNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ApproveManagerRequestNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ApproveManagerRequestNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestEndedNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ListenCount>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ListenCount), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SaveNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.SaveOfRepostNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SaveOfRepostNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ApproveManagerRequestNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.CommentMentionNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentMentionNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistLibraryFolderType), TypeInfoPropertyName = "PlaylistLibraryFolderType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistLibraryExplorePlaylistIdentifierType), TypeInfoPropertyName = "PlaylistLibraryExplorePlaylistIdentifierType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.SendTipNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SendTipNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentReactionNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.CommentThreadNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentThreadNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ReactionNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ReactionNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.RemixNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CosignNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.AnnouncementNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AnnouncementNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ListenStreakReminderNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ListenStreakReminderNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentThreadNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestWinnersSelectedNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixContestUpdateNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestSubmissionNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SendTipNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.SupporterDethronedNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SupporterDethronedNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ReactionNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ReceiveTipNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ReceiveTipNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TastemakerNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TastemakerNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TrackAddedToPurchasedAlbumNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackAddedToPurchasedAlbumNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TrackAddedToPlaylistNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackAddedToPlaylistNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ReceiveTipNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TrendingUndergroundNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingUndergroundNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ChallengeRewardNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ChallengeRewardNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.UsdcPurchaseSellerNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UsdcPurchaseSellerNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.SupporterRankUpNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SupporterRankUpNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.FanClubTextPostNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanClubTextPostNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.FanRemixContestStartedNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestStartedNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackAddedToPurchasedAlbumNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.RequestManagerNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RequestManagerNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.CommentNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ClaimableRewardNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ClaimableRewardNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.CreateNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.MilestoneNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.MilestoneNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.FanRemixContestEndingSoonNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestEndingSoonNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TrendingNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TastemakerNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentMentionNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ClaimableRewardNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AnnouncementNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UsdcPurchaseSellerNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RequestManagerNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.RepostOfRepostNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RepostOfRepostNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TrendingPlaylistNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingPlaylistNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.FollowNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FollowNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentThreadNotificationActionDataType), TypeInfoPropertyName = "CommentThreadNotificationActionDataType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateNotificationActionData), TypeInfoPropertyName = "CreateNotificationActionData2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingUndergroundNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.RepostNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RepostNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ArtistRemixContestSubmissionsNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ArtistRemixContestSubmissionsNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ArtistRemixContestEndingSoonNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ArtistRemixContestEndingSoonNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.UsdcPurchaseBuyerNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UsdcPurchaseBuyerNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ArtistRemixContestEndedNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ArtistRemixContestEndedNotificationAction), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SaveOfRepostNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SupporterDethronedNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SaveNotificationActionDataType), TypeInfoPropertyName = "SaveNotificationActionDataType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TierChangeNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingUndergroundNotificationActionDataTimeRange), TypeInfoPropertyName = "TrendingUndergroundNotificationActionDataTimeRange2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ChallengeRewardNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ArtistRemixContestSubmissionsNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreatePlaylistNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateTrackNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ArtistRemixContestEndedNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestEndingSoonNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SaveOfRepostNotificationActionDataType), TypeInfoPropertyName = "SaveOfRepostNotificationActionDataType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ListenStreakReminderNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentReactionNotificationActionDataType), TypeInfoPropertyName = "CommentReactionNotificationActionDataType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RepostNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RepostNotificationActionDataType), TypeInfoPropertyName = "RepostNotificationActionDataType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RepostOfRepostNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingPlaylistNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FollowNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ArtistRemixContestEndingSoonNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentMentionNotificationActionDataType), TypeInfoPropertyName = "CommentMentionNotificationActionDataType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentNotificationActionDataType), TypeInfoPropertyName = "CommentNotificationActionDataType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingNotificationActionDataTimeRange), TypeInfoPropertyName = "TrendingNotificationActionDataTimeRange2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.MilestoneNotificationActionData), TypeInfoPropertyName = "MilestoneNotificationActionData2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SupporterRankUpNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RepostOfRepostNotificationActionDataType), TypeInfoPropertyName = "RepostOfRepostNotificationActionDataType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingPlaylistNotificationActionDataTimeRange), TypeInfoPropertyName = "TrendingPlaylistNotificationActionDataTimeRange2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UsdcPurchaseBuyerNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackAddedToPlaylistNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanClubTextPostNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestStartedNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserMilestoneNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackMilestoneNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistMilestoneNotificationActionData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserResponseSingle), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetBulkEventsEventType), TypeInfoPropertyName = "GetBulkEventsEventType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAllEventsSortMethod), TypeInfoPropertyName = "GetAllEventsSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAllEventsEventType), TypeInfoPropertyName = "GetAllEventsEventType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetEntityEventsEntityType), TypeInfoPropertyName = "GetEntityEventsEntityType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetRemixContestsStatus), TypeInfoPropertyName = "GetRemixContestsStatus2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetEventCommentsSortMethod), TypeInfoPropertyName = "GetEventCommentsSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetBestSellingType), TypeInfoPropertyName = "GetBestSellingType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchPlaylistsSortMethod), TypeInfoPropertyName = "SearchPlaylistsSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetPlaylistsNewReleasesType), TypeInfoPropertyName = "GetPlaylistsNewReleasesType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingPlaylistsTime), TypeInfoPropertyName = "GetTrendingPlaylistsTime2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingPlaylistsType), TypeInfoPropertyName = "GetTrendingPlaylistsType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTipsCurrentUserFollows), TypeInfoPropertyName = "GetTipsCurrentUserFollows2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTipsUniqueBy), TypeInfoPropertyName = "GetTipsUniqueBy2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetRecommendedTracksTime), TypeInfoPropertyName = "GetRecommendedTracksTime2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetRecommendedTracksWithVersionTime), TypeInfoPropertyName = "GetRecommendedTracksWithVersionTime2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetMostSharedTracksTimeRange), TypeInfoPropertyName = "GetMostSharedTracksTimeRange2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingUsdcPurchaseTracksTime), TypeInfoPropertyName = "GetTrendingUsdcPurchaseTracksTime2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingUsdcPurchaseTracksWithVersionTime), TypeInfoPropertyName = "GetTrendingUsdcPurchaseTracksWithVersionTime2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchTracksSortMethod), TypeInfoPropertyName = "SearchTracksSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingTracksTime), TypeInfoPropertyName = "GetTrendingTracksTime2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingTracksWithVersionTime), TypeInfoPropertyName = "GetTrendingTracksWithVersionTime2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrackCommentsSortMethod), TypeInfoPropertyName = "GetTrackCommentsSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrackRemixesSortMethod), TypeInfoPropertyName = "GetTrackRemixesSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserHandleSort), TypeInfoPropertyName = "GetTracksByUserHandleSort2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserHandleSortMethod), TypeInfoPropertyName = "GetTracksByUserHandleSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserHandleSortDirection), TypeInfoPropertyName = "GetTracksByUserHandleSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserHandleFilterTracks), TypeInfoPropertyName = "GetTracksByUserHandleFilterTracks2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAiAttributedTracksByUserHandleSort), TypeInfoPropertyName = "GetAiAttributedTracksByUserHandleSort2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAiAttributedTracksByUserHandleSortMethod), TypeInfoPropertyName = "GetAiAttributedTracksByUserHandleSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAiAttributedTracksByUserHandleSortDirection), TypeInfoPropertyName = "GetAiAttributedTracksByUserHandleSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAiAttributedTracksByUserHandleFilterTracks), TypeInfoPropertyName = "GetAiAttributedTracksByUserHandleFilterTracks2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchUsersSortMethod), TypeInfoPropertyName = "SearchUsersSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAlbumsByUserSortMethod), TypeInfoPropertyName = "GetAlbumsByUserSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetDeveloperAppsInclude), TypeInfoPropertyName = "GetDeveloperAppsInclude2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserBalanceHistoryGranularity), TypeInfoPropertyName = "GetUserBalanceHistoryGranularity2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserTrackHistorySortMethod), TypeInfoPropertyName = "GetUserTrackHistorySortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserTrackHistorySortDirection), TypeInfoPropertyName = "GetUserTrackHistorySortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetPlaylistsByUserSortMethod), TypeInfoPropertyName = "GetPlaylistsByUserSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserRecommendedTracksTimeRange), TypeInfoPropertyName = "GetUserRecommendedTracksTimeRange2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserSort), TypeInfoPropertyName = "GetTracksByUserSort2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserSortMethod), TypeInfoPropertyName = "GetTracksByUserSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserSortDirection), TypeInfoPropertyName = "GetTracksByUserSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserFilterTracks), TypeInfoPropertyName = "GetTracksByUserFilterTracks2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.GetTracksByUserGateConditionItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserGateConditionItem), TypeInfoPropertyName = "GetTracksByUserGateConditionItem2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksCountByUserFilterTracks), TypeInfoPropertyName = "GetTracksCountByUserFilterTracks2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.GetTracksCountByUserGateConditionItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksCountByUserGateConditionItem), TypeInfoPropertyName = "GetTracksCountByUserGateConditionItem2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetCoinsSortMethod), TypeInfoPropertyName = "GetCoinsSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetCoinsSortDirection), TypeInfoPropertyName = "GetCoinsSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetCoinMembersSortDirection), TypeInfoPropertyName = "GetCoinMembersSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.GetNotificationsType>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetNotificationsType), TypeInfoPropertyName = "GetNotificationsType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingPlaylistsWithVersionTime), TypeInfoPropertyName = "GetTrendingPlaylistsWithVersionTime2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchAutocompleteKind), TypeInfoPropertyName = "SearchAutocompleteKind2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchAutocompleteSortMethod), TypeInfoPropertyName = "SearchAutocompleteSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchKind), TypeInfoPropertyName = "SearchKind2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchSortMethod), TypeInfoPropertyName = "SearchSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchTagsKind), TypeInfoPropertyName = "SearchTagsKind2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchTagsSortMethod), TypeInfoPropertyName = "SearchTagsSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetBestNewReleasesWindow), TypeInfoPropertyName = "GetBestNewReleasesWindow2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUnderTheRadarTracksFilter), TypeInfoPropertyName = "GetUnderTheRadarTracksFilter2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAudioTransactionHistorySortMethod), TypeInfoPropertyName = "GetAudioTransactionHistorySortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAudioTransactionHistorySortDirection), TypeInfoPropertyName = "GetAudioTransactionHistorySortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserFavoriteTracksSortMethod), TypeInfoPropertyName = "GetUserFavoriteTracksSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserFavoriteTracksSortDirection), TypeInfoPropertyName = "GetUserFavoriteTracksSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserFeedFilter), TypeInfoPropertyName = "GetUserFeedFilter2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryAlbumsSortDirection), TypeInfoPropertyName = "GetUserLibraryAlbumsSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryAlbumsType), TypeInfoPropertyName = "GetUserLibraryAlbumsType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryAlbumsSortMethod), TypeInfoPropertyName = "GetUserLibraryAlbumsSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryPlaylistsSortDirection), TypeInfoPropertyName = "GetUserLibraryPlaylistsSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryPlaylistsType), TypeInfoPropertyName = "GetUserLibraryPlaylistsType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryPlaylistsSortMethod), TypeInfoPropertyName = "GetUserLibraryPlaylistsSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryTracksSortMethod), TypeInfoPropertyName = "GetUserLibraryTracksSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryTracksSortDirection), TypeInfoPropertyName = "GetUserLibraryTracksSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryTracksType), TypeInfoPropertyName = "GetUserLibraryTracksType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetPurchasesSortMethod), TypeInfoPropertyName = "GetPurchasesSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetPurchasesSortDirection), TypeInfoPropertyName = "GetPurchasesSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetSalesSortMethod), TypeInfoPropertyName = "GetSalesSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetSalesSortDirection), TypeInfoPropertyName = "GetSalesSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAudioTransactionsSortMethod), TypeInfoPropertyName = "GetAudioTransactionsSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAudioTransactionsSortDirection), TypeInfoPropertyName = "GetAudioTransactionsSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUsdcTransactionsSortMethod), TypeInfoPropertyName = "GetUsdcTransactionsSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUsdcTransactionsSortDirection), TypeInfoPropertyName = "GetUsdcTransactionsSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.GetUsdcTransactionsTypeItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUsdcTransactionsTypeItem), TypeInfoPropertyName = "GetUsdcTransactionsTypeItem2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUsdcTransactionsMethod), TypeInfoPropertyName = "GetUsdcTransactionsMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.GetUsdcTransactionCountTypeItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUsdcTransactionCountTypeItem), TypeInfoPropertyName = "GetUsdcTransactionCountTypeItem2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUsdcTransactionCountMethod), TypeInfoPropertyName = "GetUsdcTransactionCountMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackActivity?), TypeInfoPropertyName = "NullableTrackActivity2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Genre?), TypeInfoPropertyName = "NullableGenre2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Mood?), TypeInfoPropertyName = "NullableMood2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AccessGate?), TypeInfoPropertyName = "NullableAccessGate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentEntityType?), TypeInfoPropertyName = "NullableCommentEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackActivityVariant2ItemType?), TypeInfoPropertyName = "NullableTrackActivityVariant2ItemType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UpdateUserRequestBodyProfileType?), TypeInfoPropertyName = "NullableUpdateUserRequestBodyProfileType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CollectionActivityWithoutTracks?), TypeInfoPropertyName = "NullableCollectionActivityWithoutTracks2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.EventEventType?), TypeInfoPropertyName = "NullableEventEventType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.EventEntityType?), TypeInfoPropertyName = "NullableEventEntityType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateUserRequestBodyProfileType?), TypeInfoPropertyName = "NullableCreateUserRequestBodyProfileType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RewardCodeErrorResponseError?), TypeInfoPropertyName = "NullableRewardCodeErrorResponseError2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserFeedItem?), TypeInfoPropertyName = "NullableUserFeedItem2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CollectionActivityWithoutTracksVariant2ItemType?), TypeInfoPropertyName = "NullableCollectionActivityWithoutTracksVariant2ItemType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedAccessGate?), TypeInfoPropertyName = "NullableExtendedAccessGate2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ActivityItemType?), TypeInfoPropertyName = "NullableActivityItemType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.BestSellingItemContentType?), TypeInfoPropertyName = "NullableBestSellingItemContentType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserFeedItemDiscriminatorType?), TypeInfoPropertyName = "NullableUserFeedItemDiscriminatorType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.NftCollectionChain?), TypeInfoPropertyName = "NullableNftCollectionChain2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.NftCollectionStandard?), TypeInfoPropertyName = "NullableNftCollectionStandard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.OneOf<global::Audius.PlaylistLibraryFolder, global::Audius.PlaylistLibraryPlaylistIdentifier, global::Audius.PlaylistLibraryExplorePlaylistIdentifier>?), TypeInfoPropertyName = "NullableOneOfPlaylistLibraryFolderPlaylistLibraryPlaylistIdentifierPlaylistLibraryExplorePlaylistIdentifier2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Notification?), TypeInfoPropertyName = "NullableNotification2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.NotificationDiscriminatorType?), TypeInfoPropertyName = "NullableNotificationDiscriminatorType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistLibraryPlaylistIdentifierType?), TypeInfoPropertyName = "NullablePlaylistLibraryPlaylistIdentifierType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistLibraryFolderType?), TypeInfoPropertyName = "NullablePlaylistLibraryFolderType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistLibraryExplorePlaylistIdentifierType?), TypeInfoPropertyName = "NullablePlaylistLibraryExplorePlaylistIdentifierType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentThreadNotificationActionDataType?), TypeInfoPropertyName = "NullableCommentThreadNotificationActionDataType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateNotificationActionData?), TypeInfoPropertyName = "NullableCreateNotificationActionData2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SaveNotificationActionDataType?), TypeInfoPropertyName = "NullableSaveNotificationActionDataType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingUndergroundNotificationActionDataTimeRange?), TypeInfoPropertyName = "NullableTrendingUndergroundNotificationActionDataTimeRange2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SaveOfRepostNotificationActionDataType?), TypeInfoPropertyName = "NullableSaveOfRepostNotificationActionDataType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentReactionNotificationActionDataType?), TypeInfoPropertyName = "NullableCommentReactionNotificationActionDataType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RepostNotificationActionDataType?), TypeInfoPropertyName = "NullableRepostNotificationActionDataType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentMentionNotificationActionDataType?), TypeInfoPropertyName = "NullableCommentMentionNotificationActionDataType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentNotificationActionDataType?), TypeInfoPropertyName = "NullableCommentNotificationActionDataType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingNotificationActionDataTimeRange?), TypeInfoPropertyName = "NullableTrendingNotificationActionDataTimeRange2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.MilestoneNotificationActionData?), TypeInfoPropertyName = "NullableMilestoneNotificationActionData2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RepostOfRepostNotificationActionDataType?), TypeInfoPropertyName = "NullableRepostOfRepostNotificationActionDataType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingPlaylistNotificationActionDataTimeRange?), TypeInfoPropertyName = "NullableTrendingPlaylistNotificationActionDataTimeRange2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetBulkEventsEventType?), TypeInfoPropertyName = "NullableGetBulkEventsEventType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAllEventsSortMethod?), TypeInfoPropertyName = "NullableGetAllEventsSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAllEventsEventType?), TypeInfoPropertyName = "NullableGetAllEventsEventType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetEntityEventsEntityType?), TypeInfoPropertyName = "NullableGetEntityEventsEntityType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetRemixContestsStatus?), TypeInfoPropertyName = "NullableGetRemixContestsStatus2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetEventCommentsSortMethod?), TypeInfoPropertyName = "NullableGetEventCommentsSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetBestSellingType?), TypeInfoPropertyName = "NullableGetBestSellingType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchPlaylistsSortMethod?), TypeInfoPropertyName = "NullableSearchPlaylistsSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetPlaylistsNewReleasesType?), TypeInfoPropertyName = "NullableGetPlaylistsNewReleasesType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingPlaylistsTime?), TypeInfoPropertyName = "NullableGetTrendingPlaylistsTime2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingPlaylistsType?), TypeInfoPropertyName = "NullableGetTrendingPlaylistsType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTipsCurrentUserFollows?), TypeInfoPropertyName = "NullableGetTipsCurrentUserFollows2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTipsUniqueBy?), TypeInfoPropertyName = "NullableGetTipsUniqueBy2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetRecommendedTracksTime?), TypeInfoPropertyName = "NullableGetRecommendedTracksTime2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetRecommendedTracksWithVersionTime?), TypeInfoPropertyName = "NullableGetRecommendedTracksWithVersionTime2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetMostSharedTracksTimeRange?), TypeInfoPropertyName = "NullableGetMostSharedTracksTimeRange2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingUsdcPurchaseTracksTime?), TypeInfoPropertyName = "NullableGetTrendingUsdcPurchaseTracksTime2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingUsdcPurchaseTracksWithVersionTime?), TypeInfoPropertyName = "NullableGetTrendingUsdcPurchaseTracksWithVersionTime2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchTracksSortMethod?), TypeInfoPropertyName = "NullableSearchTracksSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingTracksTime?), TypeInfoPropertyName = "NullableGetTrendingTracksTime2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingTracksWithVersionTime?), TypeInfoPropertyName = "NullableGetTrendingTracksWithVersionTime2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrackCommentsSortMethod?), TypeInfoPropertyName = "NullableGetTrackCommentsSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrackRemixesSortMethod?), TypeInfoPropertyName = "NullableGetTrackRemixesSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserHandleSort?), TypeInfoPropertyName = "NullableGetTracksByUserHandleSort2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserHandleSortMethod?), TypeInfoPropertyName = "NullableGetTracksByUserHandleSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserHandleSortDirection?), TypeInfoPropertyName = "NullableGetTracksByUserHandleSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserHandleFilterTracks?), TypeInfoPropertyName = "NullableGetTracksByUserHandleFilterTracks2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAiAttributedTracksByUserHandleSort?), TypeInfoPropertyName = "NullableGetAiAttributedTracksByUserHandleSort2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAiAttributedTracksByUserHandleSortMethod?), TypeInfoPropertyName = "NullableGetAiAttributedTracksByUserHandleSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAiAttributedTracksByUserHandleSortDirection?), TypeInfoPropertyName = "NullableGetAiAttributedTracksByUserHandleSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAiAttributedTracksByUserHandleFilterTracks?), TypeInfoPropertyName = "NullableGetAiAttributedTracksByUserHandleFilterTracks2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchUsersSortMethod?), TypeInfoPropertyName = "NullableSearchUsersSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAlbumsByUserSortMethod?), TypeInfoPropertyName = "NullableGetAlbumsByUserSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetDeveloperAppsInclude?), TypeInfoPropertyName = "NullableGetDeveloperAppsInclude2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserBalanceHistoryGranularity?), TypeInfoPropertyName = "NullableGetUserBalanceHistoryGranularity2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserTrackHistorySortMethod?), TypeInfoPropertyName = "NullableGetUserTrackHistorySortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserTrackHistorySortDirection?), TypeInfoPropertyName = "NullableGetUserTrackHistorySortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetPlaylistsByUserSortMethod?), TypeInfoPropertyName = "NullableGetPlaylistsByUserSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserRecommendedTracksTimeRange?), TypeInfoPropertyName = "NullableGetUserRecommendedTracksTimeRange2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserSort?), TypeInfoPropertyName = "NullableGetTracksByUserSort2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserSortMethod?), TypeInfoPropertyName = "NullableGetTracksByUserSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserSortDirection?), TypeInfoPropertyName = "NullableGetTracksByUserSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserFilterTracks?), TypeInfoPropertyName = "NullableGetTracksByUserFilterTracks2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserGateConditionItem?), TypeInfoPropertyName = "NullableGetTracksByUserGateConditionItem2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksCountByUserFilterTracks?), TypeInfoPropertyName = "NullableGetTracksCountByUserFilterTracks2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksCountByUserGateConditionItem?), TypeInfoPropertyName = "NullableGetTracksCountByUserGateConditionItem2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetCoinsSortMethod?), TypeInfoPropertyName = "NullableGetCoinsSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetCoinsSortDirection?), TypeInfoPropertyName = "NullableGetCoinsSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetCoinMembersSortDirection?), TypeInfoPropertyName = "NullableGetCoinMembersSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetNotificationsType?), TypeInfoPropertyName = "NullableGetNotificationsType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingPlaylistsWithVersionTime?), TypeInfoPropertyName = "NullableGetTrendingPlaylistsWithVersionTime2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchAutocompleteKind?), TypeInfoPropertyName = "NullableSearchAutocompleteKind2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchAutocompleteSortMethod?), TypeInfoPropertyName = "NullableSearchAutocompleteSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchKind?), TypeInfoPropertyName = "NullableSearchKind2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchSortMethod?), TypeInfoPropertyName = "NullableSearchSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchTagsKind?), TypeInfoPropertyName = "NullableSearchTagsKind2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchTagsSortMethod?), TypeInfoPropertyName = "NullableSearchTagsSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetBestNewReleasesWindow?), TypeInfoPropertyName = "NullableGetBestNewReleasesWindow2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUnderTheRadarTracksFilter?), TypeInfoPropertyName = "NullableGetUnderTheRadarTracksFilter2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAudioTransactionHistorySortMethod?), TypeInfoPropertyName = "NullableGetAudioTransactionHistorySortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAudioTransactionHistorySortDirection?), TypeInfoPropertyName = "NullableGetAudioTransactionHistorySortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserFavoriteTracksSortMethod?), TypeInfoPropertyName = "NullableGetUserFavoriteTracksSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserFavoriteTracksSortDirection?), TypeInfoPropertyName = "NullableGetUserFavoriteTracksSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserFeedFilter?), TypeInfoPropertyName = "NullableGetUserFeedFilter2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryAlbumsSortDirection?), TypeInfoPropertyName = "NullableGetUserLibraryAlbumsSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryAlbumsType?), TypeInfoPropertyName = "NullableGetUserLibraryAlbumsType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryAlbumsSortMethod?), TypeInfoPropertyName = "NullableGetUserLibraryAlbumsSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryPlaylistsSortDirection?), TypeInfoPropertyName = "NullableGetUserLibraryPlaylistsSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryPlaylistsType?), TypeInfoPropertyName = "NullableGetUserLibraryPlaylistsType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryPlaylistsSortMethod?), TypeInfoPropertyName = "NullableGetUserLibraryPlaylistsSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryTracksSortMethod?), TypeInfoPropertyName = "NullableGetUserLibraryTracksSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryTracksSortDirection?), TypeInfoPropertyName = "NullableGetUserLibraryTracksSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryTracksType?), TypeInfoPropertyName = "NullableGetUserLibraryTracksType2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetPurchasesSortMethod?), TypeInfoPropertyName = "NullableGetPurchasesSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetPurchasesSortDirection?), TypeInfoPropertyName = "NullableGetPurchasesSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetSalesSortMethod?), TypeInfoPropertyName = "NullableGetSalesSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetSalesSortDirection?), TypeInfoPropertyName = "NullableGetSalesSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAudioTransactionsSortMethod?), TypeInfoPropertyName = "NullableGetAudioTransactionsSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAudioTransactionsSortDirection?), TypeInfoPropertyName = "NullableGetAudioTransactionsSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUsdcTransactionsSortMethod?), TypeInfoPropertyName = "NullableGetUsdcTransactionsSortMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUsdcTransactionsSortDirection?), TypeInfoPropertyName = "NullableGetUsdcTransactionsSortDirection2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUsdcTransactionsTypeItem?), TypeInfoPropertyName = "NullableGetUsdcTransactionsTypeItem2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUsdcTransactionsMethod?), TypeInfoPropertyName = "NullableGetUsdcTransactionsMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUsdcTransactionCountTypeItem?), TypeInfoPropertyName = "NullableGetUsdcTransactionCountTypeItem2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUsdcTransactionCountMethod?), TypeInfoPropertyName = "NullableGetUsdcTransactionCountMethod2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrackActivity>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Purchase>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.PlaylistAddedTimestamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.DdexResourceContributor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.RemixedTrackAggregate>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ClaimedPrize>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.UndisbursedChallenge>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.UserSubscribers>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.User>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Track>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Playlist>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.DashboardWalletUser>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.AuthorizedApp>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Activity>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.DeveloperApp>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Repost>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Favorite>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Comment>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrackDownloadCountsResponseDataItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Event>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CoinsVolumeLeadersResponseDataItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.UserIdAddress>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.BalanceHistoryDataPoint>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Stem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.PurchaseSplit>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.PlaylistWithoutTracks>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.PrizePublic>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ManagedUser>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Reaction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CoinMember>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.SearchTrack>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.SearchPlaylist>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.BlobInfo>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrackElementWrite>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CollectionActivityWithoutTracks>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.SalesAggregate>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.UserCoinAccount>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.UserManager>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ReplyComment>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ClaimRewardsResponseDataItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Tip>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.UserCoin>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.UserFeedItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Coin>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Supporter>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrackSegment>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Supporting>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.BestSellingItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TransactionDetails>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ChallengeResponse>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TopListener>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CommentMention>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrackId>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.AccountCollection>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.PlaylistUpdate>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Remix>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.PaymentSplit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ExtendedPaymentSplit>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.OneOf<global::Audius.PlaylistLibraryFolder, global::Audius.PlaylistLibraryPlaylistIdentifier, global::Audius.PlaylistLibraryExplorePlaylistIdentifier>>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Notification>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.SaleJson>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.SupporterReference>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.SaveNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.FanRemixContestEndedNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.FanRemixContestWinnersSelectedNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.RemixContestUpdateNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.FanRemixContestSubmissionNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TierChangeNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CosignNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CommentReactionNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ApproveManagerRequestNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ListenCount>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.SaveOfRepostNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CommentMentionNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.SendTipNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CommentThreadNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ReactionNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.RemixNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.AnnouncementNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ListenStreakReminderNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.SupporterDethronedNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ReceiveTipNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TastemakerNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrackAddedToPurchasedAlbumNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrackAddedToPlaylistNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrendingUndergroundNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ChallengeRewardNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.UsdcPurchaseSellerNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.SupporterRankUpNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.FanClubTextPostNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.FanRemixContestStartedNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.RequestManagerNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CommentNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ClaimableRewardNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CreateNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.MilestoneNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.FanRemixContestEndingSoonNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrendingNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.RepostOfRepostNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrendingPlaylistNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.FollowNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.RepostNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ArtistRemixContestSubmissionsNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ArtistRemixContestEndingSoonNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.UsdcPurchaseBuyerNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ArtistRemixContestEndedNotificationAction>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.GetTracksByUserGateConditionItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.GetTracksCountByUserGateConditionItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.GetNotificationsType>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.GetUsdcTransactionsTypeItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.GetUsdcTransactionCountTypeItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::Audius.JsonConverters.AccessGateJsonConverter());
            options.Converters.Add(new global::Audius.JsonConverters.TrackActivityJsonConverter());
            options.Converters.Add(new global::Audius.JsonConverters.CollectionActivityWithoutTracksJsonConverter());
            options.Converters.Add(new global::Audius.JsonConverters.UserFeedItemJsonConverter());
            options.Converters.Add(new global::Audius.JsonConverters.ExtendedAccessGateJsonConverter());
            options.Converters.Add(new global::Audius.JsonConverters.NotificationJsonConverter());
            options.Converters.Add(new global::Audius.JsonConverters.CreateNotificationActionDataJsonConverter());
            options.Converters.Add(new global::Audius.JsonConverters.MilestoneNotificationActionDataJsonConverter());
            options.Converters.Add(new global::Audius.JsonConverters.OneOfJsonConverter<global::Audius.PlaylistLibraryFolder, global::Audius.PlaylistLibraryPlaylistIdentifier, global::Audius.PlaylistLibraryExplorePlaylistIdentifier>());
            options.Converters.Add(new global::Audius.JsonConverters.OneOfJsonConverter<global::Audius.PlaylistLibraryFolder, global::Audius.PlaylistLibraryPlaylistIdentifier, global::Audius.PlaylistLibraryExplorePlaylistIdentifier>());
            options.Converters.Add(new global::Audius.JsonConverters.UnixTimestampJsonConverter());

            options.Converters.Add(new LazyEnumJsonConverterFactory());

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Audius.TrackActivityVariant2ItemType)

                    || typeToConvert == typeof(global::Audius.TrackActivityVariant2ItemType?)

                    || typeToConvert == typeof(global::Audius.UpdateUserRequestBodyProfileType)

                    || typeToConvert == typeof(global::Audius.UpdateUserRequestBodyProfileType?)

                    || typeToConvert == typeof(global::Audius.EventEventType)

                    || typeToConvert == typeof(global::Audius.EventEventType?)

                    || typeToConvert == typeof(global::Audius.EventEntityType)

                    || typeToConvert == typeof(global::Audius.EventEntityType?)

                    || typeToConvert == typeof(global::Audius.CreateUserRequestBodyProfileType)

                    || typeToConvert == typeof(global::Audius.CreateUserRequestBodyProfileType?)

                    || typeToConvert == typeof(global::Audius.RewardCodeErrorResponseError)

                    || typeToConvert == typeof(global::Audius.RewardCodeErrorResponseError?)

                    || typeToConvert == typeof(global::Audius.Genre)

                    || typeToConvert == typeof(global::Audius.Genre?)

                    || typeToConvert == typeof(global::Audius.Mood)

                    || typeToConvert == typeof(global::Audius.Mood?)

                    || typeToConvert == typeof(global::Audius.CommentEntityType)

                    || typeToConvert == typeof(global::Audius.CommentEntityType?)

                    || typeToConvert == typeof(global::Audius.CollectionActivityWithoutTracksVariant2ItemType)

                    || typeToConvert == typeof(global::Audius.CollectionActivityWithoutTracksVariant2ItemType?)

                    || typeToConvert == typeof(global::Audius.ActivityItemType)

                    || typeToConvert == typeof(global::Audius.ActivityItemType?)

                    || typeToConvert == typeof(global::Audius.BestSellingItemContentType)

                    || typeToConvert == typeof(global::Audius.BestSellingItemContentType?)

                    || typeToConvert == typeof(global::Audius.UserFeedItemDiscriminatorType)

                    || typeToConvert == typeof(global::Audius.UserFeedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::Audius.NftCollectionChain)

                    || typeToConvert == typeof(global::Audius.NftCollectionChain?)

                    || typeToConvert == typeof(global::Audius.NftCollectionStandard)

                    || typeToConvert == typeof(global::Audius.NftCollectionStandard?)

                    || typeToConvert == typeof(global::Audius.NotificationDiscriminatorType)

                    || typeToConvert == typeof(global::Audius.NotificationDiscriminatorType?)

                    || typeToConvert == typeof(global::Audius.PlaylistLibraryPlaylistIdentifierType)

                    || typeToConvert == typeof(global::Audius.PlaylistLibraryPlaylistIdentifierType?)

                    || typeToConvert == typeof(global::Audius.PlaylistLibraryFolderType)

                    || typeToConvert == typeof(global::Audius.PlaylistLibraryFolderType?)

                    || typeToConvert == typeof(global::Audius.PlaylistLibraryExplorePlaylistIdentifierType)

                    || typeToConvert == typeof(global::Audius.PlaylistLibraryExplorePlaylistIdentifierType?)

                    || typeToConvert == typeof(global::Audius.CommentThreadNotificationActionDataType)

                    || typeToConvert == typeof(global::Audius.CommentThreadNotificationActionDataType?)

                    || typeToConvert == typeof(global::Audius.SaveNotificationActionDataType)

                    || typeToConvert == typeof(global::Audius.SaveNotificationActionDataType?)

                    || typeToConvert == typeof(global::Audius.TrendingUndergroundNotificationActionDataTimeRange)

                    || typeToConvert == typeof(global::Audius.TrendingUndergroundNotificationActionDataTimeRange?)

                    || typeToConvert == typeof(global::Audius.SaveOfRepostNotificationActionDataType)

                    || typeToConvert == typeof(global::Audius.SaveOfRepostNotificationActionDataType?)

                    || typeToConvert == typeof(global::Audius.CommentReactionNotificationActionDataType)

                    || typeToConvert == typeof(global::Audius.CommentReactionNotificationActionDataType?)

                    || typeToConvert == typeof(global::Audius.RepostNotificationActionDataType)

                    || typeToConvert == typeof(global::Audius.RepostNotificationActionDataType?)

                    || typeToConvert == typeof(global::Audius.CommentMentionNotificationActionDataType)

                    || typeToConvert == typeof(global::Audius.CommentMentionNotificationActionDataType?)

                    || typeToConvert == typeof(global::Audius.CommentNotificationActionDataType)

                    || typeToConvert == typeof(global::Audius.CommentNotificationActionDataType?)

                    || typeToConvert == typeof(global::Audius.TrendingNotificationActionDataTimeRange)

                    || typeToConvert == typeof(global::Audius.TrendingNotificationActionDataTimeRange?)

                    || typeToConvert == typeof(global::Audius.RepostOfRepostNotificationActionDataType)

                    || typeToConvert == typeof(global::Audius.RepostOfRepostNotificationActionDataType?)

                    || typeToConvert == typeof(global::Audius.TrendingPlaylistNotificationActionDataTimeRange)

                    || typeToConvert == typeof(global::Audius.TrendingPlaylistNotificationActionDataTimeRange?)

                    || typeToConvert == typeof(global::Audius.GetBulkEventsEventType)

                    || typeToConvert == typeof(global::Audius.GetBulkEventsEventType?)

                    || typeToConvert == typeof(global::Audius.GetAllEventsSortMethod)

                    || typeToConvert == typeof(global::Audius.GetAllEventsSortMethod?)

                    || typeToConvert == typeof(global::Audius.GetAllEventsEventType)

                    || typeToConvert == typeof(global::Audius.GetAllEventsEventType?)

                    || typeToConvert == typeof(global::Audius.GetEntityEventsEntityType)

                    || typeToConvert == typeof(global::Audius.GetEntityEventsEntityType?)

                    || typeToConvert == typeof(global::Audius.GetRemixContestsStatus)

                    || typeToConvert == typeof(global::Audius.GetRemixContestsStatus?)

                    || typeToConvert == typeof(global::Audius.GetEventCommentsSortMethod)

                    || typeToConvert == typeof(global::Audius.GetEventCommentsSortMethod?)

                    || typeToConvert == typeof(global::Audius.GetBestSellingType)

                    || typeToConvert == typeof(global::Audius.GetBestSellingType?)

                    || typeToConvert == typeof(global::Audius.SearchPlaylistsSortMethod)

                    || typeToConvert == typeof(global::Audius.SearchPlaylistsSortMethod?)

                    || typeToConvert == typeof(global::Audius.GetPlaylistsNewReleasesType)

                    || typeToConvert == typeof(global::Audius.GetPlaylistsNewReleasesType?)

                    || typeToConvert == typeof(global::Audius.GetTrendingPlaylistsTime)

                    || typeToConvert == typeof(global::Audius.GetTrendingPlaylistsTime?)

                    || typeToConvert == typeof(global::Audius.GetTrendingPlaylistsType)

                    || typeToConvert == typeof(global::Audius.GetTrendingPlaylistsType?)

                    || typeToConvert == typeof(global::Audius.GetTipsCurrentUserFollows)

                    || typeToConvert == typeof(global::Audius.GetTipsCurrentUserFollows?)

                    || typeToConvert == typeof(global::Audius.GetTipsUniqueBy)

                    || typeToConvert == typeof(global::Audius.GetTipsUniqueBy?)

                    || typeToConvert == typeof(global::Audius.GetRecommendedTracksTime)

                    || typeToConvert == typeof(global::Audius.GetRecommendedTracksTime?)

                    || typeToConvert == typeof(global::Audius.GetRecommendedTracksWithVersionTime)

                    || typeToConvert == typeof(global::Audius.GetRecommendedTracksWithVersionTime?)

                    || typeToConvert == typeof(global::Audius.GetMostSharedTracksTimeRange)

                    || typeToConvert == typeof(global::Audius.GetMostSharedTracksTimeRange?)

                    || typeToConvert == typeof(global::Audius.GetTrendingUsdcPurchaseTracksTime)

                    || typeToConvert == typeof(global::Audius.GetTrendingUsdcPurchaseTracksTime?)

                    || typeToConvert == typeof(global::Audius.GetTrendingUsdcPurchaseTracksWithVersionTime)

                    || typeToConvert == typeof(global::Audius.GetTrendingUsdcPurchaseTracksWithVersionTime?)

                    || typeToConvert == typeof(global::Audius.SearchTracksSortMethod)

                    || typeToConvert == typeof(global::Audius.SearchTracksSortMethod?)

                    || typeToConvert == typeof(global::Audius.GetTrendingTracksTime)

                    || typeToConvert == typeof(global::Audius.GetTrendingTracksTime?)

                    || typeToConvert == typeof(global::Audius.GetTrendingTracksWithVersionTime)

                    || typeToConvert == typeof(global::Audius.GetTrendingTracksWithVersionTime?)

                    || typeToConvert == typeof(global::Audius.GetTrackCommentsSortMethod)

                    || typeToConvert == typeof(global::Audius.GetTrackCommentsSortMethod?)

                    || typeToConvert == typeof(global::Audius.GetTrackRemixesSortMethod)

                    || typeToConvert == typeof(global::Audius.GetTrackRemixesSortMethod?)

                    || typeToConvert == typeof(global::Audius.GetTracksByUserHandleSort)

                    || typeToConvert == typeof(global::Audius.GetTracksByUserHandleSort?)

                    || typeToConvert == typeof(global::Audius.GetTracksByUserHandleSortMethod)

                    || typeToConvert == typeof(global::Audius.GetTracksByUserHandleSortMethod?)

                    || typeToConvert == typeof(global::Audius.GetTracksByUserHandleSortDirection)

                    || typeToConvert == typeof(global::Audius.GetTracksByUserHandleSortDirection?)

                    || typeToConvert == typeof(global::Audius.GetTracksByUserHandleFilterTracks)

                    || typeToConvert == typeof(global::Audius.GetTracksByUserHandleFilterTracks?)

                    || typeToConvert == typeof(global::Audius.GetAiAttributedTracksByUserHandleSort)

                    || typeToConvert == typeof(global::Audius.GetAiAttributedTracksByUserHandleSort?)

                    || typeToConvert == typeof(global::Audius.GetAiAttributedTracksByUserHandleSortMethod)

                    || typeToConvert == typeof(global::Audius.GetAiAttributedTracksByUserHandleSortMethod?)

                    || typeToConvert == typeof(global::Audius.GetAiAttributedTracksByUserHandleSortDirection)

                    || typeToConvert == typeof(global::Audius.GetAiAttributedTracksByUserHandleSortDirection?)

                    || typeToConvert == typeof(global::Audius.GetAiAttributedTracksByUserHandleFilterTracks)

                    || typeToConvert == typeof(global::Audius.GetAiAttributedTracksByUserHandleFilterTracks?)

                    || typeToConvert == typeof(global::Audius.SearchUsersSortMethod)

                    || typeToConvert == typeof(global::Audius.SearchUsersSortMethod?)

                    || typeToConvert == typeof(global::Audius.GetAlbumsByUserSortMethod)

                    || typeToConvert == typeof(global::Audius.GetAlbumsByUserSortMethod?)

                    || typeToConvert == typeof(global::Audius.GetDeveloperAppsInclude)

                    || typeToConvert == typeof(global::Audius.GetDeveloperAppsInclude?)

                    || typeToConvert == typeof(global::Audius.GetUserBalanceHistoryGranularity)

                    || typeToConvert == typeof(global::Audius.GetUserBalanceHistoryGranularity?)

                    || typeToConvert == typeof(global::Audius.GetUserTrackHistorySortMethod)

                    || typeToConvert == typeof(global::Audius.GetUserTrackHistorySortMethod?)

                    || typeToConvert == typeof(global::Audius.GetUserTrackHistorySortDirection)

                    || typeToConvert == typeof(global::Audius.GetUserTrackHistorySortDirection?)

                    || typeToConvert == typeof(global::Audius.GetPlaylistsByUserSortMethod)

                    || typeToConvert == typeof(global::Audius.GetPlaylistsByUserSortMethod?)

                    || typeToConvert == typeof(global::Audius.GetUserRecommendedTracksTimeRange)

                    || typeToConvert == typeof(global::Audius.GetUserRecommendedTracksTimeRange?)

                    || typeToConvert == typeof(global::Audius.GetTracksByUserSort)

                    || typeToConvert == typeof(global::Audius.GetTracksByUserSort?)

                    || typeToConvert == typeof(global::Audius.GetTracksByUserSortMethod)

                    || typeToConvert == typeof(global::Audius.GetTracksByUserSortMethod?)

                    || typeToConvert == typeof(global::Audius.GetTracksByUserSortDirection)

                    || typeToConvert == typeof(global::Audius.GetTracksByUserSortDirection?)

                    || typeToConvert == typeof(global::Audius.GetTracksByUserFilterTracks)

                    || typeToConvert == typeof(global::Audius.GetTracksByUserFilterTracks?)

                    || typeToConvert == typeof(global::Audius.GetTracksByUserGateConditionItem)

                    || typeToConvert == typeof(global::Audius.GetTracksByUserGateConditionItem?)

                    || typeToConvert == typeof(global::Audius.GetTracksCountByUserFilterTracks)

                    || typeToConvert == typeof(global::Audius.GetTracksCountByUserFilterTracks?)

                    || typeToConvert == typeof(global::Audius.GetTracksCountByUserGateConditionItem)

                    || typeToConvert == typeof(global::Audius.GetTracksCountByUserGateConditionItem?)

                    || typeToConvert == typeof(global::Audius.GetCoinsSortMethod)

                    || typeToConvert == typeof(global::Audius.GetCoinsSortMethod?)

                    || typeToConvert == typeof(global::Audius.GetCoinsSortDirection)

                    || typeToConvert == typeof(global::Audius.GetCoinsSortDirection?)

                    || typeToConvert == typeof(global::Audius.GetCoinMembersSortDirection)

                    || typeToConvert == typeof(global::Audius.GetCoinMembersSortDirection?)

                    || typeToConvert == typeof(global::Audius.GetNotificationsType)

                    || typeToConvert == typeof(global::Audius.GetNotificationsType?)

                    || typeToConvert == typeof(global::Audius.GetTrendingPlaylistsWithVersionTime)

                    || typeToConvert == typeof(global::Audius.GetTrendingPlaylistsWithVersionTime?)

                    || typeToConvert == typeof(global::Audius.SearchAutocompleteKind)

                    || typeToConvert == typeof(global::Audius.SearchAutocompleteKind?)

                    || typeToConvert == typeof(global::Audius.SearchAutocompleteSortMethod)

                    || typeToConvert == typeof(global::Audius.SearchAutocompleteSortMethod?)

                    || typeToConvert == typeof(global::Audius.SearchKind)

                    || typeToConvert == typeof(global::Audius.SearchKind?)

                    || typeToConvert == typeof(global::Audius.SearchSortMethod)

                    || typeToConvert == typeof(global::Audius.SearchSortMethod?)

                    || typeToConvert == typeof(global::Audius.SearchTagsKind)

                    || typeToConvert == typeof(global::Audius.SearchTagsKind?)

                    || typeToConvert == typeof(global::Audius.SearchTagsSortMethod)

                    || typeToConvert == typeof(global::Audius.SearchTagsSortMethod?)

                    || typeToConvert == typeof(global::Audius.GetBestNewReleasesWindow)

                    || typeToConvert == typeof(global::Audius.GetBestNewReleasesWindow?)

                    || typeToConvert == typeof(global::Audius.GetUnderTheRadarTracksFilter)

                    || typeToConvert == typeof(global::Audius.GetUnderTheRadarTracksFilter?)

                    || typeToConvert == typeof(global::Audius.GetAudioTransactionHistorySortMethod)

                    || typeToConvert == typeof(global::Audius.GetAudioTransactionHistorySortMethod?)

                    || typeToConvert == typeof(global::Audius.GetAudioTransactionHistorySortDirection)

                    || typeToConvert == typeof(global::Audius.GetAudioTransactionHistorySortDirection?)

                    || typeToConvert == typeof(global::Audius.GetUserFavoriteTracksSortMethod)

                    || typeToConvert == typeof(global::Audius.GetUserFavoriteTracksSortMethod?)

                    || typeToConvert == typeof(global::Audius.GetUserFavoriteTracksSortDirection)

                    || typeToConvert == typeof(global::Audius.GetUserFavoriteTracksSortDirection?)

                    || typeToConvert == typeof(global::Audius.GetUserFeedFilter)

                    || typeToConvert == typeof(global::Audius.GetUserFeedFilter?)

                    || typeToConvert == typeof(global::Audius.GetUserLibraryAlbumsSortDirection)

                    || typeToConvert == typeof(global::Audius.GetUserLibraryAlbumsSortDirection?)

                    || typeToConvert == typeof(global::Audius.GetUserLibraryAlbumsType)

                    || typeToConvert == typeof(global::Audius.GetUserLibraryAlbumsType?)

                    || typeToConvert == typeof(global::Audius.GetUserLibraryAlbumsSortMethod)

                    || typeToConvert == typeof(global::Audius.GetUserLibraryAlbumsSortMethod?)

                    || typeToConvert == typeof(global::Audius.GetUserLibraryPlaylistsSortDirection)

                    || typeToConvert == typeof(global::Audius.GetUserLibraryPlaylistsSortDirection?)

                    || typeToConvert == typeof(global::Audius.GetUserLibraryPlaylistsType)

                    || typeToConvert == typeof(global::Audius.GetUserLibraryPlaylistsType?)

                    || typeToConvert == typeof(global::Audius.GetUserLibraryPlaylistsSortMethod)

                    || typeToConvert == typeof(global::Audius.GetUserLibraryPlaylistsSortMethod?)

                    || typeToConvert == typeof(global::Audius.GetUserLibraryTracksSortMethod)

                    || typeToConvert == typeof(global::Audius.GetUserLibraryTracksSortMethod?)

                    || typeToConvert == typeof(global::Audius.GetUserLibraryTracksSortDirection)

                    || typeToConvert == typeof(global::Audius.GetUserLibraryTracksSortDirection?)

                    || typeToConvert == typeof(global::Audius.GetUserLibraryTracksType)

                    || typeToConvert == typeof(global::Audius.GetUserLibraryTracksType?)

                    || typeToConvert == typeof(global::Audius.GetPurchasesSortMethod)

                    || typeToConvert == typeof(global::Audius.GetPurchasesSortMethod?)

                    || typeToConvert == typeof(global::Audius.GetPurchasesSortDirection)

                    || typeToConvert == typeof(global::Audius.GetPurchasesSortDirection?)

                    || typeToConvert == typeof(global::Audius.GetSalesSortMethod)

                    || typeToConvert == typeof(global::Audius.GetSalesSortMethod?)

                    || typeToConvert == typeof(global::Audius.GetSalesSortDirection)

                    || typeToConvert == typeof(global::Audius.GetSalesSortDirection?)

                    || typeToConvert == typeof(global::Audius.GetAudioTransactionsSortMethod)

                    || typeToConvert == typeof(global::Audius.GetAudioTransactionsSortMethod?)

                    || typeToConvert == typeof(global::Audius.GetAudioTransactionsSortDirection)

                    || typeToConvert == typeof(global::Audius.GetAudioTransactionsSortDirection?)

                    || typeToConvert == typeof(global::Audius.GetUsdcTransactionsSortMethod)

                    || typeToConvert == typeof(global::Audius.GetUsdcTransactionsSortMethod?)

                    || typeToConvert == typeof(global::Audius.GetUsdcTransactionsSortDirection)

                    || typeToConvert == typeof(global::Audius.GetUsdcTransactionsSortDirection?)

                    || typeToConvert == typeof(global::Audius.GetUsdcTransactionsTypeItem)

                    || typeToConvert == typeof(global::Audius.GetUsdcTransactionsTypeItem?)

                    || typeToConvert == typeof(global::Audius.GetUsdcTransactionsMethod)

                    || typeToConvert == typeof(global::Audius.GetUsdcTransactionsMethod?)

                    || typeToConvert == typeof(global::Audius.GetUsdcTransactionCountTypeItem)

                    || typeToConvert == typeof(global::Audius.GetUsdcTransactionCountTypeItem?)

                    || typeToConvert == typeof(global::Audius.GetUsdcTransactionCountMethod)

                    || typeToConvert == typeof(global::Audius.GetUsdcTransactionCountMethod?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Audius.TrackActivityVariant2ItemType))
                {
                    return new global::Audius.JsonConverters.TrackActivityVariant2ItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.TrackActivityVariant2ItemType?))
                {
                    return new global::Audius.JsonConverters.TrackActivityVariant2ItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.UpdateUserRequestBodyProfileType))
                {
                    return new global::Audius.JsonConverters.UpdateUserRequestBodyProfileTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.UpdateUserRequestBodyProfileType?))
                {
                    return new global::Audius.JsonConverters.UpdateUserRequestBodyProfileTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.EventEventType))
                {
                    return new global::Audius.JsonConverters.EventEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.EventEventType?))
                {
                    return new global::Audius.JsonConverters.EventEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.EventEntityType))
                {
                    return new global::Audius.JsonConverters.EventEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.EventEntityType?))
                {
                    return new global::Audius.JsonConverters.EventEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.CreateUserRequestBodyProfileType))
                {
                    return new global::Audius.JsonConverters.CreateUserRequestBodyProfileTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.CreateUserRequestBodyProfileType?))
                {
                    return new global::Audius.JsonConverters.CreateUserRequestBodyProfileTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.RewardCodeErrorResponseError))
                {
                    return new global::Audius.JsonConverters.RewardCodeErrorResponseErrorJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.RewardCodeErrorResponseError?))
                {
                    return new global::Audius.JsonConverters.RewardCodeErrorResponseErrorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.Genre))
                {
                    return new global::Audius.JsonConverters.GenreJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.Genre?))
                {
                    return new global::Audius.JsonConverters.GenreNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.Mood))
                {
                    return new global::Audius.JsonConverters.MoodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.Mood?))
                {
                    return new global::Audius.JsonConverters.MoodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.CommentEntityType))
                {
                    return new global::Audius.JsonConverters.CommentEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.CommentEntityType?))
                {
                    return new global::Audius.JsonConverters.CommentEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.CollectionActivityWithoutTracksVariant2ItemType))
                {
                    return new global::Audius.JsonConverters.CollectionActivityWithoutTracksVariant2ItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.CollectionActivityWithoutTracksVariant2ItemType?))
                {
                    return new global::Audius.JsonConverters.CollectionActivityWithoutTracksVariant2ItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.ActivityItemType))
                {
                    return new global::Audius.JsonConverters.ActivityItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.ActivityItemType?))
                {
                    return new global::Audius.JsonConverters.ActivityItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.BestSellingItemContentType))
                {
                    return new global::Audius.JsonConverters.BestSellingItemContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.BestSellingItemContentType?))
                {
                    return new global::Audius.JsonConverters.BestSellingItemContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.UserFeedItemDiscriminatorType))
                {
                    return new global::Audius.JsonConverters.UserFeedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.UserFeedItemDiscriminatorType?))
                {
                    return new global::Audius.JsonConverters.UserFeedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.NftCollectionChain))
                {
                    return new global::Audius.JsonConverters.NftCollectionChainJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.NftCollectionChain?))
                {
                    return new global::Audius.JsonConverters.NftCollectionChainNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.NftCollectionStandard))
                {
                    return new global::Audius.JsonConverters.NftCollectionStandardJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.NftCollectionStandard?))
                {
                    return new global::Audius.JsonConverters.NftCollectionStandardNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.NotificationDiscriminatorType))
                {
                    return new global::Audius.JsonConverters.NotificationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.NotificationDiscriminatorType?))
                {
                    return new global::Audius.JsonConverters.NotificationDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.PlaylistLibraryPlaylistIdentifierType))
                {
                    return new global::Audius.JsonConverters.PlaylistLibraryPlaylistIdentifierTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.PlaylistLibraryPlaylistIdentifierType?))
                {
                    return new global::Audius.JsonConverters.PlaylistLibraryPlaylistIdentifierTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.PlaylistLibraryFolderType))
                {
                    return new global::Audius.JsonConverters.PlaylistLibraryFolderTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.PlaylistLibraryFolderType?))
                {
                    return new global::Audius.JsonConverters.PlaylistLibraryFolderTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.PlaylistLibraryExplorePlaylistIdentifierType))
                {
                    return new global::Audius.JsonConverters.PlaylistLibraryExplorePlaylistIdentifierTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.PlaylistLibraryExplorePlaylistIdentifierType?))
                {
                    return new global::Audius.JsonConverters.PlaylistLibraryExplorePlaylistIdentifierTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.CommentThreadNotificationActionDataType))
                {
                    return new global::Audius.JsonConverters.CommentThreadNotificationActionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.CommentThreadNotificationActionDataType?))
                {
                    return new global::Audius.JsonConverters.CommentThreadNotificationActionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SaveNotificationActionDataType))
                {
                    return new global::Audius.JsonConverters.SaveNotificationActionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SaveNotificationActionDataType?))
                {
                    return new global::Audius.JsonConverters.SaveNotificationActionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.TrendingUndergroundNotificationActionDataTimeRange))
                {
                    return new global::Audius.JsonConverters.TrendingUndergroundNotificationActionDataTimeRangeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.TrendingUndergroundNotificationActionDataTimeRange?))
                {
                    return new global::Audius.JsonConverters.TrendingUndergroundNotificationActionDataTimeRangeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SaveOfRepostNotificationActionDataType))
                {
                    return new global::Audius.JsonConverters.SaveOfRepostNotificationActionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SaveOfRepostNotificationActionDataType?))
                {
                    return new global::Audius.JsonConverters.SaveOfRepostNotificationActionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.CommentReactionNotificationActionDataType))
                {
                    return new global::Audius.JsonConverters.CommentReactionNotificationActionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.CommentReactionNotificationActionDataType?))
                {
                    return new global::Audius.JsonConverters.CommentReactionNotificationActionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.RepostNotificationActionDataType))
                {
                    return new global::Audius.JsonConverters.RepostNotificationActionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.RepostNotificationActionDataType?))
                {
                    return new global::Audius.JsonConverters.RepostNotificationActionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.CommentMentionNotificationActionDataType))
                {
                    return new global::Audius.JsonConverters.CommentMentionNotificationActionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.CommentMentionNotificationActionDataType?))
                {
                    return new global::Audius.JsonConverters.CommentMentionNotificationActionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.CommentNotificationActionDataType))
                {
                    return new global::Audius.JsonConverters.CommentNotificationActionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.CommentNotificationActionDataType?))
                {
                    return new global::Audius.JsonConverters.CommentNotificationActionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.TrendingNotificationActionDataTimeRange))
                {
                    return new global::Audius.JsonConverters.TrendingNotificationActionDataTimeRangeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.TrendingNotificationActionDataTimeRange?))
                {
                    return new global::Audius.JsonConverters.TrendingNotificationActionDataTimeRangeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.RepostOfRepostNotificationActionDataType))
                {
                    return new global::Audius.JsonConverters.RepostOfRepostNotificationActionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.RepostOfRepostNotificationActionDataType?))
                {
                    return new global::Audius.JsonConverters.RepostOfRepostNotificationActionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.TrendingPlaylistNotificationActionDataTimeRange))
                {
                    return new global::Audius.JsonConverters.TrendingPlaylistNotificationActionDataTimeRangeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.TrendingPlaylistNotificationActionDataTimeRange?))
                {
                    return new global::Audius.JsonConverters.TrendingPlaylistNotificationActionDataTimeRangeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetBulkEventsEventType))
                {
                    return new global::Audius.JsonConverters.GetBulkEventsEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetBulkEventsEventType?))
                {
                    return new global::Audius.JsonConverters.GetBulkEventsEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetAllEventsSortMethod))
                {
                    return new global::Audius.JsonConverters.GetAllEventsSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetAllEventsSortMethod?))
                {
                    return new global::Audius.JsonConverters.GetAllEventsSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetAllEventsEventType))
                {
                    return new global::Audius.JsonConverters.GetAllEventsEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetAllEventsEventType?))
                {
                    return new global::Audius.JsonConverters.GetAllEventsEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetEntityEventsEntityType))
                {
                    return new global::Audius.JsonConverters.GetEntityEventsEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetEntityEventsEntityType?))
                {
                    return new global::Audius.JsonConverters.GetEntityEventsEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetRemixContestsStatus))
                {
                    return new global::Audius.JsonConverters.GetRemixContestsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetRemixContestsStatus?))
                {
                    return new global::Audius.JsonConverters.GetRemixContestsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetEventCommentsSortMethod))
                {
                    return new global::Audius.JsonConverters.GetEventCommentsSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetEventCommentsSortMethod?))
                {
                    return new global::Audius.JsonConverters.GetEventCommentsSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetBestSellingType))
                {
                    return new global::Audius.JsonConverters.GetBestSellingTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetBestSellingType?))
                {
                    return new global::Audius.JsonConverters.GetBestSellingTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchPlaylistsSortMethod))
                {
                    return new global::Audius.JsonConverters.SearchPlaylistsSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchPlaylistsSortMethod?))
                {
                    return new global::Audius.JsonConverters.SearchPlaylistsSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetPlaylistsNewReleasesType))
                {
                    return new global::Audius.JsonConverters.GetPlaylistsNewReleasesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetPlaylistsNewReleasesType?))
                {
                    return new global::Audius.JsonConverters.GetPlaylistsNewReleasesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTrendingPlaylistsTime))
                {
                    return new global::Audius.JsonConverters.GetTrendingPlaylistsTimeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTrendingPlaylistsTime?))
                {
                    return new global::Audius.JsonConverters.GetTrendingPlaylistsTimeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTrendingPlaylistsType))
                {
                    return new global::Audius.JsonConverters.GetTrendingPlaylistsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTrendingPlaylistsType?))
                {
                    return new global::Audius.JsonConverters.GetTrendingPlaylistsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTipsCurrentUserFollows))
                {
                    return new global::Audius.JsonConverters.GetTipsCurrentUserFollowsJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTipsCurrentUserFollows?))
                {
                    return new global::Audius.JsonConverters.GetTipsCurrentUserFollowsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTipsUniqueBy))
                {
                    return new global::Audius.JsonConverters.GetTipsUniqueByJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTipsUniqueBy?))
                {
                    return new global::Audius.JsonConverters.GetTipsUniqueByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetRecommendedTracksTime))
                {
                    return new global::Audius.JsonConverters.GetRecommendedTracksTimeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetRecommendedTracksTime?))
                {
                    return new global::Audius.JsonConverters.GetRecommendedTracksTimeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetRecommendedTracksWithVersionTime))
                {
                    return new global::Audius.JsonConverters.GetRecommendedTracksWithVersionTimeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetRecommendedTracksWithVersionTime?))
                {
                    return new global::Audius.JsonConverters.GetRecommendedTracksWithVersionTimeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetMostSharedTracksTimeRange))
                {
                    return new global::Audius.JsonConverters.GetMostSharedTracksTimeRangeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetMostSharedTracksTimeRange?))
                {
                    return new global::Audius.JsonConverters.GetMostSharedTracksTimeRangeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTrendingUsdcPurchaseTracksTime))
                {
                    return new global::Audius.JsonConverters.GetTrendingUsdcPurchaseTracksTimeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTrendingUsdcPurchaseTracksTime?))
                {
                    return new global::Audius.JsonConverters.GetTrendingUsdcPurchaseTracksTimeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTrendingUsdcPurchaseTracksWithVersionTime))
                {
                    return new global::Audius.JsonConverters.GetTrendingUsdcPurchaseTracksWithVersionTimeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTrendingUsdcPurchaseTracksWithVersionTime?))
                {
                    return new global::Audius.JsonConverters.GetTrendingUsdcPurchaseTracksWithVersionTimeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchTracksSortMethod))
                {
                    return new global::Audius.JsonConverters.SearchTracksSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchTracksSortMethod?))
                {
                    return new global::Audius.JsonConverters.SearchTracksSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTrendingTracksTime))
                {
                    return new global::Audius.JsonConverters.GetTrendingTracksTimeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTrendingTracksTime?))
                {
                    return new global::Audius.JsonConverters.GetTrendingTracksTimeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTrendingTracksWithVersionTime))
                {
                    return new global::Audius.JsonConverters.GetTrendingTracksWithVersionTimeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTrendingTracksWithVersionTime?))
                {
                    return new global::Audius.JsonConverters.GetTrendingTracksWithVersionTimeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTrackCommentsSortMethod))
                {
                    return new global::Audius.JsonConverters.GetTrackCommentsSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTrackCommentsSortMethod?))
                {
                    return new global::Audius.JsonConverters.GetTrackCommentsSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTrackRemixesSortMethod))
                {
                    return new global::Audius.JsonConverters.GetTrackRemixesSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTrackRemixesSortMethod?))
                {
                    return new global::Audius.JsonConverters.GetTrackRemixesSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTracksByUserHandleSort))
                {
                    return new global::Audius.JsonConverters.GetTracksByUserHandleSortJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTracksByUserHandleSort?))
                {
                    return new global::Audius.JsonConverters.GetTracksByUserHandleSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTracksByUserHandleSortMethod))
                {
                    return new global::Audius.JsonConverters.GetTracksByUserHandleSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTracksByUserHandleSortMethod?))
                {
                    return new global::Audius.JsonConverters.GetTracksByUserHandleSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTracksByUserHandleSortDirection))
                {
                    return new global::Audius.JsonConverters.GetTracksByUserHandleSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTracksByUserHandleSortDirection?))
                {
                    return new global::Audius.JsonConverters.GetTracksByUserHandleSortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTracksByUserHandleFilterTracks))
                {
                    return new global::Audius.JsonConverters.GetTracksByUserHandleFilterTracksJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTracksByUserHandleFilterTracks?))
                {
                    return new global::Audius.JsonConverters.GetTracksByUserHandleFilterTracksNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetAiAttributedTracksByUserHandleSort))
                {
                    return new global::Audius.JsonConverters.GetAiAttributedTracksByUserHandleSortJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetAiAttributedTracksByUserHandleSort?))
                {
                    return new global::Audius.JsonConverters.GetAiAttributedTracksByUserHandleSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetAiAttributedTracksByUserHandleSortMethod))
                {
                    return new global::Audius.JsonConverters.GetAiAttributedTracksByUserHandleSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetAiAttributedTracksByUserHandleSortMethod?))
                {
                    return new global::Audius.JsonConverters.GetAiAttributedTracksByUserHandleSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetAiAttributedTracksByUserHandleSortDirection))
                {
                    return new global::Audius.JsonConverters.GetAiAttributedTracksByUserHandleSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetAiAttributedTracksByUserHandleSortDirection?))
                {
                    return new global::Audius.JsonConverters.GetAiAttributedTracksByUserHandleSortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetAiAttributedTracksByUserHandleFilterTracks))
                {
                    return new global::Audius.JsonConverters.GetAiAttributedTracksByUserHandleFilterTracksJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetAiAttributedTracksByUserHandleFilterTracks?))
                {
                    return new global::Audius.JsonConverters.GetAiAttributedTracksByUserHandleFilterTracksNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchUsersSortMethod))
                {
                    return new global::Audius.JsonConverters.SearchUsersSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchUsersSortMethod?))
                {
                    return new global::Audius.JsonConverters.SearchUsersSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetAlbumsByUserSortMethod))
                {
                    return new global::Audius.JsonConverters.GetAlbumsByUserSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetAlbumsByUserSortMethod?))
                {
                    return new global::Audius.JsonConverters.GetAlbumsByUserSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetDeveloperAppsInclude))
                {
                    return new global::Audius.JsonConverters.GetDeveloperAppsIncludeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetDeveloperAppsInclude?))
                {
                    return new global::Audius.JsonConverters.GetDeveloperAppsIncludeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserBalanceHistoryGranularity))
                {
                    return new global::Audius.JsonConverters.GetUserBalanceHistoryGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserBalanceHistoryGranularity?))
                {
                    return new global::Audius.JsonConverters.GetUserBalanceHistoryGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserTrackHistorySortMethod))
                {
                    return new global::Audius.JsonConverters.GetUserTrackHistorySortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserTrackHistorySortMethod?))
                {
                    return new global::Audius.JsonConverters.GetUserTrackHistorySortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserTrackHistorySortDirection))
                {
                    return new global::Audius.JsonConverters.GetUserTrackHistorySortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserTrackHistorySortDirection?))
                {
                    return new global::Audius.JsonConverters.GetUserTrackHistorySortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetPlaylistsByUserSortMethod))
                {
                    return new global::Audius.JsonConverters.GetPlaylistsByUserSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetPlaylistsByUserSortMethod?))
                {
                    return new global::Audius.JsonConverters.GetPlaylistsByUserSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserRecommendedTracksTimeRange))
                {
                    return new global::Audius.JsonConverters.GetUserRecommendedTracksTimeRangeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserRecommendedTracksTimeRange?))
                {
                    return new global::Audius.JsonConverters.GetUserRecommendedTracksTimeRangeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTracksByUserSort))
                {
                    return new global::Audius.JsonConverters.GetTracksByUserSortJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTracksByUserSort?))
                {
                    return new global::Audius.JsonConverters.GetTracksByUserSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTracksByUserSortMethod))
                {
                    return new global::Audius.JsonConverters.GetTracksByUserSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTracksByUserSortMethod?))
                {
                    return new global::Audius.JsonConverters.GetTracksByUserSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTracksByUserSortDirection))
                {
                    return new global::Audius.JsonConverters.GetTracksByUserSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTracksByUserSortDirection?))
                {
                    return new global::Audius.JsonConverters.GetTracksByUserSortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTracksByUserFilterTracks))
                {
                    return new global::Audius.JsonConverters.GetTracksByUserFilterTracksJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTracksByUserFilterTracks?))
                {
                    return new global::Audius.JsonConverters.GetTracksByUserFilterTracksNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTracksByUserGateConditionItem))
                {
                    return new global::Audius.JsonConverters.GetTracksByUserGateConditionItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTracksByUserGateConditionItem?))
                {
                    return new global::Audius.JsonConverters.GetTracksByUserGateConditionItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTracksCountByUserFilterTracks))
                {
                    return new global::Audius.JsonConverters.GetTracksCountByUserFilterTracksJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTracksCountByUserFilterTracks?))
                {
                    return new global::Audius.JsonConverters.GetTracksCountByUserFilterTracksNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTracksCountByUserGateConditionItem))
                {
                    return new global::Audius.JsonConverters.GetTracksCountByUserGateConditionItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTracksCountByUserGateConditionItem?))
                {
                    return new global::Audius.JsonConverters.GetTracksCountByUserGateConditionItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetCoinsSortMethod))
                {
                    return new global::Audius.JsonConverters.GetCoinsSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetCoinsSortMethod?))
                {
                    return new global::Audius.JsonConverters.GetCoinsSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetCoinsSortDirection))
                {
                    return new global::Audius.JsonConverters.GetCoinsSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetCoinsSortDirection?))
                {
                    return new global::Audius.JsonConverters.GetCoinsSortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetCoinMembersSortDirection))
                {
                    return new global::Audius.JsonConverters.GetCoinMembersSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetCoinMembersSortDirection?))
                {
                    return new global::Audius.JsonConverters.GetCoinMembersSortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetNotificationsType))
                {
                    return new global::Audius.JsonConverters.GetNotificationsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetNotificationsType?))
                {
                    return new global::Audius.JsonConverters.GetNotificationsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTrendingPlaylistsWithVersionTime))
                {
                    return new global::Audius.JsonConverters.GetTrendingPlaylistsWithVersionTimeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetTrendingPlaylistsWithVersionTime?))
                {
                    return new global::Audius.JsonConverters.GetTrendingPlaylistsWithVersionTimeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchAutocompleteKind))
                {
                    return new global::Audius.JsonConverters.SearchAutocompleteKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchAutocompleteKind?))
                {
                    return new global::Audius.JsonConverters.SearchAutocompleteKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchAutocompleteSortMethod))
                {
                    return new global::Audius.JsonConverters.SearchAutocompleteSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchAutocompleteSortMethod?))
                {
                    return new global::Audius.JsonConverters.SearchAutocompleteSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchKind))
                {
                    return new global::Audius.JsonConverters.SearchKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchKind?))
                {
                    return new global::Audius.JsonConverters.SearchKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchSortMethod))
                {
                    return new global::Audius.JsonConverters.SearchSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchSortMethod?))
                {
                    return new global::Audius.JsonConverters.SearchSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchTagsKind))
                {
                    return new global::Audius.JsonConverters.SearchTagsKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchTagsKind?))
                {
                    return new global::Audius.JsonConverters.SearchTagsKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchTagsSortMethod))
                {
                    return new global::Audius.JsonConverters.SearchTagsSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.SearchTagsSortMethod?))
                {
                    return new global::Audius.JsonConverters.SearchTagsSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetBestNewReleasesWindow))
                {
                    return new global::Audius.JsonConverters.GetBestNewReleasesWindowJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetBestNewReleasesWindow?))
                {
                    return new global::Audius.JsonConverters.GetBestNewReleasesWindowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUnderTheRadarTracksFilter))
                {
                    return new global::Audius.JsonConverters.GetUnderTheRadarTracksFilterJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUnderTheRadarTracksFilter?))
                {
                    return new global::Audius.JsonConverters.GetUnderTheRadarTracksFilterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetAudioTransactionHistorySortMethod))
                {
                    return new global::Audius.JsonConverters.GetAudioTransactionHistorySortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetAudioTransactionHistorySortMethod?))
                {
                    return new global::Audius.JsonConverters.GetAudioTransactionHistorySortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetAudioTransactionHistorySortDirection))
                {
                    return new global::Audius.JsonConverters.GetAudioTransactionHistorySortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetAudioTransactionHistorySortDirection?))
                {
                    return new global::Audius.JsonConverters.GetAudioTransactionHistorySortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserFavoriteTracksSortMethod))
                {
                    return new global::Audius.JsonConverters.GetUserFavoriteTracksSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserFavoriteTracksSortMethod?))
                {
                    return new global::Audius.JsonConverters.GetUserFavoriteTracksSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserFavoriteTracksSortDirection))
                {
                    return new global::Audius.JsonConverters.GetUserFavoriteTracksSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserFavoriteTracksSortDirection?))
                {
                    return new global::Audius.JsonConverters.GetUserFavoriteTracksSortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserFeedFilter))
                {
                    return new global::Audius.JsonConverters.GetUserFeedFilterJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserFeedFilter?))
                {
                    return new global::Audius.JsonConverters.GetUserFeedFilterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserLibraryAlbumsSortDirection))
                {
                    return new global::Audius.JsonConverters.GetUserLibraryAlbumsSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserLibraryAlbumsSortDirection?))
                {
                    return new global::Audius.JsonConverters.GetUserLibraryAlbumsSortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserLibraryAlbumsType))
                {
                    return new global::Audius.JsonConverters.GetUserLibraryAlbumsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserLibraryAlbumsType?))
                {
                    return new global::Audius.JsonConverters.GetUserLibraryAlbumsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserLibraryAlbumsSortMethod))
                {
                    return new global::Audius.JsonConverters.GetUserLibraryAlbumsSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserLibraryAlbumsSortMethod?))
                {
                    return new global::Audius.JsonConverters.GetUserLibraryAlbumsSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserLibraryPlaylistsSortDirection))
                {
                    return new global::Audius.JsonConverters.GetUserLibraryPlaylistsSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserLibraryPlaylistsSortDirection?))
                {
                    return new global::Audius.JsonConverters.GetUserLibraryPlaylistsSortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserLibraryPlaylistsType))
                {
                    return new global::Audius.JsonConverters.GetUserLibraryPlaylistsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserLibraryPlaylistsType?))
                {
                    return new global::Audius.JsonConverters.GetUserLibraryPlaylistsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserLibraryPlaylistsSortMethod))
                {
                    return new global::Audius.JsonConverters.GetUserLibraryPlaylistsSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserLibraryPlaylistsSortMethod?))
                {
                    return new global::Audius.JsonConverters.GetUserLibraryPlaylistsSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserLibraryTracksSortMethod))
                {
                    return new global::Audius.JsonConverters.GetUserLibraryTracksSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserLibraryTracksSortMethod?))
                {
                    return new global::Audius.JsonConverters.GetUserLibraryTracksSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserLibraryTracksSortDirection))
                {
                    return new global::Audius.JsonConverters.GetUserLibraryTracksSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserLibraryTracksSortDirection?))
                {
                    return new global::Audius.JsonConverters.GetUserLibraryTracksSortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserLibraryTracksType))
                {
                    return new global::Audius.JsonConverters.GetUserLibraryTracksTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUserLibraryTracksType?))
                {
                    return new global::Audius.JsonConverters.GetUserLibraryTracksTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetPurchasesSortMethod))
                {
                    return new global::Audius.JsonConverters.GetPurchasesSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetPurchasesSortMethod?))
                {
                    return new global::Audius.JsonConverters.GetPurchasesSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetPurchasesSortDirection))
                {
                    return new global::Audius.JsonConverters.GetPurchasesSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetPurchasesSortDirection?))
                {
                    return new global::Audius.JsonConverters.GetPurchasesSortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetSalesSortMethod))
                {
                    return new global::Audius.JsonConverters.GetSalesSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetSalesSortMethod?))
                {
                    return new global::Audius.JsonConverters.GetSalesSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetSalesSortDirection))
                {
                    return new global::Audius.JsonConverters.GetSalesSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetSalesSortDirection?))
                {
                    return new global::Audius.JsonConverters.GetSalesSortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetAudioTransactionsSortMethod))
                {
                    return new global::Audius.JsonConverters.GetAudioTransactionsSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetAudioTransactionsSortMethod?))
                {
                    return new global::Audius.JsonConverters.GetAudioTransactionsSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetAudioTransactionsSortDirection))
                {
                    return new global::Audius.JsonConverters.GetAudioTransactionsSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetAudioTransactionsSortDirection?))
                {
                    return new global::Audius.JsonConverters.GetAudioTransactionsSortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUsdcTransactionsSortMethod))
                {
                    return new global::Audius.JsonConverters.GetUsdcTransactionsSortMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUsdcTransactionsSortMethod?))
                {
                    return new global::Audius.JsonConverters.GetUsdcTransactionsSortMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUsdcTransactionsSortDirection))
                {
                    return new global::Audius.JsonConverters.GetUsdcTransactionsSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUsdcTransactionsSortDirection?))
                {
                    return new global::Audius.JsonConverters.GetUsdcTransactionsSortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUsdcTransactionsTypeItem))
                {
                    return new global::Audius.JsonConverters.GetUsdcTransactionsTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUsdcTransactionsTypeItem?))
                {
                    return new global::Audius.JsonConverters.GetUsdcTransactionsTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUsdcTransactionsMethod))
                {
                    return new global::Audius.JsonConverters.GetUsdcTransactionsMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUsdcTransactionsMethod?))
                {
                    return new global::Audius.JsonConverters.GetUsdcTransactionsMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUsdcTransactionCountTypeItem))
                {
                    return new global::Audius.JsonConverters.GetUsdcTransactionCountTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUsdcTransactionCountTypeItem?))
                {
                    return new global::Audius.JsonConverters.GetUsdcTransactionCountTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUsdcTransactionCountMethod))
                {
                    return new global::Audius.JsonConverters.GetUsdcTransactionCountMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetUsdcTransactionCountMethod?))
                {
                    return new global::Audius.JsonConverters.GetUsdcTransactionCountMethodNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}