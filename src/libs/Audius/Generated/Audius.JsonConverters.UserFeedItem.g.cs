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


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.UserFeedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.UserFeedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.UserFeedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Audius.TrackFeedItem? track = default;
            if (discriminator?.Type == global::Audius.UserFeedItemDiscriminatorType.Track)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.TrackFeedItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.TrackFeedItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.TrackFeedItem)}");
                track = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Audius.PlaylistFeedItem? playlist = default;
            if (discriminator?.Type == global::Audius.UserFeedItemDiscriminatorType.Playlist)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.PlaylistFeedItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.PlaylistFeedItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Audius.PlaylistFeedItem)}");
                playlist = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Audius.UserFeedItem(
                discriminator?.Type,
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
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTrack(), typeInfo);
            }
            else if (value.IsPlaylist)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Audius.PlaylistFeedItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Audius.PlaylistFeedItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Audius.PlaylistFeedItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickPlaylist(), typeInfo);
            }
        }
    }
}