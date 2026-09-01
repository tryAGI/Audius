
#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public enum GetNotificationsType
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
        PlaylistMilestone,
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
        TrackMilestone,
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
    public static class GetNotificationsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetNotificationsType value)
        {
            return value switch
            {
                GetNotificationsType.Announcement => "announcement",
                GetNotificationsType.ApproveManagerRequest => "approve_manager_request",
                GetNotificationsType.ArtistRemixContestEnded => "artist_remix_contest_ended",
                GetNotificationsType.ArtistRemixContestEndingSoon => "artist_remix_contest_ending_soon",
                GetNotificationsType.ArtistRemixContestSubmissions => "artist_remix_contest_submissions",
                GetNotificationsType.ChallengeReward => "challenge_reward",
                GetNotificationsType.ClaimableReward => "claimable_reward",
                GetNotificationsType.Comment => "comment",
                GetNotificationsType.CommentMention => "comment_mention",
                GetNotificationsType.CommentReaction => "comment_reaction",
                GetNotificationsType.CommentThread => "comment_thread",
                GetNotificationsType.Cosign => "cosign",
                GetNotificationsType.Create => "create",
                GetNotificationsType.FanClubTextPost => "fan_club_text_post",
                GetNotificationsType.FanRemixContestEnded => "fan_remix_contest_ended",
                GetNotificationsType.FanRemixContestEndingSoon => "fan_remix_contest_ending_soon",
                GetNotificationsType.FanRemixContestStarted => "fan_remix_contest_started",
                GetNotificationsType.FanRemixContestSubmission => "fan_remix_contest_submission",
                GetNotificationsType.FanRemixContestWinnersSelected => "fan_remix_contest_winners_selected",
                GetNotificationsType.Follow => "follow",
                GetNotificationsType.ListenStreakReminder => "listen_streak_reminder",
                GetNotificationsType.Milestone => "milestone",
                GetNotificationsType.PlaylistMilestone => "playlist_milestone",
                GetNotificationsType.Reaction => "reaction",
                GetNotificationsType.Remix => "remix",
                GetNotificationsType.RemixContestUpdate => "remix_contest_update",
                GetNotificationsType.Repost => "repost",
                GetNotificationsType.RepostOfRepost => "repost_of_repost",
                GetNotificationsType.RequestManager => "request_manager",
                GetNotificationsType.Save => "save",
                GetNotificationsType.SaveOfRepost => "save_of_repost",
                GetNotificationsType.SupporterDethroned => "supporter_dethroned",
                GetNotificationsType.SupporterRankUp => "supporter_rank_up",
                GetNotificationsType.SupportingRankUp => "supporting_rank_up",
                GetNotificationsType.Tastemaker => "tastemaker",
                GetNotificationsType.TierChange => "tier_change",
                GetNotificationsType.TipReceive => "tip_receive",
                GetNotificationsType.TipSend => "tip_send",
                GetNotificationsType.TrackAddedToPlaylist => "track_added_to_playlist",
                GetNotificationsType.TrackAddedToPurchasedAlbum => "track_added_to_purchased_album",
                GetNotificationsType.TrackMilestone => "track_milestone",
                GetNotificationsType.Trending => "trending",
                GetNotificationsType.TrendingPlaylist => "trending_playlist",
                GetNotificationsType.TrendingUnderground => "trending_underground",
                GetNotificationsType.UsdcPurchaseBuyer => "usdc_purchase_buyer",
                GetNotificationsType.UsdcPurchaseSeller => "usdc_purchase_seller",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetNotificationsType? ToEnum(string value)
        {
            return value switch
            {
                "announcement" => GetNotificationsType.Announcement,
                "approve_manager_request" => GetNotificationsType.ApproveManagerRequest,
                "artist_remix_contest_ended" => GetNotificationsType.ArtistRemixContestEnded,
                "artist_remix_contest_ending_soon" => GetNotificationsType.ArtistRemixContestEndingSoon,
                "artist_remix_contest_submissions" => GetNotificationsType.ArtistRemixContestSubmissions,
                "challenge_reward" => GetNotificationsType.ChallengeReward,
                "claimable_reward" => GetNotificationsType.ClaimableReward,
                "comment" => GetNotificationsType.Comment,
                "comment_mention" => GetNotificationsType.CommentMention,
                "comment_reaction" => GetNotificationsType.CommentReaction,
                "comment_thread" => GetNotificationsType.CommentThread,
                "cosign" => GetNotificationsType.Cosign,
                "create" => GetNotificationsType.Create,
                "fan_club_text_post" => GetNotificationsType.FanClubTextPost,
                "fan_remix_contest_ended" => GetNotificationsType.FanRemixContestEnded,
                "fan_remix_contest_ending_soon" => GetNotificationsType.FanRemixContestEndingSoon,
                "fan_remix_contest_started" => GetNotificationsType.FanRemixContestStarted,
                "fan_remix_contest_submission" => GetNotificationsType.FanRemixContestSubmission,
                "fan_remix_contest_winners_selected" => GetNotificationsType.FanRemixContestWinnersSelected,
                "follow" => GetNotificationsType.Follow,
                "listen_streak_reminder" => GetNotificationsType.ListenStreakReminder,
                "milestone" => GetNotificationsType.Milestone,
                "playlist_milestone" => GetNotificationsType.PlaylistMilestone,
                "reaction" => GetNotificationsType.Reaction,
                "remix" => GetNotificationsType.Remix,
                "remix_contest_update" => GetNotificationsType.RemixContestUpdate,
                "repost" => GetNotificationsType.Repost,
                "repost_of_repost" => GetNotificationsType.RepostOfRepost,
                "request_manager" => GetNotificationsType.RequestManager,
                "save" => GetNotificationsType.Save,
                "save_of_repost" => GetNotificationsType.SaveOfRepost,
                "supporter_dethroned" => GetNotificationsType.SupporterDethroned,
                "supporter_rank_up" => GetNotificationsType.SupporterRankUp,
                "supporting_rank_up" => GetNotificationsType.SupportingRankUp,
                "tastemaker" => GetNotificationsType.Tastemaker,
                "tier_change" => GetNotificationsType.TierChange,
                "tip_receive" => GetNotificationsType.TipReceive,
                "tip_send" => GetNotificationsType.TipSend,
                "track_added_to_playlist" => GetNotificationsType.TrackAddedToPlaylist,
                "track_added_to_purchased_album" => GetNotificationsType.TrackAddedToPurchasedAlbum,
                "track_milestone" => GetNotificationsType.TrackMilestone,
                "trending" => GetNotificationsType.Trending,
                "trending_playlist" => GetNotificationsType.TrendingPlaylist,
                "trending_underground" => GetNotificationsType.TrendingUnderground,
                "usdc_purchase_buyer" => GetNotificationsType.UsdcPurchaseBuyer,
                "usdc_purchase_seller" => GetNotificationsType.UsdcPurchaseSeller,
                _ => null,
            };
        }
    }
}