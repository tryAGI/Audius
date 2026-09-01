#nullable enable

namespace Audius.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetTracksByUserFilterTracksNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Audius.GetTracksByUserFilterTracks?>
    {
        /// <inheritdoc />
        public override global::Audius.GetTracksByUserFilterTracks? Read(
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
                        return global::Audius.GetTracksByUserFilterTracksExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Audius.GetTracksByUserFilterTracks)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Audius.GetTracksByUserFilterTracks?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Audius.GetTracksByUserFilterTracks? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Audius.GetTracksByUserFilterTracksExtensions.ToValueString(value.Value));
            }
        }
    }
}
