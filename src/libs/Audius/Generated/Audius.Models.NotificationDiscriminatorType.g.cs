
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum NotificationDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Announcement,
        /// <summary>
        ///
        /// </summary>
        ApproveManagerRequest,
        /// <summary>
        ///
        /// </summary>
        ArtistRemixContestEnded,
        /// <summary>
        ///
        /// </summary>
        ArtistRemixContestEndingSoon,
        /// <summary>
        ///
        /// </summary>
        ArtistRemixContestSubmissions,
        /// <summary>
        ///
        /// </summary>
        ChallengeReward,
        /// <summary>
        ///
        /// </summary>
        ClaimableReward,
        /// <summary>
        ///
        /// </summary>
        Comment,
        /// <summary>
        ///
        /// </summary>
        CommentMention,
        /// <summary>
        ///
        /// </summary>
        CommentReaction,
        /// <summary>
        ///
        /// </summary>
        CommentThread,
        /// <summary>
        ///
        /// </summary>
        Cosign,
        /// <summary>
        ///
        /// </summary>
        Create,
        /// <summary>
        ///
        /// </summary>
        FanClubTextPost,
        /// <summary>
        ///
        /// </summary>
        FanRemixContestEnded,
        /// <summary>
        ///
        /// </summary>
        FanRemixContestEndingSoon,
        /// <summary>
        ///
        /// </summary>
        FanRemixContestStarted,
        /// <summary>
        ///
        /// </summary>
        FanRemixContestSubmission,
        /// <summary>
        ///
        /// </summary>
        FanRemixContestWinnersSelected,
        /// <summary>
        ///
        /// </summary>
        Follow,
        /// <summary>
        ///
        /// </summary>
        ListenStreakReminder,
        /// <summary>
        ///
        /// </summary>
        Milestone,
        /// <summary>
        ///
        /// </summary>
        Reaction,
        /// <summary>
        ///
        /// </summary>
        Remix,
        /// <summary>
        ///
        /// </summary>
        RemixContestUpdate,
        /// <summary>
        ///
        /// </summary>
        Repost,
        /// <summary>
        ///
        /// </summary>
        RepostOfRepost,
        /// <summary>
        ///
        /// </summary>
        RequestManager,
        /// <summary>
        ///
        /// </summary>
        Save,
        /// <summary>
        ///
        /// </summary>
        SaveOfRepost,
        /// <summary>
        ///
        /// </summary>
        SupporterDethroned,
        /// <summary>
        ///
        /// </summary>
        SupporterRankUp,
        /// <summary>
        ///
        /// </summary>
        SupportingRankUp,
        /// <summary>
        ///
        /// </summary>
        Tastemaker,
        /// <summary>
        ///
        /// </summary>
        TierChange,
        /// <summary>
        ///
        /// </summary>
        TipReceive,
        /// <summary>
        ///
        /// </summary>
        TipSend,
        /// <summary>
        ///
        /// </summary>
        TrackAddedToPlaylist,
        /// <summary>
        ///
        /// </summary>
        TrackAddedToPurchasedAlbum,
        /// <summary>
        ///
        /// </summary>
        Trending,
        /// <summary>
        ///
        /// </summary>
        TrendingPlaylist,
        /// <summary>
        ///
        /// </summary>
        TrendingUnderground,
        /// <summary>
        ///
        /// </summary>
        UsdcPurchaseBuyer,
        /// <summary>
        ///
        /// </summary>
        UsdcPurchaseSeller,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NotificationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NotificationDiscriminatorType value)
        {
            return value switch
            {
                NotificationDiscriminatorType.Announcement => "announcement",
                NotificationDiscriminatorType.ApproveManagerRequest => "approve_manager_request",
                NotificationDiscriminatorType.ArtistRemixContestEnded => "artist_remix_contest_ended",
                NotificationDiscriminatorType.ArtistRemixContestEndingSoon => "artist_remix_contest_ending_soon",
                NotificationDiscriminatorType.ArtistRemixContestSubmissions => "artist_remix_contest_submissions",
                NotificationDiscriminatorType.ChallengeReward => "challenge_reward",
                NotificationDiscriminatorType.ClaimableReward => "claimable_reward",
                NotificationDiscriminatorType.Comment => "comment",
                NotificationDiscriminatorType.CommentMention => "comment_mention",
                NotificationDiscriminatorType.CommentReaction => "comment_reaction",
                NotificationDiscriminatorType.CommentThread => "comment_thread",
                NotificationDiscriminatorType.Cosign => "cosign",
                NotificationDiscriminatorType.Create => "create",
                NotificationDiscriminatorType.FanClubTextPost => "fan_club_text_post",
                NotificationDiscriminatorType.FanRemixContestEnded => "fan_remix_contest_ended",
                NotificationDiscriminatorType.FanRemixContestEndingSoon => "fan_remix_contest_ending_soon",
                NotificationDiscriminatorType.FanRemixContestStarted => "fan_remix_contest_started",
                NotificationDiscriminatorType.FanRemixContestSubmission => "fan_remix_contest_submission",
                NotificationDiscriminatorType.FanRemixContestWinnersSelected => "fan_remix_contest_winners_selected",
                NotificationDiscriminatorType.Follow => "follow",
                NotificationDiscriminatorType.ListenStreakReminder => "listen_streak_reminder",
                NotificationDiscriminatorType.Milestone => "milestone",
                NotificationDiscriminatorType.Reaction => "reaction",
                NotificationDiscriminatorType.Remix => "remix",
                NotificationDiscriminatorType.RemixContestUpdate => "remix_contest_update",
                NotificationDiscriminatorType.Repost => "repost",
                NotificationDiscriminatorType.RepostOfRepost => "repost_of_repost",
                NotificationDiscriminatorType.RequestManager => "request_manager",
                NotificationDiscriminatorType.Save => "save",
                NotificationDiscriminatorType.SaveOfRepost => "save_of_repost",
                NotificationDiscriminatorType.SupporterDethroned => "supporter_dethroned",
                NotificationDiscriminatorType.SupporterRankUp => "supporter_rank_up",
                NotificationDiscriminatorType.SupportingRankUp => "supporting_rank_up",
                NotificationDiscriminatorType.Tastemaker => "tastemaker",
                NotificationDiscriminatorType.TierChange => "tier_change",
                NotificationDiscriminatorType.TipReceive => "tip_receive",
                NotificationDiscriminatorType.TipSend => "tip_send",
                NotificationDiscriminatorType.TrackAddedToPlaylist => "track_added_to_playlist",
                NotificationDiscriminatorType.TrackAddedToPurchasedAlbum => "track_added_to_purchased_album",
                NotificationDiscriminatorType.Trending => "trending",
                NotificationDiscriminatorType.TrendingPlaylist => "trending_playlist",
                NotificationDiscriminatorType.TrendingUnderground => "trending_underground",
                NotificationDiscriminatorType.UsdcPurchaseBuyer => "usdc_purchase_buyer",
                NotificationDiscriminatorType.UsdcPurchaseSeller => "usdc_purchase_seller",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NotificationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "announcement" => NotificationDiscriminatorType.Announcement,
                "approve_manager_request" => NotificationDiscriminatorType.ApproveManagerRequest,
                "artist_remix_contest_ended" => NotificationDiscriminatorType.ArtistRemixContestEnded,
                "artist_remix_contest_ending_soon" => NotificationDiscriminatorType.ArtistRemixContestEndingSoon,
                "artist_remix_contest_submissions" => NotificationDiscriminatorType.ArtistRemixContestSubmissions,
                "challenge_reward" => NotificationDiscriminatorType.ChallengeReward,
                "claimable_reward" => NotificationDiscriminatorType.ClaimableReward,
                "comment" => NotificationDiscriminatorType.Comment,
                "comment_mention" => NotificationDiscriminatorType.CommentMention,
                "comment_reaction" => NotificationDiscriminatorType.CommentReaction,
                "comment_thread" => NotificationDiscriminatorType.CommentThread,
                "cosign" => NotificationDiscriminatorType.Cosign,
                "create" => NotificationDiscriminatorType.Create,
                "fan_club_text_post" => NotificationDiscriminatorType.FanClubTextPost,
                "fan_remix_contest_ended" => NotificationDiscriminatorType.FanRemixContestEnded,
                "fan_remix_contest_ending_soon" => NotificationDiscriminatorType.FanRemixContestEndingSoon,
                "fan_remix_contest_started" => NotificationDiscriminatorType.FanRemixContestStarted,
                "fan_remix_contest_submission" => NotificationDiscriminatorType.FanRemixContestSubmission,
                "fan_remix_contest_winners_selected" => NotificationDiscriminatorType.FanRemixContestWinnersSelected,
                "follow" => NotificationDiscriminatorType.Follow,
                "listen_streak_reminder" => NotificationDiscriminatorType.ListenStreakReminder,
                "milestone" => NotificationDiscriminatorType.Milestone,
                "reaction" => NotificationDiscriminatorType.Reaction,
                "remix" => NotificationDiscriminatorType.Remix,
                "remix_contest_update" => NotificationDiscriminatorType.RemixContestUpdate,
                "repost" => NotificationDiscriminatorType.Repost,
                "repost_of_repost" => NotificationDiscriminatorType.RepostOfRepost,
                "request_manager" => NotificationDiscriminatorType.RequestManager,
                "save" => NotificationDiscriminatorType.Save,
                "save_of_repost" => NotificationDiscriminatorType.SaveOfRepost,
                "supporter_dethroned" => NotificationDiscriminatorType.SupporterDethroned,
                "supporter_rank_up" => NotificationDiscriminatorType.SupporterRankUp,
                "supporting_rank_up" => NotificationDiscriminatorType.SupportingRankUp,
                "tastemaker" => NotificationDiscriminatorType.Tastemaker,
                "tier_change" => NotificationDiscriminatorType.TierChange,
                "tip_receive" => NotificationDiscriminatorType.TipReceive,
                "tip_send" => NotificationDiscriminatorType.TipSend,
                "track_added_to_playlist" => NotificationDiscriminatorType.TrackAddedToPlaylist,
                "track_added_to_purchased_album" => NotificationDiscriminatorType.TrackAddedToPurchasedAlbum,
                "trending" => NotificationDiscriminatorType.Trending,
                "trending_playlist" => NotificationDiscriminatorType.TrendingPlaylist,
                "trending_underground" => NotificationDiscriminatorType.TrendingUnderground,
                "usdc_purchase_buyer" => NotificationDiscriminatorType.UsdcPurchaseBuyer,
                "usdc_purchase_seller" => NotificationDiscriminatorType.UsdcPurchaseSeller,
                _ => null,
            };
        }
    }
}