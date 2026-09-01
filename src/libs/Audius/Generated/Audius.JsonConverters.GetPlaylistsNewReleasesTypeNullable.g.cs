#nullable enable

namespace Audius.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetPlaylistsNewReleasesTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Audius.GetPlaylistsNewReleasesType?>
    {
        /// <inheritdoc />
        public override global::Audius.GetPlaylistsNewReleasesType? Read(
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
                        return global::Audius.GetPlaylistsNewReleasesTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Audius.GetPlaylistsNewReleasesType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Audius.GetPlaylistsNewReleasesType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Audius.GetPlaylistsNewReleasesType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Audius.GetPlaylistsNewReleasesTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
