
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.VersionMetadata), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.DdexRightsController))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentEntityType), TypeInfoPropertyName = "CommentEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackCommentCountResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.User>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.User), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Track>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Track), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Playlist>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Playlist), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateTrackRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FieldVisibility))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.StemParent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixParentWrite), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TipGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.FollowGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PurchaseGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TokenGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UpdateTrackRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackDownloadCountResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackDownloadCountResponseData), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackDownloadCountsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TrackDownloadCountsResponseDataItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackDownloadCountsResponseDataItem), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingIdsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrendingTimesIds), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RepostRequestBody), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.WriteResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackInspect), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.BlobInfo), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AccessInfoResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackAccessInfo), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.StemsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Stem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Stem), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.UsdcGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TracksResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackFavoritesResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ReplyComment>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ReplyComment), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackCommentNotificationResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentNotificationSetting), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixablesResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.RemixingResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackRepostsResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CreateTrackResponse), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackSearch), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TopListener), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TopListener>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.CommentMention>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentMention), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedAccessGate), TypeInfoPropertyName = "ExtendedAccessGate2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedTokenGate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.TrackId>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.TrackId), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Remix>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Remix), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedPurchaseGate), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.PaymentSplit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PaymentSplit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedUsdcGate), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.ExtendedPaymentSplit>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedPaymentSplit), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetBestNewReleasesWindow), TypeInfoPropertyName = "GetBestNewReleasesWindow2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUnderTheRadarTracksFilter), TypeInfoPropertyName = "GetUnderTheRadarTracksFilter2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Genre?), TypeInfoPropertyName = "NullableGenre2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Mood?), TypeInfoPropertyName = "NullableMood2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.AccessGate?), TypeInfoPropertyName = "NullableAccessGate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentEntityType?), TypeInfoPropertyName = "NullableCommentEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ExtendedAccessGate?), TypeInfoPropertyName = "NullableExtendedAccessGate2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetBestNewReleasesWindow?), TypeInfoPropertyName = "NullableGetBestNewReleasesWindow2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetUnderTheRadarTracksFilter?), TypeInfoPropertyName = "NullableGetUnderTheRadarTracksFilter2", GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.PlaylistAddedTimestamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.DdexResourceContributor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.User>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Track>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Playlist>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Repost>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Favorite>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Comment>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrackDownloadCountsResponseDataItem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Stem>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.BlobInfo>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrackElementWrite>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ReplyComment>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrackSegment>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TopListener>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CommentMention>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TrackId>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Remix>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.PaymentSplit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ExtendedPaymentSplit>), GenerationMode = global::System.Text.Json.Serialization.JsonSourceGenerationMode.Metadata)]
    internal sealed partial class TracksSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TracksSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TracksSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TracksSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Audius.JsonConverters.AccessGateJsonConverter());
            options.Converters.Add(new global::Audius.JsonConverters.ExtendedAccessGateJsonConverter());
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
                    typeToConvert == typeof(global::Audius.Genre)

                    || typeToConvert == typeof(global::Audius.Genre?)

                    || typeToConvert == typeof(global::Audius.Mood)

                    || typeToConvert == typeof(global::Audius.Mood?)

                    || typeToConvert == typeof(global::Audius.CommentEntityType)

                    || typeToConvert == typeof(global::Audius.CommentEntityType?)

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

                    || typeToConvert == typeof(global::Audius.GetBestNewReleasesWindow)

                    || typeToConvert == typeof(global::Audius.GetBestNewReleasesWindow?)

                    || typeToConvert == typeof(global::Audius.GetUnderTheRadarTracksFilter)

                    || typeToConvert == typeof(global::Audius.GetUnderTheRadarTracksFilter?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

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
                    0 => new TracksSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}