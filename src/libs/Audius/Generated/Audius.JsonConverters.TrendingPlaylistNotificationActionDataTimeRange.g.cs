#nullable enable

namespace Audius.JsonConverters
{
    /// <inheritdoc />
    public sealed class TrendingPlaylistNotificationActionDataTimeRangeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Audius.TrendingPlaylistNotificationActionDataTimeRange>
    {
        /// <inheritdoc />
        public override global::Audius.TrendingPlaylistNotificationActionDataTimeRange Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Audius.TrendingPlaylistNotificationActionDataTimeRangeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Audius.TrendingPlaylistNotificationActionDataTimeRange)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Audius.TrendingPlaylistNotificationActionDataTimeRange);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Audius.TrendingPlaylistNotificationActionDataTimeRange value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Audius.TrendingPlaylistNotificationActionDataTimeRangeExtensions.ToValueString(value));
        }
    }
}
