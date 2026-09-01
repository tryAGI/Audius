#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Audius
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Notification : global::System.IEquatable<Notification>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.FollowNotification? Follow { get; init; }
#else
        public global::Audius.FollowNotification? Follow { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Follow))]
#endif
        public bool IsFollow => Follow != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFollow(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.FollowNotification? value)
        {
            value = Follow;
            return IsFollow;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.FollowNotification PickFollow() => IsFollow
            ? Follow!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Follow' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.SaveNotification? Save { get; init; }
#else
        public global::Audius.SaveNotification? Save { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Save))]
#endif
        public bool IsSave => Save != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSave(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.SaveNotification? value)
        {
            value = Save;
            return IsSave;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.SaveNotification PickSave() => IsSave
            ? Save!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Save' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.RepostNotification? Repost { get; init; }
#else
        public global::Audius.RepostNotification? Repost { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Repost))]
#endif
        public bool IsRepost => Repost != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepost(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.RepostNotification? value)
        {
            value = Repost;
            return IsRepost;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.RepostNotification PickRepost() => IsRepost
            ? Repost!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Repost' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.RepostOfRepostNotification? RepostOf { get; init; }
#else
        public global::Audius.RepostOfRepostNotification? RepostOf { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepostOf))]
#endif
        public bool IsRepostOf => RepostOf != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRepostOf(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.RepostOfRepostNotification? value)
        {
            value = RepostOf;
            return IsRepostOf;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.RepostOfRepostNotification PickRepostOf() => IsRepostOf
            ? RepostOf!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RepostOf' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.SaveOfRepostNotification? SaveOfRepost { get; init; }
#else
        public global::Audius.SaveOfRepostNotification? SaveOfRepost { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SaveOfRepost))]
#endif
        public bool IsSaveOfRepost => SaveOfRepost != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSaveOfRepost(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.SaveOfRepostNotification? value)
        {
            value = SaveOfRepost;
            return IsSaveOfRepost;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.SaveOfRepostNotification PickSaveOfRepost() => IsSaveOfRepost
            ? SaveOfRepost!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SaveOfRepost' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.TastemakerNotification? Tastemaker { get; init; }
#else
        public global::Audius.TastemakerNotification? Tastemaker { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tastemaker))]
#endif
        public bool IsTastemaker => Tastemaker != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTastemaker(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.TastemakerNotification? value)
        {
            value = Tastemaker;
            return IsTastemaker;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.TastemakerNotification PickTastemaker() => IsTastemaker
            ? Tastemaker!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Tastemaker' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.RemixNotification? Remix { get; init; }
#else
        public global::Audius.RemixNotification? Remix { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Remix))]
#endif
        public bool IsRemix => Remix != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRemix(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.RemixNotification? value)
        {
            value = Remix;
            return IsRemix;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.RemixNotification PickRemix() => IsRemix
            ? Remix!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Remix' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.CosignNotification? Cosign { get; init; }
#else
        public global::Audius.CosignNotification? Cosign { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Cosign))]
#endif
        public bool IsCosign => Cosign != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCosign(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.CosignNotification? value)
        {
            value = Cosign;
            return IsCosign;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.CosignNotification PickCosign() => IsCosign
            ? Cosign!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Cosign' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.CreateNotification? Create { get; init; }
#else
        public global::Audius.CreateNotification? Create { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Create))]
#endif
        public bool IsCreate => Create != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.CreateNotification? value)
        {
            value = Create;
            return IsCreate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.CreateNotification PickCreate() => IsCreate
            ? Create!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Create' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.SendTipNotification? SendTip { get; init; }
#else
        public global::Audius.SendTipNotification? SendTip { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SendTip))]
#endif
        public bool IsSendTip => SendTip != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSendTip(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.SendTipNotification? value)
        {
            value = SendTip;
            return IsSendTip;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.SendTipNotification PickSendTip() => IsSendTip
            ? SendTip!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SendTip' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.ReceiveTipNotification? ReceiveTip { get; init; }
#else
        public global::Audius.ReceiveTipNotification? ReceiveTip { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReceiveTip))]
#endif
        public bool IsReceiveTip => ReceiveTip != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReceiveTip(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.ReceiveTipNotification? value)
        {
            value = ReceiveTip;
            return IsReceiveTip;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.ReceiveTipNotification PickReceiveTip() => IsReceiveTip
            ? ReceiveTip!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReceiveTip' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.SupporterDethronedNotification? SupporterDethroned { get; init; }
#else
        public global::Audius.SupporterDethronedNotification? SupporterDethroned { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SupporterDethroned))]
#endif
        public bool IsSupporterDethroned => SupporterDethroned != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSupporterDethroned(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.SupporterDethronedNotification? value)
        {
            value = SupporterDethroned;
            return IsSupporterDethroned;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.SupporterDethronedNotification PickSupporterDethroned() => IsSupporterDethroned
            ? SupporterDethroned!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SupporterDethroned' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.SupporterRankUpNotification? SupporterRankUp1 { get; init; }
#else
        public global::Audius.SupporterRankUpNotification? SupporterRankUp1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SupporterRankUp1))]
#endif
        public bool IsSupporterRankUp1 => SupporterRankUp1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSupporterRankUp1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.SupporterRankUpNotification? value)
        {
            value = SupporterRankUp1;
            return IsSupporterRankUp1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.SupporterRankUpNotification PickSupporterRankUp1() => IsSupporterRankUp1
            ? SupporterRankUp1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SupporterRankUp1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.SupporterRankUpNotification? SupporterRankUp2 { get; init; }
#else
        public global::Audius.SupporterRankUpNotification? SupporterRankUp2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SupporterRankUp2))]
#endif
        public bool IsSupporterRankUp2 => SupporterRankUp2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSupporterRankUp2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.SupporterRankUpNotification? value)
        {
            value = SupporterRankUp2;
            return IsSupporterRankUp2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.SupporterRankUpNotification PickSupporterRankUp2() => IsSupporterRankUp2
            ? SupporterRankUp2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SupporterRankUp2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.ChallengeRewardNotification? ChallengeReward { get; init; }
#else
        public global::Audius.ChallengeRewardNotification? ChallengeReward { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChallengeReward))]
#endif
        public bool IsChallengeReward => ChallengeReward != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChallengeReward(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.ChallengeRewardNotification? value)
        {
            value = ChallengeReward;
            return IsChallengeReward;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.ChallengeRewardNotification PickChallengeReward() => IsChallengeReward
            ? ChallengeReward!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChallengeReward' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.ClaimableRewardNotification? ClaimableReward { get; init; }
#else
        public global::Audius.ClaimableRewardNotification? ClaimableReward { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClaimableReward))]
#endif
        public bool IsClaimableReward => ClaimableReward != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickClaimableReward(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.ClaimableRewardNotification? value)
        {
            value = ClaimableReward;
            return IsClaimableReward;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.ClaimableRewardNotification PickClaimableReward() => IsClaimableReward
            ? ClaimableReward!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ClaimableReward' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.ReactionNotification? Reaction { get; init; }
#else
        public global::Audius.ReactionNotification? Reaction { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Reaction))]
#endif
        public bool IsReaction => Reaction != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReaction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.ReactionNotification? value)
        {
            value = Reaction;
            return IsReaction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.ReactionNotification PickReaction() => IsReaction
            ? Reaction!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Reaction' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.MilestoneNotification? Milestone { get; init; }
#else
        public global::Audius.MilestoneNotification? Milestone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Milestone))]
#endif
        public bool IsMilestone => Milestone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMilestone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.MilestoneNotification? value)
        {
            value = Milestone;
            return IsMilestone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.MilestoneNotification PickMilestone() => IsMilestone
            ? Milestone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Milestone' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.TierChangeNotification? TierChange { get; init; }
#else
        public global::Audius.TierChangeNotification? TierChange { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TierChange))]
#endif
        public bool IsTierChange => TierChange != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTierChange(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.TierChangeNotification? value)
        {
            value = TierChange;
            return IsTierChange;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.TierChangeNotification PickTierChange() => IsTierChange
            ? TierChange!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TierChange' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.TrackAddedToPlaylistNotification? TrackAddedToPlaylist { get; init; }
#else
        public global::Audius.TrackAddedToPlaylistNotification? TrackAddedToPlaylist { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TrackAddedToPlaylist))]
#endif
        public bool IsTrackAddedToPlaylist => TrackAddedToPlaylist != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTrackAddedToPlaylist(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.TrackAddedToPlaylistNotification? value)
        {
            value = TrackAddedToPlaylist;
            return IsTrackAddedToPlaylist;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.TrackAddedToPlaylistNotification PickTrackAddedToPlaylist() => IsTrackAddedToPlaylist
            ? TrackAddedToPlaylist!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TrackAddedToPlaylist' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.TrackAddedToPurchasedAlbumNotification? TrackAddedToPurchasedAlbum { get; init; }
#else
        public global::Audius.TrackAddedToPurchasedAlbumNotification? TrackAddedToPurchasedAlbum { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TrackAddedToPurchasedAlbum))]
#endif
        public bool IsTrackAddedToPurchasedAlbum => TrackAddedToPurchasedAlbum != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTrackAddedToPurchasedAlbum(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.TrackAddedToPurchasedAlbumNotification? value)
        {
            value = TrackAddedToPurchasedAlbum;
            return IsTrackAddedToPurchasedAlbum;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.TrackAddedToPurchasedAlbumNotification PickTrackAddedToPurchasedAlbum() => IsTrackAddedToPurchasedAlbum
            ? TrackAddedToPurchasedAlbum!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TrackAddedToPurchasedAlbum' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.UsdcPurchaseSellerNotification? UsdcPurchaseSeller { get; init; }
#else
        public global::Audius.UsdcPurchaseSellerNotification? UsdcPurchaseSeller { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UsdcPurchaseSeller))]
#endif
        public bool IsUsdcPurchaseSeller => UsdcPurchaseSeller != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUsdcPurchaseSeller(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.UsdcPurchaseSellerNotification? value)
        {
            value = UsdcPurchaseSeller;
            return IsUsdcPurchaseSeller;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.UsdcPurchaseSellerNotification PickUsdcPurchaseSeller() => IsUsdcPurchaseSeller
            ? UsdcPurchaseSeller!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UsdcPurchaseSeller' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.UsdcPurchaseBuyerNotification? UsdcPurchaseBuyer { get; init; }
#else
        public global::Audius.UsdcPurchaseBuyerNotification? UsdcPurchaseBuyer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UsdcPurchaseBuyer))]
#endif
        public bool IsUsdcPurchaseBuyer => UsdcPurchaseBuyer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUsdcPurchaseBuyer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.UsdcPurchaseBuyerNotification? value)
        {
            value = UsdcPurchaseBuyer;
            return IsUsdcPurchaseBuyer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.UsdcPurchaseBuyerNotification PickUsdcPurchaseBuyer() => IsUsdcPurchaseBuyer
            ? UsdcPurchaseBuyer!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UsdcPurchaseBuyer' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.RequestManagerNotification? RequestManager { get; init; }
#else
        public global::Audius.RequestManagerNotification? RequestManager { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequestManager))]
#endif
        public bool IsRequestManager => RequestManager != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRequestManager(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.RequestManagerNotification? value)
        {
            value = RequestManager;
            return IsRequestManager;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.RequestManagerNotification PickRequestManager() => IsRequestManager
            ? RequestManager!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RequestManager' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.ApproveManagerRequestNotification? ApproveManagerRequest { get; init; }
#else
        public global::Audius.ApproveManagerRequestNotification? ApproveManagerRequest { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApproveManagerRequest))]
#endif
        public bool IsApproveManagerRequest => ApproveManagerRequest != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickApproveManagerRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.ApproveManagerRequestNotification? value)
        {
            value = ApproveManagerRequest;
            return IsApproveManagerRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.ApproveManagerRequestNotification PickApproveManagerRequest() => IsApproveManagerRequest
            ? ApproveManagerRequest!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApproveManagerRequest' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.TrendingNotification? Trending { get; init; }
#else
        public global::Audius.TrendingNotification? Trending { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Trending))]
#endif
        public bool IsTrending => Trending != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTrending(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.TrendingNotification? value)
        {
            value = Trending;
            return IsTrending;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.TrendingNotification PickTrending() => IsTrending
            ? Trending!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Trending' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.TrendingPlaylistNotification? TrendingPlaylist { get; init; }
#else
        public global::Audius.TrendingPlaylistNotification? TrendingPlaylist { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TrendingPlaylist))]
#endif
        public bool IsTrendingPlaylist => TrendingPlaylist != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTrendingPlaylist(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.TrendingPlaylistNotification? value)
        {
            value = TrendingPlaylist;
            return IsTrendingPlaylist;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.TrendingPlaylistNotification PickTrendingPlaylist() => IsTrendingPlaylist
            ? TrendingPlaylist!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TrendingPlaylist' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.TrendingUndergroundNotification? TrendingUnderground { get; init; }
#else
        public global::Audius.TrendingUndergroundNotification? TrendingUnderground { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TrendingUnderground))]
#endif
        public bool IsTrendingUnderground => TrendingUnderground != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTrendingUnderground(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.TrendingUndergroundNotification? value)
        {
            value = TrendingUnderground;
            return IsTrendingUnderground;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.TrendingUndergroundNotification PickTrendingUnderground() => IsTrendingUnderground
            ? TrendingUnderground!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TrendingUnderground' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.AnnouncementNotification? Announcement { get; init; }
#else
        public global::Audius.AnnouncementNotification? Announcement { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Announcement))]
#endif
        public bool IsAnnouncement => Announcement != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAnnouncement(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.AnnouncementNotification? value)
        {
            value = Announcement;
            return IsAnnouncement;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.AnnouncementNotification PickAnnouncement() => IsAnnouncement
            ? Announcement!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Announcement' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.CommentNotification? Comment { get; init; }
#else
        public global::Audius.CommentNotification? Comment { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Comment))]
#endif
        public bool IsComment => Comment != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComment(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.CommentNotification? value)
        {
            value = Comment;
            return IsComment;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.CommentNotification PickComment() => IsComment
            ? Comment!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Comment' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.CommentThreadNotification? CommentThread { get; init; }
#else
        public global::Audius.CommentThreadNotification? CommentThread { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommentThread))]
#endif
        public bool IsCommentThread => CommentThread != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCommentThread(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.CommentThreadNotification? value)
        {
            value = CommentThread;
            return IsCommentThread;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.CommentThreadNotification PickCommentThread() => IsCommentThread
            ? CommentThread!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CommentThread' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.CommentMentionNotification? CommentMention { get; init; }
#else
        public global::Audius.CommentMentionNotification? CommentMention { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommentMention))]
#endif
        public bool IsCommentMention => CommentMention != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCommentMention(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.CommentMentionNotification? value)
        {
            value = CommentMention;
            return IsCommentMention;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.CommentMentionNotification PickCommentMention() => IsCommentMention
            ? CommentMention!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CommentMention' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.CommentReactionNotification? CommentReaction { get; init; }
#else
        public global::Audius.CommentReactionNotification? CommentReaction { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommentReaction))]
#endif
        public bool IsCommentReaction => CommentReaction != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCommentReaction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.CommentReactionNotification? value)
        {
            value = CommentReaction;
            return IsCommentReaction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.CommentReactionNotification PickCommentReaction() => IsCommentReaction
            ? CommentReaction!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CommentReaction' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.ListenStreakReminderNotification? ListenStreakReminder { get; init; }
#else
        public global::Audius.ListenStreakReminderNotification? ListenStreakReminder { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ListenStreakReminder))]
#endif
        public bool IsListenStreakReminder => ListenStreakReminder != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickListenStreakReminder(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.ListenStreakReminderNotification? value)
        {
            value = ListenStreakReminder;
            return IsListenStreakReminder;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.ListenStreakReminderNotification PickListenStreakReminder() => IsListenStreakReminder
            ? ListenStreakReminder!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ListenStreakReminder' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.FanRemixContestStartedNotification? FanRemixContestStarted { get; init; }
#else
        public global::Audius.FanRemixContestStartedNotification? FanRemixContestStarted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FanRemixContestStarted))]
#endif
        public bool IsFanRemixContestStarted => FanRemixContestStarted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFanRemixContestStarted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.FanRemixContestStartedNotification? value)
        {
            value = FanRemixContestStarted;
            return IsFanRemixContestStarted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.FanRemixContestStartedNotification PickFanRemixContestStarted() => IsFanRemixContestStarted
            ? FanRemixContestStarted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FanRemixContestStarted' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.FanRemixContestEndedNotification? FanRemixContestEnded { get; init; }
#else
        public global::Audius.FanRemixContestEndedNotification? FanRemixContestEnded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FanRemixContestEnded))]
#endif
        public bool IsFanRemixContestEnded => FanRemixContestEnded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFanRemixContestEnded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.FanRemixContestEndedNotification? value)
        {
            value = FanRemixContestEnded;
            return IsFanRemixContestEnded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.FanRemixContestEndedNotification PickFanRemixContestEnded() => IsFanRemixContestEnded
            ? FanRemixContestEnded!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FanRemixContestEnded' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.FanRemixContestEndingSoonNotification? FanRemixContestEndingSoon { get; init; }
#else
        public global::Audius.FanRemixContestEndingSoonNotification? FanRemixContestEndingSoon { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FanRemixContestEndingSoon))]
#endif
        public bool IsFanRemixContestEndingSoon => FanRemixContestEndingSoon != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFanRemixContestEndingSoon(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.FanRemixContestEndingSoonNotification? value)
        {
            value = FanRemixContestEndingSoon;
            return IsFanRemixContestEndingSoon;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.FanRemixContestEndingSoonNotification PickFanRemixContestEndingSoon() => IsFanRemixContestEndingSoon
            ? FanRemixContestEndingSoon!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FanRemixContestEndingSoon' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.ArtistRemixContestEndedNotification? ArtistRemixContestEnded { get; init; }
#else
        public global::Audius.ArtistRemixContestEndedNotification? ArtistRemixContestEnded { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArtistRemixContestEnded))]
#endif
        public bool IsArtistRemixContestEnded => ArtistRemixContestEnded != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickArtistRemixContestEnded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.ArtistRemixContestEndedNotification? value)
        {
            value = ArtistRemixContestEnded;
            return IsArtistRemixContestEnded;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.ArtistRemixContestEndedNotification PickArtistRemixContestEnded() => IsArtistRemixContestEnded
            ? ArtistRemixContestEnded!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ArtistRemixContestEnded' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.ArtistRemixContestEndingSoonNotification? ArtistRemixContestEndingSoon { get; init; }
#else
        public global::Audius.ArtistRemixContestEndingSoonNotification? ArtistRemixContestEndingSoon { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArtistRemixContestEndingSoon))]
#endif
        public bool IsArtistRemixContestEndingSoon => ArtistRemixContestEndingSoon != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickArtistRemixContestEndingSoon(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.ArtistRemixContestEndingSoonNotification? value)
        {
            value = ArtistRemixContestEndingSoon;
            return IsArtistRemixContestEndingSoon;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.ArtistRemixContestEndingSoonNotification PickArtistRemixContestEndingSoon() => IsArtistRemixContestEndingSoon
            ? ArtistRemixContestEndingSoon!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ArtistRemixContestEndingSoon' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.ArtistRemixContestSubmissionsNotification? ArtistRemixContestSubmissions { get; init; }
#else
        public global::Audius.ArtistRemixContestSubmissionsNotification? ArtistRemixContestSubmissions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArtistRemixContestSubmissions))]
#endif
        public bool IsArtistRemixContestSubmissions => ArtistRemixContestSubmissions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickArtistRemixContestSubmissions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.ArtistRemixContestSubmissionsNotification? value)
        {
            value = ArtistRemixContestSubmissions;
            return IsArtistRemixContestSubmissions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.ArtistRemixContestSubmissionsNotification PickArtistRemixContestSubmissions() => IsArtistRemixContestSubmissions
            ? ArtistRemixContestSubmissions!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ArtistRemixContestSubmissions' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.FanRemixContestWinnersSelectedNotification? FanRemixContestWinnersSelected { get; init; }
#else
        public global::Audius.FanRemixContestWinnersSelectedNotification? FanRemixContestWinnersSelected { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FanRemixContestWinnersSelected))]
#endif
        public bool IsFanRemixContestWinnersSelected => FanRemixContestWinnersSelected != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFanRemixContestWinnersSelected(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.FanRemixContestWinnersSelectedNotification? value)
        {
            value = FanRemixContestWinnersSelected;
            return IsFanRemixContestWinnersSelected;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.FanRemixContestWinnersSelectedNotification PickFanRemixContestWinnersSelected() => IsFanRemixContestWinnersSelected
            ? FanRemixContestWinnersSelected!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FanRemixContestWinnersSelected' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.RemixContestUpdateNotification? RemixContestUpdate { get; init; }
#else
        public global::Audius.RemixContestUpdateNotification? RemixContestUpdate { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RemixContestUpdate))]
#endif
        public bool IsRemixContestUpdate => RemixContestUpdate != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRemixContestUpdate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.RemixContestUpdateNotification? value)
        {
            value = RemixContestUpdate;
            return IsRemixContestUpdate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.RemixContestUpdateNotification PickRemixContestUpdate() => IsRemixContestUpdate
            ? RemixContestUpdate!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RemixContestUpdate' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.FanRemixContestSubmissionNotification? FanRemixContestSubmission { get; init; }
#else
        public global::Audius.FanRemixContestSubmissionNotification? FanRemixContestSubmission { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FanRemixContestSubmission))]
#endif
        public bool IsFanRemixContestSubmission => FanRemixContestSubmission != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFanRemixContestSubmission(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.FanRemixContestSubmissionNotification? value)
        {
            value = FanRemixContestSubmission;
            return IsFanRemixContestSubmission;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.FanRemixContestSubmissionNotification PickFanRemixContestSubmission() => IsFanRemixContestSubmission
            ? FanRemixContestSubmission!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FanRemixContestSubmission' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Audius.FanClubTextPostNotification? FanClubTextPost { get; init; }
#else
        public global::Audius.FanClubTextPostNotification? FanClubTextPost { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FanClubTextPost))]
#endif
        public bool IsFanClubTextPost => FanClubTextPost != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFanClubTextPost(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Audius.FanClubTextPostNotification? value)
        {
            value = FanClubTextPost;
            return IsFanClubTextPost;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Audius.FanClubTextPostNotification PickFanClubTextPost() => IsFanClubTextPost
            ? FanClubTextPost!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FanClubTextPost' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.FollowNotification value) => new Notification((global::Audius.FollowNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.FollowNotification?(Notification @this) => @this.Follow;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.FollowNotification? value)
        {
            Follow = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromFollow(global::Audius.FollowNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.SaveNotification value) => new Notification((global::Audius.SaveNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.SaveNotification?(Notification @this) => @this.Save;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.SaveNotification? value)
        {
            Save = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromSave(global::Audius.SaveNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.RepostNotification value) => new Notification((global::Audius.RepostNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.RepostNotification?(Notification @this) => @this.Repost;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.RepostNotification? value)
        {
            Repost = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromRepost(global::Audius.RepostNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.RepostOfRepostNotification value) => new Notification((global::Audius.RepostOfRepostNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.RepostOfRepostNotification?(Notification @this) => @this.RepostOf;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.RepostOfRepostNotification? value)
        {
            RepostOf = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromRepostOf(global::Audius.RepostOfRepostNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.SaveOfRepostNotification value) => new Notification((global::Audius.SaveOfRepostNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.SaveOfRepostNotification?(Notification @this) => @this.SaveOfRepost;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.SaveOfRepostNotification? value)
        {
            SaveOfRepost = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromSaveOfRepost(global::Audius.SaveOfRepostNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.TastemakerNotification value) => new Notification((global::Audius.TastemakerNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.TastemakerNotification?(Notification @this) => @this.Tastemaker;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.TastemakerNotification? value)
        {
            Tastemaker = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromTastemaker(global::Audius.TastemakerNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.RemixNotification value) => new Notification((global::Audius.RemixNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.RemixNotification?(Notification @this) => @this.Remix;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.RemixNotification? value)
        {
            Remix = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromRemix(global::Audius.RemixNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.CosignNotification value) => new Notification((global::Audius.CosignNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.CosignNotification?(Notification @this) => @this.Cosign;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.CosignNotification? value)
        {
            Cosign = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromCosign(global::Audius.CosignNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.CreateNotification value) => new Notification((global::Audius.CreateNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.CreateNotification?(Notification @this) => @this.Create;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.CreateNotification? value)
        {
            Create = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromCreate(global::Audius.CreateNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.SendTipNotification value) => new Notification((global::Audius.SendTipNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.SendTipNotification?(Notification @this) => @this.SendTip;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.SendTipNotification? value)
        {
            SendTip = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromSendTip(global::Audius.SendTipNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.ReceiveTipNotification value) => new Notification((global::Audius.ReceiveTipNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.ReceiveTipNotification?(Notification @this) => @this.ReceiveTip;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.ReceiveTipNotification? value)
        {
            ReceiveTip = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromReceiveTip(global::Audius.ReceiveTipNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.SupporterDethronedNotification value) => new Notification((global::Audius.SupporterDethronedNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.SupporterDethronedNotification?(Notification @this) => @this.SupporterDethroned;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.SupporterDethronedNotification? value)
        {
            SupporterDethroned = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromSupporterDethroned(global::Audius.SupporterDethronedNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.SupporterRankUpNotification value) => new Notification((global::Audius.SupporterRankUpNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.SupporterRankUpNotification?(Notification @this) => @this.SupporterRankUp1;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.SupporterRankUpNotification? value)
        {
            SupporterRankUp1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromSupporterRankUp1(global::Audius.SupporterRankUpNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.ChallengeRewardNotification value) => new Notification((global::Audius.ChallengeRewardNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.ChallengeRewardNotification?(Notification @this) => @this.ChallengeReward;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.ChallengeRewardNotification? value)
        {
            ChallengeReward = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromChallengeReward(global::Audius.ChallengeRewardNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.ClaimableRewardNotification value) => new Notification((global::Audius.ClaimableRewardNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.ClaimableRewardNotification?(Notification @this) => @this.ClaimableReward;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.ClaimableRewardNotification? value)
        {
            ClaimableReward = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromClaimableReward(global::Audius.ClaimableRewardNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.ReactionNotification value) => new Notification((global::Audius.ReactionNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.ReactionNotification?(Notification @this) => @this.Reaction;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.ReactionNotification? value)
        {
            Reaction = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromReaction(global::Audius.ReactionNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.MilestoneNotification value) => new Notification((global::Audius.MilestoneNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.MilestoneNotification?(Notification @this) => @this.Milestone;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.MilestoneNotification? value)
        {
            Milestone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromMilestone(global::Audius.MilestoneNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.TierChangeNotification value) => new Notification((global::Audius.TierChangeNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.TierChangeNotification?(Notification @this) => @this.TierChange;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.TierChangeNotification? value)
        {
            TierChange = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromTierChange(global::Audius.TierChangeNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.TrackAddedToPlaylistNotification value) => new Notification((global::Audius.TrackAddedToPlaylistNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.TrackAddedToPlaylistNotification?(Notification @this) => @this.TrackAddedToPlaylist;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.TrackAddedToPlaylistNotification? value)
        {
            TrackAddedToPlaylist = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromTrackAddedToPlaylist(global::Audius.TrackAddedToPlaylistNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.TrackAddedToPurchasedAlbumNotification value) => new Notification((global::Audius.TrackAddedToPurchasedAlbumNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.TrackAddedToPurchasedAlbumNotification?(Notification @this) => @this.TrackAddedToPurchasedAlbum;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.TrackAddedToPurchasedAlbumNotification? value)
        {
            TrackAddedToPurchasedAlbum = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromTrackAddedToPurchasedAlbum(global::Audius.TrackAddedToPurchasedAlbumNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.UsdcPurchaseSellerNotification value) => new Notification((global::Audius.UsdcPurchaseSellerNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.UsdcPurchaseSellerNotification?(Notification @this) => @this.UsdcPurchaseSeller;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.UsdcPurchaseSellerNotification? value)
        {
            UsdcPurchaseSeller = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromUsdcPurchaseSeller(global::Audius.UsdcPurchaseSellerNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.UsdcPurchaseBuyerNotification value) => new Notification((global::Audius.UsdcPurchaseBuyerNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.UsdcPurchaseBuyerNotification?(Notification @this) => @this.UsdcPurchaseBuyer;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.UsdcPurchaseBuyerNotification? value)
        {
            UsdcPurchaseBuyer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromUsdcPurchaseBuyer(global::Audius.UsdcPurchaseBuyerNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.RequestManagerNotification value) => new Notification((global::Audius.RequestManagerNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.RequestManagerNotification?(Notification @this) => @this.RequestManager;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.RequestManagerNotification? value)
        {
            RequestManager = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromRequestManager(global::Audius.RequestManagerNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.ApproveManagerRequestNotification value) => new Notification((global::Audius.ApproveManagerRequestNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.ApproveManagerRequestNotification?(Notification @this) => @this.ApproveManagerRequest;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.ApproveManagerRequestNotification? value)
        {
            ApproveManagerRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromApproveManagerRequest(global::Audius.ApproveManagerRequestNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.TrendingNotification value) => new Notification((global::Audius.TrendingNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.TrendingNotification?(Notification @this) => @this.Trending;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.TrendingNotification? value)
        {
            Trending = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromTrending(global::Audius.TrendingNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.TrendingPlaylistNotification value) => new Notification((global::Audius.TrendingPlaylistNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.TrendingPlaylistNotification?(Notification @this) => @this.TrendingPlaylist;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.TrendingPlaylistNotification? value)
        {
            TrendingPlaylist = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromTrendingPlaylist(global::Audius.TrendingPlaylistNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.TrendingUndergroundNotification value) => new Notification((global::Audius.TrendingUndergroundNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.TrendingUndergroundNotification?(Notification @this) => @this.TrendingUnderground;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.TrendingUndergroundNotification? value)
        {
            TrendingUnderground = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromTrendingUnderground(global::Audius.TrendingUndergroundNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.AnnouncementNotification value) => new Notification((global::Audius.AnnouncementNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.AnnouncementNotification?(Notification @this) => @this.Announcement;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.AnnouncementNotification? value)
        {
            Announcement = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromAnnouncement(global::Audius.AnnouncementNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.CommentNotification value) => new Notification((global::Audius.CommentNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.CommentNotification?(Notification @this) => @this.Comment;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.CommentNotification? value)
        {
            Comment = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromComment(global::Audius.CommentNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.CommentThreadNotification value) => new Notification((global::Audius.CommentThreadNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.CommentThreadNotification?(Notification @this) => @this.CommentThread;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.CommentThreadNotification? value)
        {
            CommentThread = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromCommentThread(global::Audius.CommentThreadNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.CommentMentionNotification value) => new Notification((global::Audius.CommentMentionNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.CommentMentionNotification?(Notification @this) => @this.CommentMention;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.CommentMentionNotification? value)
        {
            CommentMention = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromCommentMention(global::Audius.CommentMentionNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.CommentReactionNotification value) => new Notification((global::Audius.CommentReactionNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.CommentReactionNotification?(Notification @this) => @this.CommentReaction;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.CommentReactionNotification? value)
        {
            CommentReaction = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromCommentReaction(global::Audius.CommentReactionNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.ListenStreakReminderNotification value) => new Notification((global::Audius.ListenStreakReminderNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.ListenStreakReminderNotification?(Notification @this) => @this.ListenStreakReminder;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.ListenStreakReminderNotification? value)
        {
            ListenStreakReminder = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromListenStreakReminder(global::Audius.ListenStreakReminderNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.FanRemixContestStartedNotification value) => new Notification((global::Audius.FanRemixContestStartedNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.FanRemixContestStartedNotification?(Notification @this) => @this.FanRemixContestStarted;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.FanRemixContestStartedNotification? value)
        {
            FanRemixContestStarted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromFanRemixContestStarted(global::Audius.FanRemixContestStartedNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.FanRemixContestEndedNotification value) => new Notification((global::Audius.FanRemixContestEndedNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.FanRemixContestEndedNotification?(Notification @this) => @this.FanRemixContestEnded;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.FanRemixContestEndedNotification? value)
        {
            FanRemixContestEnded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromFanRemixContestEnded(global::Audius.FanRemixContestEndedNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.FanRemixContestEndingSoonNotification value) => new Notification((global::Audius.FanRemixContestEndingSoonNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.FanRemixContestEndingSoonNotification?(Notification @this) => @this.FanRemixContestEndingSoon;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.FanRemixContestEndingSoonNotification? value)
        {
            FanRemixContestEndingSoon = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromFanRemixContestEndingSoon(global::Audius.FanRemixContestEndingSoonNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.ArtistRemixContestEndedNotification value) => new Notification((global::Audius.ArtistRemixContestEndedNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.ArtistRemixContestEndedNotification?(Notification @this) => @this.ArtistRemixContestEnded;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.ArtistRemixContestEndedNotification? value)
        {
            ArtistRemixContestEnded = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromArtistRemixContestEnded(global::Audius.ArtistRemixContestEndedNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.ArtistRemixContestEndingSoonNotification value) => new Notification((global::Audius.ArtistRemixContestEndingSoonNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.ArtistRemixContestEndingSoonNotification?(Notification @this) => @this.ArtistRemixContestEndingSoon;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.ArtistRemixContestEndingSoonNotification? value)
        {
            ArtistRemixContestEndingSoon = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromArtistRemixContestEndingSoon(global::Audius.ArtistRemixContestEndingSoonNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.ArtistRemixContestSubmissionsNotification value) => new Notification((global::Audius.ArtistRemixContestSubmissionsNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.ArtistRemixContestSubmissionsNotification?(Notification @this) => @this.ArtistRemixContestSubmissions;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.ArtistRemixContestSubmissionsNotification? value)
        {
            ArtistRemixContestSubmissions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromArtistRemixContestSubmissions(global::Audius.ArtistRemixContestSubmissionsNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.FanRemixContestWinnersSelectedNotification value) => new Notification((global::Audius.FanRemixContestWinnersSelectedNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.FanRemixContestWinnersSelectedNotification?(Notification @this) => @this.FanRemixContestWinnersSelected;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.FanRemixContestWinnersSelectedNotification? value)
        {
            FanRemixContestWinnersSelected = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromFanRemixContestWinnersSelected(global::Audius.FanRemixContestWinnersSelectedNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.RemixContestUpdateNotification value) => new Notification((global::Audius.RemixContestUpdateNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.RemixContestUpdateNotification?(Notification @this) => @this.RemixContestUpdate;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.RemixContestUpdateNotification? value)
        {
            RemixContestUpdate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromRemixContestUpdate(global::Audius.RemixContestUpdateNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.FanRemixContestSubmissionNotification value) => new Notification((global::Audius.FanRemixContestSubmissionNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.FanRemixContestSubmissionNotification?(Notification @this) => @this.FanRemixContestSubmission;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.FanRemixContestSubmissionNotification? value)
        {
            FanRemixContestSubmission = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromFanRemixContestSubmission(global::Audius.FanRemixContestSubmissionNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Notification(global::Audius.FanClubTextPostNotification value) => new Notification((global::Audius.FanClubTextPostNotification?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Audius.FanClubTextPostNotification?(Notification @this) => @this.FanClubTextPost;

        /// <summary>
        ///
        /// </summary>
        public Notification(global::Audius.FanClubTextPostNotification? value)
        {
            FanClubTextPost = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Notification FromFanClubTextPost(global::Audius.FanClubTextPostNotification? value) => new Notification(value);

        /// <summary>
        ///
        /// </summary>
        public Notification(
            global::Audius.FollowNotification? follow,
            global::Audius.SaveNotification? save,
            global::Audius.RepostNotification? repost,
            global::Audius.RepostOfRepostNotification? repostOf,
            global::Audius.SaveOfRepostNotification? saveOfRepost,
            global::Audius.TastemakerNotification? tastemaker,
            global::Audius.RemixNotification? remix,
            global::Audius.CosignNotification? cosign,
            global::Audius.CreateNotification? create,
            global::Audius.SendTipNotification? sendTip,
            global::Audius.ReceiveTipNotification? receiveTip,
            global::Audius.SupporterDethronedNotification? supporterDethroned,
            global::Audius.SupporterRankUpNotification? supporterRankUp1,
            global::Audius.SupporterRankUpNotification? supporterRankUp2,
            global::Audius.ChallengeRewardNotification? challengeReward,
            global::Audius.ClaimableRewardNotification? claimableReward,
            global::Audius.ReactionNotification? reaction,
            global::Audius.MilestoneNotification? milestone,
            global::Audius.TierChangeNotification? tierChange,
            global::Audius.TrackAddedToPlaylistNotification? trackAddedToPlaylist,
            global::Audius.TrackAddedToPurchasedAlbumNotification? trackAddedToPurchasedAlbum,
            global::Audius.UsdcPurchaseSellerNotification? usdcPurchaseSeller,
            global::Audius.UsdcPurchaseBuyerNotification? usdcPurchaseBuyer,
            global::Audius.RequestManagerNotification? requestManager,
            global::Audius.ApproveManagerRequestNotification? approveManagerRequest,
            global::Audius.TrendingNotification? trending,
            global::Audius.TrendingPlaylistNotification? trendingPlaylist,
            global::Audius.TrendingUndergroundNotification? trendingUnderground,
            global::Audius.AnnouncementNotification? announcement,
            global::Audius.CommentNotification? comment,
            global::Audius.CommentThreadNotification? commentThread,
            global::Audius.CommentMentionNotification? commentMention,
            global::Audius.CommentReactionNotification? commentReaction,
            global::Audius.ListenStreakReminderNotification? listenStreakReminder,
            global::Audius.FanRemixContestStartedNotification? fanRemixContestStarted,
            global::Audius.FanRemixContestEndedNotification? fanRemixContestEnded,
            global::Audius.FanRemixContestEndingSoonNotification? fanRemixContestEndingSoon,
            global::Audius.ArtistRemixContestEndedNotification? artistRemixContestEnded,
            global::Audius.ArtistRemixContestEndingSoonNotification? artistRemixContestEndingSoon,
            global::Audius.ArtistRemixContestSubmissionsNotification? artistRemixContestSubmissions,
            global::Audius.FanRemixContestWinnersSelectedNotification? fanRemixContestWinnersSelected,
            global::Audius.RemixContestUpdateNotification? remixContestUpdate,
            global::Audius.FanRemixContestSubmissionNotification? fanRemixContestSubmission,
            global::Audius.FanClubTextPostNotification? fanClubTextPost
            )
        {
            Follow = follow;
            Save = save;
            Repost = repost;
            RepostOf = repostOf;
            SaveOfRepost = saveOfRepost;
            Tastemaker = tastemaker;
            Remix = remix;
            Cosign = cosign;
            Create = create;
            SendTip = sendTip;
            ReceiveTip = receiveTip;
            SupporterDethroned = supporterDethroned;
            SupporterRankUp1 = supporterRankUp1;
            SupporterRankUp2 = supporterRankUp2;
            ChallengeReward = challengeReward;
            ClaimableReward = claimableReward;
            Reaction = reaction;
            Milestone = milestone;
            TierChange = tierChange;
            TrackAddedToPlaylist = trackAddedToPlaylist;
            TrackAddedToPurchasedAlbum = trackAddedToPurchasedAlbum;
            UsdcPurchaseSeller = usdcPurchaseSeller;
            UsdcPurchaseBuyer = usdcPurchaseBuyer;
            RequestManager = requestManager;
            ApproveManagerRequest = approveManagerRequest;
            Trending = trending;
            TrendingPlaylist = trendingPlaylist;
            TrendingUnderground = trendingUnderground;
            Announcement = announcement;
            Comment = comment;
            CommentThread = commentThread;
            CommentMention = commentMention;
            CommentReaction = commentReaction;
            ListenStreakReminder = listenStreakReminder;
            FanRemixContestStarted = fanRemixContestStarted;
            FanRemixContestEnded = fanRemixContestEnded;
            FanRemixContestEndingSoon = fanRemixContestEndingSoon;
            ArtistRemixContestEnded = artistRemixContestEnded;
            ArtistRemixContestEndingSoon = artistRemixContestEndingSoon;
            ArtistRemixContestSubmissions = artistRemixContestSubmissions;
            FanRemixContestWinnersSelected = fanRemixContestWinnersSelected;
            RemixContestUpdate = remixContestUpdate;
            FanRemixContestSubmission = fanRemixContestSubmission;
            FanClubTextPost = fanClubTextPost;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            FanClubTextPost as object ??
            FanRemixContestSubmission as object ??
            RemixContestUpdate as object ??
            FanRemixContestWinnersSelected as object ??
            ArtistRemixContestSubmissions as object ??
            ArtistRemixContestEndingSoon as object ??
            ArtistRemixContestEnded as object ??
            FanRemixContestEndingSoon as object ??
            FanRemixContestEnded as object ??
            FanRemixContestStarted as object ??
            ListenStreakReminder as object ??
            CommentReaction as object ??
            CommentMention as object ??
            CommentThread as object ??
            Comment as object ??
            Announcement as object ??
            TrendingUnderground as object ??
            TrendingPlaylist as object ??
            Trending as object ??
            ApproveManagerRequest as object ??
            RequestManager as object ??
            UsdcPurchaseBuyer as object ??
            UsdcPurchaseSeller as object ??
            TrackAddedToPurchasedAlbum as object ??
            TrackAddedToPlaylist as object ??
            TierChange as object ??
            Milestone as object ??
            Reaction as object ??
            ClaimableReward as object ??
            ChallengeReward as object ??
            SupporterRankUp2 as object ??
            SupporterRankUp1 as object ??
            SupporterDethroned as object ??
            ReceiveTip as object ??
            SendTip as object ??
            Create as object ??
            Cosign as object ??
            Remix as object ??
            Tastemaker as object ??
            SaveOfRepost as object ??
            RepostOf as object ??
            Repost as object ??
            Save as object ??
            Follow as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Follow?.ToString() ??
            Save?.ToString() ??
            Repost?.ToString() ??
            RepostOf?.ToString() ??
            SaveOfRepost?.ToString() ??
            Tastemaker?.ToString() ??
            Remix?.ToString() ??
            Cosign?.ToString() ??
            Create?.ToString() ??
            SendTip?.ToString() ??
            ReceiveTip?.ToString() ??
            SupporterDethroned?.ToString() ??
            SupporterRankUp1?.ToString() ??
            SupporterRankUp2?.ToString() ??
            ChallengeReward?.ToString() ??
            ClaimableReward?.ToString() ??
            Reaction?.ToString() ??
            Milestone?.ToString() ??
            TierChange?.ToString() ??
            TrackAddedToPlaylist?.ToString() ??
            TrackAddedToPurchasedAlbum?.ToString() ??
            UsdcPurchaseSeller?.ToString() ??
            UsdcPurchaseBuyer?.ToString() ??
            RequestManager?.ToString() ??
            ApproveManagerRequest?.ToString() ??
            Trending?.ToString() ??
            TrendingPlaylist?.ToString() ??
            TrendingUnderground?.ToString() ??
            Announcement?.ToString() ??
            Comment?.ToString() ??
            CommentThread?.ToString() ??
            CommentMention?.ToString() ??
            CommentReaction?.ToString() ??
            ListenStreakReminder?.ToString() ??
            FanRemixContestStarted?.ToString() ??
            FanRemixContestEnded?.ToString() ??
            FanRemixContestEndingSoon?.ToString() ??
            ArtistRemixContestEnded?.ToString() ??
            ArtistRemixContestEndingSoon?.ToString() ??
            ArtistRemixContestSubmissions?.ToString() ??
            FanRemixContestWinnersSelected?.ToString() ??
            RemixContestUpdate?.ToString() ??
            FanRemixContestSubmission?.ToString() ??
            FanClubTextPost?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && IsRemixContestUpdate && !IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && IsFanRemixContestSubmission && !IsFanClubTextPost || !IsFollow && !IsSave && !IsRepost && !IsRepostOf && !IsSaveOfRepost && !IsTastemaker && !IsRemix && !IsCosign && !IsCreate && !IsSendTip && !IsReceiveTip && !IsSupporterDethroned && !IsSupporterRankUp1 && !IsSupporterRankUp2 && !IsChallengeReward && !IsClaimableReward && !IsReaction && !IsMilestone && !IsTierChange && !IsTrackAddedToPlaylist && !IsTrackAddedToPurchasedAlbum && !IsUsdcPurchaseSeller && !IsUsdcPurchaseBuyer && !IsRequestManager && !IsApproveManagerRequest && !IsTrending && !IsTrendingPlaylist && !IsTrendingUnderground && !IsAnnouncement && !IsComment && !IsCommentThread && !IsCommentMention && !IsCommentReaction && !IsListenStreakReminder && !IsFanRemixContestStarted && !IsFanRemixContestEnded && !IsFanRemixContestEndingSoon && !IsArtistRemixContestEnded && !IsArtistRemixContestEndingSoon && !IsArtistRemixContestSubmissions && !IsFanRemixContestWinnersSelected && !IsRemixContestUpdate && !IsFanRemixContestSubmission && IsFanClubTextPost;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Audius.FollowNotification, TResult>? follow = null,
            global::System.Func<global::Audius.SaveNotification, TResult>? save = null,
            global::System.Func<global::Audius.RepostNotification, TResult>? repost = null,
            global::System.Func<global::Audius.RepostOfRepostNotification, TResult>? repostOf = null,
            global::System.Func<global::Audius.SaveOfRepostNotification, TResult>? saveOfRepost = null,
            global::System.Func<global::Audius.TastemakerNotification, TResult>? tastemaker = null,
            global::System.Func<global::Audius.RemixNotification, TResult>? remix = null,
            global::System.Func<global::Audius.CosignNotification, TResult>? cosign = null,
            global::System.Func<global::Audius.CreateNotification, TResult>? create = null,
            global::System.Func<global::Audius.SendTipNotification, TResult>? sendTip = null,
            global::System.Func<global::Audius.ReceiveTipNotification, TResult>? receiveTip = null,
            global::System.Func<global::Audius.SupporterDethronedNotification, TResult>? supporterDethroned = null,
            global::System.Func<global::Audius.SupporterRankUpNotification, TResult>? supporterRankUp1 = null,
            global::System.Func<global::Audius.SupporterRankUpNotification, TResult>? supporterRankUp2 = null,
            global::System.Func<global::Audius.ChallengeRewardNotification, TResult>? challengeReward = null,
            global::System.Func<global::Audius.ClaimableRewardNotification, TResult>? claimableReward = null,
            global::System.Func<global::Audius.ReactionNotification, TResult>? reaction = null,
            global::System.Func<global::Audius.MilestoneNotification, TResult>? milestone = null,
            global::System.Func<global::Audius.TierChangeNotification, TResult>? tierChange = null,
            global::System.Func<global::Audius.TrackAddedToPlaylistNotification, TResult>? trackAddedToPlaylist = null,
            global::System.Func<global::Audius.TrackAddedToPurchasedAlbumNotification, TResult>? trackAddedToPurchasedAlbum = null,
            global::System.Func<global::Audius.UsdcPurchaseSellerNotification, TResult>? usdcPurchaseSeller = null,
            global::System.Func<global::Audius.UsdcPurchaseBuyerNotification, TResult>? usdcPurchaseBuyer = null,
            global::System.Func<global::Audius.RequestManagerNotification, TResult>? requestManager = null,
            global::System.Func<global::Audius.ApproveManagerRequestNotification, TResult>? approveManagerRequest = null,
            global::System.Func<global::Audius.TrendingNotification, TResult>? trending = null,
            global::System.Func<global::Audius.TrendingPlaylistNotification, TResult>? trendingPlaylist = null,
            global::System.Func<global::Audius.TrendingUndergroundNotification, TResult>? trendingUnderground = null,
            global::System.Func<global::Audius.AnnouncementNotification, TResult>? announcement = null,
            global::System.Func<global::Audius.CommentNotification, TResult>? comment = null,
            global::System.Func<global::Audius.CommentThreadNotification, TResult>? commentThread = null,
            global::System.Func<global::Audius.CommentMentionNotification, TResult>? commentMention = null,
            global::System.Func<global::Audius.CommentReactionNotification, TResult>? commentReaction = null,
            global::System.Func<global::Audius.ListenStreakReminderNotification, TResult>? listenStreakReminder = null,
            global::System.Func<global::Audius.FanRemixContestStartedNotification, TResult>? fanRemixContestStarted = null,
            global::System.Func<global::Audius.FanRemixContestEndedNotification, TResult>? fanRemixContestEnded = null,
            global::System.Func<global::Audius.FanRemixContestEndingSoonNotification, TResult>? fanRemixContestEndingSoon = null,
            global::System.Func<global::Audius.ArtistRemixContestEndedNotification, TResult>? artistRemixContestEnded = null,
            global::System.Func<global::Audius.ArtistRemixContestEndingSoonNotification, TResult>? artistRemixContestEndingSoon = null,
            global::System.Func<global::Audius.ArtistRemixContestSubmissionsNotification, TResult>? artistRemixContestSubmissions = null,
            global::System.Func<global::Audius.FanRemixContestWinnersSelectedNotification, TResult>? fanRemixContestWinnersSelected = null,
            global::System.Func<global::Audius.RemixContestUpdateNotification, TResult>? remixContestUpdate = null,
            global::System.Func<global::Audius.FanRemixContestSubmissionNotification, TResult>? fanRemixContestSubmission = null,
            global::System.Func<global::Audius.FanClubTextPostNotification, TResult>? fanClubTextPost = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFollow && follow != null)
            {
                return follow(Follow!);
            }
            else if (IsSave && save != null)
            {
                return save(Save!);
            }
            else if (IsRepost && repost != null)
            {
                return repost(Repost!);
            }
            else if (IsRepostOf && repostOf != null)
            {
                return repostOf(RepostOf!);
            }
            else if (IsSaveOfRepost && saveOfRepost != null)
            {
                return saveOfRepost(SaveOfRepost!);
            }
            else if (IsTastemaker && tastemaker != null)
            {
                return tastemaker(Tastemaker!);
            }
            else if (IsRemix && remix != null)
            {
                return remix(Remix!);
            }
            else if (IsCosign && cosign != null)
            {
                return cosign(Cosign!);
            }
            else if (IsCreate && create != null)
            {
                return create(Create!);
            }
            else if (IsSendTip && sendTip != null)
            {
                return sendTip(SendTip!);
            }
            else if (IsReceiveTip && receiveTip != null)
            {
                return receiveTip(ReceiveTip!);
            }
            else if (IsSupporterDethroned && supporterDethroned != null)
            {
                return supporterDethroned(SupporterDethroned!);
            }
            else if (IsSupporterRankUp1 && supporterRankUp1 != null)
            {
                return supporterRankUp1(SupporterRankUp1!);
            }
            else if (IsSupporterRankUp2 && supporterRankUp2 != null)
            {
                return supporterRankUp2(SupporterRankUp2!);
            }
            else if (IsChallengeReward && challengeReward != null)
            {
                return challengeReward(ChallengeReward!);
            }
            else if (IsClaimableReward && claimableReward != null)
            {
                return claimableReward(ClaimableReward!);
            }
            else if (IsReaction && reaction != null)
            {
                return reaction(Reaction!);
            }
            else if (IsMilestone && milestone != null)
            {
                return milestone(Milestone!);
            }
            else if (IsTierChange && tierChange != null)
            {
                return tierChange(TierChange!);
            }
            else if (IsTrackAddedToPlaylist && trackAddedToPlaylist != null)
            {
                return trackAddedToPlaylist(TrackAddedToPlaylist!);
            }
            else if (IsTrackAddedToPurchasedAlbum && trackAddedToPurchasedAlbum != null)
            {
                return trackAddedToPurchasedAlbum(TrackAddedToPurchasedAlbum!);
            }
            else if (IsUsdcPurchaseSeller && usdcPurchaseSeller != null)
            {
                return usdcPurchaseSeller(UsdcPurchaseSeller!);
            }
            else if (IsUsdcPurchaseBuyer && usdcPurchaseBuyer != null)
            {
                return usdcPurchaseBuyer(UsdcPurchaseBuyer!);
            }
            else if (IsRequestManager && requestManager != null)
            {
                return requestManager(RequestManager!);
            }
            else if (IsApproveManagerRequest && approveManagerRequest != null)
            {
                return approveManagerRequest(ApproveManagerRequest!);
            }
            else if (IsTrending && trending != null)
            {
                return trending(Trending!);
            }
            else if (IsTrendingPlaylist && trendingPlaylist != null)
            {
                return trendingPlaylist(TrendingPlaylist!);
            }
            else if (IsTrendingUnderground && trendingUnderground != null)
            {
                return trendingUnderground(TrendingUnderground!);
            }
            else if (IsAnnouncement && announcement != null)
            {
                return announcement(Announcement!);
            }
            else if (IsComment && comment != null)
            {
                return comment(Comment!);
            }
            else if (IsCommentThread && commentThread != null)
            {
                return commentThread(CommentThread!);
            }
            else if (IsCommentMention && commentMention != null)
            {
                return commentMention(CommentMention!);
            }
            else if (IsCommentReaction && commentReaction != null)
            {
                return commentReaction(CommentReaction!);
            }
            else if (IsListenStreakReminder && listenStreakReminder != null)
            {
                return listenStreakReminder(ListenStreakReminder!);
            }
            else if (IsFanRemixContestStarted && fanRemixContestStarted != null)
            {
                return fanRemixContestStarted(FanRemixContestStarted!);
            }
            else if (IsFanRemixContestEnded && fanRemixContestEnded != null)
            {
                return fanRemixContestEnded(FanRemixContestEnded!);
            }
            else if (IsFanRemixContestEndingSoon && fanRemixContestEndingSoon != null)
            {
                return fanRemixContestEndingSoon(FanRemixContestEndingSoon!);
            }
            else if (IsArtistRemixContestEnded && artistRemixContestEnded != null)
            {
                return artistRemixContestEnded(ArtistRemixContestEnded!);
            }
            else if (IsArtistRemixContestEndingSoon && artistRemixContestEndingSoon != null)
            {
                return artistRemixContestEndingSoon(ArtistRemixContestEndingSoon!);
            }
            else if (IsArtistRemixContestSubmissions && artistRemixContestSubmissions != null)
            {
                return artistRemixContestSubmissions(ArtistRemixContestSubmissions!);
            }
            else if (IsFanRemixContestWinnersSelected && fanRemixContestWinnersSelected != null)
            {
                return fanRemixContestWinnersSelected(FanRemixContestWinnersSelected!);
            }
            else if (IsRemixContestUpdate && remixContestUpdate != null)
            {
                return remixContestUpdate(RemixContestUpdate!);
            }
            else if (IsFanRemixContestSubmission && fanRemixContestSubmission != null)
            {
                return fanRemixContestSubmission(FanRemixContestSubmission!);
            }
            else if (IsFanClubTextPost && fanClubTextPost != null)
            {
                return fanClubTextPost(FanClubTextPost!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Audius.FollowNotification>? follow = null,

            global::System.Action<global::Audius.SaveNotification>? save = null,

            global::System.Action<global::Audius.RepostNotification>? repost = null,

            global::System.Action<global::Audius.RepostOfRepostNotification>? repostOf = null,

            global::System.Action<global::Audius.SaveOfRepostNotification>? saveOfRepost = null,

            global::System.Action<global::Audius.TastemakerNotification>? tastemaker = null,

            global::System.Action<global::Audius.RemixNotification>? remix = null,

            global::System.Action<global::Audius.CosignNotification>? cosign = null,

            global::System.Action<global::Audius.CreateNotification>? create = null,

            global::System.Action<global::Audius.SendTipNotification>? sendTip = null,

            global::System.Action<global::Audius.ReceiveTipNotification>? receiveTip = null,

            global::System.Action<global::Audius.SupporterDethronedNotification>? supporterDethroned = null,

            global::System.Action<global::Audius.SupporterRankUpNotification>? supporterRankUp1 = null,

            global::System.Action<global::Audius.SupporterRankUpNotification>? supporterRankUp2 = null,

            global::System.Action<global::Audius.ChallengeRewardNotification>? challengeReward = null,

            global::System.Action<global::Audius.ClaimableRewardNotification>? claimableReward = null,

            global::System.Action<global::Audius.ReactionNotification>? reaction = null,

            global::System.Action<global::Audius.MilestoneNotification>? milestone = null,

            global::System.Action<global::Audius.TierChangeNotification>? tierChange = null,

            global::System.Action<global::Audius.TrackAddedToPlaylistNotification>? trackAddedToPlaylist = null,

            global::System.Action<global::Audius.TrackAddedToPurchasedAlbumNotification>? trackAddedToPurchasedAlbum = null,

            global::System.Action<global::Audius.UsdcPurchaseSellerNotification>? usdcPurchaseSeller = null,

            global::System.Action<global::Audius.UsdcPurchaseBuyerNotification>? usdcPurchaseBuyer = null,

            global::System.Action<global::Audius.RequestManagerNotification>? requestManager = null,

            global::System.Action<global::Audius.ApproveManagerRequestNotification>? approveManagerRequest = null,

            global::System.Action<global::Audius.TrendingNotification>? trending = null,

            global::System.Action<global::Audius.TrendingPlaylistNotification>? trendingPlaylist = null,

            global::System.Action<global::Audius.TrendingUndergroundNotification>? trendingUnderground = null,

            global::System.Action<global::Audius.AnnouncementNotification>? announcement = null,

            global::System.Action<global::Audius.CommentNotification>? comment = null,

            global::System.Action<global::Audius.CommentThreadNotification>? commentThread = null,

            global::System.Action<global::Audius.CommentMentionNotification>? commentMention = null,

            global::System.Action<global::Audius.CommentReactionNotification>? commentReaction = null,

            global::System.Action<global::Audius.ListenStreakReminderNotification>? listenStreakReminder = null,

            global::System.Action<global::Audius.FanRemixContestStartedNotification>? fanRemixContestStarted = null,

            global::System.Action<global::Audius.FanRemixContestEndedNotification>? fanRemixContestEnded = null,

            global::System.Action<global::Audius.FanRemixContestEndingSoonNotification>? fanRemixContestEndingSoon = null,

            global::System.Action<global::Audius.ArtistRemixContestEndedNotification>? artistRemixContestEnded = null,

            global::System.Action<global::Audius.ArtistRemixContestEndingSoonNotification>? artistRemixContestEndingSoon = null,

            global::System.Action<global::Audius.ArtistRemixContestSubmissionsNotification>? artistRemixContestSubmissions = null,

            global::System.Action<global::Audius.FanRemixContestWinnersSelectedNotification>? fanRemixContestWinnersSelected = null,

            global::System.Action<global::Audius.RemixContestUpdateNotification>? remixContestUpdate = null,

            global::System.Action<global::Audius.FanRemixContestSubmissionNotification>? fanRemixContestSubmission = null,

            global::System.Action<global::Audius.FanClubTextPostNotification>? fanClubTextPost = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFollow)
            {
                follow?.Invoke(Follow!);
            }
            else if (IsSave)
            {
                save?.Invoke(Save!);
            }
            else if (IsRepost)
            {
                repost?.Invoke(Repost!);
            }
            else if (IsRepostOf)
            {
                repostOf?.Invoke(RepostOf!);
            }
            else if (IsSaveOfRepost)
            {
                saveOfRepost?.Invoke(SaveOfRepost!);
            }
            else if (IsTastemaker)
            {
                tastemaker?.Invoke(Tastemaker!);
            }
            else if (IsRemix)
            {
                remix?.Invoke(Remix!);
            }
            else if (IsCosign)
            {
                cosign?.Invoke(Cosign!);
            }
            else if (IsCreate)
            {
                create?.Invoke(Create!);
            }
            else if (IsSendTip)
            {
                sendTip?.Invoke(SendTip!);
            }
            else if (IsReceiveTip)
            {
                receiveTip?.Invoke(ReceiveTip!);
            }
            else if (IsSupporterDethroned)
            {
                supporterDethroned?.Invoke(SupporterDethroned!);
            }
            else if (IsSupporterRankUp1)
            {
                supporterRankUp1?.Invoke(SupporterRankUp1!);
            }
            else if (IsSupporterRankUp2)
            {
                supporterRankUp2?.Invoke(SupporterRankUp2!);
            }
            else if (IsChallengeReward)
            {
                challengeReward?.Invoke(ChallengeReward!);
            }
            else if (IsClaimableReward)
            {
                claimableReward?.Invoke(ClaimableReward!);
            }
            else if (IsReaction)
            {
                reaction?.Invoke(Reaction!);
            }
            else if (IsMilestone)
            {
                milestone?.Invoke(Milestone!);
            }
            else if (IsTierChange)
            {
                tierChange?.Invoke(TierChange!);
            }
            else if (IsTrackAddedToPlaylist)
            {
                trackAddedToPlaylist?.Invoke(TrackAddedToPlaylist!);
            }
            else if (IsTrackAddedToPurchasedAlbum)
            {
                trackAddedToPurchasedAlbum?.Invoke(TrackAddedToPurchasedAlbum!);
            }
            else if (IsUsdcPurchaseSeller)
            {
                usdcPurchaseSeller?.Invoke(UsdcPurchaseSeller!);
            }
            else if (IsUsdcPurchaseBuyer)
            {
                usdcPurchaseBuyer?.Invoke(UsdcPurchaseBuyer!);
            }
            else if (IsRequestManager)
            {
                requestManager?.Invoke(RequestManager!);
            }
            else if (IsApproveManagerRequest)
            {
                approveManagerRequest?.Invoke(ApproveManagerRequest!);
            }
            else if (IsTrending)
            {
                trending?.Invoke(Trending!);
            }
            else if (IsTrendingPlaylist)
            {
                trendingPlaylist?.Invoke(TrendingPlaylist!);
            }
            else if (IsTrendingUnderground)
            {
                trendingUnderground?.Invoke(TrendingUnderground!);
            }
            else if (IsAnnouncement)
            {
                announcement?.Invoke(Announcement!);
            }
            else if (IsComment)
            {
                comment?.Invoke(Comment!);
            }
            else if (IsCommentThread)
            {
                commentThread?.Invoke(CommentThread!);
            }
            else if (IsCommentMention)
            {
                commentMention?.Invoke(CommentMention!);
            }
            else if (IsCommentReaction)
            {
                commentReaction?.Invoke(CommentReaction!);
            }
            else if (IsListenStreakReminder)
            {
                listenStreakReminder?.Invoke(ListenStreakReminder!);
            }
            else if (IsFanRemixContestStarted)
            {
                fanRemixContestStarted?.Invoke(FanRemixContestStarted!);
            }
            else if (IsFanRemixContestEnded)
            {
                fanRemixContestEnded?.Invoke(FanRemixContestEnded!);
            }
            else if (IsFanRemixContestEndingSoon)
            {
                fanRemixContestEndingSoon?.Invoke(FanRemixContestEndingSoon!);
            }
            else if (IsArtistRemixContestEnded)
            {
                artistRemixContestEnded?.Invoke(ArtistRemixContestEnded!);
            }
            else if (IsArtistRemixContestEndingSoon)
            {
                artistRemixContestEndingSoon?.Invoke(ArtistRemixContestEndingSoon!);
            }
            else if (IsArtistRemixContestSubmissions)
            {
                artistRemixContestSubmissions?.Invoke(ArtistRemixContestSubmissions!);
            }
            else if (IsFanRemixContestWinnersSelected)
            {
                fanRemixContestWinnersSelected?.Invoke(FanRemixContestWinnersSelected!);
            }
            else if (IsRemixContestUpdate)
            {
                remixContestUpdate?.Invoke(RemixContestUpdate!);
            }
            else if (IsFanRemixContestSubmission)
            {
                fanRemixContestSubmission?.Invoke(FanRemixContestSubmission!);
            }
            else if (IsFanClubTextPost)
            {
                fanClubTextPost?.Invoke(FanClubTextPost!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Audius.FollowNotification>? follow = null,
            global::System.Action<global::Audius.SaveNotification>? save = null,
            global::System.Action<global::Audius.RepostNotification>? repost = null,
            global::System.Action<global::Audius.RepostOfRepostNotification>? repostOf = null,
            global::System.Action<global::Audius.SaveOfRepostNotification>? saveOfRepost = null,
            global::System.Action<global::Audius.TastemakerNotification>? tastemaker = null,
            global::System.Action<global::Audius.RemixNotification>? remix = null,
            global::System.Action<global::Audius.CosignNotification>? cosign = null,
            global::System.Action<global::Audius.CreateNotification>? create = null,
            global::System.Action<global::Audius.SendTipNotification>? sendTip = null,
            global::System.Action<global::Audius.ReceiveTipNotification>? receiveTip = null,
            global::System.Action<global::Audius.SupporterDethronedNotification>? supporterDethroned = null,
            global::System.Action<global::Audius.SupporterRankUpNotification>? supporterRankUp1 = null,
            global::System.Action<global::Audius.SupporterRankUpNotification>? supporterRankUp2 = null,
            global::System.Action<global::Audius.ChallengeRewardNotification>? challengeReward = null,
            global::System.Action<global::Audius.ClaimableRewardNotification>? claimableReward = null,
            global::System.Action<global::Audius.ReactionNotification>? reaction = null,
            global::System.Action<global::Audius.MilestoneNotification>? milestone = null,
            global::System.Action<global::Audius.TierChangeNotification>? tierChange = null,
            global::System.Action<global::Audius.TrackAddedToPlaylistNotification>? trackAddedToPlaylist = null,
            global::System.Action<global::Audius.TrackAddedToPurchasedAlbumNotification>? trackAddedToPurchasedAlbum = null,
            global::System.Action<global::Audius.UsdcPurchaseSellerNotification>? usdcPurchaseSeller = null,
            global::System.Action<global::Audius.UsdcPurchaseBuyerNotification>? usdcPurchaseBuyer = null,
            global::System.Action<global::Audius.RequestManagerNotification>? requestManager = null,
            global::System.Action<global::Audius.ApproveManagerRequestNotification>? approveManagerRequest = null,
            global::System.Action<global::Audius.TrendingNotification>? trending = null,
            global::System.Action<global::Audius.TrendingPlaylistNotification>? trendingPlaylist = null,
            global::System.Action<global::Audius.TrendingUndergroundNotification>? trendingUnderground = null,
            global::System.Action<global::Audius.AnnouncementNotification>? announcement = null,
            global::System.Action<global::Audius.CommentNotification>? comment = null,
            global::System.Action<global::Audius.CommentThreadNotification>? commentThread = null,
            global::System.Action<global::Audius.CommentMentionNotification>? commentMention = null,
            global::System.Action<global::Audius.CommentReactionNotification>? commentReaction = null,
            global::System.Action<global::Audius.ListenStreakReminderNotification>? listenStreakReminder = null,
            global::System.Action<global::Audius.FanRemixContestStartedNotification>? fanRemixContestStarted = null,
            global::System.Action<global::Audius.FanRemixContestEndedNotification>? fanRemixContestEnded = null,
            global::System.Action<global::Audius.FanRemixContestEndingSoonNotification>? fanRemixContestEndingSoon = null,
            global::System.Action<global::Audius.ArtistRemixContestEndedNotification>? artistRemixContestEnded = null,
            global::System.Action<global::Audius.ArtistRemixContestEndingSoonNotification>? artistRemixContestEndingSoon = null,
            global::System.Action<global::Audius.ArtistRemixContestSubmissionsNotification>? artistRemixContestSubmissions = null,
            global::System.Action<global::Audius.FanRemixContestWinnersSelectedNotification>? fanRemixContestWinnersSelected = null,
            global::System.Action<global::Audius.RemixContestUpdateNotification>? remixContestUpdate = null,
            global::System.Action<global::Audius.FanRemixContestSubmissionNotification>? fanRemixContestSubmission = null,
            global::System.Action<global::Audius.FanClubTextPostNotification>? fanClubTextPost = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFollow)
            {
                follow?.Invoke(Follow!);
            }
            else if (IsSave)
            {
                save?.Invoke(Save!);
            }
            else if (IsRepost)
            {
                repost?.Invoke(Repost!);
            }
            else if (IsRepostOf)
            {
                repostOf?.Invoke(RepostOf!);
            }
            else if (IsSaveOfRepost)
            {
                saveOfRepost?.Invoke(SaveOfRepost!);
            }
            else if (IsTastemaker)
            {
                tastemaker?.Invoke(Tastemaker!);
            }
            else if (IsRemix)
            {
                remix?.Invoke(Remix!);
            }
            else if (IsCosign)
            {
                cosign?.Invoke(Cosign!);
            }
            else if (IsCreate)
            {
                create?.Invoke(Create!);
            }
            else if (IsSendTip)
            {
                sendTip?.Invoke(SendTip!);
            }
            else if (IsReceiveTip)
            {
                receiveTip?.Invoke(ReceiveTip!);
            }
            else if (IsSupporterDethroned)
            {
                supporterDethroned?.Invoke(SupporterDethroned!);
            }
            else if (IsSupporterRankUp1)
            {
                supporterRankUp1?.Invoke(SupporterRankUp1!);
            }
            else if (IsSupporterRankUp2)
            {
                supporterRankUp2?.Invoke(SupporterRankUp2!);
            }
            else if (IsChallengeReward)
            {
                challengeReward?.Invoke(ChallengeReward!);
            }
            else if (IsClaimableReward)
            {
                claimableReward?.Invoke(ClaimableReward!);
            }
            else if (IsReaction)
            {
                reaction?.Invoke(Reaction!);
            }
            else if (IsMilestone)
            {
                milestone?.Invoke(Milestone!);
            }
            else if (IsTierChange)
            {
                tierChange?.Invoke(TierChange!);
            }
            else if (IsTrackAddedToPlaylist)
            {
                trackAddedToPlaylist?.Invoke(TrackAddedToPlaylist!);
            }
            else if (IsTrackAddedToPurchasedAlbum)
            {
                trackAddedToPurchasedAlbum?.Invoke(TrackAddedToPurchasedAlbum!);
            }
            else if (IsUsdcPurchaseSeller)
            {
                usdcPurchaseSeller?.Invoke(UsdcPurchaseSeller!);
            }
            else if (IsUsdcPurchaseBuyer)
            {
                usdcPurchaseBuyer?.Invoke(UsdcPurchaseBuyer!);
            }
            else if (IsRequestManager)
            {
                requestManager?.Invoke(RequestManager!);
            }
            else if (IsApproveManagerRequest)
            {
                approveManagerRequest?.Invoke(ApproveManagerRequest!);
            }
            else if (IsTrending)
            {
                trending?.Invoke(Trending!);
            }
            else if (IsTrendingPlaylist)
            {
                trendingPlaylist?.Invoke(TrendingPlaylist!);
            }
            else if (IsTrendingUnderground)
            {
                trendingUnderground?.Invoke(TrendingUnderground!);
            }
            else if (IsAnnouncement)
            {
                announcement?.Invoke(Announcement!);
            }
            else if (IsComment)
            {
                comment?.Invoke(Comment!);
            }
            else if (IsCommentThread)
            {
                commentThread?.Invoke(CommentThread!);
            }
            else if (IsCommentMention)
            {
                commentMention?.Invoke(CommentMention!);
            }
            else if (IsCommentReaction)
            {
                commentReaction?.Invoke(CommentReaction!);
            }
            else if (IsListenStreakReminder)
            {
                listenStreakReminder?.Invoke(ListenStreakReminder!);
            }
            else if (IsFanRemixContestStarted)
            {
                fanRemixContestStarted?.Invoke(FanRemixContestStarted!);
            }
            else if (IsFanRemixContestEnded)
            {
                fanRemixContestEnded?.Invoke(FanRemixContestEnded!);
            }
            else if (IsFanRemixContestEndingSoon)
            {
                fanRemixContestEndingSoon?.Invoke(FanRemixContestEndingSoon!);
            }
            else if (IsArtistRemixContestEnded)
            {
                artistRemixContestEnded?.Invoke(ArtistRemixContestEnded!);
            }
            else if (IsArtistRemixContestEndingSoon)
            {
                artistRemixContestEndingSoon?.Invoke(ArtistRemixContestEndingSoon!);
            }
            else if (IsArtistRemixContestSubmissions)
            {
                artistRemixContestSubmissions?.Invoke(ArtistRemixContestSubmissions!);
            }
            else if (IsFanRemixContestWinnersSelected)
            {
                fanRemixContestWinnersSelected?.Invoke(FanRemixContestWinnersSelected!);
            }
            else if (IsRemixContestUpdate)
            {
                remixContestUpdate?.Invoke(RemixContestUpdate!);
            }
            else if (IsFanRemixContestSubmission)
            {
                fanRemixContestSubmission?.Invoke(FanRemixContestSubmission!);
            }
            else if (IsFanClubTextPost)
            {
                fanClubTextPost?.Invoke(FanClubTextPost!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Follow,
                typeof(global::Audius.FollowNotification),
                Save,
                typeof(global::Audius.SaveNotification),
                Repost,
                typeof(global::Audius.RepostNotification),
                RepostOf,
                typeof(global::Audius.RepostOfRepostNotification),
                SaveOfRepost,
                typeof(global::Audius.SaveOfRepostNotification),
                Tastemaker,
                typeof(global::Audius.TastemakerNotification),
                Remix,
                typeof(global::Audius.RemixNotification),
                Cosign,
                typeof(global::Audius.CosignNotification),
                Create,
                typeof(global::Audius.CreateNotification),
                SendTip,
                typeof(global::Audius.SendTipNotification),
                ReceiveTip,
                typeof(global::Audius.ReceiveTipNotification),
                SupporterDethroned,
                typeof(global::Audius.SupporterDethronedNotification),
                SupporterRankUp1,
                typeof(global::Audius.SupporterRankUpNotification),
                SupporterRankUp2,
                typeof(global::Audius.SupporterRankUpNotification),
                ChallengeReward,
                typeof(global::Audius.ChallengeRewardNotification),
                ClaimableReward,
                typeof(global::Audius.ClaimableRewardNotification),
                Reaction,
                typeof(global::Audius.ReactionNotification),
                Milestone,
                typeof(global::Audius.MilestoneNotification),
                TierChange,
                typeof(global::Audius.TierChangeNotification),
                TrackAddedToPlaylist,
                typeof(global::Audius.TrackAddedToPlaylistNotification),
                TrackAddedToPurchasedAlbum,
                typeof(global::Audius.TrackAddedToPurchasedAlbumNotification),
                UsdcPurchaseSeller,
                typeof(global::Audius.UsdcPurchaseSellerNotification),
                UsdcPurchaseBuyer,
                typeof(global::Audius.UsdcPurchaseBuyerNotification),
                RequestManager,
                typeof(global::Audius.RequestManagerNotification),
                ApproveManagerRequest,
                typeof(global::Audius.ApproveManagerRequestNotification),
                Trending,
                typeof(global::Audius.TrendingNotification),
                TrendingPlaylist,
                typeof(global::Audius.TrendingPlaylistNotification),
                TrendingUnderground,
                typeof(global::Audius.TrendingUndergroundNotification),
                Announcement,
                typeof(global::Audius.AnnouncementNotification),
                Comment,
                typeof(global::Audius.CommentNotification),
                CommentThread,
                typeof(global::Audius.CommentThreadNotification),
                CommentMention,
                typeof(global::Audius.CommentMentionNotification),
                CommentReaction,
                typeof(global::Audius.CommentReactionNotification),
                ListenStreakReminder,
                typeof(global::Audius.ListenStreakReminderNotification),
                FanRemixContestStarted,
                typeof(global::Audius.FanRemixContestStartedNotification),
                FanRemixContestEnded,
                typeof(global::Audius.FanRemixContestEndedNotification),
                FanRemixContestEndingSoon,
                typeof(global::Audius.FanRemixContestEndingSoonNotification),
                ArtistRemixContestEnded,
                typeof(global::Audius.ArtistRemixContestEndedNotification),
                ArtistRemixContestEndingSoon,
                typeof(global::Audius.ArtistRemixContestEndingSoonNotification),
                ArtistRemixContestSubmissions,
                typeof(global::Audius.ArtistRemixContestSubmissionsNotification),
                FanRemixContestWinnersSelected,
                typeof(global::Audius.FanRemixContestWinnersSelectedNotification),
                RemixContestUpdate,
                typeof(global::Audius.RemixContestUpdateNotification),
                FanRemixContestSubmission,
                typeof(global::Audius.FanRemixContestSubmissionNotification),
                FanClubTextPost,
                typeof(global::Audius.FanClubTextPostNotification),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(Notification other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Audius.FollowNotification?>.Default.Equals(Follow, other.Follow) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.SaveNotification?>.Default.Equals(Save, other.Save) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.RepostNotification?>.Default.Equals(Repost, other.Repost) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.RepostOfRepostNotification?>.Default.Equals(RepostOf, other.RepostOf) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.SaveOfRepostNotification?>.Default.Equals(SaveOfRepost, other.SaveOfRepost) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.TastemakerNotification?>.Default.Equals(Tastemaker, other.Tastemaker) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.RemixNotification?>.Default.Equals(Remix, other.Remix) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.CosignNotification?>.Default.Equals(Cosign, other.Cosign) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.CreateNotification?>.Default.Equals(Create, other.Create) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.SendTipNotification?>.Default.Equals(SendTip, other.SendTip) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.ReceiveTipNotification?>.Default.Equals(ReceiveTip, other.ReceiveTip) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.SupporterDethronedNotification?>.Default.Equals(SupporterDethroned, other.SupporterDethroned) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.SupporterRankUpNotification?>.Default.Equals(SupporterRankUp1, other.SupporterRankUp1) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.SupporterRankUpNotification?>.Default.Equals(SupporterRankUp2, other.SupporterRankUp2) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.ChallengeRewardNotification?>.Default.Equals(ChallengeReward, other.ChallengeReward) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.ClaimableRewardNotification?>.Default.Equals(ClaimableReward, other.ClaimableReward) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.ReactionNotification?>.Default.Equals(Reaction, other.Reaction) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.MilestoneNotification?>.Default.Equals(Milestone, other.Milestone) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.TierChangeNotification?>.Default.Equals(TierChange, other.TierChange) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.TrackAddedToPlaylistNotification?>.Default.Equals(TrackAddedToPlaylist, other.TrackAddedToPlaylist) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.TrackAddedToPurchasedAlbumNotification?>.Default.Equals(TrackAddedToPurchasedAlbum, other.TrackAddedToPurchasedAlbum) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.UsdcPurchaseSellerNotification?>.Default.Equals(UsdcPurchaseSeller, other.UsdcPurchaseSeller) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.UsdcPurchaseBuyerNotification?>.Default.Equals(UsdcPurchaseBuyer, other.UsdcPurchaseBuyer) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.RequestManagerNotification?>.Default.Equals(RequestManager, other.RequestManager) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.ApproveManagerRequestNotification?>.Default.Equals(ApproveManagerRequest, other.ApproveManagerRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.TrendingNotification?>.Default.Equals(Trending, other.Trending) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.TrendingPlaylistNotification?>.Default.Equals(TrendingPlaylist, other.TrendingPlaylist) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.TrendingUndergroundNotification?>.Default.Equals(TrendingUnderground, other.TrendingUnderground) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.AnnouncementNotification?>.Default.Equals(Announcement, other.Announcement) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.CommentNotification?>.Default.Equals(Comment, other.Comment) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.CommentThreadNotification?>.Default.Equals(CommentThread, other.CommentThread) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.CommentMentionNotification?>.Default.Equals(CommentMention, other.CommentMention) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.CommentReactionNotification?>.Default.Equals(CommentReaction, other.CommentReaction) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.ListenStreakReminderNotification?>.Default.Equals(ListenStreakReminder, other.ListenStreakReminder) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.FanRemixContestStartedNotification?>.Default.Equals(FanRemixContestStarted, other.FanRemixContestStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.FanRemixContestEndedNotification?>.Default.Equals(FanRemixContestEnded, other.FanRemixContestEnded) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.FanRemixContestEndingSoonNotification?>.Default.Equals(FanRemixContestEndingSoon, other.FanRemixContestEndingSoon) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.ArtistRemixContestEndedNotification?>.Default.Equals(ArtistRemixContestEnded, other.ArtistRemixContestEnded) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.ArtistRemixContestEndingSoonNotification?>.Default.Equals(ArtistRemixContestEndingSoon, other.ArtistRemixContestEndingSoon) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.ArtistRemixContestSubmissionsNotification?>.Default.Equals(ArtistRemixContestSubmissions, other.ArtistRemixContestSubmissions) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.FanRemixContestWinnersSelectedNotification?>.Default.Equals(FanRemixContestWinnersSelected, other.FanRemixContestWinnersSelected) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.RemixContestUpdateNotification?>.Default.Equals(RemixContestUpdate, other.RemixContestUpdate) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.FanRemixContestSubmissionNotification?>.Default.Equals(FanRemixContestSubmission, other.FanRemixContestSubmission) &&
                global::System.Collections.Generic.EqualityComparer<global::Audius.FanClubTextPostNotification?>.Default.Equals(FanClubTextPost, other.FanClubTextPost)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Notification obj1, Notification obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Notification>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Notification obj1, Notification obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Notification o && Equals(o);
        }
    }
}
