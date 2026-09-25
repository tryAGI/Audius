
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
        GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateAccessKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackLibraryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.VersionMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TrackActivity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackActivity), TypeInfoPropertyName = "TrackActivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PurchasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Purchase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Purchase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreatePlaylistRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Genre), TypeInfoPropertyName = "Genre2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Mood), TypeInfoPropertyName = "Mood2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.PlaylistAddedTimestamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistAddedTimestamp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AccessGate), TypeInfoPropertyName = "AccessGate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.DdexResourceContributor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DdexResourceContributor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DdexCopyright))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserTracksRemixedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.RemixedTrackAggregate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixedTrackAggregate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CidDataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DataAndType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DdexRightsController))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ClaimedPrizesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ClaimedPrize>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ClaimedPrize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UndisbursedChallenges))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.UndisbursedChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UndisbursedChallenge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PinCommentRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentEntityType), TypeInfoPropertyName = "CommentEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ClaimRewardsRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.BulkSubscribersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.UserSubscribers>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserSubscribers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackCommentCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Coin))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PurchasersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PrizeClaimRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateRewardCodeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistTracksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Track>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Track))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PrizeClaimResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingPlaylistsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Playlist>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Playlist))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateTrackRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FieldVisibility))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.StemParent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixParentWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CollectiblesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Collectibles))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateCommentRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DashboardWalletUsersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.DashboardWalletUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DashboardWalletUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TipGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FollowGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PurchaseGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TokenGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UpdateTrackRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AuthorizedApps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.AuthorizedApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AuthorizedApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Reposts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Activity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Activity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DeveloperAppsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.DeveloperApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DeveloperApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistArtwork))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Access))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Repost>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Repost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Favorite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Favorite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackCommentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Comment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Comment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Related))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DynamicBondingCurveInsights))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ArtistLocker))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ArtistCoinFees))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RewardPool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackDownloadCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackDownloadCountResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackDownloadCountsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TrackDownloadCountsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackDownloadCountsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserTracksDownloadCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TracksCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.EventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Event>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Event))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixContestsRelated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixContestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.EventFollowState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.EventFollowStateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FollowingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TagsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackActivityVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackActivityVariant2ItemType), TypeInfoPropertyName = "TrackActivityVariant2ItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TopUsersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingIdsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingTimesIds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PurchasesCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.EmailAccessResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.EmailAccess))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AddManagerRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AttestationReponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Attestation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserCoinResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserCoinWithAccounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateCommentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RepostRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinsVolumeLeadersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.CoinsVolumeLeadersResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinsVolumeLeadersResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.WriteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CidData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchAutocompleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackInspect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.BlobInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserIdsAddressesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.UserIdAddress>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserIdAddress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AccessInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackAccessInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserAccountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Account))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.BalanceHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.BalanceHistoryDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.BalanceHistoryDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.StemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Stem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Stem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.HistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UsdcGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.PurchaseSplit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PurchaseSplit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.PlaylistWithoutTracks>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistWithoutTracks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PrizesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.PrizePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PrizePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateCoinResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateCoinResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UnclaimedIdResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TracksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ManagedUsersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ManagedUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ManagedUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Reactions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Reaction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Reaction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PurchasersCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateDeveloperAppResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinMembersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.CoinMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.SearchTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchTrack))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.SearchPlaylist>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchPlaylist))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackInspectList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.BlobInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FavoriteRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackDownloadRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TrackElementWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackElementWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserArtistCoinBadge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoverPhoto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ProfilePicture))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistLibrary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistUpdatesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistUpdates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UpdateUserRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UpdateUserRequestBodyProfileType), TypeInfoPropertyName = "UpdateUserRequestBodyProfileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserPlaylistLibrary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UpdateUserRequestBodyEvents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UpdateCommentRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinInsightsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinInsights))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CollectionLibraryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.CollectionActivityWithoutTracks>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CollectionActivityWithoutTracks), TypeInfoPropertyName = "CollectionActivityWithoutTracks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackFavoritesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetSupporter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Supporter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UpdateCoinRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateRewardCodeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SalesAggregateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.SalesAggregate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SalesAggregate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RelatedArtistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.UserCoinAccount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserCoinAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ManagersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.UserManager>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserManager))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.EventEventType), TypeInfoPropertyName = "EventEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.EventEntityType), TypeInfoPropertyName = "EventEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateUserRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateUserRequestBodyProfileType), TypeInfoPropertyName = "CreateUserRequestBodyProfileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateUserRequestBodyEvents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RegisterApiKeyRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RegisterApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DeactivateAccessKeyRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetSupporting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Supporting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SalesJsonResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SalesJsonContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ReactCommentRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentRepliesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ReplyComment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ReplyComment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TransactionHistoryCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreatePlaylistResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackCommentNotificationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentNotificationSetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.VerifyToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DecodedUserToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixersCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ClaimRewardsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ClaimRewardsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ClaimRewardsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UpdateDeveloperAppRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTipsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Tip>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Tip))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserCoinsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.UserCoin>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserCoin))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateCoinRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FavoritesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixablesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RewardCodeErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RewardCodeErrorResponseError), TypeInfoPropertyName = "RewardCodeErrorResponseError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateGrantRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DeactivateAccessKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserCommentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinMembersCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Grant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AlbumsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ApproveGrantRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserFeedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.UserFeedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserFeedItem), TypeInfoPropertyName = "UserFeedItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackRepostsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TopGenreUsersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.MutualFollowersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RedeemAmountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateDeveloperAppRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Coin>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UpdateCoinResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateTrackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetSupporters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Supporter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RewardCodeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UpdatePlaylistRequestBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Tracks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DeveloperAppResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixesResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackArtwork))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixParent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AlbumBacklink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoverArt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TrackSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UrlWithMirrors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.StreamUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FollowersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetSupportedUsers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Supporting>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.NotificationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Notifications))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ConnectedWalletsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ConnectedWallets))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.BestSellingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.BestSellingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.BestSellingItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackSearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserTrackListenCountsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Audius.MonthlyAggregatePlay>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SubscribersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TransactionHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TransactionDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TransactionDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetChallenges))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ChallengeResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ChallengeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TopListener))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TopListener>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CollectionActivityWithoutTracksVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CollectionActivityWithoutTracksVariant2ItemType), TypeInfoPropertyName = "CollectionActivityWithoutTracksVariant2ItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.CommentMention>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentMention))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedAccessGate), TypeInfoPropertyName = "ExtendedAccessGate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ActivityItemType), TypeInfoPropertyName = "ActivityItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedTokenGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.NftGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.NftCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TrackId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.AccountCollection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AccountCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.BestSellingItemContentType), TypeInfoPropertyName = "BestSellingItemContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackFeedItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistFeedItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserFeedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserFeedItemDiscriminatorType), TypeInfoPropertyName = "UserFeedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.PlaylistUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Remix>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Remix))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedPurchaseGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinInsightsExtensions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CoinInsightsDynamicBondingCurve))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.PaymentSplit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PaymentSplit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.MonthlyAggregatePlay))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.NftCollectionChain), TypeInfoPropertyName = "NftCollectionChain2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.NftCollectionStandard), TypeInfoPropertyName = "NftCollectionStandard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedUsdcGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ExtendedPaymentSplit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedPaymentSplit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.OneOf<global::Audius.PlaylistLibraryFolder, global::Audius.PlaylistLibraryPlaylistIdentifier, global::Audius.PlaylistLibraryExplorePlaylistIdentifier>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.OneOf<global::Audius.PlaylistLibraryFolder, global::Audius.PlaylistLibraryPlaylistIdentifier, global::Audius.PlaylistLibraryExplorePlaylistIdentifier>), TypeInfoPropertyName = "OneOfPlaylistLibraryFolderPlaylistLibraryPlaylistIdentifierPlaylistLibraryExplorePlaylistIdentifier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistLibraryFolder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistLibraryPlaylistIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistLibraryExplorePlaylistIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Notification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Notification), TypeInfoPropertyName = "Notification2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.SaleJson>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SaleJson))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.SupporterReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SupporterReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AccountCollectionUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FollowNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SaveNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RepostNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RepostOfRepostNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SaveOfRepostNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TastemakerNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CosignNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SendTipNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ReceiveTipNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SupporterDethronedNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SupporterRankUpNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ChallengeRewardNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ClaimableRewardNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ReactionNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.MilestoneNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TierChangeNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackAddedToPlaylistNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackAddedToPurchasedAlbumNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UsdcPurchaseSellerNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UsdcPurchaseBuyerNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RequestManagerNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ApproveManagerRequestNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingPlaylistNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingUndergroundNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AnnouncementNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentThreadNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentMentionNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentReactionNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ListenStreakReminderNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestStartedNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestEndedNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestEndingSoonNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ArtistRemixContestEndedNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ArtistRemixContestEndingSoonNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ArtistRemixContestSubmissionsNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestWinnersSelectedNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixContestUpdateNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestSubmissionNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanClubTextPostNotification))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.NotificationDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.NotificationDiscriminatorType), TypeInfoPropertyName = "NotificationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.SaveNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SaveNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistLibraryPlaylistIdentifierType), TypeInfoPropertyName = "PlaylistLibraryPlaylistIdentifierType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.FanRemixContestEndedNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestEndedNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.FanRemixContestWinnersSelectedNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestWinnersSelectedNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.RemixContestUpdateNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixContestUpdateNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.FanRemixContestSubmissionNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestSubmissionNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TierChangeNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TierChangeNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.CosignNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CosignNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.CommentReactionNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentReactionNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ApproveManagerRequestNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ApproveManagerRequestNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestEndedNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ListenCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ListenCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SaveNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.SaveOfRepostNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SaveOfRepostNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ApproveManagerRequestNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.CommentMentionNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentMentionNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistLibraryFolderType), TypeInfoPropertyName = "PlaylistLibraryFolderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistLibraryExplorePlaylistIdentifierType), TypeInfoPropertyName = "PlaylistLibraryExplorePlaylistIdentifierType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.SendTipNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SendTipNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentReactionNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.CommentThreadNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentThreadNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ReactionNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ReactionNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.RemixNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CosignNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.AnnouncementNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AnnouncementNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ListenStreakReminderNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ListenStreakReminderNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentThreadNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestWinnersSelectedNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixContestUpdateNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestSubmissionNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SendTipNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.SupporterDethronedNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SupporterDethronedNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ReactionNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ReceiveTipNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ReceiveTipNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TastemakerNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TastemakerNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TrackAddedToPurchasedAlbumNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackAddedToPurchasedAlbumNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TrackAddedToPlaylistNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackAddedToPlaylistNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ReceiveTipNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TrendingUndergroundNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingUndergroundNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ChallengeRewardNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ChallengeRewardNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.UsdcPurchaseSellerNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UsdcPurchaseSellerNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.SupporterRankUpNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SupporterRankUpNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.FanClubTextPostNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanClubTextPostNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.FanRemixContestStartedNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestStartedNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackAddedToPurchasedAlbumNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.RequestManagerNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RequestManagerNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.CommentNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ClaimableRewardNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ClaimableRewardNotificationAction))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.CreateNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.MilestoneNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.MilestoneNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.FanRemixContestEndingSoonNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestEndingSoonNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TrendingNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TastemakerNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentMentionNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ClaimableRewardNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AnnouncementNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UsdcPurchaseSellerNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RequestManagerNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.RepostOfRepostNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RepostOfRepostNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TrendingPlaylistNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingPlaylistNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.FollowNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FollowNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentThreadNotificationActionDataType), TypeInfoPropertyName = "CommentThreadNotificationActionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateNotificationActionData), TypeInfoPropertyName = "CreateNotificationActionData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingUndergroundNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.RepostNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RepostNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ArtistRemixContestSubmissionsNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ArtistRemixContestSubmissionsNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ArtistRemixContestEndingSoonNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ArtistRemixContestEndingSoonNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.UsdcPurchaseBuyerNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UsdcPurchaseBuyerNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ArtistRemixContestEndedNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ArtistRemixContestEndedNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SaveOfRepostNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SupporterDethronedNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SaveNotificationActionDataType), TypeInfoPropertyName = "SaveNotificationActionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TierChangeNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingUndergroundNotificationActionDataTimeRange), TypeInfoPropertyName = "TrendingUndergroundNotificationActionDataTimeRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ChallengeRewardNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ArtistRemixContestSubmissionsNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreatePlaylistNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateTrackNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ArtistRemixContestEndedNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestEndingSoonNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SaveOfRepostNotificationActionDataType), TypeInfoPropertyName = "SaveOfRepostNotificationActionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ListenStreakReminderNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentReactionNotificationActionDataType), TypeInfoPropertyName = "CommentReactionNotificationActionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RepostNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RepostNotificationActionDataType), TypeInfoPropertyName = "RepostNotificationActionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RepostOfRepostNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingPlaylistNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FollowNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ArtistRemixContestEndingSoonNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentMentionNotificationActionDataType), TypeInfoPropertyName = "CommentMentionNotificationActionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentNotificationActionDataType), TypeInfoPropertyName = "CommentNotificationActionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingNotificationActionDataTimeRange), TypeInfoPropertyName = "TrendingNotificationActionDataTimeRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.MilestoneNotificationActionData), TypeInfoPropertyName = "MilestoneNotificationActionData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SupporterRankUpNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RepostOfRepostNotificationActionDataType), TypeInfoPropertyName = "RepostOfRepostNotificationActionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingPlaylistNotificationActionDataTimeRange), TypeInfoPropertyName = "TrendingPlaylistNotificationActionDataTimeRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UsdcPurchaseBuyerNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackAddedToPlaylistNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanClubTextPostNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FanRemixContestStartedNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserMilestoneNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackMilestoneNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistMilestoneNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserResponseSingle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetBulkEventsEventType), TypeInfoPropertyName = "GetBulkEventsEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAllEventsSortMethod), TypeInfoPropertyName = "GetAllEventsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAllEventsEventType), TypeInfoPropertyName = "GetAllEventsEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetEntityEventsEntityType), TypeInfoPropertyName = "GetEntityEventsEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetRemixContestsStatus), TypeInfoPropertyName = "GetRemixContestsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetEventCommentsSortMethod), TypeInfoPropertyName = "GetEventCommentsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetBestSellingType), TypeInfoPropertyName = "GetBestSellingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchPlaylistsSortMethod), TypeInfoPropertyName = "SearchPlaylistsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetPlaylistsNewReleasesType), TypeInfoPropertyName = "GetPlaylistsNewReleasesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingPlaylistsTime), TypeInfoPropertyName = "GetTrendingPlaylistsTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingPlaylistsType), TypeInfoPropertyName = "GetTrendingPlaylistsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTipsCurrentUserFollows), TypeInfoPropertyName = "GetTipsCurrentUserFollows2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTipsUniqueBy), TypeInfoPropertyName = "GetTipsUniqueBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetRecommendedTracksTime), TypeInfoPropertyName = "GetRecommendedTracksTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetRecommendedTracksWithVersionTime), TypeInfoPropertyName = "GetRecommendedTracksWithVersionTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetMostSharedTracksTimeRange), TypeInfoPropertyName = "GetMostSharedTracksTimeRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingUsdcPurchaseTracksTime), TypeInfoPropertyName = "GetTrendingUsdcPurchaseTracksTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingUsdcPurchaseTracksWithVersionTime), TypeInfoPropertyName = "GetTrendingUsdcPurchaseTracksWithVersionTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchTracksSortMethod), TypeInfoPropertyName = "SearchTracksSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingTracksTime), TypeInfoPropertyName = "GetTrendingTracksTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingTracksWithVersionTime), TypeInfoPropertyName = "GetTrendingTracksWithVersionTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrackCommentsSortMethod), TypeInfoPropertyName = "GetTrackCommentsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrackRemixesSortMethod), TypeInfoPropertyName = "GetTrackRemixesSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserHandleSort), TypeInfoPropertyName = "GetTracksByUserHandleSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserHandleSortMethod), TypeInfoPropertyName = "GetTracksByUserHandleSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserHandleSortDirection), TypeInfoPropertyName = "GetTracksByUserHandleSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserHandleFilterTracks), TypeInfoPropertyName = "GetTracksByUserHandleFilterTracks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAiAttributedTracksByUserHandleSort), TypeInfoPropertyName = "GetAiAttributedTracksByUserHandleSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAiAttributedTracksByUserHandleSortMethod), TypeInfoPropertyName = "GetAiAttributedTracksByUserHandleSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAiAttributedTracksByUserHandleSortDirection), TypeInfoPropertyName = "GetAiAttributedTracksByUserHandleSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAiAttributedTracksByUserHandleFilterTracks), TypeInfoPropertyName = "GetAiAttributedTracksByUserHandleFilterTracks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchUsersSortMethod), TypeInfoPropertyName = "SearchUsersSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAlbumsByUserSortMethod), TypeInfoPropertyName = "GetAlbumsByUserSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetDeveloperAppsInclude), TypeInfoPropertyName = "GetDeveloperAppsInclude2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserBalanceHistoryGranularity), TypeInfoPropertyName = "GetUserBalanceHistoryGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserTrackHistorySortMethod), TypeInfoPropertyName = "GetUserTrackHistorySortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserTrackHistorySortDirection), TypeInfoPropertyName = "GetUserTrackHistorySortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetPlaylistsByUserSortMethod), TypeInfoPropertyName = "GetPlaylistsByUserSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserRecommendedTracksTimeRange), TypeInfoPropertyName = "GetUserRecommendedTracksTimeRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserSort), TypeInfoPropertyName = "GetTracksByUserSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserSortMethod), TypeInfoPropertyName = "GetTracksByUserSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserSortDirection), TypeInfoPropertyName = "GetTracksByUserSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserFilterTracks), TypeInfoPropertyName = "GetTracksByUserFilterTracks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.GetTracksByUserGateConditionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserGateConditionItem), TypeInfoPropertyName = "GetTracksByUserGateConditionItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksCountByUserFilterTracks), TypeInfoPropertyName = "GetTracksCountByUserFilterTracks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.GetTracksCountByUserGateConditionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksCountByUserGateConditionItem), TypeInfoPropertyName = "GetTracksCountByUserGateConditionItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetCoinsSortMethod), TypeInfoPropertyName = "GetCoinsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetCoinsSortDirection), TypeInfoPropertyName = "GetCoinsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetCoinMembersSortDirection), TypeInfoPropertyName = "GetCoinMembersSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.GetNotificationsType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetNotificationsType), TypeInfoPropertyName = "GetNotificationsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingPlaylistsWithVersionTime), TypeInfoPropertyName = "GetTrendingPlaylistsWithVersionTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchAutocompleteKind), TypeInfoPropertyName = "SearchAutocompleteKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchAutocompleteSortMethod), TypeInfoPropertyName = "SearchAutocompleteSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchKind), TypeInfoPropertyName = "SearchKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchSortMethod), TypeInfoPropertyName = "SearchSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchTagsKind), TypeInfoPropertyName = "SearchTagsKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchTagsSortMethod), TypeInfoPropertyName = "SearchTagsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetBestNewReleasesWindow), TypeInfoPropertyName = "GetBestNewReleasesWindow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUnderTheRadarTracksFilter), TypeInfoPropertyName = "GetUnderTheRadarTracksFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAudioTransactionHistorySortMethod), TypeInfoPropertyName = "GetAudioTransactionHistorySortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAudioTransactionHistorySortDirection), TypeInfoPropertyName = "GetAudioTransactionHistorySortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserFavoriteTracksSortMethod), TypeInfoPropertyName = "GetUserFavoriteTracksSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserFavoriteTracksSortDirection), TypeInfoPropertyName = "GetUserFavoriteTracksSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserFeedFilter), TypeInfoPropertyName = "GetUserFeedFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryAlbumsSortDirection), TypeInfoPropertyName = "GetUserLibraryAlbumsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryAlbumsType), TypeInfoPropertyName = "GetUserLibraryAlbumsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryAlbumsSortMethod), TypeInfoPropertyName = "GetUserLibraryAlbumsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryPlaylistsSortDirection), TypeInfoPropertyName = "GetUserLibraryPlaylistsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryPlaylistsType), TypeInfoPropertyName = "GetUserLibraryPlaylistsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryPlaylistsSortMethod), TypeInfoPropertyName = "GetUserLibraryPlaylistsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryTracksSortMethod), TypeInfoPropertyName = "GetUserLibraryTracksSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryTracksSortDirection), TypeInfoPropertyName = "GetUserLibraryTracksSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryTracksType), TypeInfoPropertyName = "GetUserLibraryTracksType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetPurchasesSortMethod), TypeInfoPropertyName = "GetPurchasesSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetPurchasesSortDirection), TypeInfoPropertyName = "GetPurchasesSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetSalesSortMethod), TypeInfoPropertyName = "GetSalesSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetSalesSortDirection), TypeInfoPropertyName = "GetSalesSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAudioTransactionsSortMethod), TypeInfoPropertyName = "GetAudioTransactionsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAudioTransactionsSortDirection), TypeInfoPropertyName = "GetAudioTransactionsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUsdcTransactionsSortMethod), TypeInfoPropertyName = "GetUsdcTransactionsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUsdcTransactionsSortDirection), TypeInfoPropertyName = "GetUsdcTransactionsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.GetUsdcTransactionsTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUsdcTransactionsTypeItem), TypeInfoPropertyName = "GetUsdcTransactionsTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUsdcTransactionsMethod), TypeInfoPropertyName = "GetUsdcTransactionsMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.GetUsdcTransactionCountTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUsdcTransactionCountTypeItem), TypeInfoPropertyName = "GetUsdcTransactionCountTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUsdcTransactionCountMethod), TypeInfoPropertyName = "GetUsdcTransactionCountMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackActivity?), TypeInfoPropertyName = "NullableTrackActivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Genre?), TypeInfoPropertyName = "NullableGenre2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Mood?), TypeInfoPropertyName = "NullableMood2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AccessGate?), TypeInfoPropertyName = "NullableAccessGate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentEntityType?), TypeInfoPropertyName = "NullableCommentEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackActivityVariant2ItemType?), TypeInfoPropertyName = "NullableTrackActivityVariant2ItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UpdateUserRequestBodyProfileType?), TypeInfoPropertyName = "NullableUpdateUserRequestBodyProfileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CollectionActivityWithoutTracks?), TypeInfoPropertyName = "NullableCollectionActivityWithoutTracks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.EventEventType?), TypeInfoPropertyName = "NullableEventEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.EventEntityType?), TypeInfoPropertyName = "NullableEventEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateUserRequestBodyProfileType?), TypeInfoPropertyName = "NullableCreateUserRequestBodyProfileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RewardCodeErrorResponseError?), TypeInfoPropertyName = "NullableRewardCodeErrorResponseError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserFeedItem?), TypeInfoPropertyName = "NullableUserFeedItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CollectionActivityWithoutTracksVariant2ItemType?), TypeInfoPropertyName = "NullableCollectionActivityWithoutTracksVariant2ItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedAccessGate?), TypeInfoPropertyName = "NullableExtendedAccessGate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ActivityItemType?), TypeInfoPropertyName = "NullableActivityItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.BestSellingItemContentType?), TypeInfoPropertyName = "NullableBestSellingItemContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UserFeedItemDiscriminatorType?), TypeInfoPropertyName = "NullableUserFeedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.NftCollectionChain?), TypeInfoPropertyName = "NullableNftCollectionChain2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.NftCollectionStandard?), TypeInfoPropertyName = "NullableNftCollectionStandard2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.OneOf<global::Audius.PlaylistLibraryFolder, global::Audius.PlaylistLibraryPlaylistIdentifier, global::Audius.PlaylistLibraryExplorePlaylistIdentifier>?), TypeInfoPropertyName = "NullableOneOfPlaylistLibraryFolderPlaylistLibraryPlaylistIdentifierPlaylistLibraryExplorePlaylistIdentifier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Notification?), TypeInfoPropertyName = "NullableNotification2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.NotificationDiscriminatorType?), TypeInfoPropertyName = "NullableNotificationDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistLibraryPlaylistIdentifierType?), TypeInfoPropertyName = "NullablePlaylistLibraryPlaylistIdentifierType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistLibraryFolderType?), TypeInfoPropertyName = "NullablePlaylistLibraryFolderType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistLibraryExplorePlaylistIdentifierType?), TypeInfoPropertyName = "NullablePlaylistLibraryExplorePlaylistIdentifierType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentThreadNotificationActionDataType?), TypeInfoPropertyName = "NullableCommentThreadNotificationActionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateNotificationActionData?), TypeInfoPropertyName = "NullableCreateNotificationActionData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SaveNotificationActionDataType?), TypeInfoPropertyName = "NullableSaveNotificationActionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingUndergroundNotificationActionDataTimeRange?), TypeInfoPropertyName = "NullableTrendingUndergroundNotificationActionDataTimeRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SaveOfRepostNotificationActionDataType?), TypeInfoPropertyName = "NullableSaveOfRepostNotificationActionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentReactionNotificationActionDataType?), TypeInfoPropertyName = "NullableCommentReactionNotificationActionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RepostNotificationActionDataType?), TypeInfoPropertyName = "NullableRepostNotificationActionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentMentionNotificationActionDataType?), TypeInfoPropertyName = "NullableCommentMentionNotificationActionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentNotificationActionDataType?), TypeInfoPropertyName = "NullableCommentNotificationActionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingNotificationActionDataTimeRange?), TypeInfoPropertyName = "NullableTrendingNotificationActionDataTimeRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.MilestoneNotificationActionData?), TypeInfoPropertyName = "NullableMilestoneNotificationActionData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RepostOfRepostNotificationActionDataType?), TypeInfoPropertyName = "NullableRepostOfRepostNotificationActionDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingPlaylistNotificationActionDataTimeRange?), TypeInfoPropertyName = "NullableTrendingPlaylistNotificationActionDataTimeRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetBulkEventsEventType?), TypeInfoPropertyName = "NullableGetBulkEventsEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAllEventsSortMethod?), TypeInfoPropertyName = "NullableGetAllEventsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAllEventsEventType?), TypeInfoPropertyName = "NullableGetAllEventsEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetEntityEventsEntityType?), TypeInfoPropertyName = "NullableGetEntityEventsEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetRemixContestsStatus?), TypeInfoPropertyName = "NullableGetRemixContestsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetEventCommentsSortMethod?), TypeInfoPropertyName = "NullableGetEventCommentsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetBestSellingType?), TypeInfoPropertyName = "NullableGetBestSellingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchPlaylistsSortMethod?), TypeInfoPropertyName = "NullableSearchPlaylistsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetPlaylistsNewReleasesType?), TypeInfoPropertyName = "NullableGetPlaylistsNewReleasesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingPlaylistsTime?), TypeInfoPropertyName = "NullableGetTrendingPlaylistsTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingPlaylistsType?), TypeInfoPropertyName = "NullableGetTrendingPlaylistsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTipsCurrentUserFollows?), TypeInfoPropertyName = "NullableGetTipsCurrentUserFollows2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTipsUniqueBy?), TypeInfoPropertyName = "NullableGetTipsUniqueBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetRecommendedTracksTime?), TypeInfoPropertyName = "NullableGetRecommendedTracksTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetRecommendedTracksWithVersionTime?), TypeInfoPropertyName = "NullableGetRecommendedTracksWithVersionTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetMostSharedTracksTimeRange?), TypeInfoPropertyName = "NullableGetMostSharedTracksTimeRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingUsdcPurchaseTracksTime?), TypeInfoPropertyName = "NullableGetTrendingUsdcPurchaseTracksTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingUsdcPurchaseTracksWithVersionTime?), TypeInfoPropertyName = "NullableGetTrendingUsdcPurchaseTracksWithVersionTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchTracksSortMethod?), TypeInfoPropertyName = "NullableSearchTracksSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingTracksTime?), TypeInfoPropertyName = "NullableGetTrendingTracksTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingTracksWithVersionTime?), TypeInfoPropertyName = "NullableGetTrendingTracksWithVersionTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrackCommentsSortMethod?), TypeInfoPropertyName = "NullableGetTrackCommentsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrackRemixesSortMethod?), TypeInfoPropertyName = "NullableGetTrackRemixesSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserHandleSort?), TypeInfoPropertyName = "NullableGetTracksByUserHandleSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserHandleSortMethod?), TypeInfoPropertyName = "NullableGetTracksByUserHandleSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserHandleSortDirection?), TypeInfoPropertyName = "NullableGetTracksByUserHandleSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserHandleFilterTracks?), TypeInfoPropertyName = "NullableGetTracksByUserHandleFilterTracks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAiAttributedTracksByUserHandleSort?), TypeInfoPropertyName = "NullableGetAiAttributedTracksByUserHandleSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAiAttributedTracksByUserHandleSortMethod?), TypeInfoPropertyName = "NullableGetAiAttributedTracksByUserHandleSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAiAttributedTracksByUserHandleSortDirection?), TypeInfoPropertyName = "NullableGetAiAttributedTracksByUserHandleSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAiAttributedTracksByUserHandleFilterTracks?), TypeInfoPropertyName = "NullableGetAiAttributedTracksByUserHandleFilterTracks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchUsersSortMethod?), TypeInfoPropertyName = "NullableSearchUsersSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAlbumsByUserSortMethod?), TypeInfoPropertyName = "NullableGetAlbumsByUserSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetDeveloperAppsInclude?), TypeInfoPropertyName = "NullableGetDeveloperAppsInclude2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserBalanceHistoryGranularity?), TypeInfoPropertyName = "NullableGetUserBalanceHistoryGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserTrackHistorySortMethod?), TypeInfoPropertyName = "NullableGetUserTrackHistorySortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserTrackHistorySortDirection?), TypeInfoPropertyName = "NullableGetUserTrackHistorySortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetPlaylistsByUserSortMethod?), TypeInfoPropertyName = "NullableGetPlaylistsByUserSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserRecommendedTracksTimeRange?), TypeInfoPropertyName = "NullableGetUserRecommendedTracksTimeRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserSort?), TypeInfoPropertyName = "NullableGetTracksByUserSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserSortMethod?), TypeInfoPropertyName = "NullableGetTracksByUserSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserSortDirection?), TypeInfoPropertyName = "NullableGetTracksByUserSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserFilterTracks?), TypeInfoPropertyName = "NullableGetTracksByUserFilterTracks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksByUserGateConditionItem?), TypeInfoPropertyName = "NullableGetTracksByUserGateConditionItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksCountByUserFilterTracks?), TypeInfoPropertyName = "NullableGetTracksCountByUserFilterTracks2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTracksCountByUserGateConditionItem?), TypeInfoPropertyName = "NullableGetTracksCountByUserGateConditionItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetCoinsSortMethod?), TypeInfoPropertyName = "NullableGetCoinsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetCoinsSortDirection?), TypeInfoPropertyName = "NullableGetCoinsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetCoinMembersSortDirection?), TypeInfoPropertyName = "NullableGetCoinMembersSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetNotificationsType?), TypeInfoPropertyName = "NullableGetNotificationsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetTrendingPlaylistsWithVersionTime?), TypeInfoPropertyName = "NullableGetTrendingPlaylistsWithVersionTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchAutocompleteKind?), TypeInfoPropertyName = "NullableSearchAutocompleteKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchAutocompleteSortMethod?), TypeInfoPropertyName = "NullableSearchAutocompleteSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchKind?), TypeInfoPropertyName = "NullableSearchKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchSortMethod?), TypeInfoPropertyName = "NullableSearchSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchTagsKind?), TypeInfoPropertyName = "NullableSearchTagsKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SearchTagsSortMethod?), TypeInfoPropertyName = "NullableSearchTagsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetBestNewReleasesWindow?), TypeInfoPropertyName = "NullableGetBestNewReleasesWindow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUnderTheRadarTracksFilter?), TypeInfoPropertyName = "NullableGetUnderTheRadarTracksFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAudioTransactionHistorySortMethod?), TypeInfoPropertyName = "NullableGetAudioTransactionHistorySortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAudioTransactionHistorySortDirection?), TypeInfoPropertyName = "NullableGetAudioTransactionHistorySortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserFavoriteTracksSortMethod?), TypeInfoPropertyName = "NullableGetUserFavoriteTracksSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserFavoriteTracksSortDirection?), TypeInfoPropertyName = "NullableGetUserFavoriteTracksSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserFeedFilter?), TypeInfoPropertyName = "NullableGetUserFeedFilter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryAlbumsSortDirection?), TypeInfoPropertyName = "NullableGetUserLibraryAlbumsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryAlbumsType?), TypeInfoPropertyName = "NullableGetUserLibraryAlbumsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryAlbumsSortMethod?), TypeInfoPropertyName = "NullableGetUserLibraryAlbumsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryPlaylistsSortDirection?), TypeInfoPropertyName = "NullableGetUserLibraryPlaylistsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryPlaylistsType?), TypeInfoPropertyName = "NullableGetUserLibraryPlaylistsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryPlaylistsSortMethod?), TypeInfoPropertyName = "NullableGetUserLibraryPlaylistsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryTracksSortMethod?), TypeInfoPropertyName = "NullableGetUserLibraryTracksSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryTracksSortDirection?), TypeInfoPropertyName = "NullableGetUserLibraryTracksSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUserLibraryTracksType?), TypeInfoPropertyName = "NullableGetUserLibraryTracksType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetPurchasesSortMethod?), TypeInfoPropertyName = "NullableGetPurchasesSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetPurchasesSortDirection?), TypeInfoPropertyName = "NullableGetPurchasesSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetSalesSortMethod?), TypeInfoPropertyName = "NullableGetSalesSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetSalesSortDirection?), TypeInfoPropertyName = "NullableGetSalesSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAudioTransactionsSortMethod?), TypeInfoPropertyName = "NullableGetAudioTransactionsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetAudioTransactionsSortDirection?), TypeInfoPropertyName = "NullableGetAudioTransactionsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUsdcTransactionsSortMethod?), TypeInfoPropertyName = "NullableGetUsdcTransactionsSortMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUsdcTransactionsSortDirection?), TypeInfoPropertyName = "NullableGetUsdcTransactionsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUsdcTransactionsTypeItem?), TypeInfoPropertyName = "NullableGetUsdcTransactionsTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUsdcTransactionsMethod?), TypeInfoPropertyName = "NullableGetUsdcTransactionsMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUsdcTransactionCountTypeItem?), TypeInfoPropertyName = "NullableGetUsdcTransactionCountTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUsdcTransactionCountMethod?), TypeInfoPropertyName = "NullableGetUsdcTransactionCountMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrackActivity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Purchase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.PlaylistAddedTimestamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.DdexResourceContributor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.RemixedTrackAggregate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ClaimedPrize>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.UndisbursedChallenge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.UserSubscribers>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Track>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Playlist>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.DashboardWalletUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.AuthorizedApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Activity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.DeveloperApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Repost>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Favorite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Comment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrackDownloadCountsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Event>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CoinsVolumeLeadersResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.UserIdAddress>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.BalanceHistoryDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Stem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.PurchaseSplit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.PlaylistWithoutTracks>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.PrizePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ManagedUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Reaction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CoinMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.SearchTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.SearchPlaylist>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.BlobInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrackElementWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CollectionActivityWithoutTracks>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.SalesAggregate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.UserCoinAccount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.UserManager>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ReplyComment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ClaimRewardsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Tip>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.UserCoin>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.UserFeedItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Coin>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Supporter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrackSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Supporting>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.BestSellingItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TransactionDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ChallengeResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TopListener>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CommentMention>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrackId>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.AccountCollection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.PlaylistUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Remix>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.PaymentSplit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ExtendedPaymentSplit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.OneOf<global::Audius.PlaylistLibraryFolder, global::Audius.PlaylistLibraryPlaylistIdentifier, global::Audius.PlaylistLibraryExplorePlaylistIdentifier>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Notification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.SaleJson>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.SupporterReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.SaveNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.FanRemixContestEndedNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.FanRemixContestWinnersSelectedNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.RemixContestUpdateNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.FanRemixContestSubmissionNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TierChangeNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CosignNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CommentReactionNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ApproveManagerRequestNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ListenCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.SaveOfRepostNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CommentMentionNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.SendTipNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CommentThreadNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ReactionNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.RemixNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.AnnouncementNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ListenStreakReminderNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.SupporterDethronedNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ReceiveTipNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TastemakerNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrackAddedToPurchasedAlbumNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrackAddedToPlaylistNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrendingUndergroundNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ChallengeRewardNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.UsdcPurchaseSellerNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.SupporterRankUpNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.FanClubTextPostNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.FanRemixContestStartedNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.RequestManagerNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CommentNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ClaimableRewardNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CreateNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.MilestoneNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.FanRemixContestEndingSoonNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrendingNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.RepostOfRepostNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrendingPlaylistNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.FollowNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.RepostNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ArtistRemixContestSubmissionsNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ArtistRemixContestEndingSoonNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.UsdcPurchaseBuyerNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ArtistRemixContestEndedNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.GetTracksByUserGateConditionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.GetTracksCountByUserGateConditionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.GetNotificationsType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.GetUsdcTransactionsTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.GetUsdcTransactionCountTypeItem>))]
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

         static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
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
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

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