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

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("actions")) __score0++;
            if (__jsonProps.Contains("group_id")) __score0++;
            if (__jsonProps.Contains("is_seen")) __score0++;
            if (__jsonProps.Contains("seen_at")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("actions")) __score1++;
            if (__jsonProps.Contains("group_id")) __score1++;
            if (__jsonProps.Contains("is_seen")) __score1++;
            if (__jsonProps.Contains("seen_at")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("actions")) __score2++;
            if (__jsonProps.Contains("group_id")) __score2++;
            if (__jsonProps.Contains("is_seen")) __score2++;
            if (__jsonProps.Contains("seen_at")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("actions")) __score3++;
            if (__jsonProps.Contains("group_id")) __score3++;
            if (__jsonProps.Contains("is_seen")) __score3++;
            if (__jsonProps.Contains("seen_at")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("actions")) __score4++;
            if (__jsonProps.Contains("group_id")) __score4++;
            if (__jsonProps.Contains("is_seen")) __score4++;
            if (__jsonProps.Contains("seen_at")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("actions")) __score5++;
            if (__jsonProps.Contains("group_id")) __score5++;
            if (__jsonProps.Contains("is_seen")) __score5++;
            if (__jsonProps.Contains("seen_at")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("actions")) __score6++;
            if (__jsonProps.Contains("group_id")) __score6++;
            if (__jsonProps.Contains("is_seen")) __score6++;
            if (__jsonProps.Contains("seen_at")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("actions")) __score7++;
            if (__jsonProps.Contains("group_id")) __score7++;
            if (__jsonProps.Contains("is_seen")) __score7++;
            if (__jsonProps.Contains("seen_at")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("actions")) __score8++;
            if (__jsonProps.Contains("group_id")) __score8++;
            if (__jsonProps.Contains("is_seen")) __score8++;
            if (__jsonProps.Contains("seen_at")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("actions")) __score9++;
            if (__jsonProps.Contains("group_id")) __score9++;
            if (__jsonProps.Contains("is_seen")) __score9++;
            if (__jsonProps.Contains("seen_at")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("actions")) __score10++;
            if (__jsonProps.Contains("group_id")) __score10++;
            if (__jsonProps.Contains("is_seen")) __score10++;
            if (__jsonProps.Contains("seen_at")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("actions")) __score11++;
            if (__jsonProps.Contains("group_id")) __score11++;
            if (__jsonProps.Contains("is_seen")) __score11++;
            if (__jsonProps.Contains("seen_at")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("actions")) __score12++;
            if (__jsonProps.Contains("group_id")) __score12++;
            if (__jsonProps.Contains("is_seen")) __score12++;
            if (__jsonProps.Contains("seen_at")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("actions")) __score13++;
            if (__jsonProps.Contains("group_id")) __score13++;
            if (__jsonProps.Contains("is_seen")) __score13++;
            if (__jsonProps.Contains("seen_at")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("actions")) __score14++;
            if (__jsonProps.Contains("group_id")) __score14++;
            if (__jsonProps.Contains("is_seen")) __score14++;
            if (__jsonProps.Contains("seen_at")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("actions")) __score15++;
            if (__jsonProps.Contains("group_id")) __score15++;
            if (__jsonProps.Contains("is_seen")) __score15++;
            if (__jsonProps.Contains("seen_at")) __score15++;
            if (__jsonProps.Contains("type")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("actions")) __score16++;
            if (__jsonProps.Contains("group_id")) __score16++;
            if (__jsonProps.Contains("is_seen")) __score16++;
            if (__jsonProps.Contains("seen_at")) __score16++;
            if (__jsonProps.Contains("type")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("actions")) __score17++;
            if (__jsonProps.Contains("group_id")) __score17++;
            if (__jsonProps.Contains("is_seen")) __score17++;
            if (__jsonProps.Contains("seen_at")) __score17++;
            if (__jsonProps.Contains("type")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("actions")) __score18++;
            if (__jsonProps.Contains("group_id")) __score18++;
            if (__jsonProps.Contains("is_seen")) __score18++;
            if (__jsonProps.Contains("seen_at")) __score18++;
            if (__jsonProps.Contains("type")) __score18++;
            var __score19 = 0;
            if (__jsonProps.Contains("actions")) __score19++;
            if (__jsonProps.Contains("group_id")) __score19++;
            if (__jsonProps.Contains("is_seen")) __score19++;
            if (__jsonProps.Contains("seen_at")) __score19++;
            if (__jsonProps.Contains("type")) __score19++;
            var __score20 = 0;
            if (__jsonProps.Contains("actions")) __score20++;
            if (__jsonProps.Contains("group_id")) __score20++;
            if (__jsonProps.Contains("is_seen")) __score20++;
            if (__jsonProps.Contains("seen_at")) __score20++;
            if (__jsonProps.Contains("type")) __score20++;
            var __score21 = 0;
            if (__jsonProps.Contains("actions")) __score21++;
            if (__jsonProps.Contains("group_id")) __score21++;
            if (__jsonProps.Contains("is_seen")) __score21++;
            if (__jsonProps.Contains("seen_at")) __score21++;
            if (__jsonProps.Contains("type")) __score21++;
            var __score22 = 0;
            if (__jsonProps.Contains("actions")) __score22++;
            if (__jsonProps.Contains("group_id")) __score22++;
            if (__jsonProps.Contains("is_seen")) __score22++;
            if (__jsonProps.Contains("seen_at")) __score22++;
            if (__jsonProps.Contains("type")) __score22++;
            var __score23 = 0;
            if (__jsonProps.Contains("actions")) __score23++;
            if (__jsonProps.Contains("group_id")) __score23++;
            if (__jsonProps.Contains("is_seen")) __score23++;
            if (__jsonProps.Contains("seen_at")) __score23++;
            if (__jsonProps.Contains("type")) __score23++;
            var __score24 = 0;
            if (__jsonProps.Contains("actions")) __score24++;
            if (__jsonProps.Contains("group_id")) __score24++;
            if (__jsonProps.Contains("is_seen")) __score24++;
            if (__jsonProps.Contains("seen_at")) __score24++;
            if (__jsonProps.Contains("type")) __score24++;
            var __score25 = 0;
            if (__jsonProps.Contains("actions")) __score25++;
            if (__jsonProps.Contains("group_id")) __score25++;
            if (__jsonProps.Contains("is_seen")) __score25++;
            if (__jsonProps.Contains("seen_at")) __score25++;
            if (__jsonProps.Contains("type")) __score25++;
            var __score26 = 0;
            if (__jsonProps.Contains("actions")) __score26++;
            if (__jsonProps.Contains("group_id")) __score26++;
            if (__jsonProps.Contains("is_seen")) __score26++;
            if (__jsonProps.Contains("seen_at")) __score26++;
            if (__jsonProps.Contains("type")) __score26++;
            var __score27 = 0;
            if (__jsonProps.Contains("actions")) __score27++;
            if (__jsonProps.Contains("group_id")) __score27++;
            if (__jsonProps.Contains("is_seen")) __score27++;
            if (__jsonProps.Contains("seen_at")) __score27++;
            if (__jsonProps.Contains("type")) __score27++;
            var __score28 = 0;
            if (__jsonProps.Contains("actions")) __score28++;
            if (__jsonProps.Contains("group_id")) __score28++;
            if (__jsonProps.Contains("is_seen")) __score28++;
            if (__jsonProps.Contains("seen_at")) __score28++;
            if (__jsonProps.Contains("type")) __score28++;
            var __score29 = 0;
            if (__jsonProps.Contains("actions")) __score29++;
            if (__jsonProps.Contains("group_id")) __score29++;
            if (__jsonProps.Contains("is_seen")) __score29++;
            if (__jsonProps.Contains("seen_at")) __score29++;
            if (__jsonProps.Contains("type")) __score29++;
            var __score30 = 0;
            if (__jsonProps.Contains("actions")) __score30++;
            if (__jsonProps.Contains("group_id")) __score30++;
            if (__jsonProps.Contains("is_seen")) __score30++;
            if (__jsonProps.Contains("seen_at")) __score30++;
            if (__jsonProps.Contains("type")) __score30++;
            var __score31 = 0;
            if (__jsonProps.Contains("actions")) __score31++;
            if (__jsonProps.Contains("group_id")) __score31++;
            if (__jsonProps.Contains("is_seen")) __score31++;
            if (__jsonProps.Contains("seen_at")) __score31++;
            if (__jsonProps.Contains("type")) __score31++;
            var __score32 = 0;
            if (__jsonProps.Contains("actions")) __score32++;
            if (__jsonProps.Contains("group_id")) __score32++;
            if (__jsonProps.Contains("is_seen")) __score32++;
            if (__jsonProps.Contains("seen_at")) __score32++;
            if (__jsonProps.Contains("type")) __score32++;
            var __score33 = 0;
            if (__jsonProps.Contains("actions")) __score33++;
            if (__jsonProps.Contains("group_id")) __score33++;
            if (__jsonProps.Contains("is_seen")) __score33++;
            if (__jsonProps.Contains("seen_at")) __score33++;
            if (__jsonProps.Contains("type")) __score33++;
            var __score34 = 0;
            if (__jsonProps.Contains("actions")) __score34++;
            if (__jsonProps.Contains("group_id")) __score34++;
            if (__jsonProps.Contains("is_seen")) __score34++;
            if (__jsonProps.Contains("seen_at")) __score34++;
            if (__jsonProps.Contains("type")) __score34++;
            var __score35 = 0;
            if (__jsonProps.Contains("actions")) __score35++;
            if (__jsonProps.Contains("group_id")) __score35++;
            if (__jsonProps.Contains("is_seen")) __score35++;
            if (__jsonProps.Contains("seen_at")) __score35++;
            if (__jsonProps.Contains("type")) __score35++;
            var __score36 = 0;
            if (__jsonProps.Contains("actions")) __score36++;
            if (__jsonProps.Contains("group_id")) __score36++;
            if (__jsonProps.Contains("is_seen")) __score36++;
            if (__jsonProps.Contains("seen_at")) __score36++;
            if (__jsonProps.Contains("type")) __score36++;
            var __score37 = 0;
            if (__jsonProps.Contains("actions")) __score37++;
            if (__jsonProps.Contains("group_id")) __score37++;
            if (__jsonProps.Contains("is_seen")) __score37++;
            if (__jsonProps.Contains("seen_at")) __score37++;
            if (__jsonProps.Contains("type")) __score37++;
            var __score38 = 0;
            if (__jsonProps.Contains("actions")) __score38++;
            if (__jsonProps.Contains("group_id")) __score38++;
            if (__jsonProps.Contains("is_seen")) __score38++;
            if (__jsonProps.Contains("seen_at")) __score38++;
            if (__jsonProps.Contains("type")) __score38++;
            var __score39 = 0;
            if (__jsonProps.Contains("actions")) __score39++;
            if (__jsonProps.Contains("group_id")) __score39++;
            if (__jsonProps.Contains("is_seen")) __score39++;
            if (__jsonProps.Contains("seen_at")) __score39++;
            if (__jsonProps.Contains("type")) __score39++;
            var __score40 = 0;
            if (__jsonProps.Contains("actions")) __score40++;
            if (__jsonProps.Contains("group_id")) __score40++;
            if (__jsonProps.Contains("is_seen")) __score40++;
            if (__jsonProps.Contains("seen_at")) __score40++;
            if (__jsonProps.Contains("type")) __score40++;
            var __score41 = 0;
            if (__jsonProps.Contains("actions")) __score41++;
            if (__jsonProps.Contains("group_id")) __score41++;
            if (__jsonProps.Contains("is_seen")) __score41++;
            if (__jsonProps.Contains("seen_at")) __score41++;
            if (__jsonProps.Contains("type")) __score41++;
            var __score42 = 0;
            if (__jsonProps.Contains("actions")) __score42++;
            if (__jsonProps.Contains("group_id")) __score42++;
            if (__jsonProps.Contains("is_seen")) __score42++;
            if (__jsonProps.Contains("seen_at")) __score42++;
            if (__jsonProps.Contains("type")) __score42++;
            var __score43 = 0;
            if (__jsonProps.Contains("actions")) __score43++;
            if (__jsonProps.Contains("group_id")) __score43++;
            if (__jsonProps.Contains("is_seen")) __score43++;
            if (__jsonProps.Contains("seen_at")) __score43++;
            if (__jsonProps.Contains("type")) __score43++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }
            if (__score14 > __bestScore) { __bestScore = __score14; __bestIndex = 14; }
            if (__score15 > __bestScore) { __bestScore = __score15; __bestIndex = 15; }
            if (__score16 > __bestScore) { __bestScore = __score16; __bestIndex = 16; }
            if (__score17 > __bestScore) { __bestScore = __score17; __bestIndex = 17; }
            if (__score18 > __bestScore) { __bestScore = __score18; __bestIndex = 18; }
            if (__score19 > __bestScore) { __bestScore = __score19; __bestIndex = 19; }
            if (__score20 > __bestScore) { __bestScore = __score20; __bestIndex = 20; }
            if (__score21 > __bestScore) { __bestScore = __score21; __bestIndex = 21; }
            if (__score22 > __bestScore) { __bestScore = __score22; __bestIndex = 22; }
            if (__score23 > __bestScore) { __bestScore = __score23; __bestIndex = 23; }
            if (__score24 > __bestScore) { __bestScore = __score24; __bestIndex = 24; }
            if (__score25 > __bestScore) { __bestScore = __score25; __bestIndex = 25; }
            if (__score26 > __bestScore) { __bestScore = __score26; __bestIndex = 26; }
            if (__score27 > __bestScore) { __bestScore = __score27; __bestIndex = 27; }
            if (__score28 > __bestScore) { __bestScore = __score28; __bestIndex = 28; }
            if (__score29 > __bestScore) { __bestScore = __score29; __bestIndex = 29; }
            if (__score30 > __bestScore) { __bestScore = __score30; __bestIndex = 30; }
            if (__score31 > __bestScore) { __bestScore = __score31; __bestIndex = 31; }
            if (__score32 > __bestScore) { __bestScore = __score32; __bestIndex = 32; }
            if (__score33 > __bestScore) { __bestScore = __score33; __bestIndex = 33; }
            if (__score34 > __bestScore) { __bestScore = __score34; __bestIndex = 34; }
            if (__score35 > __bestScore) { __bestScore = __score35; __bestIndex = 35; }
            if (__score36 > __bestScore) { __bestScore = __score36; __bestIndex = 36; }
            if (__score37 > __bestScore) { __bestScore = __score37; __bestIndex = 37; }
            if (__score38 > __bestScore) { __bestScore = __score38; __bestIndex = 38; }
            if (__score39 > __bestScore) { __bestScore = __score39; __bestIndex = 39; }
            if (__score40 > __bestScore) { __bestScore = __score40; __bestIndex = 40; }
            if (__score41 > __bestScore) { __bestScore = __score41; __bestIndex = 41; }
            if (__score42 > __bestScore) { __bestScore = __score42; __bestIndex = 42; }
            if (__score43 > __bestScore) { __bestScore = __score43; __bestIndex = 43; }

            global::Audius.FollowNotification? follow = default;
            global::Audius.SaveNotification? save = default;
            global::Audius.RepostNotification? repost = default;
            global::Audius.RepostOfRepostNotification? repostOf = default;
            global::Audius.SaveOfRepostNotification? saveOfRepost = default;
            global::Audius.TastemakerNotification? tastemaker = default;
            global::Audius.RemixNotification? remix = default;
            global::Audius.CosignNotification? cosign = default;
            global::Audius.CreateNotification? create = default;
            global::Audius.SendTipNotification? sendTip = default;
            global::Audius.ReceiveTipNotification? receiveTip = default;
            global::Audius.SupporterDethronedNotification? supporterDethroned = default;
            global::Audius.SupporterRankUpNotification? supporterRankUp1 = default;
            global::Audius.SupporterRankUpNotification? supporterRankUp2 = default;
            global::Audius.ChallengeRewardNotification? challengeReward = default;
            global::Audius.ClaimableRewardNotification? claimableReward = default;
            global::Audius.ReactionNotification? reaction = default;
            global::Audius.MilestoneNotification? milestone = default;
            global::Audius.TierChangeNotification? tierChange = default;
            global::Audius.TrackAddedToPlaylistNotification? trackAddedToPlaylist = default;
            global::Audius.TrackAddedToPurchasedAlbumNotification? trackAddedToPurchasedAlbum = default;
            global::Audius.UsdcPurchaseSellerNotification? usdcPurchaseSeller = default;
            global::Audius.UsdcPurchaseBuyerNotification? usdcPurchaseBuyer = default;
            global::Audius.RequestManagerNotification? requestManager = default;
            global::Audius.ApproveManagerRequestNotification? approveManagerRequest = default;
            global::Audius.TrendingNotification? trending = default;
            global::Audius.TrendingPlaylistNotification? trendingPlaylist = default;
            global::Audius.TrendingUndergroundNotification? trendingUnderground = default;
            global::Audius.AnnouncementNotification? announcement = default;
            global::Audius.CommentNotification? comment = default;
            global::Audius.CommentThreadNotification? commentThread = default;
            global::Audius.CommentMentionNotification? commentMention = default;
            global::Audius.CommentReactionNotification? commentReaction = default;
            global::Audius.ListenStreakReminderNotification? listenStreakReminder = default;
            global::Audius.FanRemixContestStartedNotification? fanRemixContestStarted = default;
            global::Audius.FanRemixContestEndedNotification? fanRemixContestEnded = default;
            global::Audius.FanRemixContestEndingSoonNotification? fanRemixContestEndingSoon = default;
            global::Audius.ArtistRemixContestEndedNotification? artistRemixContestEnded = default;
            global::Audius.ArtistRemixContestEndingSoonNotification? artistRemixContestEndingSoon = default;
            global::Audius.ArtistRemixContestSubmissionsNotification? artistRemixContestSubmissions = default;
            global::Audius.FanRemixContestWinnersSelectedNotification? fanRemixContestWinnersSelected = default;
            global::Audius.RemixContestUpdateNotification? remixContestUpdate = default;
            global::Audius.FanRemixContestSubmissionNotification? fanRemixContestSubmission = default;
            global::Audius.FanClubTextPostNotification? fanClubTextPost = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FollowNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FollowNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FollowNotification).Name}");
                        follow = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SaveNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SaveNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.SaveNotification).Name}");
                        save = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RepostNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RepostNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.RepostNotification).Name}");
                        repost = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RepostOfRepostNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RepostOfRepostNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.RepostOfRepostNotification).Name}");
                        repostOf = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SaveOfRepostNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SaveOfRepostNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.SaveOfRepostNotification).Name}");
                        saveOfRepost = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TastemakerNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TastemakerNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TastemakerNotification).Name}");
                        tastemaker = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RemixNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RemixNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.RemixNotification).Name}");
                        remix = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CosignNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CosignNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.CosignNotification).Name}");
                        cosign = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CreateNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CreateNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.CreateNotification).Name}");
                        create = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SendTipNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SendTipNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.SendTipNotification).Name}");
                        sendTip = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ReceiveTipNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ReceiveTipNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ReceiveTipNotification).Name}");
                        receiveTip = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SupporterDethronedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SupporterDethronedNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.SupporterDethronedNotification).Name}");
                        supporterDethroned = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SupporterRankUpNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SupporterRankUpNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.SupporterRankUpNotification).Name}");
                        supporterRankUp1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 13)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SupporterRankUpNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SupporterRankUpNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.SupporterRankUpNotification).Name}");
                        supporterRankUp2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 14)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ChallengeRewardNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ChallengeRewardNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ChallengeRewardNotification).Name}");
                        challengeReward = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 15)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ClaimableRewardNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ClaimableRewardNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ClaimableRewardNotification).Name}");
                        claimableReward = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 16)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ReactionNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ReactionNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ReactionNotification).Name}");
                        reaction = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 17)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.MilestoneNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.MilestoneNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.MilestoneNotification).Name}");
                        milestone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 18)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TierChangeNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TierChangeNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TierChangeNotification).Name}");
                        tierChange = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 19)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrackAddedToPlaylistNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrackAddedToPlaylistNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TrackAddedToPlaylistNotification).Name}");
                        trackAddedToPlaylist = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 20)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrackAddedToPurchasedAlbumNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrackAddedToPurchasedAlbumNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TrackAddedToPurchasedAlbumNotification).Name}");
                        trackAddedToPurchasedAlbum = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 21)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.UsdcPurchaseSellerNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.UsdcPurchaseSellerNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.UsdcPurchaseSellerNotification).Name}");
                        usdcPurchaseSeller = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 22)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.UsdcPurchaseBuyerNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.UsdcPurchaseBuyerNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.UsdcPurchaseBuyerNotification).Name}");
                        usdcPurchaseBuyer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 23)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RequestManagerNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RequestManagerNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.RequestManagerNotification).Name}");
                        requestManager = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 24)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ApproveManagerRequestNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ApproveManagerRequestNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ApproveManagerRequestNotification).Name}");
                        approveManagerRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 25)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrendingNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrendingNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TrendingNotification).Name}");
                        trending = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 26)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrendingPlaylistNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrendingPlaylistNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TrendingPlaylistNotification).Name}");
                        trendingPlaylist = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 27)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrendingUndergroundNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrendingUndergroundNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TrendingUndergroundNotification).Name}");
                        trendingUnderground = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 28)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.AnnouncementNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.AnnouncementNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.AnnouncementNotification).Name}");
                        announcement = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 29)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CommentNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CommentNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.CommentNotification).Name}");
                        comment = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 30)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CommentThreadNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CommentThreadNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.CommentThreadNotification).Name}");
                        commentThread = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 31)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CommentMentionNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CommentMentionNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.CommentMentionNotification).Name}");
                        commentMention = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 32)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CommentReactionNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CommentReactionNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.CommentReactionNotification).Name}");
                        commentReaction = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 33)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ListenStreakReminderNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ListenStreakReminderNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ListenStreakReminderNotification).Name}");
                        listenStreakReminder = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 34)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestStartedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestStartedNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FanRemixContestStartedNotification).Name}");
                        fanRemixContestStarted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 35)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestEndedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestEndedNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FanRemixContestEndedNotification).Name}");
                        fanRemixContestEnded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 36)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestEndingSoonNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestEndingSoonNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FanRemixContestEndingSoonNotification).Name}");
                        fanRemixContestEndingSoon = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 37)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ArtistRemixContestEndedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ArtistRemixContestEndedNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ArtistRemixContestEndedNotification).Name}");
                        artistRemixContestEnded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 38)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ArtistRemixContestEndingSoonNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ArtistRemixContestEndingSoonNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ArtistRemixContestEndingSoonNotification).Name}");
                        artistRemixContestEndingSoon = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 39)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ArtistRemixContestSubmissionsNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ArtistRemixContestSubmissionsNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ArtistRemixContestSubmissionsNotification).Name}");
                        artistRemixContestSubmissions = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 40)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestWinnersSelectedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestWinnersSelectedNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FanRemixContestWinnersSelectedNotification).Name}");
                        fanRemixContestWinnersSelected = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 41)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RemixContestUpdateNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RemixContestUpdateNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.RemixContestUpdateNotification).Name}");
                        remixContestUpdate = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 42)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestSubmissionNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestSubmissionNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FanRemixContestSubmissionNotification).Name}");
                        fanRemixContestSubmission = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 43)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanClubTextPostNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanClubTextPostNotification> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FanClubTextPostNotification).Name}");
                        fanClubTextPost = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FollowNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FollowNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FollowNotification).Name}");
                    follow = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SaveNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SaveNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.SaveNotification).Name}");
                    save = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RepostNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RepostNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.RepostNotification).Name}");
                    repost = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RepostOfRepostNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RepostOfRepostNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.RepostOfRepostNotification).Name}");
                    repostOf = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SaveOfRepostNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SaveOfRepostNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.SaveOfRepostNotification).Name}");
                    saveOfRepost = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TastemakerNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TastemakerNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TastemakerNotification).Name}");
                    tastemaker = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RemixNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RemixNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.RemixNotification).Name}");
                    remix = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CosignNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CosignNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.CosignNotification).Name}");
                    cosign = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CreateNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CreateNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.CreateNotification).Name}");
                    create = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SendTipNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SendTipNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.SendTipNotification).Name}");
                    sendTip = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ReceiveTipNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ReceiveTipNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ReceiveTipNotification).Name}");
                    receiveTip = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SupporterDethronedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SupporterDethronedNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.SupporterDethronedNotification).Name}");
                    supporterDethroned = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SupporterRankUpNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SupporterRankUpNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.SupporterRankUpNotification).Name}");
                    supporterRankUp1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SupporterRankUpNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SupporterRankUpNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.SupporterRankUpNotification).Name}");
                    supporterRankUp2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ChallengeRewardNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ChallengeRewardNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ChallengeRewardNotification).Name}");
                    challengeReward = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ClaimableRewardNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ClaimableRewardNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ClaimableRewardNotification).Name}");
                    claimableReward = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ReactionNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ReactionNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ReactionNotification).Name}");
                    reaction = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.MilestoneNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.MilestoneNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.MilestoneNotification).Name}");
                    milestone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TierChangeNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TierChangeNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TierChangeNotification).Name}");
                    tierChange = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrackAddedToPlaylistNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrackAddedToPlaylistNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TrackAddedToPlaylistNotification).Name}");
                    trackAddedToPlaylist = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrackAddedToPurchasedAlbumNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrackAddedToPurchasedAlbumNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TrackAddedToPurchasedAlbumNotification).Name}");
                    trackAddedToPurchasedAlbum = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.UsdcPurchaseSellerNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.UsdcPurchaseSellerNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.UsdcPurchaseSellerNotification).Name}");
                    usdcPurchaseSeller = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.UsdcPurchaseBuyerNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.UsdcPurchaseBuyerNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.UsdcPurchaseBuyerNotification).Name}");
                    usdcPurchaseBuyer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RequestManagerNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RequestManagerNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.RequestManagerNotification).Name}");
                    requestManager = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ApproveManagerRequestNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ApproveManagerRequestNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ApproveManagerRequestNotification).Name}");
                    approveManagerRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrendingNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrendingNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TrendingNotification).Name}");
                    trending = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrendingPlaylistNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrendingPlaylistNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TrendingPlaylistNotification).Name}");
                    trendingPlaylist = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrendingUndergroundNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrendingUndergroundNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TrendingUndergroundNotification).Name}");
                    trendingUnderground = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.AnnouncementNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.AnnouncementNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.AnnouncementNotification).Name}");
                    announcement = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CommentNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CommentNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.CommentNotification).Name}");
                    comment = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CommentThreadNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CommentThreadNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.CommentThreadNotification).Name}");
                    commentThread = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CommentMentionNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CommentMentionNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.CommentMentionNotification).Name}");
                    commentMention = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CommentReactionNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CommentReactionNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.CommentReactionNotification).Name}");
                    commentReaction = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ListenStreakReminderNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ListenStreakReminderNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ListenStreakReminderNotification).Name}");
                    listenStreakReminder = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestStartedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestStartedNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FanRemixContestStartedNotification).Name}");
                    fanRemixContestStarted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestEndedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestEndedNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FanRemixContestEndedNotification).Name}");
                    fanRemixContestEnded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestEndingSoonNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestEndingSoonNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FanRemixContestEndingSoonNotification).Name}");
                    fanRemixContestEndingSoon = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ArtistRemixContestEndedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ArtistRemixContestEndedNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ArtistRemixContestEndedNotification).Name}");
                    artistRemixContestEnded = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ArtistRemixContestEndingSoonNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ArtistRemixContestEndingSoonNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ArtistRemixContestEndingSoonNotification).Name}");
                    artistRemixContestEndingSoon = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ArtistRemixContestSubmissionsNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ArtistRemixContestSubmissionsNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ArtistRemixContestSubmissionsNotification).Name}");
                    artistRemixContestSubmissions = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestWinnersSelectedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestWinnersSelectedNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FanRemixContestWinnersSelectedNotification).Name}");
                    fanRemixContestWinnersSelected = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RemixContestUpdateNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RemixContestUpdateNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.RemixContestUpdateNotification).Name}");
                    remixContestUpdate = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestSubmissionNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestSubmissionNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FanRemixContestSubmissionNotification).Name}");
                    fanRemixContestSubmission = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (follow == null && save == null && repost == null && repostOf == null && saveOfRepost == null && tastemaker == null && remix == null && cosign == null && create == null && sendTip == null && receiveTip == null && supporterDethroned == null && supporterRankUp1 == null && supporterRankUp2 == null && challengeReward == null && claimableReward == null && reaction == null && milestone == null && tierChange == null && trackAddedToPlaylist == null && trackAddedToPurchasedAlbum == null && usdcPurchaseSeller == null && usdcPurchaseBuyer == null && requestManager == null && approveManagerRequest == null && trending == null && trendingPlaylist == null && trendingUnderground == null && announcement == null && comment == null && commentThread == null && commentMention == null && commentReaction == null && listenStreakReminder == null && fanRemixContestStarted == null && fanRemixContestEnded == null && fanRemixContestEndingSoon == null && artistRemixContestEnded == null && artistRemixContestEndingSoon == null && artistRemixContestSubmissions == null && fanRemixContestWinnersSelected == null && remixContestUpdate == null && fanRemixContestSubmission == null && fanClubTextPost == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanClubTextPostNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanClubTextPostNotification> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FanClubTextPostNotification).Name}");
                    fanClubTextPost = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Audius.Notification(
                follow,

                save,

                repost,

                repostOf,

                saveOfRepost,

                tastemaker,

                remix,

                cosign,

                create,

                sendTip,

                receiveTip,

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
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Follow!, typeInfo);
            }
            else if (value.IsSave)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SaveNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SaveNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.SaveNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Save!, typeInfo);
            }
            else if (value.IsRepost)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RepostNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RepostNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.RepostNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Repost!, typeInfo);
            }
            else if (value.IsRepostOf)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RepostOfRepostNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RepostOfRepostNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.RepostOfRepostNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RepostOf!, typeInfo);
            }
            else if (value.IsSaveOfRepost)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SaveOfRepostNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SaveOfRepostNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.SaveOfRepostNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SaveOfRepost!, typeInfo);
            }
            else if (value.IsTastemaker)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TastemakerNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TastemakerNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TastemakerNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tastemaker!, typeInfo);
            }
            else if (value.IsRemix)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RemixNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RemixNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.RemixNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Remix!, typeInfo);
            }
            else if (value.IsCosign)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CosignNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CosignNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.CosignNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cosign!, typeInfo);
            }
            else if (value.IsCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CreateNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CreateNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.CreateNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Create!, typeInfo);
            }
            else if (value.IsSendTip)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SendTipNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SendTipNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.SendTipNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SendTip!, typeInfo);
            }
            else if (value.IsReceiveTip)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ReceiveTipNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ReceiveTipNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ReceiveTipNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReceiveTip!, typeInfo);
            }
            else if (value.IsSupporterDethroned)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SupporterDethronedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SupporterDethronedNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.SupporterDethronedNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SupporterDethroned!, typeInfo);
            }
            else if (value.IsSupporterRankUp1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SupporterRankUpNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SupporterRankUpNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.SupporterRankUpNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SupporterRankUp1!, typeInfo);
            }
            else if (value.IsSupporterRankUp2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.SupporterRankUpNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.SupporterRankUpNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.SupporterRankUpNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SupporterRankUp2!, typeInfo);
            }
            else if (value.IsChallengeReward)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ChallengeRewardNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ChallengeRewardNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ChallengeRewardNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChallengeReward!, typeInfo);
            }
            else if (value.IsClaimableReward)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ClaimableRewardNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ClaimableRewardNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ClaimableRewardNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ClaimableReward!, typeInfo);
            }
            else if (value.IsReaction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ReactionNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ReactionNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ReactionNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Reaction!, typeInfo);
            }
            else if (value.IsMilestone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.MilestoneNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.MilestoneNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.MilestoneNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Milestone!, typeInfo);
            }
            else if (value.IsTierChange)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TierChangeNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TierChangeNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TierChangeNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TierChange!, typeInfo);
            }
            else if (value.IsTrackAddedToPlaylist)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrackAddedToPlaylistNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrackAddedToPlaylistNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TrackAddedToPlaylistNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TrackAddedToPlaylist!, typeInfo);
            }
            else if (value.IsTrackAddedToPurchasedAlbum)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrackAddedToPurchasedAlbumNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrackAddedToPurchasedAlbumNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TrackAddedToPurchasedAlbumNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TrackAddedToPurchasedAlbum!, typeInfo);
            }
            else if (value.IsUsdcPurchaseSeller)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.UsdcPurchaseSellerNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.UsdcPurchaseSellerNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.UsdcPurchaseSellerNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UsdcPurchaseSeller!, typeInfo);
            }
            else if (value.IsUsdcPurchaseBuyer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.UsdcPurchaseBuyerNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.UsdcPurchaseBuyerNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.UsdcPurchaseBuyerNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UsdcPurchaseBuyer!, typeInfo);
            }
            else if (value.IsRequestManager)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RequestManagerNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RequestManagerNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.RequestManagerNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequestManager!, typeInfo);
            }
            else if (value.IsApproveManagerRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ApproveManagerRequestNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ApproveManagerRequestNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ApproveManagerRequestNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApproveManagerRequest!, typeInfo);
            }
            else if (value.IsTrending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrendingNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrendingNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TrendingNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Trending!, typeInfo);
            }
            else if (value.IsTrendingPlaylist)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrendingPlaylistNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrendingPlaylistNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TrendingPlaylistNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TrendingPlaylist!, typeInfo);
            }
            else if (value.IsTrendingUnderground)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrendingUndergroundNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrendingUndergroundNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TrendingUndergroundNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TrendingUnderground!, typeInfo);
            }
            else if (value.IsAnnouncement)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.AnnouncementNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.AnnouncementNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.AnnouncementNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Announcement!, typeInfo);
            }
            else if (value.IsComment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CommentNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CommentNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.CommentNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Comment!, typeInfo);
            }
            else if (value.IsCommentThread)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CommentThreadNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CommentThreadNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.CommentThreadNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommentThread!, typeInfo);
            }
            else if (value.IsCommentMention)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CommentMentionNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CommentMentionNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.CommentMentionNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommentMention!, typeInfo);
            }
            else if (value.IsCommentReaction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.CommentReactionNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.CommentReactionNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.CommentReactionNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommentReaction!, typeInfo);
            }
            else if (value.IsListenStreakReminder)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ListenStreakReminderNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ListenStreakReminderNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ListenStreakReminderNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ListenStreakReminder!, typeInfo);
            }
            else if (value.IsFanRemixContestStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestStartedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestStartedNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FanRemixContestStartedNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FanRemixContestStarted!, typeInfo);
            }
            else if (value.IsFanRemixContestEnded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestEndedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestEndedNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FanRemixContestEndedNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FanRemixContestEnded!, typeInfo);
            }
            else if (value.IsFanRemixContestEndingSoon)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestEndingSoonNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestEndingSoonNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FanRemixContestEndingSoonNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FanRemixContestEndingSoon!, typeInfo);
            }
            else if (value.IsArtistRemixContestEnded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ArtistRemixContestEndedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ArtistRemixContestEndedNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ArtistRemixContestEndedNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArtistRemixContestEnded!, typeInfo);
            }
            else if (value.IsArtistRemixContestEndingSoon)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ArtistRemixContestEndingSoonNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ArtistRemixContestEndingSoonNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ArtistRemixContestEndingSoonNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArtistRemixContestEndingSoon!, typeInfo);
            }
            else if (value.IsArtistRemixContestSubmissions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.ArtistRemixContestSubmissionsNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.ArtistRemixContestSubmissionsNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.ArtistRemixContestSubmissionsNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArtistRemixContestSubmissions!, typeInfo);
            }
            else if (value.IsFanRemixContestWinnersSelected)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestWinnersSelectedNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestWinnersSelectedNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FanRemixContestWinnersSelectedNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FanRemixContestWinnersSelected!, typeInfo);
            }
            else if (value.IsRemixContestUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.RemixContestUpdateNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.RemixContestUpdateNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.RemixContestUpdateNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RemixContestUpdate!, typeInfo);
            }
            else if (value.IsFanRemixContestSubmission)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanRemixContestSubmissionNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanRemixContestSubmissionNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FanRemixContestSubmissionNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FanRemixContestSubmission!, typeInfo);
            }
            else if (value.IsFanClubTextPost)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.FanClubTextPostNotification), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.FanClubTextPostNotification?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.FanClubTextPostNotification).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FanClubTextPost!, typeInfo);
            }
        }
    }
}