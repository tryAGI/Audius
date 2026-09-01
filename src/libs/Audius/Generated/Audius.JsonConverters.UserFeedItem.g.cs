#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Audius.JsonConverters
{
    /// <inheritdoc />
    public class UserFeedItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Audius.UserFeedItem>
    {
        /// <inheritdoc />
        public override global::Audius.UserFeedItem Read(
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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("item")) __score0++;
            if (__jsonProps.Contains("item.access")) __score0++;
            if (__jsonProps.Contains("item.access_authorities")) __score0++;
            if (__jsonProps.Contains("item.ai_attribution_user_id")) __score0++;
            if (__jsonProps.Contains("item.album_backlink")) __score0++;
            if (__jsonProps.Contains("item.allowed_api_keys")) __score0++;
            if (__jsonProps.Contains("item.artists")) __score0++;
            if (__jsonProps.Contains("item.artwork")) __score0++;
            if (__jsonProps.Contains("item.audio_analysis_error_count")) __score0++;
            if (__jsonProps.Contains("item.audio_upload_id")) __score0++;
            if (__jsonProps.Contains("item.blocknumber")) __score0++;
            if (__jsonProps.Contains("item.bpm")) __score0++;
            if (__jsonProps.Contains("item.comment_count")) __score0++;
            if (__jsonProps.Contains("item.comments_disabled")) __score0++;
            if (__jsonProps.Contains("item.copyright_line")) __score0++;
            if (__jsonProps.Contains("item.cover_art")) __score0++;
            if (__jsonProps.Contains("item.cover_art_cids")) __score0++;
            if (__jsonProps.Contains("item.cover_art_sizes")) __score0++;
            if (__jsonProps.Contains("item.cover_original_artist")) __score0++;
            if (__jsonProps.Contains("item.cover_original_song_title")) __score0++;
            if (__jsonProps.Contains("item.create_date")) __score0++;
            if (__jsonProps.Contains("item.created_at")) __score0++;
            if (__jsonProps.Contains("item.credits_splits")) __score0++;
            if (__jsonProps.Contains("item.ddex_app")) __score0++;
            if (__jsonProps.Contains("item.ddex_release_ids")) __score0++;
            if (__jsonProps.Contains("item.description")) __score0++;
            if (__jsonProps.Contains("item.download")) __score0++;
            if (__jsonProps.Contains("item.download_conditions")) __score0++;
            if (__jsonProps.Contains("item.duration")) __score0++;
            if (__jsonProps.Contains("item.favorite_count")) __score0++;
            if (__jsonProps.Contains("item.field_visibility")) __score0++;
            if (__jsonProps.Contains("item.followee_favorites")) __score0++;
            if (__jsonProps.Contains("item.followee_reposts")) __score0++;
            if (__jsonProps.Contains("item.genre")) __score0++;
            if (__jsonProps.Contains("item.has_current_user_reposted")) __score0++;
            if (__jsonProps.Contains("item.has_current_user_saved")) __score0++;
            if (__jsonProps.Contains("item.id")) __score0++;
            if (__jsonProps.Contains("item.indirect_resource_contributors")) __score0++;
            if (__jsonProps.Contains("item.is_available")) __score0++;
            if (__jsonProps.Contains("item.is_custom_bpm")) __score0++;
            if (__jsonProps.Contains("item.is_custom_musical_key")) __score0++;
            if (__jsonProps.Contains("item.is_delete")) __score0++;
            if (__jsonProps.Contains("item.is_download_gated")) __score0++;
            if (__jsonProps.Contains("item.is_downloadable")) __score0++;
            if (__jsonProps.Contains("item.is_original_available")) __score0++;
            if (__jsonProps.Contains("item.is_owned_by_user")) __score0++;
            if (__jsonProps.Contains("item.is_scheduled_release")) __score0++;
            if (__jsonProps.Contains("item.is_stream_gated")) __score0++;
            if (__jsonProps.Contains("item.is_streamable")) __score0++;
            if (__jsonProps.Contains("item.is_unlisted")) __score0++;
            if (__jsonProps.Contains("item.isrc")) __score0++;
            if (__jsonProps.Contains("item.iswc")) __score0++;
            if (__jsonProps.Contains("item.license")) __score0++;
            if (__jsonProps.Contains("item.mood")) __score0++;
            if (__jsonProps.Contains("item.musical_key")) __score0++;
            if (__jsonProps.Contains("item.orig_file_cid")) __score0++;
            if (__jsonProps.Contains("item.orig_filename")) __score0++;
            if (__jsonProps.Contains("item.parental_warning_type")) __score0++;
            if (__jsonProps.Contains("item.permalink")) __score0++;
            if (__jsonProps.Contains("item.pinned_comment_id")) __score0++;
            if (__jsonProps.Contains("item.play_count")) __score0++;
            if (__jsonProps.Contains("item.playlists_containing_track")) __score0++;
            if (__jsonProps.Contains("item.preview")) __score0++;
            if (__jsonProps.Contains("item.preview_cid")) __score0++;
            if (__jsonProps.Contains("item.preview_start_seconds")) __score0++;
            if (__jsonProps.Contains("item.producer_copyright_line")) __score0++;
            if (__jsonProps.Contains("item.release_date")) __score0++;
            if (__jsonProps.Contains("item.remix_of")) __score0++;
            if (__jsonProps.Contains("item.repost_count")) __score0++;
            if (__jsonProps.Contains("item.resource_contributors")) __score0++;
            if (__jsonProps.Contains("item.rights_controller")) __score0++;
            if (__jsonProps.Contains("item.route_id")) __score0++;
            if (__jsonProps.Contains("item.stem_of")) __score0++;
            if (__jsonProps.Contains("item.stream")) __score0++;
            if (__jsonProps.Contains("item.stream_conditions")) __score0++;
            if (__jsonProps.Contains("item.tags")) __score0++;
            if (__jsonProps.Contains("item.title")) __score0++;
            if (__jsonProps.Contains("item.track_cid")) __score0++;
            if (__jsonProps.Contains("item.track_segments")) __score0++;
            if (__jsonProps.Contains("item.updated_at")) __score0++;
            if (__jsonProps.Contains("item.user")) __score0++;
            if (__jsonProps.Contains("item.user_id")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("item")) __score1++;
            if (__jsonProps.Contains("item.access")) __score1++;
            if (__jsonProps.Contains("item.added_timestamps")) __score1++;
            if (__jsonProps.Contains("item.artists")) __score1++;
            if (__jsonProps.Contains("item.artwork")) __score1++;
            if (__jsonProps.Contains("item.blocknumber")) __score1++;
            if (__jsonProps.Contains("item.copyright_line")) __score1++;
            if (__jsonProps.Contains("item.cover_art")) __score1++;
            if (__jsonProps.Contains("item.cover_art_cids")) __score1++;
            if (__jsonProps.Contains("item.cover_art_sizes")) __score1++;
            if (__jsonProps.Contains("item.created_at")) __score1++;
            if (__jsonProps.Contains("item.ddex_app")) __score1++;
            if (__jsonProps.Contains("item.ddex_release_ids")) __score1++;
            if (__jsonProps.Contains("item.description")) __score1++;
            if (__jsonProps.Contains("item.favorite_count")) __score1++;
            if (__jsonProps.Contains("item.followee_favorites")) __score1++;
            if (__jsonProps.Contains("item.followee_reposts")) __score1++;
            if (__jsonProps.Contains("item.has_current_user_reposted")) __score1++;
            if (__jsonProps.Contains("item.has_current_user_saved")) __score1++;
            if (__jsonProps.Contains("item.id")) __score1++;
            if (__jsonProps.Contains("item.is_album")) __score1++;
            if (__jsonProps.Contains("item.is_delete")) __score1++;
            if (__jsonProps.Contains("item.is_image_autogenerated")) __score1++;
            if (__jsonProps.Contains("item.is_private")) __score1++;
            if (__jsonProps.Contains("item.is_scheduled_release")) __score1++;
            if (__jsonProps.Contains("item.is_stream_gated")) __score1++;
            if (__jsonProps.Contains("item.parental_warning_type")) __score1++;
            if (__jsonProps.Contains("item.permalink")) __score1++;
            if (__jsonProps.Contains("item.playlist_contents")) __score1++;
            if (__jsonProps.Contains("item.playlist_name")) __score1++;
            if (__jsonProps.Contains("item.producer_copyright_line")) __score1++;
            if (__jsonProps.Contains("item.release_date")) __score1++;
            if (__jsonProps.Contains("item.repost_count")) __score1++;
            if (__jsonProps.Contains("item.stream_conditions")) __score1++;
            if (__jsonProps.Contains("item.total_play_count")) __score1++;
            if (__jsonProps.Contains("item.track_count")) __score1++;
            if (__jsonProps.Contains("item.tracks")) __score1++;
            if (__jsonProps.Contains("item.upc")) __score1++;
            if (__jsonProps.Contains("item.updated_at")) __score1++;
            if (__jsonProps.Contains("item.user")) __score1++;
            if (__jsonProps.Contains("item.user_id")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Audius.TrackFeedItem? track = default;
            global::Audius.PlaylistFeedItem? playlist = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrackFeedItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrackFeedItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TrackFeedItem).Name}");
                        track = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.PlaylistFeedItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.PlaylistFeedItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.PlaylistFeedItem).Name}");
                        playlist = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (track == null && playlist == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrackFeedItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrackFeedItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TrackFeedItem).Name}");
                    track = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (track == null && playlist == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.PlaylistFeedItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.PlaylistFeedItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.PlaylistFeedItem).Name}");
                    playlist = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Audius.UserFeedItem(
                track,

                playlist
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Audius.UserFeedItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTrack)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrackFeedItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrackFeedItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.TrackFeedItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Track!, typeInfo);
            }
            else if (value.IsPlaylist)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.PlaylistFeedItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.PlaylistFeedItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.PlaylistFeedItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Playlist!, typeInfo);
            }
        }
    }
}