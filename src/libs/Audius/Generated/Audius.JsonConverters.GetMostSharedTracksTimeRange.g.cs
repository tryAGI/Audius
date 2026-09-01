#nullable enable

namespace Audius.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetMostSharedTracksTimeRangeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Audius.GetMostSharedTracksTimeRange>
    {
        /// <inheritdoc />
        public override global::Audius.GetMostSharedTracksTimeRange Read(
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
                        return global::Audius.GetMostSharedTracksTimeRangeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Audius.GetMostSharedTracksTimeRange)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Audius.GetMostSharedTracksTimeRange);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Audius.GetMostSharedTracksTimeRange value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Audius.GetMostSharedTracksTimeRangeExtensions.ToValueString(value));
        }
    }
}
