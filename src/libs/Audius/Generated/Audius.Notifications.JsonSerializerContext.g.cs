
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.VersionMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistUpdatesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistUpdates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.NotificationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Notifications))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.PlaylistUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.PlaylistUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.Notification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Notification), TypeInfoPropertyName = "Notification2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SaveNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.SaveOfRepostNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.SaveOfRepostNotificationAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.ApproveManagerRequestNotificationActionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.CommentMentionNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.CommentMentionNotificationAction))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Audius.GetNotificationsType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetNotificationsType), TypeInfoPropertyName = "GetNotificationsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.Notification?), TypeInfoPropertyName = "NullableNotification2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.NotificationDiscriminatorType?), TypeInfoPropertyName = "NullableNotificationDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Audius.GetNotificationsType?), TypeInfoPropertyName = "NullableGetNotificationsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.PlaylistUpdate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.Notification>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.SaveNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.FanRemixContestEndedNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.FanRemixContestWinnersSelectedNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.RemixContestUpdateNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.FanRemixContestSubmissionNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.TierChangeNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CosignNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.CommentReactionNotificationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.ApproveManagerRequestNotificationAction>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Audius.GetNotificationsType>))]
    internal sealed partial class NotificationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NotificationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static NotificationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private NotificationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Audius.JsonConverters.NotificationJsonConverter());
            options.Converters.Add(new global::Audius.JsonConverters.CreateNotificationActionDataJsonConverter());
            options.Converters.Add(new global::Audius.JsonConverters.MilestoneNotificationActionDataJsonConverter());
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
                    typeToConvert == typeof(global::Audius.NotificationDiscriminatorType)

                    || typeToConvert == typeof(global::Audius.NotificationDiscriminatorType?)

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

                    || typeToConvert == typeof(global::Audius.GetNotificationsType)

                    || typeToConvert == typeof(global::Audius.GetNotificationsType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Audius.NotificationDiscriminatorType))
                {
                    return new global::Audius.JsonConverters.NotificationDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.NotificationDiscriminatorType?))
                {
                    return new global::Audius.JsonConverters.NotificationDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Audius.GetNotificationsType))
                {
                    return new global::Audius.JsonConverters.GetNotificationsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Audius.GetNotificationsType?))
                {
                    return new global::Audius.JsonConverters.GetNotificationsTypeNullableJsonConverter();
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
                    0 => new NotificationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}