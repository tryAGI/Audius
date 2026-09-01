#nullable enable

namespace Audius.JsonConverters
{
    /// <inheritdoc />
    public sealed class TrackActivityVariant2ItemTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Audius.TrackActivityVariant2ItemType?>
    {
        /// <inheritdoc />
        public override global::Audius.TrackActivityVariant2ItemType? Read(
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
                        return global::Audius.TrackActivityVariant2ItemTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Audius.TrackActivityVariant2ItemType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Audius.TrackActivityVariant2ItemType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Audius.TrackActivityVariant2ItemType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Audius.TrackActivityVariant2ItemTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
