#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Audius.JsonConverters
{
    /// <inheritdoc />
    public class NotificationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Audius.Notification>
    {
        /// <inheritdoc />
        public override global::Audius.Notification Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.NotificationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.NotificationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.NotificationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Audius.FollowNotification? follow = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.Follow)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FollowNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FollowNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.FollowNotification)}");
                follow = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.SaveNotification? save = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.Save)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SaveNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SaveNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.SaveNotification)}");
                save = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.RepostNotification? repost = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.Repost)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RepostNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RepostNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.RepostNotification)}");
                repost = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.RepostOfRepostNotification? repostOfRepost = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.RepostOfRepost)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RepostOfRepostNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RepostOfRepostNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.RepostOfRepostNotification)}");
                repostOfRepost = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.SaveOfRepostNotification? saveOfRepost = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.SaveOfRepost)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SaveOfRepostNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SaveOfRepostNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.SaveOfRepostNotification)}");
                saveOfRepost = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.TastemakerNotification? tastemaker = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.Tastemaker)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TastemakerNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TastemakerNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.TastemakerNotification)}");
                tastemaker = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.RemixNotification? remix = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.Remix)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RemixNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RemixNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.RemixNotification)}");
                remix = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.CosignNotification? cosign = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.Cosign)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CosignNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CosignNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.CosignNotification)}");
                cosign = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.CreateNotification? create = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.Create)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CreateNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CreateNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.CreateNotification)}");
                create = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.SendTipNotification? tipSend = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.TipSend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SendTipNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SendTipNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.SendTipNotification)}");
                tipSend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.ReceiveTipNotification? tipReceive = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.TipReceive)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ReceiveTipNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ReceiveTipNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.ReceiveTipNotification)}");
                tipReceive = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.SupporterDethronedNotification? supporterDethroned = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.SupporterDethroned)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SupporterDethronedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SupporterDethronedNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.SupporterDethronedNotification)}");
                supporterDethroned = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.SupporterRankUpNotification? supporterRankUp1 = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.SupporterRankUp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SupporterRankUpNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SupporterRankUpNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.SupporterRankUpNotification)}");
                supporterRankUp1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.SupporterRankUpNotification? supporterRankUp2 = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.SupporterRankUp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SupporterRankUpNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SupporterRankUpNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.SupporterRankUpNotification)}");
                supporterRankUp2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.ChallengeRewardNotification? challengeReward = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.ChallengeReward)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ChallengeRewardNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ChallengeRewardNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.ChallengeRewardNotification)}");
                challengeReward = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.ClaimableRewardNotification? claimableReward = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.ClaimableReward)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ClaimableRewardNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ClaimableRewardNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.ClaimableRewardNotification)}");
                claimableReward = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.ReactionNotification? reaction = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.Reaction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ReactionNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ReactionNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.ReactionNotification)}");
                reaction = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.MilestoneNotification? milestone = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.Milestone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.MilestoneNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.MilestoneNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.MilestoneNotification)}");
                milestone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.TierChangeNotification? tierChange = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.TierChange)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TierChangeNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TierChangeNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.TierChangeNotification)}");
                tierChange = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.TrackAddedToPlaylistNotification? trackAddedToPlaylist = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.TrackAddedToPlaylist)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrackAddedToPlaylistNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrackAddedToPlaylistNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.TrackAddedToPlaylistNotification)}");
                trackAddedToPlaylist = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.TrackAddedToPurchasedAlbumNotification? trackAddedToPurchasedAlbum = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.TrackAddedToPurchasedAlbum)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrackAddedToPurchasedAlbumNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrackAddedToPurchasedAlbumNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.TrackAddedToPurchasedAlbumNotification)}");
                trackAddedToPurchasedAlbum = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.UsdcPurchaseSellerNotification? usdcPurchaseSeller = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.UsdcPurchaseSeller)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.UsdcPurchaseSellerNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.UsdcPurchaseSellerNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.UsdcPurchaseSellerNotification)}");
                usdcPurchaseSeller = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.UsdcPurchaseBuyerNotification? usdcPurchaseBuyer = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.UsdcPurchaseBuyer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.UsdcPurchaseBuyerNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.UsdcPurchaseBuyerNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.UsdcPurchaseBuyerNotification)}");
                usdcPurchaseBuyer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.RequestManagerNotification? requestManager = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.RequestManager)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RequestManagerNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RequestManagerNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.RequestManagerNotification)}");
                requestManager = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.ApproveManagerRequestNotification? approveManagerRequest = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.ApproveManagerRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ApproveManagerRequestNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ApproveManagerRequestNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.ApproveManagerRequestNotification)}");
                approveManagerRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.TrendingNotification? trending = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.Trending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrendingNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrendingNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.TrendingNotification)}");
                trending = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.TrendingPlaylistNotification? trendingPlaylist = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.TrendingPlaylist)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrendingPlaylistNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrendingPlaylistNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.TrendingPlaylistNotification)}");
                trendingPlaylist = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.TrendingUndergroundNotification? trendingUnderground = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.TrendingUnderground)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrendingUndergroundNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrendingUndergroundNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.TrendingUndergroundNotification)}");
                trendingUnderground = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.AnnouncementNotification? announcement = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.Announcement)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.AnnouncementNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.AnnouncementNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.AnnouncementNotification)}");
                announcement = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.CommentNotification? comment = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.Comment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CommentNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CommentNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.CommentNotification)}");
                comment = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.CommentThreadNotification? commentThread = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.CommentThread)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CommentThreadNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CommentThreadNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.CommentThreadNotification)}");
                commentThread = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.CommentMentionNotification? commentMention = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.CommentMention)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CommentMentionNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CommentMentionNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.CommentMentionNotification)}");
                commentMention = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.CommentReactionNotification? commentReaction = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.CommentReaction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CommentReactionNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CommentReactionNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.CommentReactionNotification)}");
                commentReaction = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.ListenStreakReminderNotification? listenStreakReminder = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.ListenStreakReminder)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ListenStreakReminderNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ListenStreakReminderNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.ListenStreakReminderNotification)}");
                listenStreakReminder = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.FanRemixContestStartedNotification? fanRemixContestStarted = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.FanRemixContestStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestStartedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestStartedNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.FanRemixContestStartedNotification)}");
                fanRemixContestStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.FanRemixContestEndedNotification? fanRemixContestEnded = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.FanRemixContestEnded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestEndedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestEndedNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.FanRemixContestEndedNotification)}");
                fanRemixContestEnded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.FanRemixContestEndingSoonNotification? fanRemixContestEndingSoon = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.FanRemixContestEndingSoon)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestEndingSoonNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestEndingSoonNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.FanRemixContestEndingSoonNotification)}");
                fanRemixContestEndingSoon = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.ArtistRemixContestEndedNotification? artistRemixContestEnded = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.ArtistRemixContestEnded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ArtistRemixContestEndedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ArtistRemixContestEndedNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.ArtistRemixContestEndedNotification)}");
                artistRemixContestEnded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.ArtistRemixContestEndingSoonNotification? artistRemixContestEndingSoon = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.ArtistRemixContestEndingSoon)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ArtistRemixContestEndingSoonNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ArtistRemixContestEndingSoonNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.ArtistRemixContestEndingSoonNotification)}");
                artistRemixContestEndingSoon = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.ArtistRemixContestSubmissionsNotification? artistRemixContestSubmissions = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.ArtistRemixContestSubmissions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ArtistRemixContestSubmissionsNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ArtistRemixContestSubmissionsNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.ArtistRemixContestSubmissionsNotification)}");
                artistRemixContestSubmissions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.FanRemixContestWinnersSelectedNotification? fanRemixContestWinnersSelected = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.FanRemixContestWinnersSelected)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestWinnersSelectedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestWinnersSelectedNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.FanRemixContestWinnersSelectedNotification)}");
                fanRemixContestWinnersSelected = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.RemixContestUpdateNotification? remixContestUpdate = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.RemixContestUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RemixContestUpdateNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RemixContestUpdateNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.RemixContestUpdateNotification)}");
                remixContestUpdate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.FanRemixContestSubmissionNotification? fanRemixContestSubmission = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.FanRemixContestSubmission)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestSubmissionNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestSubmissionNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.FanRemixContestSubmissionNotification)}");
                fanRemixContestSubmission = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.FanClubTextPostNotification? fanClubTextPost = default;
            if (discriminator?.Type == global::Audius.NotificationDiscriminatorType.FanClubTextPost)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanClubTextPostNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanClubTextPostNotification> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.FanClubTextPostNotification)}");
                fanClubTextPost = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Audius.Notification(
                discriminator?.Type,
                follow,

                save,

                repost,

                repostOfRepost,

                saveOfRepost,

                tastemaker,

                remix,

                cosign,

                create,

                tipSend,

                tipReceive,

                supporterDethroned,

                supporterRankUp1,

                supporterRankUp2,

                challengeReward,

                claimableReward,

                reaction,

                milestone,

                tierChange,

                trackAddedToPlaylist,

                trackAddedToPurchasedAlbum,

                usdcPurchaseSeller,

                usdcPurchaseBuyer,

                requestManager,

                approveManagerRequest,

                trending,

                trendingPlaylist,

                trendingUnderground,

                announcement,

                comment,

                commentThread,

                commentMention,

                commentReaction,

                listenStreakReminder,

                fanRemixContestStarted,

                fanRemixContestEnded,

                fanRemixContestEndingSoon,

                artistRemixContestEnded,

                artistRemixContestEndingSoon,

                artistRemixContestSubmissions,

                fanRemixContestWinnersSelected,

                remixContestUpdate,

                fanRemixContestSubmission,

                fanClubTextPost
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Audius.Notification value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFollow)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FollowNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FollowNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FollowNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFollow(), typeInfo);
            }
            else if (value.IsSave)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SaveNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SaveNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.SaveNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSave(), typeInfo);
            }
            else if (value.IsRepost)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RepostNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RepostNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.RepostNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRepost(), typeInfo);
            }
            else if (value.IsRepostOfRepost)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RepostOfRepostNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RepostOfRepostNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.RepostOfRepostNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRepostOfRepost(), typeInfo);
            }
            else if (value.IsSaveOfRepost)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SaveOfRepostNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SaveOfRepostNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.SaveOfRepostNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSaveOfRepost(), typeInfo);
            }
            else if (value.IsTastemaker)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TastemakerNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TastemakerNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TastemakerNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTastemaker(), typeInfo);
            }
            else if (value.IsRemix)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RemixNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RemixNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.RemixNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRemix(), typeInfo);
            }
            else if (value.IsCosign)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CosignNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CosignNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.CosignNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCosign(), typeInfo);
            }
            else if (value.IsCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CreateNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CreateNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.CreateNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCreate(), typeInfo);
            }
            else if (value.IsTipSend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SendTipNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SendTipNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.SendTipNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTipSend(), typeInfo);
            }
            else if (value.IsTipReceive)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ReceiveTipNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ReceiveTipNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ReceiveTipNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTipReceive(), typeInfo);
            }
            else if (value.IsSupporterDethroned)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SupporterDethronedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SupporterDethronedNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.SupporterDethronedNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSupporterDethroned(), typeInfo);
            }
            else if (value.IsSupporterRankUp1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SupporterRankUpNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SupporterRankUpNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.SupporterRankUpNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSupporterRankUp1(), typeInfo);
            }
            else if (value.IsSupporterRankUp2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SupporterRankUpNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SupporterRankUpNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.SupporterRankUpNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSupporterRankUp2(), typeInfo);
            }
            else if (value.IsChallengeReward)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ChallengeRewardNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ChallengeRewardNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ChallengeRewardNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickChallengeReward(), typeInfo);
            }
            else if (value.IsClaimableReward)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ClaimableRewardNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ClaimableRewardNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ClaimableRewardNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickClaimableReward(), typeInfo);
            }
            else if (value.IsReaction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ReactionNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ReactionNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ReactionNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickReaction(), typeInfo);
            }
            else if (value.IsMilestone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.MilestoneNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.MilestoneNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.MilestoneNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMilestone(), typeInfo);
            }
            else if (value.IsTierChange)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TierChangeNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TierChangeNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TierChangeNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTierChange(), typeInfo);
            }
            else if (value.IsTrackAddedToPlaylist)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrackAddedToPlaylistNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrackAddedToPlaylistNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TrackAddedToPlaylistNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTrackAddedToPlaylist(), typeInfo);
            }
            else if (value.IsTrackAddedToPurchasedAlbum)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrackAddedToPurchasedAlbumNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrackAddedToPurchasedAlbumNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TrackAddedToPurchasedAlbumNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTrackAddedToPurchasedAlbum(), typeInfo);
            }
            else if (value.IsUsdcPurchaseSeller)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.UsdcPurchaseSellerNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.UsdcPurchaseSellerNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.UsdcPurchaseSellerNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUsdcPurchaseSeller(), typeInfo);
            }
            else if (value.IsUsdcPurchaseBuyer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.UsdcPurchaseBuyerNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.UsdcPurchaseBuyerNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.UsdcPurchaseBuyerNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUsdcPurchaseBuyer(), typeInfo);
            }
            else if (value.IsRequestManager)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RequestManagerNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RequestManagerNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.RequestManagerNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRequestManager(), typeInfo);
            }
            else if (value.IsApproveManagerRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ApproveManagerRequestNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ApproveManagerRequestNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ApproveManagerRequestNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickApproveManagerRequest(), typeInfo);
            }
            else if (value.IsTrending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrendingNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrendingNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TrendingNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTrending(), typeInfo);
            }
            else if (value.IsTrendingPlaylist)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrendingPlaylistNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrendingPlaylistNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TrendingPlaylistNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTrendingPlaylist(), typeInfo);
            }
            else if (value.IsTrendingUnderground)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrendingUndergroundNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrendingUndergroundNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TrendingUndergroundNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTrendingUnderground(), typeInfo);
            }
            else if (value.IsAnnouncement)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.AnnouncementNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.AnnouncementNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.AnnouncementNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAnnouncement(), typeInfo);
            }
            else if (value.IsComment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CommentNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CommentNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.CommentNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComment(), typeInfo);
            }
            else if (value.IsCommentThread)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CommentThreadNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CommentThreadNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.CommentThreadNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCommentThread(), typeInfo);
            }
            else if (value.IsCommentMention)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CommentMentionNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CommentMentionNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.CommentMentionNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCommentMention(), typeInfo);
            }
            else if (value.IsCommentReaction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CommentReactionNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CommentReactionNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.CommentReactionNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCommentReaction(), typeInfo);
            }
            else if (value.IsListenStreakReminder)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ListenStreakReminderNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ListenStreakReminderNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ListenStreakReminderNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickListenStreakReminder(), typeInfo);
            }
            else if (value.IsFanRemixContestStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestStartedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestStartedNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FanRemixContestStartedNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFanRemixContestStarted(), typeInfo);
            }
            else if (value.IsFanRemixContestEnded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestEndedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestEndedNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FanRemixContestEndedNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFanRemixContestEnded(), typeInfo);
            }
            else if (value.IsFanRemixContestEndingSoon)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestEndingSoonNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestEndingSoonNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FanRemixContestEndingSoonNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFanRemixContestEndingSoon(), typeInfo);
            }
            else if (value.IsArtistRemixContestEnded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ArtistRemixContestEndedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ArtistRemixContestEndedNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ArtistRemixContestEndedNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickArtistRemixContestEnded(), typeInfo);
            }
            else if (value.IsArtistRemixContestEndingSoon)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ArtistRemixContestEndingSoonNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ArtistRemixContestEndingSoonNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ArtistRemixContestEndingSoonNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickArtistRemixContestEndingSoon(), typeInfo);
            }
            else if (value.IsArtistRemixContestSubmissions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ArtistRemixContestSubmissionsNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ArtistRemixContestSubmissionsNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ArtistRemixContestSubmissionsNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickArtistRemixContestSubmissions(), typeInfo);
            }
            else if (value.IsFanRemixContestWinnersSelected)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestWinnersSelectedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestWinnersSelectedNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FanRemixContestWinnersSelectedNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFanRemixContestWinnersSelected(), typeInfo);
            }
            else if (value.IsRemixContestUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RemixContestUpdateNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RemixContestUpdateNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.RemixContestUpdateNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRemixContestUpdate(), typeInfo);
            }
            else if (value.IsFanRemixContestSubmission)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestSubmissionNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestSubmissionNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FanRemixContestSubmissionNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFanRemixContestSubmission(), typeInfo);
            }
            else if (value.IsFanClubTextPost)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanClubTextPostNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanClubTextPostNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FanClubTextPostNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFanClubTextPost(), typeInfo);
            }
        }
    }
}