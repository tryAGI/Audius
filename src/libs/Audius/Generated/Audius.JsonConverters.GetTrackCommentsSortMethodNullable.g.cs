#nullable enable

namespace Audius.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetTrackCommentsSortMethodNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Audius.GetTrackCommentsSortMethod?>
    {
        /// <inheritdoc />
        public override global::Audius.GetTrackCommentsSortMethod? Read(
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
                        return global::Audius.GetTrackCommentsSortMethodExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Audius.GetTrackCommentsSortMethod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Audius.GetTrackCommentsSortMethod?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Audius.GetTrackCommentsSortMethod? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Audius.GetTrackCommentsSortMethodExtensions.ToValueString(value.Value));
            }
        }
    }
}
