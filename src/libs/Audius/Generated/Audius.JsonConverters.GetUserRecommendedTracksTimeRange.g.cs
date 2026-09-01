#nullable enable

namespace Audius.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetUserRecommendedTracksTimeRangeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Audius.GetUserRecommendedTracksTimeRange>
    {
        /// <inheritdoc />
        public override global::Audius.GetUserRecommendedTracksTimeRange Read(
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
                        return global::Audius.GetUserRecommendedTracksTimeRangeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Audius.GetUserRecommendedTracksTimeRange)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Audius.GetUserRecommendedTracksTimeRange);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Audius.GetUserRecommendedTracksTimeRange value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Audius.GetUserRecommendedTracksTimeRangeExtensions.ToValueString(value));
        }
    }
}
